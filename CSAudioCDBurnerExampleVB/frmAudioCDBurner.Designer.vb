<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudioCDBurner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAudioCDBurner))
        Me.AudioCDBurner1 = New CSAudioCDBurner.AudioCDBurner()
        Me.cmdCheckLicense = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblSizeLength = New System.Windows.Forms.Label()
        Me.lstTracks = New System.Windows.Forms.ListView()
        Me.cTrackNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTrackName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTrackSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTrackTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTrackFile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.progressBarTotal = New System.Windows.Forms.ProgressBar()
        Me.prgSizeLength = New System.Windows.Forms.ProgressBar()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnBurn = New System.Windows.Forms.Button()
        Me.prgProgress = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddFiles = New System.Windows.Forms.Button()
        Me.comboDrives = New System.Windows.Forms.ComboBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AudioCDBurner1
        '
        Me.AudioCDBurner1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AudioCDBurner1.Location = New System.Drawing.Point(502, 68)
        Me.AudioCDBurner1.Name = "AudioCDBurner1"
        Me.AudioCDBurner1.Size = New System.Drawing.Size(52, 52)
        Me.AudioCDBurner1.TabIndex = 0
        Me.AudioCDBurner1.UserKey = "Your registration key"
        Me.AudioCDBurner1.UserName = "Your email"
        '
        'cmdCheckLicense
        '
        Me.cmdCheckLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdCheckLicense.Image = CType(resources.GetObject("cmdCheckLicense.Image"), System.Drawing.Image)
        Me.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCheckLicense.Location = New System.Drawing.Point(472, 478)
        Me.cmdCheckLicense.Name = "cmdCheckLicense"
        Me.cmdCheckLicense.Size = New System.Drawing.Size(168, 23)
        Me.cmdCheckLicense.TabIndex = 229
        Me.cmdCheckLicense.Text = "Order a license online"
        Me.cmdCheckLicense.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(220, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(254, 16)
        Me.label3.TabIndex = 227
        Me.label3.Text = ".NET component to burn audio CDs."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(6, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(218, 25)
        Me.label2.TabIndex = 226
        Me.label2.Text = "CSAudioCDBurner |"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pictureBox1.Location = New System.Drawing.Point(-37, -2)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(957, 45)
        Me.pictureBox1.TabIndex = 225
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pictureBox2.Location = New System.Drawing.Point(-27, 6)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(957, 45)
        Me.pictureBox2.TabIndex = 228
        Me.pictureBox2.TabStop = False
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'lblSizeLength
        '
        Me.lblSizeLength.AutoSize = True
        Me.lblSizeLength.Location = New System.Drawing.Point(332, 492)
        Me.lblSizeLength.Name = "lblSizeLength"
        Me.lblSizeLength.Size = New System.Drawing.Size(64, 13)
        Me.lblSizeLength.TabIndex = 224
        Me.lblSizeLength.Text = "00:00 MINS"
        '
        'lstTracks
        '
        Me.lstTracks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cTrackNum, Me.cTrackName, Me.cTrackSize, Me.cTrackTime, Me.cTrackFile})
        Me.lstTracks.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTracks.FullRowSelect = True
        Me.lstTracks.GridLines = True
        Me.lstTracks.HideSelection = False
        Me.lstTracks.Location = New System.Drawing.Point(22, 126)
        Me.lstTracks.MultiSelect = False
        Me.lstTracks.Name = "lstTracks"
        Me.lstTracks.Size = New System.Drawing.Size(618, 298)
        Me.lstTracks.TabIndex = 222
        Me.lstTracks.UseCompatibleStateImageBehavior = False
        Me.lstTracks.View = System.Windows.Forms.View.Details
        '
        'cTrackNum
        '
        Me.cTrackNum.Text = "Track Num"
        Me.cTrackNum.Width = 80
        '
        'cTrackName
        '
        Me.cTrackName.Text = "Track Name"
        Me.cTrackName.Width = 220
        '
        'cTrackSize
        '
        Me.cTrackSize.Text = "Track Size"
        Me.cTrackSize.Width = 120
        '
        'cTrackTime
        '
        Me.cTrackTime.Text = "Track Time"
        Me.cTrackTime.Width = 120
        '
        'cTrackFile
        '
        Me.cTrackFile.Text = "Track File"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(103, 91)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 216
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(25, 659)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(34, 13)
        Me.label1.TabIndex = 221
        Me.label1.Text = "Total:"
        '
        'progressBarTotal
        '
        Me.progressBarTotal.Location = New System.Drawing.Point(26, 675)
        Me.progressBarTotal.Name = "progressBarTotal"
        Me.progressBarTotal.Size = New System.Drawing.Size(614, 29)
        Me.progressBarTotal.TabIndex = 220
        '
        'prgSizeLength
        '
        Me.prgSizeLength.Location = New System.Drawing.Point(22, 443)
        Me.prgSizeLength.Maximum = 4800
        Me.prgSizeLength.Name = "prgSizeLength"
        Me.prgSizeLength.Size = New System.Drawing.Size(618, 15)
        Me.prgSizeLength.TabIndex = 223
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(22, 91)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 215
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnBurn
        '
        Me.btnBurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnBurn.Location = New System.Drawing.Point(26, 546)
        Me.btnBurn.Name = "btnBurn"
        Me.btnBurn.Size = New System.Drawing.Size(152, 29)
        Me.btnBurn.TabIndex = 214
        Me.btnBurn.Text = "Burn Audio CD"
        Me.btnBurn.UseVisualStyleBackColor = True
        '
        'prgProgress
        '
        Me.prgProgress.Location = New System.Drawing.Point(26, 618)
        Me.prgProgress.Name = "prgProgress"
        Me.prgProgress.Size = New System.Drawing.Size(614, 29)
        Me.prgProgress.TabIndex = 213
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(25, 600)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(612, 15)
        Me.lblStatus.TabIndex = 218
        Me.lblStatus.Text = "..."
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(184, 546)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCancel.TabIndex = 217
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddFiles
        '
        Me.btnAddFiles.Location = New System.Drawing.Point(25, 478)
        Me.btnAddFiles.Name = "btnAddFiles"
        Me.btnAddFiles.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFiles.TabIndex = 211
        Me.btnAddFiles.Text = "Add Files"
        Me.btnAddFiles.UseVisualStyleBackColor = True
        '
        'comboDrives
        '
        Me.comboDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDrives.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboDrives.FormattingEnabled = True
        Me.comboDrives.Location = New System.Drawing.Point(22, 64)
        Me.comboDrives.Name = "comboDrives"
        Me.comboDrives.Size = New System.Drawing.Size(618, 21)
        Me.comboDrives.TabIndex = 210
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(103, 478)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 212
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(184, 478)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 219
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmAudioCDBurner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 722)
        Me.Controls.Add(Me.AudioCDBurner1)
        Me.Controls.Add(Me.cmdCheckLicense)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.lblSizeLength)
        Me.Controls.Add(Me.lstTracks)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.progressBarTotal)
        Me.Controls.Add(Me.prgSizeLength)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnBurn)
        Me.Controls.Add(Me.prgProgress)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddFiles)
        Me.Controls.Add(Me.comboDrives)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnClear)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAudioCDBurner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSAudioCDBurner - VB Full Example"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AudioCDBurner1 As CSAudioCDBurner.AudioCDBurner
    Private WithEvents cmdCheckLicense As Button
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents lblSizeLength As Label
    Private WithEvents lstTracks As ListView
    Private WithEvents cTrackNum As ColumnHeader
    Private WithEvents cTrackName As ColumnHeader
    Private WithEvents cTrackSize As ColumnHeader
    Private WithEvents cTrackTime As ColumnHeader
    Private WithEvents cTrackFile As ColumnHeader
    Friend WithEvents btnClose As Button
    Private WithEvents label1 As Label
    Friend WithEvents progressBarTotal As ProgressBar
    Private WithEvents prgSizeLength As ProgressBar
    Friend WithEvents btnOpen As Button
    Private WithEvents btnBurn As Button
    Friend WithEvents prgProgress As ProgressBar
    Friend WithEvents lblStatus As Label
    Private WithEvents btnCancel As Button
    Friend WithEvents btnAddFiles As Button
    Friend WithEvents comboDrives As ComboBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClear As Button
End Class
