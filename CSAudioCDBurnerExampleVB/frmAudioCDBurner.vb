#Region "LICENSE"
'
' Copyright (c) Microncode.com
' 
' This source is subject to the Microsoft Public License. 
' See https://opensource.org/licenses/ms-pl.html.
' All other rights reserved. 
' 
' THIS CODE And INFORMATION Is PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED Or IMPLIED, INCLUDING BUT Not LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY And/Or FITNESS FOR A PARTICULAR PURPOSE. 
'
#End Region

Imports System.IO

Public Class frmAudioCDBurner

    Private _total As Double = 0

    ''' <summary>
    ''' Form load.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioCDBurner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AudioCDBurner1.UserName = "Your email"
        AudioCDBurner1.UserKey = "Your registration key"

        For Each DriveName As String In AudioCDBurner1.DrivesInfo
            comboDrives.Items.Add(DriveName)
        Next

        If comboDrives.Items.Count > 0 Then comboDrives.SelectedIndex = 0

    End Sub

    ''' <summary>
    ''' Open the CD drive.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        AudioCDBurner1.EjectCD(comboDrives.SelectedIndex)

    End Sub

    ''' <summary>
    ''' Close the CD drive.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        AudioCDBurner1.CloseTray(comboDrives.SelectedIndex)

    End Sub

    ''' <summary>
    ''' Add WAV audio files to the tracks list to burn.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddFiles_Click(sender As Object, e As EventArgs) Handles btnAddFiles.Click

        openFileDialog1.Filter = "Audio (*.WAV)|*.WAV"
        openFileDialog1.Multiselect = True

        'Add the WAV file
        If openFileDialog1.ShowDialog(Me) = DialogResult.OK Then

            For Each file In openFileDialog1.FileNames

                If AudioCDBurner1.FilesAdd(file) = 0 Then

                    Dim arr As String() = New String(4) {}
                    Dim track As ListViewItem

                    'Get some information about the track to burn
                    Dim info As FileInfo = New FileInfo(file)
                    Dim wav_len As Double = AudioCDBurner1.GetWAVLength(file)

                    'Track number
                    arr(0) = "Track0" & (lstTracks.Items.Count + 1).ToString() & ".cda"

                    'Track file name
                    arr(1) = Path.GetFileName(file)

                    'Track size
                    arr(2) = (info.Length / 1024 / 1024).ToString() & " MB"

                    'Track length
                    arr(3) = (wav_len / 60).ToString("N2") & " Mins"

                    'Track path
                    arr(4) = file

                    'Add the track to the list view
                    track = New ListViewItem(arr)
                    lstTracks.Items.Add(track)

                    'Total length
                    _total = _total + wav_len

                    'More then 80 minutes (4800 seconds)?
                    If _total > 4800 Then
                        prgSizeLength.Value = 4800
                        lblSizeLength.ForeColor = Color.Red
                    Else
                        prgSizeLength.Value = CInt(_total)
                        lblSizeLength.ForeColor = Color.Black
                    End If

                    lblSizeLength.Text = (_total / 60).ToString("N2") & " MINS"
                    If lstTracks.Items.Count > 0 Then lstTracks.Items(0).Selected = True

                Else

                    MessageBox.Show("Please add a legal PCM WAV audio file (44100 samples rate, 16 bits and 2 channels)")

                End If

            Next

        End If

    End Sub

    ''' <summary>
    ''' Remove the selected tracks from the list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lstTracks.Items.Count > 0 Then

            AudioCDBurner1.FilesRemoveIndex(lstTracks.SelectedItems(0).Index)
            Dim wav_len As Double = AudioCDBurner1.GetWAVLength(lstTracks.Items(lstTracks.SelectedItems(0).Index).SubItems(4).Text)
            prgSizeLength.Value = prgSizeLength.Value - CInt(wav_len)
            _total = _total - wav_len

            'More then 80 minutes (4800 seconds)
            If _total > 4800 Then
                prgSizeLength.Value = 4800
                lblSizeLength.ForeColor = Color.Red
            Else
                prgSizeLength.Value = CInt(_total)
                lblSizeLength.ForeColor = Color.Black
            End If

            lblSizeLength.Text = (_total / 60).ToString("N2") & " MINS"
            lstTracks.Items(lstTracks.SelectedItems(0).Index).Remove()

            If lstTracks.Items.Count > 0 Then lstTracks.Items(0).Selected = True

        End If

    End Sub

    ''' <summary>
    ''' Clear all the tracks from the list to burn.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        AudioCDBurner1.FilesClear()
        lstTracks.Items.Clear()
        lblSizeLength.Text = "00:00 Mins"
        prgSizeLength.Value = 0

    End Sub

    ''' <summary>
    ''' Burn the tracks in the list to an Audio CD.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBurn_Click(sender As Object, e As EventArgs) Handles btnBurn.Click

        If lstTracks.Items.Count < 1 Then
            MessageBox.Show("Add one or more WAV files to the items list")
            Return
        End If

        progressBarTotal.Maximum = lstTracks.Items.Count
        AudioCDBurner1.BurnAudioCD(comboDrives.SelectedIndex)

    End Sub

    ''' <summary>
    ''' Cancel the burn process.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        AudioCDBurner1.CancelBurn()

    End Sub

    'Events:

    ''' <summary>
    ''' On burn error.
    ''' </summary>
    ''' <param name="m"></param>
    ''' <param name="ErrorNumber"></param>
    ''' <param name="Message"></param>
    Private Sub AudioCDBurner1_BurnError(m As CSAudioCDBurner.AudioCDBurner, ErrorNumber As Integer, Message As String) Handles AudioCDBurner1.BurnError

        Console.WriteLine(Message)

    End Sub

    ''' <summary>
    ''' When the burn process has done.
    ''' </summary>
    ''' <param name="m"></param>
    Private Sub AudioCDBurner1_BurnFinished(m As CSAudioCDBurner.AudioCDBurner) Handles AudioCDBurner1.BurnFinished

        prgProgress.Value = 100
        lblStatus.Text = "Finished..."
        AudioCDBurner1.EjectCD(comboDrives.SelectedIndex)

    End Sub

    ''' <summary>
    ''' When the process is preparing to burn.
    ''' </summary>
    ''' <param name="m"></param>
    Private Sub AudioCDBurner1_BurnPreparing(m As CSAudioCDBurner.AudioCDBurner) Handles AudioCDBurner1.BurnPreparing

        lblStatus.Text = "Preparing..."

    End Sub

    ''' <summary>
    ''' The burn progress of the process.
    ''' </summary>
    ''' <param name="m"></param>
    ''' <param name="Percent"></param>
    Private Sub AudioCDBurner1_BurnProgress(m As CSAudioCDBurner.AudioCDBurner, Percent As Integer) Handles AudioCDBurner1.BurnProgress

        lblStatus.Text = "Burning..."
        prgProgress.Value = Percent

    End Sub

    ''' <summary>
    ''' When burn a track.
    ''' </summary>
    ''' <param name="m"></param>
    ''' <param name="TrackNumber"></param>
    Private Sub AudioCDBurner1_BurnTrack(m As CSAudioCDBurner.AudioCDBurner, TrackNumber As Integer) Handles AudioCDBurner1.BurnTrack

        lblStatus.Text = "BurnTrack..."
        progressBarTotal.Value = TrackNumber

    End Sub

    ''' <summary>
    ''' Check the license.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdCheckLicense_Click(sender As Object, e As EventArgs) Handles cmdCheckLicense.Click

        If AudioCDBurner1.CheckLicense() Then MessageBox.Show("Registration is OK")

    End Sub
End Class
