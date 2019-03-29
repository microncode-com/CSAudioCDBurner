namespace CSAudioCDBurnerExample
{
    partial class frmAudioCDBurner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudioCDBurner));
            this.lblSizeLength = new System.Windows.Forms.Label();
            this.cTrackFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prgSizeLength = new System.Windows.Forms.ProgressBar();
            this.lstTracks = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarTotal = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBurn = new System.Windows.Forms.Button();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.comboDrives = new System.Windows.Forms.ComboBox();
            this.audioCDBurner1 = new CSAudioCDBurner.AudioCDBurner();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmdCheckLicense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSizeLength
            // 
            this.lblSizeLength.AutoSize = true;
            this.lblSizeLength.Location = new System.Drawing.Point(331, 492);
            this.lblSizeLength.Name = "lblSizeLength";
            this.lblSizeLength.Size = new System.Drawing.Size(64, 13);
            this.lblSizeLength.TabIndex = 203;
            this.lblSizeLength.Text = "00:00 MINS";
            // 
            // cTrackFile
            // 
            this.cTrackFile.Text = "Track File";
            // 
            // cTrackTime
            // 
            this.cTrackTime.Text = "Track Time";
            this.cTrackTime.Width = 120;
            // 
            // cTrackSize
            // 
            this.cTrackSize.Text = "Track Size";
            this.cTrackSize.Width = 120;
            // 
            // cTrackName
            // 
            this.cTrackName.Text = "Track Name";
            this.cTrackName.Width = 220;
            // 
            // cTrackNum
            // 
            this.cTrackNum.Text = "Track Num";
            this.cTrackNum.Width = 80;
            // 
            // prgSizeLength
            // 
            this.prgSizeLength.Location = new System.Drawing.Point(21, 443);
            this.prgSizeLength.Maximum = 4800;
            this.prgSizeLength.Name = "prgSizeLength";
            this.prgSizeLength.Size = new System.Drawing.Size(618, 15);
            this.prgSizeLength.TabIndex = 202;
            // 
            // lstTracks
            // 
            this.lstTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTrackNum,
            this.cTrackName,
            this.cTrackSize,
            this.cTrackTime,
            this.cTrackFile});
            this.lstTracks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTracks.FullRowSelect = true;
            this.lstTracks.GridLines = true;
            this.lstTracks.HideSelection = false;
            this.lstTracks.Location = new System.Drawing.Point(21, 126);
            this.lstTracks.MultiSelect = false;
            this.lstTracks.Name = "lstTracks";
            this.lstTracks.Size = new System.Drawing.Size(618, 298);
            this.lstTracks.TabIndex = 201;
            this.lstTracks.UseCompatibleStateImageBehavior = false;
            this.lstTracks.View = System.Windows.Forms.View.Details;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(102, 91);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 194;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 659);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 199;
            this.label1.Text = "Total:";
            // 
            // progressBarTotal
            // 
            this.progressBarTotal.Location = new System.Drawing.Point(25, 675);
            this.progressBarTotal.Name = "progressBarTotal";
            this.progressBarTotal.Size = new System.Drawing.Size(614, 29);
            this.progressBarTotal.TabIndex = 198;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(21, 91);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 193;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBurn
            // 
            this.btnBurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBurn.Location = new System.Drawing.Point(25, 546);
            this.btnBurn.Name = "btnBurn";
            this.btnBurn.Size = new System.Drawing.Size(152, 29);
            this.btnBurn.TabIndex = 192;
            this.btnBurn.Text = "Burn Audio CD";
            this.btnBurn.UseVisualStyleBackColor = true;
            this.btnBurn.Click += new System.EventHandler(this.btnBurn_Click);
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(25, 618);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(614, 29);
            this.prgProgress.TabIndex = 191;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(102, 478);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 190;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(183, 478);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 197;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(24, 600);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(612, 15);
            this.lblStatus.TabIndex = 196;
            this.lblStatus.Text = "...";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 546);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 195;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Location = new System.Drawing.Point(24, 478);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(75, 23);
            this.btnAddFiles.TabIndex = 189;
            this.btnAddFiles.Text = "Add Files";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // comboDrives
            // 
            this.comboDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDrives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDrives.FormattingEnabled = true;
            this.comboDrives.Location = new System.Drawing.Point(21, 64);
            this.comboDrives.Name = "comboDrives";
            this.comboDrives.Size = new System.Drawing.Size(618, 21);
            this.comboDrives.TabIndex = 188;
            // 
            // audioCDBurner1
            // 
            this.audioCDBurner1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.audioCDBurner1.Location = new System.Drawing.Point(524, 57);
            this.audioCDBurner1.Name = "audioCDBurner1";
            this.audioCDBurner1.Size = new System.Drawing.Size(52, 52);
            this.audioCDBurner1.TabIndex = 204;
            this.audioCDBurner1.UserKey = "Your registration key";
            this.audioCDBurner1.UserName = "Your email";
            this.audioCDBurner1.BurnProgress += new CSAudioCDBurner.AudioCDBurner.BurnProgressHandler(this.audioCDBurner1_BurnProgress);
            this.audioCDBurner1.BurnFinished += new CSAudioCDBurner.AudioCDBurner.BurnFinishedHandler(this.audioCDBurner1_BurnFinished);
            this.audioCDBurner1.BurnPreparing += new CSAudioCDBurner.AudioCDBurner.BurnPreparingHandler(this.audioCDBurner1_BurnPreparing);
            this.audioCDBurner1.BurnTrack += new CSAudioCDBurner.AudioCDBurner.BurnTrackHandler(this.audioCDBurner1_BurnTrack);
            this.audioCDBurner1.BurnError += new CSAudioCDBurner.AudioCDBurner.BurnErrorHandler(this.audioCDBurner1_BurnError);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 16);
            this.label3.TabIndex = 207;
            this.label3.Text = ".NET component to burn audio CDs.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 206;
            this.label2.Text = "CSAudioCDBurner |";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-38, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 45);
            this.pictureBox1.TabIndex = 205;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(-28, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(957, 45);
            this.pictureBox2.TabIndex = 208;
            this.pictureBox2.TabStop = false;
            // 
            // cmdCheckLicense
            // 
            this.cmdCheckLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdCheckLicense.Image = ((System.Drawing.Image)(resources.GetObject("cmdCheckLicense.Image")));
            this.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCheckLicense.Location = new System.Drawing.Point(471, 478);
            this.cmdCheckLicense.Name = "cmdCheckLicense";
            this.cmdCheckLicense.Size = new System.Drawing.Size(168, 23);
            this.cmdCheckLicense.TabIndex = 209;
            this.cmdCheckLicense.Text = "Order a license online";
            this.cmdCheckLicense.UseVisualStyleBackColor = true;
            this.cmdCheckLicense.Click += new System.EventHandler(this.cmdCheckLicense_Click);
            // 
            // frmAudioCDBurner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 722);
            this.Controls.Add(this.cmdCheckLicense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.audioCDBurner1);
            this.Controls.Add(this.lblSizeLength);
            this.Controls.Add(this.prgSizeLength);
            this.Controls.Add(this.lstTracks);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarTotal);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnBurn);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.comboDrives);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAudioCDBurner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSAudioCDBurner - Full Example";
            this.Load += new System.EventHandler(this.frmAudioCDBurner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSizeLength;
        private System.Windows.Forms.ColumnHeader cTrackFile;
        private System.Windows.Forms.ColumnHeader cTrackTime;
        private System.Windows.Forms.ColumnHeader cTrackSize;
        private System.Windows.Forms.ColumnHeader cTrackName;
        private System.Windows.Forms.ColumnHeader cTrackNum;
        private System.Windows.Forms.ProgressBar prgSizeLength;
        private System.Windows.Forms.ListView lstTracks;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ProgressBar progressBarTotal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBurn;
        internal System.Windows.Forms.ProgressBar prgProgress;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnAddFiles;
        internal System.Windows.Forms.ComboBox comboDrives;
        private CSAudioCDBurner.AudioCDBurner audioCDBurner1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmdCheckLicense;
    }
}

