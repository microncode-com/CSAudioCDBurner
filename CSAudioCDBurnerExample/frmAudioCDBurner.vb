Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CSAudioCDBurnerExample
    Public Partial Class frmAudioCDBurner
        Inherits Form

        Private _total As Double = 0

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub cmdCheckLicense_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioCDBurner1.CheckLicense() Then MessageBox.Show("Registration is OK")
        End Sub

        Private Sub frmAudioCDBurner_Load(ByVal sender As Object, ByVal e As EventArgs)
            audioCDBurner1.UserName = "Your email"
            audioCDBurner1.UserKey = "Your registration key"

            For Each DriveName As String In audioCDBurner1.DrivesInfo
                comboDrives.Items.Add(DriveName)
            Next

            If comboDrives.Items.Count > 0 Then comboDrives.SelectedIndex = 0
        End Sub

        Private Sub cmdRegistration_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDBurner1.CheckLicense()
        End Sub

        Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDBurner1.EjectCD(comboDrives.SelectedIndex)
        End Sub

        Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDBurner1.CloseTray(comboDrives.SelectedIndex)
        End Sub

        Private Sub btnAddFiles_Click(ByVal sender As Object, ByVal e As EventArgs)
            If openFileDialog1.ShowDialog(Me) = DialogResult.OK Then

                If audioCDBurner1.FilesAdd(openFileDialog1.FileNames(0).ToString()) = 0 Then
                    Dim arr As String() = New String(4) {}
                    Dim track As ListViewItem
                    Dim info As FileInfo = New FileInfo(openFileDialog1.FileNames(0).ToString())
                    Dim wav_len As Double = audioCDBurner1.GetWAVLength(openFileDialog1.FileNames(0).ToString())
                    arr(0) = "Track0" & (lstTracks.Items.Count + 1).ToString() & ".cda"
                    arr(1) = Path.GetFileName(openFileDialog1.FileNames(0).ToString())
                    arr(2) = (info.Length / 1024 / 1024).ToString() & " MB"
                    arr(3) = (wav_len / 60).ToString("N2") & " Mins"
                    arr(4) = openFileDialog1.FileNames(0).ToString()
                    track = New ListViewItem(arr)
                    lstTracks.Items.Add(track)
                    _total = _total + wav_len

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
            End If
        End Sub

        Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lstTracks.Items.Count > 0 Then
                audioCDBurner1.FilesRemoveIndex(lstTracks.SelectedItems(0).Index)
                Dim wav_len As Double = audioCDBurner1.GetWAVLength(lstTracks.Items(lstTracks.SelectedItems(0).Index).SubItems(4).Text)
                prgSizeLength.Value = prgSizeLength.Value - CInt(wav_len)
                _total = _total - wav_len

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

        Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDBurner1.FilesClear()
            lstTracks.Items.Clear()
            lblSizeLength.Text = "00:00 Mins"
            prgSizeLength.Value = 0
        End Sub

        Private Sub btnBurn_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lstTracks.Items.Count < 1 Then
                MessageBox.Show("Add one or more WAV files to the items list")
                Return
            End If

            progressBarTotal.Maximum = lstTracks.Items.Count
            audioCDBurner1.BurnAudioCD(comboDrives.SelectedIndex)
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDBurner1.CancelBurn()
        End Sub

        Private Sub audioCDBurner1_BurnError(ByVal m As CSAudioCDBurner.AudioCDBurner, ByVal ErrorNumber As Integer, ByVal Message As String)
            Console.WriteLine(Message)
        End Sub

        Private Sub audioCDBurner1_BurnFinished(ByVal m As CSAudioCDBurner.AudioCDBurner)
            prgProgress.Value = 100
            lblStatus.Text = "Finished..."
            audioCDBurner1.EjectCD(comboDrives.SelectedIndex)
        End Sub

        Private Sub audioCDBurner1_BurnPreparing(ByVal m As CSAudioCDBurner.AudioCDBurner)
            lblStatus.Text = "Preparing..."
        End Sub

        Private Sub audioCDBurner1_BurnProgress(ByVal m As CSAudioCDBurner.AudioCDBurner, ByVal Percent As Integer)
            lblStatus.Text = "Burning..."
            prgProgress.Value = Percent
        End Sub

        Private Sub audioCDBurner1_BurnTrack(ByVal m As CSAudioCDBurner.AudioCDBurner, ByVal TrackNumber As Integer)
            lblStatus.Text = "BurnTrack..."
            progressBarTotal.Value = TrackNumber
        End Sub
    End Class
End Namespace
