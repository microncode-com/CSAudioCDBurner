#region LICENSE
//
// Copyright (c) Microncode.com
// 
// This source is subject to the Microsoft Public License. 
// See https://opensource.org/licenses/ms-pl.html.
// All other rights reserved. 
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAudioCDBurnerExample
{
    public partial class frmAudioCDBurner : Form
    {
        private double _total = 0;

        /// <summary>
        /// Constructor.
        /// </summary>
        public frmAudioCDBurner()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioCDBurner_Load(object sender, EventArgs e)
        {
            audioCDBurner1.UserName = "Your email";
            audioCDBurner1.UserKey = "Your registration key";

            foreach (string DriveName in audioCDBurner1.DrivesInfo)
            {
                comboDrives.Items.Add(DriveName);
            }

            if (comboDrives.Items.Count > 0)
                comboDrives.SelectedIndex = 0;
        }

        /// <summary>
        /// Open the CD drive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            audioCDBurner1.EjectCD(comboDrives.SelectedIndex);
        }

        /// <summary>
        /// Close the CD drive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            audioCDBurner1.CloseTray(comboDrives.SelectedIndex);
        }

        /// <summary>
        /// Add WAV audio files to the tracks list to burn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Audio (*.WAV)|*.WAV";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    //Add the WAV file
                    if (audioCDBurner1.FilesAdd(file) == 0)
                    {
                        string[] arr = new string[5];
                        ListViewItem track;

                        //Get some information about the track to burn
                        FileInfo info = new FileInfo(file);
                        double wav_len = audioCDBurner1.GetWAVLength(file);

                        //Track number
                        arr[0] = "Track0" + (lstTracks.Items.Count + 1).ToString() + ".cda";

                        //Track file name
                        arr[1] = Path.GetFileName(file);

                        //Track size
                        arr[2] = (info.Length / 1024 / 1024).ToString() + " MB";

                        //Track length
                        arr[3] = (wav_len / 60).ToString("N2") + " Mins";

                        //Track path
                        arr[4] = file;

                        //Add the track to the list view
                        track = new ListViewItem(arr);
                        lstTracks.Items.Add(track);

                        //Total length
                        _total = _total + wav_len;

                        // More then 80 minutes (4800 seconds)?
                        if (_total > 4800)
                        {
                            prgSizeLength.Value = 4800;
                            lblSizeLength.ForeColor = Color.Red;
                        }
                        else
                        {
                            prgSizeLength.Value = (int)_total;
                            lblSizeLength.ForeColor = Color.Black;
                        }

                        lblSizeLength.Text = (_total / 60).ToString("N2") + " MINS";

                        if (lstTracks.Items.Count > 0)
                            lstTracks.Items[0].Selected = true;

                    }
                    else
                        MessageBox.Show("Please add a legal PCM WAV audio file (44100 samples rate, 16 bits and 2 channels)");
                }
            }
        }

        /// <summary>
        /// Remove the selected tracks from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstTracks.Items.Count > 0)
            {
                audioCDBurner1.FilesRemoveIndex(lstTracks.SelectedItems[0].Index);

                double wav_len = audioCDBurner1.GetWAVLength(lstTracks.Items[lstTracks.SelectedItems[0].Index].SubItems[4].Text);

                prgSizeLength.Value = prgSizeLength.Value - (int)wav_len;

                _total = _total - wav_len;

                // More then 80 minutes (4800 seconds)
                if (_total > 4800)
                {
                    prgSizeLength.Value = 4800;
                    lblSizeLength.ForeColor = Color.Red;
                }
                else
                {
                    prgSizeLength.Value = (int)_total;
                    lblSizeLength.ForeColor = Color.Black;
                }

                lblSizeLength.Text = (_total / 60).ToString("N2") + " MINS";

                lstTracks.Items[lstTracks.SelectedItems[0].Index].Remove();

                if (lstTracks.Items.Count > 0)
                    lstTracks.Items[0].Selected = true;
            }
        }

        /// <summary>
        /// Clear all the tracks from the list to burn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            audioCDBurner1.FilesClear();
            lstTracks.Items.Clear();
            lblSizeLength.Text = "00:00 Mins";
            prgSizeLength.Value = 0;
        }

        /// <summary>
        /// Burn the tracks in the list to an Audio CD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBurn_Click(object sender, EventArgs e)
        {
            if (lstTracks.Items.Count < 1)
            {
                MessageBox.Show("Add one or more WAV files to the items list");
                return;
            }

            progressBarTotal.Maximum = lstTracks.Items.Count;
            audioCDBurner1.BurnAudioCD(comboDrives.SelectedIndex);
        }

        /// <summary>
        /// Cancel the burn process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            audioCDBurner1.CancelBurn();
        }

        //Events:
        
        /// <summary>
        /// On burn error.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="ErrorNumber"></param>
        /// <param name="Message"></param>
        private void audioCDBurner1_BurnError(CSAudioCDBurner.AudioCDBurner m, int ErrorNumber, string Message)
        {
            Console.WriteLine(Message);
        }

        /// <summary>
        /// When the burn process has done.
        /// </summary>
        /// <param name="m"></param>
        private void audioCDBurner1_BurnFinished(CSAudioCDBurner.AudioCDBurner m)
        {
            prgProgress.Value = 100;
            lblStatus.Text = "Finished...";
            audioCDBurner1.EjectCD(comboDrives.SelectedIndex);
        }

        /// <summary>
        /// When the process is preparing to burn.
        /// </summary>
        /// <param name="m"></param>
        private void audioCDBurner1_BurnPreparing(CSAudioCDBurner.AudioCDBurner m)
        {
            lblStatus.Text = "Preparing...";
        }

        /// <summary>
        /// The burn progress of the process.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="Percent"></param>
        private void audioCDBurner1_BurnProgress(CSAudioCDBurner.AudioCDBurner m, int Percent)
        {
            lblStatus.Text = "Burning...";
            prgProgress.Value = Percent;
        }

        /// <summary>
        /// When burn a track.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="TrackNumber"></param>
        private void audioCDBurner1_BurnTrack(CSAudioCDBurner.AudioCDBurner m, int TrackNumber)
        {
            lblStatus.Text = "BurnTrack...";
            progressBarTotal.Value = TrackNumber;
        }

        /// <summary>
        /// Check the license.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCheckLicense_Click(object sender, EventArgs e)
        {
            if (audioCDBurner1.CheckLicense())
                MessageBox.Show("Registration is OK");
        }
    }
}
