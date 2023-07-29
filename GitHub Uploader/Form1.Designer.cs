namespace GitHub_Uploader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Pull = new Button();
            Save = new Button();
            pictureBox1 = new PictureBox();
            UpdateSuccess = new Label();
            UpdateFail = new Label();
            UpdateRunning = new Label();
            OpenLog = new Button();
            CommitNowName = new TextBox();
            CommitNowUpdating = new Label();
            CommitNowError = new Label();
            AutosaveInfo1 = new Label();
            AutosaveActive = new CheckBox();
            AutosaveIntervall1min = new Button();
            AutosaveInfo2 = new Label();
            AutosaveIntervall10min = new Button();
            AutosaveIntervall9min = new Button();
            AutosaveIntervall8min = new Button();
            AutosaveIntervall7min = new Button();
            AutosaveIntervall5min = new Button();
            AutosaveIntervall4min = new Button();
            AutosaveIntervall3min = new Button();
            AutosaveIntervall2min = new Button();
            AutosaveIntervall6min = new Button();
            AutosaveInfo3 = new Label();
            AutosaveNextSave = new Label();
            Copyright = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pull
            // 
            Pull.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Pull.Location = new Point(50, 30);
            Pull.Name = "Pull";
            Pull.Size = new Size(125, 30);
            Pull.TabIndex = 0;
            Pull.Text = "Update Project";
            Pull.UseVisualStyleBackColor = true;
            Pull.Click += Pull_Click;
            // 
            // Save
            // 
            Save.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Save.Location = new Point(50, 90);
            Save.Name = "Save";
            Save.Size = new Size(125, 30);
            Save.TabIndex = 1;
            Save.Text = "Commit Now";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icon1;
            pictureBox1.Location = new Point(588, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // UpdateSuccess
            // 
            UpdateSuccess.AutoSize = true;
            UpdateSuccess.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            UpdateSuccess.ForeColor = Color.Green;
            UpdateSuccess.Location = new Point(200, 30);
            UpdateSuccess.Name = "UpdateSuccess";
            UpdateSuccess.Size = new Size(215, 25);
            UpdateSuccess.TabIndex = 6;
            UpdateSuccess.Text = "Everything Up to Date!";
            UpdateSuccess.Visible = false;
            // 
            // UpdateFail
            // 
            UpdateFail.AutoSize = true;
            UpdateFail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            UpdateFail.ForeColor = Color.Red;
            UpdateFail.Location = new Point(200, 30);
            UpdateFail.Name = "UpdateFail";
            UpdateFail.Size = new Size(204, 25);
            UpdateFail.TabIndex = 7;
            UpdateFail.Text = "Error while Updating!";
            UpdateFail.Visible = false;
            // 
            // UpdateRunning
            // 
            UpdateRunning.AutoSize = true;
            UpdateRunning.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateRunning.ForeColor = Color.Yellow;
            UpdateRunning.Location = new Point(200, 30);
            UpdateRunning.Name = "UpdateRunning";
            UpdateRunning.Size = new Size(111, 25);
            UpdateRunning.TabIndex = 8;
            UpdateRunning.Text = "Updating...";
            UpdateRunning.Visible = false;
            // 
            // OpenLog
            // 
            OpenLog.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            OpenLog.Location = new Point(587, 218);
            OpenLog.Name = "OpenLog";
            OpenLog.Size = new Size(201, 30);
            OpenLog.TabIndex = 9;
            OpenLog.Text = "Show Update History";
            OpenLog.UseVisualStyleBackColor = true;
            OpenLog.Click += OpenLog_Click;
            // 
            // CommitNowName
            // 
            CommitNowName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CommitNowName.Location = new Point(200, 92);
            CommitNowName.Name = "CommitNowName";
            CommitNowName.PlaceholderText = "Manual Save Name";
            CommitNowName.Size = new Size(278, 27);
            CommitNowName.TabIndex = 10;
            // 
            // CommitNowUpdating
            // 
            CommitNowUpdating.AutoSize = true;
            CommitNowUpdating.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CommitNowUpdating.ForeColor = Color.Yellow;
            CommitNowUpdating.Location = new Point(200, 92);
            CommitNowUpdating.Name = "CommitNowUpdating";
            CommitNowUpdating.Size = new Size(121, 25);
            CommitNowUpdating.TabIndex = 11;
            CommitNowUpdating.Text = "Uploading...";
            CommitNowUpdating.Visible = false;
            // 
            // CommitNowError
            // 
            CommitNowError.AutoSize = true;
            CommitNowError.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            CommitNowError.ForeColor = Color.Red;
            CommitNowError.Location = new Point(200, 92);
            CommitNowError.Name = "CommitNowError";
            CommitNowError.Size = new Size(214, 25);
            CommitNowError.TabIndex = 12;
            CommitNowError.Text = "Error while Uploading!";
            CommitNowError.Visible = false;
            // 
            // AutosaveInfo1
            // 
            AutosaveInfo1.AutoSize = true;
            AutosaveInfo1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveInfo1.ForeColor = SystemColors.Window;
            AutosaveInfo1.Location = new Point(50, 187);
            AutosaveInfo1.Name = "AutosaveInfo1";
            AutosaveInfo1.Size = new Size(176, 25);
            AutosaveInfo1.TabIndex = 13;
            AutosaveInfo1.Text = "Autosave Settings:";
            // 
            // AutosaveActive
            // 
            AutosaveActive.AutoSize = true;
            AutosaveActive.CheckAlign = ContentAlignment.MiddleRight;
            AutosaveActive.Checked = true;
            AutosaveActive.CheckState = CheckState.Checked;
            AutosaveActive.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveActive.ForeColor = SystemColors.Window;
            AutosaveActive.Location = new Point(70, 230);
            AutosaveActive.Name = "AutosaveActive";
            AutosaveActive.Size = new Size(194, 29);
            AutosaveActive.TabIndex = 14;
            AutosaveActive.Text = "Autosave Enabled:";
            AutosaveActive.UseVisualStyleBackColor = true;
            AutosaveActive.CheckedChanged += AutosaveActive_CheckedChanged;
            // 
            // AutosaveIntervall1min
            // 
            AutosaveIntervall1min.BackColor = SystemColors.Window;
            AutosaveIntervall1min.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveIntervall1min.Location = new Point(90, 316);
            AutosaveIntervall1min.Name = "AutosaveIntervall1min";
            AutosaveIntervall1min.Size = new Size(30, 30);
            AutosaveIntervall1min.TabIndex = 15;
            AutosaveIntervall1min.Text = "1";
            AutosaveIntervall1min.UseVisualStyleBackColor = false;
            AutosaveIntervall1min.Click += AutosaveIntervallmin_Click;
            // 
            // AutosaveInfo2
            // 
            AutosaveInfo2.AutoSize = true;
            AutosaveInfo2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveInfo2.ForeColor = SystemColors.ScrollBar;
            AutosaveInfo2.Location = new Point(70, 273);
            AutosaveInfo2.Name = "AutosaveInfo2";
            AutosaveInfo2.Size = new Size(290, 25);
            AutosaveInfo2.TabIndex = 16;
            AutosaveInfo2.Text = "Autosave Intervall (in minutes):";
            // 
            // AutosaveIntervall10min
            // 
            AutosaveIntervall10min.BackColor = SystemColors.Window;
            AutosaveIntervall10min.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveIntervall10min.Location = new Point(412, 316);
            AutosaveIntervall10min.Name = "AutosaveIntervall10min";
            AutosaveIntervall10min.Size = new Size(38, 30);
            AutosaveIntervall10min.TabIndex = 17;
            AutosaveIntervall10min.Text = "10";
            AutosaveIntervall10min.UseVisualStyleBackColor = false;
            AutosaveIntervall10min.Click += AutosaveIntervallmin_Click;
            // 
            // AutosaveIntervall9min
            // 
            AutosaveIntervall9min.BackColor = SystemColors.Window;
            AutosaveIntervall9min.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveIntervall9min.Location = new Point(376, 316);
            AutosaveIntervall9min.Name = "AutosaveIntervall9min";
            AutosaveIntervall9min.Size = new Size(30, 30);
            AutosaveIntervall9min.TabIndex = 18;
            AutosaveIntervall9min.Text = "9";
            AutosaveIntervall9min.UseVisualStyleBackColor = false;
            AutosaveIntervall9min.Click += AutosaveIntervallmin_Click;
            // 
            // AutosaveIntervall8min
            // 
            AutosaveIntervall8min.BackColor = SystemColors.Window;
            AutosaveIntervall8min.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveIntervall8min.Location = new Point(340, 316);
            AutosaveIntervall8min.Name = "AutosaveIntervall8min";
            AutosaveIntervall8min.Size = new Size(30, 30);
            AutosaveIntervall8min.TabIndex = 19;
            AutosaveIntervall8min.Text = "8";
            AutosaveIntervall8min.UseVisualStyleBackColor = false;
            AutosaveIntervall8min.Click += AutosaveIntervallmin_Click;
            // 
            // AutosaveIntervall7min
            // 
            AutosaveIntervall7min.BackColor = SystemColors.Window;
            AutosaveIntervall7min.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveIntervall7min.Location = new Point(304, 316);
            AutosaveIntervall7min.Name = "AutosaveIntervall7min";
            AutosaveIntervall7min.Size = new Size(30, 30);
            AutosaveIntervall7min.TabIndex = 20;
            AutosaveIntervall7min.Text = "7";
            AutosaveIntervall7min.UseVisualStyleBackColor = false;
            AutosaveIntervall7min.Click += AutosaveIntervallmin_Click;
            // 
            // AutosaveIntervall5min
            // 
            AutosaveIntervall5min.BackColor = Color.DarkTurquoise;
            AutosaveIntervall5min.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveIntervall5min.ForeColor = SystemColors.ControlText;
            AutosaveIntervall5min.Location = new Point(232, 316);
            AutosaveIntervall5min.Name = "AutosaveIntervall5min";
            AutosaveIntervall5min.Size = new Size(30, 30);
            AutosaveIntervall5min.TabIndex = 22;
            AutosaveIntervall5min.Text = "5";
            AutosaveIntervall5min.UseVisualStyleBackColor = false;
            AutosaveIntervall5min.Click += AutosaveIntervallmin_Click;
            // 
            // AutosaveIntervall4min
            // 
            AutosaveIntervall4min.BackColor = SystemColors.Window;
            AutosaveIntervall4min.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveIntervall4min.Location = new Point(196, 316);
            AutosaveIntervall4min.Name = "AutosaveIntervall4min";
            AutosaveIntervall4min.Size = new Size(30, 30);
            AutosaveIntervall4min.TabIndex = 23;
            AutosaveIntervall4min.Text = "4";
            AutosaveIntervall4min.UseVisualStyleBackColor = false;
            AutosaveIntervall4min.Click += AutosaveIntervallmin_Click;
            // 
            // AutosaveIntervall3min
            // 
            AutosaveIntervall3min.BackColor = SystemColors.Window;
            AutosaveIntervall3min.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveIntervall3min.Location = new Point(162, 316);
            AutosaveIntervall3min.Name = "AutosaveIntervall3min";
            AutosaveIntervall3min.Size = new Size(30, 30);
            AutosaveIntervall3min.TabIndex = 24;
            AutosaveIntervall3min.Text = "3";
            AutosaveIntervall3min.UseVisualStyleBackColor = false;
            AutosaveIntervall3min.Click += AutosaveIntervallmin_Click;
            // 
            // AutosaveIntervall2min
            // 
            AutosaveIntervall2min.BackColor = SystemColors.Window;
            AutosaveIntervall2min.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveIntervall2min.Location = new Point(126, 316);
            AutosaveIntervall2min.Name = "AutosaveIntervall2min";
            AutosaveIntervall2min.Size = new Size(30, 30);
            AutosaveIntervall2min.TabIndex = 25;
            AutosaveIntervall2min.Text = "2";
            AutosaveIntervall2min.UseVisualStyleBackColor = false;
            AutosaveIntervall2min.Click += AutosaveIntervallmin_Click;
            // 
            // AutosaveIntervall6min
            // 
            AutosaveIntervall6min.BackColor = SystemColors.Window;
            AutosaveIntervall6min.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveIntervall6min.Location = new Point(268, 316);
            AutosaveIntervall6min.Name = "AutosaveIntervall6min";
            AutosaveIntervall6min.Size = new Size(30, 30);
            AutosaveIntervall6min.TabIndex = 21;
            AutosaveIntervall6min.Text = "6";
            AutosaveIntervall6min.UseVisualStyleBackColor = false;
            AutosaveIntervall6min.Click += AutosaveIntervallmin_Click;
            // 
            // AutosaveInfo3
            // 
            AutosaveInfo3.AutoSize = true;
            AutosaveInfo3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveInfo3.ForeColor = Color.Green;
            AutosaveInfo3.Location = new Point(494, 317);
            AutosaveInfo3.Name = "AutosaveInfo3";
            AutosaveInfo3.Size = new Size(147, 25);
            AutosaveInfo3.TabIndex = 26;
            AutosaveInfo3.Text = "Next Autosave:";
            // 
            // AutosaveNextSave
            // 
            AutosaveNextSave.AutoSize = true;
            AutosaveNextSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutosaveNextSave.ForeColor = Color.Green;
            AutosaveNextSave.Location = new Point(647, 317);
            AutosaveNextSave.Name = "AutosaveNextSave";
            AutosaveNextSave.Size = new Size(61, 25);
            AutosaveNextSave.TabIndex = 27;
            AutosaveNextSave.Text = "00:00";
            // 
            // Copyright
            // 
            Copyright.AutoSize = true;
            Copyright.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Copyright.ForeColor = Color.Gray;
            Copyright.Location = new Point(670, 355);
            Copyright.Name = "Copyright";
            Copyright.Size = new Size(118, 21);
            Copyright.TabIndex = 28;
            Copyright.Text = "© Jakederechte";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 385);
            Controls.Add(Copyright);
            Controls.Add(AutosaveNextSave);
            Controls.Add(AutosaveInfo3);
            Controls.Add(AutosaveIntervall2min);
            Controls.Add(AutosaveIntervall3min);
            Controls.Add(AutosaveIntervall4min);
            Controls.Add(AutosaveIntervall5min);
            Controls.Add(AutosaveIntervall6min);
            Controls.Add(AutosaveIntervall7min);
            Controls.Add(AutosaveIntervall8min);
            Controls.Add(AutosaveIntervall9min);
            Controls.Add(AutosaveIntervall10min);
            Controls.Add(AutosaveInfo2);
            Controls.Add(AutosaveIntervall1min);
            Controls.Add(AutosaveActive);
            Controls.Add(AutosaveInfo1);
            Controls.Add(CommitNowError);
            Controls.Add(CommitNowUpdating);
            Controls.Add(CommitNowName);
            Controls.Add(OpenLog);
            Controls.Add(UpdateRunning);
            Controls.Add(UpdateFail);
            Controls.Add(UpdateSuccess);
            Controls.Add(pictureBox1);
            Controls.Add(Save);
            Controls.Add(Pull);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "GitHub Uploader";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Pull;
        private Button Save;
        private PictureBox pictureBox1;
        private Label UpdateSuccess;
        private Label UpdateFail;
        private Label UpdateRunning;
        private Button OpenLog;
        private TextBox CommitNowName;
        private Label CommitNowUpdating;
        private Label CommitNowError;
        private Label AutosaveInfo1;
        private CheckBox AutosaveActive;
        private Button AutosaveIntervall1min;
        private Label AutosaveInfo2;
        private Button AutosaveIntervall10min;
        private Button AutosaveIntervall9min;
        private Button AutosaveIntervall8min;
        private Button AutosaveIntervall7min;
        private Button AutosaveIntervall5min;
        private Button AutosaveIntervall4min;
        private Button AutosaveIntervall3min;
        private Button AutosaveIntervall2min;
        private Button AutosaveIntervall6min;
        private Label AutosaveInfo3;
        private Label AutosaveNextSave;
        private Label Copyright;
    }
}