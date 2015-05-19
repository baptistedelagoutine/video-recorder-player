namespace VideoPicture
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RecButton = new System.Windows.Forms.Button();
            this.ModeTabControl = new System.Windows.Forms.TabControl();
            this.VideoRecorderTabPage = new System.Windows.Forms.TabPage();
            this.VideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.PictureGrabberTabPage = new System.Windows.Forms.TabPage();
            this.CapturedImagesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Image1PictureBox = new System.Windows.Forms.PictureBox();
            this.Image2PictureBox = new System.Windows.Forms.PictureBox();
            this.Image3PictureBox = new System.Windows.Forms.PictureBox();
            this.Image4PictureBox = new System.Windows.Forms.PictureBox();
            this.Image5PictureBox = new System.Windows.Forms.PictureBox();
            this.Image6PictureBox = new System.Windows.Forms.PictureBox();
            this.VideoControlsPanel = new System.Windows.Forms.Panel();
            this.PreviousFrameButton = new System.Windows.Forms.Button();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.NextFrameButton = new System.Windows.Forms.Button();
            this.TimeReplayedVideoTrackBar = new System.Windows.Forms.TrackBar();
            this.ReplayedVideoPictureBox = new System.Windows.Forms.PictureBox();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CameraComboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ResolutionCameraComboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.FactorCameraVideoComboBox = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.PathRecordedVideoTextBox = new System.Windows.Forms.TextBox();
            this.PathRecordedVideoButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RecordingDurationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CouleurCompteurComboBox = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.PathRecordedPicturesTextBox = new System.Windows.Forms.TextBox();
            this.PathRecordedPicturesButton = new System.Windows.Forms.Button();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.ModeTabControl.SuspendLayout();
            this.VideoRecorderTabPage.SuspendLayout();
            this.PictureGrabberTabPage.SuspendLayout();
            this.CapturedImagesFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image6PictureBox)).BeginInit();
            this.VideoControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeReplayedVideoTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayedVideoPictureBox)).BeginInit();
            this.SettingsTabPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordingDurationNumericUpDown)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecButton
            // 
            this.RecButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RecButton.Location = new System.Drawing.Point(17, 465);
            this.RecButton.Name = "RecButton";
            this.RecButton.Size = new System.Drawing.Size(80, 50);
            this.RecButton.TabIndex = 0;
            this.RecButton.UseVisualStyleBackColor = true;
            this.RecButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RecButton_MouseClick);
            // 
            // ModeTabControl
            // 
            this.ModeTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.ModeTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeTabControl.Controls.Add(this.VideoRecorderTabPage);
            this.ModeTabControl.Controls.Add(this.PictureGrabberTabPage);
            this.ModeTabControl.Controls.Add(this.SettingsTabPage);
            this.ModeTabControl.Location = new System.Drawing.Point(0, 0);
            this.ModeTabControl.Multiline = true;
            this.ModeTabControl.Name = "ModeTabControl";
            this.ModeTabControl.Padding = new System.Drawing.Point(0, 0);
            this.ModeTabControl.SelectedIndex = 0;
            this.ModeTabControl.Size = new System.Drawing.Size(784, 561);
            this.ModeTabControl.TabIndex = 2;
            this.ModeTabControl.SelectedIndexChanged += new System.EventHandler(this.ModeTabControl_SelectedIndexChanged);
            // 
            // VideoRecorderTabPage
            // 
            this.VideoRecorderTabPage.Controls.Add(this.RecButton);
            this.VideoRecorderTabPage.Controls.Add(this.VideoSourcePlayer);
            this.VideoRecorderTabPage.Location = new System.Drawing.Point(4, 4);
            this.VideoRecorderTabPage.Name = "VideoRecorderTabPage";
            this.VideoRecorderTabPage.Size = new System.Drawing.Size(776, 535);
            this.VideoRecorderTabPage.TabIndex = 0;
            this.VideoRecorderTabPage.Text = "Enregistrer une vidéo (F1)";
            this.VideoRecorderTabPage.UseVisualStyleBackColor = true;
            // 
            // VideoSourcePlayer
            // 
            this.VideoSourcePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoSourcePlayer.BackColor = System.Drawing.Color.Black;
            this.VideoSourcePlayer.ForeColor = System.Drawing.Color.DarkRed;
            this.VideoSourcePlayer.Location = new System.Drawing.Point(0, 0);
            this.VideoSourcePlayer.Name = "VideoSourcePlayer";
            this.VideoSourcePlayer.Size = new System.Drawing.Size(776, 535);
            this.VideoSourcePlayer.TabIndex = 1;
            this.VideoSourcePlayer.VideoSource = null;
            this.VideoSourcePlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.VideoSourcePlayer_Paint);
            // 
            // PictureGrabberTabPage
            // 
            this.PictureGrabberTabPage.Controls.Add(this.CapturedImagesFlowLayoutPanel);
            this.PictureGrabberTabPage.Controls.Add(this.VideoControlsPanel);
            this.PictureGrabberTabPage.Controls.Add(this.ReplayedVideoPictureBox);
            this.PictureGrabberTabPage.Location = new System.Drawing.Point(4, 4);
            this.PictureGrabberTabPage.Name = "PictureGrabberTabPage";
            this.PictureGrabberTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PictureGrabberTabPage.Size = new System.Drawing.Size(776, 535);
            this.PictureGrabberTabPage.TabIndex = 1;
            this.PictureGrabberTabPage.Text = "Extraire les photos (F2)";
            // 
            // CapturedImagesFlowLayoutPanel
            // 
            this.CapturedImagesFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CapturedImagesFlowLayoutPanel.AutoSize = true;
            this.CapturedImagesFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CapturedImagesFlowLayoutPanel.Controls.Add(this.Image1PictureBox);
            this.CapturedImagesFlowLayoutPanel.Controls.Add(this.Image2PictureBox);
            this.CapturedImagesFlowLayoutPanel.Controls.Add(this.Image3PictureBox);
            this.CapturedImagesFlowLayoutPanel.Controls.Add(this.Image4PictureBox);
            this.CapturedImagesFlowLayoutPanel.Controls.Add(this.Image5PictureBox);
            this.CapturedImagesFlowLayoutPanel.Controls.Add(this.Image6PictureBox);
            this.CapturedImagesFlowLayoutPanel.Location = new System.Drawing.Point(10, 406);
            this.CapturedImagesFlowLayoutPanel.Name = "CapturedImagesFlowLayoutPanel";
            this.CapturedImagesFlowLayoutPanel.Size = new System.Drawing.Size(756, 126);
            this.CapturedImagesFlowLayoutPanel.TabIndex = 2;
            // 
            // Image1PictureBox
            // 
            this.Image1PictureBox.BackColor = System.Drawing.Color.Black;
            this.Image1PictureBox.Location = new System.Drawing.Point(3, 3);
            this.Image1PictureBox.Name = "Image1PictureBox";
            this.Image1PictureBox.Size = new System.Drawing.Size(120, 120);
            this.Image1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image1PictureBox.TabIndex = 0;
            this.Image1PictureBox.TabStop = false;
            this.Image1PictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // Image2PictureBox
            // 
            this.Image2PictureBox.BackColor = System.Drawing.Color.Black;
            this.Image2PictureBox.Location = new System.Drawing.Point(129, 3);
            this.Image2PictureBox.Name = "Image2PictureBox";
            this.Image2PictureBox.Size = new System.Drawing.Size(120, 120);
            this.Image2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image2PictureBox.TabIndex = 1;
            this.Image2PictureBox.TabStop = false;
            this.Image2PictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // Image3PictureBox
            // 
            this.Image3PictureBox.BackColor = System.Drawing.Color.Black;
            this.Image3PictureBox.Location = new System.Drawing.Point(255, 3);
            this.Image3PictureBox.Name = "Image3PictureBox";
            this.Image3PictureBox.Size = new System.Drawing.Size(120, 120);
            this.Image3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image3PictureBox.TabIndex = 2;
            this.Image3PictureBox.TabStop = false;
            this.Image3PictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // Image4PictureBox
            // 
            this.Image4PictureBox.BackColor = System.Drawing.Color.Black;
            this.Image4PictureBox.Location = new System.Drawing.Point(381, 3);
            this.Image4PictureBox.Name = "Image4PictureBox";
            this.Image4PictureBox.Size = new System.Drawing.Size(120, 120);
            this.Image4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image4PictureBox.TabIndex = 3;
            this.Image4PictureBox.TabStop = false;
            this.Image4PictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // Image5PictureBox
            // 
            this.Image5PictureBox.BackColor = System.Drawing.Color.Black;
            this.Image5PictureBox.Location = new System.Drawing.Point(507, 3);
            this.Image5PictureBox.Name = "Image5PictureBox";
            this.Image5PictureBox.Size = new System.Drawing.Size(120, 120);
            this.Image5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image5PictureBox.TabIndex = 4;
            this.Image5PictureBox.TabStop = false;
            this.Image5PictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // Image6PictureBox
            // 
            this.Image6PictureBox.BackColor = System.Drawing.Color.Black;
            this.Image6PictureBox.Location = new System.Drawing.Point(633, 3);
            this.Image6PictureBox.Name = "Image6PictureBox";
            this.Image6PictureBox.Size = new System.Drawing.Size(120, 120);
            this.Image6PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image6PictureBox.TabIndex = 5;
            this.Image6PictureBox.TabStop = false;
            this.Image6PictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // VideoControlsPanel
            // 
            this.VideoControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoControlsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VideoControlsPanel.Controls.Add(this.PreviousFrameButton);
            this.VideoControlsPanel.Controls.Add(this.PlayPauseButton);
            this.VideoControlsPanel.Controls.Add(this.NextFrameButton);
            this.VideoControlsPanel.Controls.Add(this.TimeReplayedVideoTrackBar);
            this.VideoControlsPanel.Location = new System.Drawing.Point(0, 361);
            this.VideoControlsPanel.Name = "VideoControlsPanel";
            this.VideoControlsPanel.Size = new System.Drawing.Size(776, 39);
            this.VideoControlsPanel.TabIndex = 5;
            // 
            // PreviousFrameButton
            // 
            this.PreviousFrameButton.Image = global::VideoPicture.Properties.Resources.previous;
            this.PreviousFrameButton.Location = new System.Drawing.Point(0, 0);
            this.PreviousFrameButton.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PreviousFrameButton.Name = "PreviousFrameButton";
            this.PreviousFrameButton.Size = new System.Drawing.Size(40, 36);
            this.PreviousFrameButton.TabIndex = 2;
            this.PreviousFrameButton.UseVisualStyleBackColor = true;
            this.PreviousFrameButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PreviousFrameButton_MouseClick);
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.Image = global::VideoPicture.Properties.Resources.play;
            this.PlayPauseButton.Location = new System.Drawing.Point(42, 0);
            this.PlayPauseButton.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(40, 36);
            this.PlayPauseButton.TabIndex = 3;
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayPauseButton_MouseClick);
            // 
            // NextFrameButton
            // 
            this.NextFrameButton.Image = global::VideoPicture.Properties.Resources.next;
            this.NextFrameButton.Location = new System.Drawing.Point(84, 0);
            this.NextFrameButton.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NextFrameButton.Name = "NextFrameButton";
            this.NextFrameButton.Size = new System.Drawing.Size(40, 36);
            this.NextFrameButton.TabIndex = 4;
            this.NextFrameButton.UseVisualStyleBackColor = true;
            this.NextFrameButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NextFrameButton_MouseClick);
            // 
            // TimeReplayedVideoTrackBar
            // 
            this.TimeReplayedVideoTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeReplayedVideoTrackBar.AutoSize = false;
            this.TimeReplayedVideoTrackBar.Location = new System.Drawing.Point(128, 1);
            this.TimeReplayedVideoTrackBar.Maximum = 1;
            this.TimeReplayedVideoTrackBar.Name = "TimeReplayedVideoTrackBar";
            this.TimeReplayedVideoTrackBar.Size = new System.Drawing.Size(648, 29);
            this.TimeReplayedVideoTrackBar.TabIndex = 1;
            this.TimeReplayedVideoTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // ReplayedVideoPictureBox
            // 
            this.ReplayedVideoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplayedVideoPictureBox.BackColor = System.Drawing.Color.Black;
            this.ReplayedVideoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ReplayedVideoPictureBox.Name = "ReplayedVideoPictureBox";
            this.ReplayedVideoPictureBox.Size = new System.Drawing.Size(776, 360);
            this.ReplayedVideoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ReplayedVideoPictureBox.TabIndex = 0;
            this.ReplayedVideoPictureBox.TabStop = false;
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.Controls.Add(this.panel2);
            this.SettingsTabPage.Controls.Add(this.flowLayoutPanel1);
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 4);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(776, 535);
            this.SettingsTabPage.TabIndex = 2;
            this.SettingsTabPage.Text = "Réglages";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(130, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 366);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CameraComboBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 24);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Caméra";
            // 
            // CameraComboBox
            // 
            this.CameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CameraComboBox.FormattingEnabled = true;
            this.CameraComboBox.Location = new System.Drawing.Point(182, 0);
            this.CameraComboBox.Name = "CameraComboBox";
            this.CameraComboBox.Size = new System.Drawing.Size(318, 21);
            this.CameraComboBox.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ResolutionCameraComboBox);
            this.panel3.Location = new System.Drawing.Point(3, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 27);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Résolution de la caméra";
            // 
            // ResolutionCameraComboBox
            // 
            this.ResolutionCameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionCameraComboBox.FormattingEnabled = true;
            this.ResolutionCameraComboBox.Location = new System.Drawing.Point(182, 3);
            this.ResolutionCameraComboBox.Name = "ResolutionCameraComboBox";
            this.ResolutionCameraComboBox.Size = new System.Drawing.Size(121, 21);
            this.ResolutionCameraComboBox.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.FactorCameraVideoComboBox);
            this.panel5.Location = new System.Drawing.Point(3, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 27);
            this.panel5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Facteur caméra / vidéo";
            // 
            // FactorCameraVideoComboBox
            // 
            this.FactorCameraVideoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FactorCameraVideoComboBox.FormattingEnabled = true;
            this.FactorCameraVideoComboBox.Location = new System.Drawing.Point(182, 3);
            this.FactorCameraVideoComboBox.Name = "FactorCameraVideoComboBox";
            this.FactorCameraVideoComboBox.Size = new System.Drawing.Size(121, 21);
            this.FactorCameraVideoComboBox.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.flowLayoutPanel2);
            this.panel4.Location = new System.Drawing.Point(3, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 35);
            this.panel4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Répertoire sauvegarde de la vidéo";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.PathRecordedVideoTextBox);
            this.flowLayoutPanel2.Controls.Add(this.PathRecordedVideoButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(179, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(353, 29);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // PathRecordedVideoTextBox
            // 
            this.PathRecordedVideoTextBox.Location = new System.Drawing.Point(3, 4);
            this.PathRecordedVideoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.PathRecordedVideoTextBox.Name = "PathRecordedVideoTextBox";
            this.PathRecordedVideoTextBox.ReadOnly = true;
            this.PathRecordedVideoTextBox.Size = new System.Drawing.Size(315, 20);
            this.PathRecordedVideoTextBox.TabIndex = 2;
            // 
            // PathRecordedVideoButton
            // 
            this.PathRecordedVideoButton.Location = new System.Drawing.Point(324, 3);
            this.PathRecordedVideoButton.Name = "PathRecordedVideoButton";
            this.PathRecordedVideoButton.Size = new System.Drawing.Size(26, 23);
            this.PathRecordedVideoButton.TabIndex = 2;
            this.PathRecordedVideoButton.Text = "...";
            this.PathRecordedVideoButton.UseVisualStyleBackColor = true;
            this.PathRecordedVideoButton.Click += new System.EventHandler(this.PathRecordedVideoButton_Click);
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.RecordingDurationNumericUpDown);
            this.panel6.Location = new System.Drawing.Point(3, 140);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 26);
            this.panel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temps d\'enregistrement (sec)";
            // 
            // RecordingDurationNumericUpDown
            // 
            this.RecordingDurationNumericUpDown.Location = new System.Drawing.Point(182, 3);
            this.RecordingDurationNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.RecordingDurationNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.RecordingDurationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RecordingDurationNumericUpDown.Name = "RecordingDurationNumericUpDown";
            this.RecordingDurationNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.RecordingDurationNumericUpDown.TabIndex = 3;
            this.RecordingDurationNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.CouleurCompteurComboBox);
            this.panel7.Location = new System.Drawing.Point(3, 172);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(306, 27);
            this.panel7.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Couleur du compteur";
            // 
            // CouleurCompteurComboBox
            // 
            this.CouleurCompteurComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CouleurCompteurComboBox.FormattingEnabled = true;
            this.CouleurCompteurComboBox.Location = new System.Drawing.Point(182, 3);
            this.CouleurCompteurComboBox.Name = "CouleurCompteurComboBox";
            this.CouleurCompteurComboBox.Size = new System.Drawing.Size(121, 21);
            this.CouleurCompteurComboBox.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.flowLayoutPanel3);
            this.panel8.Location = new System.Drawing.Point(3, 205);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(535, 35);
            this.panel8.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Répertoire sauvegarde des photos";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.PathRecordedPicturesTextBox);
            this.flowLayoutPanel3.Controls.Add(this.PathRecordedPicturesButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(179, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(353, 29);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // PathRecordedPicturesTextBox
            // 
            this.PathRecordedPicturesTextBox.Location = new System.Drawing.Point(3, 4);
            this.PathRecordedPicturesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.PathRecordedPicturesTextBox.Name = "PathRecordedPicturesTextBox";
            this.PathRecordedPicturesTextBox.ReadOnly = true;
            this.PathRecordedPicturesTextBox.Size = new System.Drawing.Size(315, 20);
            this.PathRecordedPicturesTextBox.TabIndex = 2;
            // 
            // PathRecordedPicturesButton
            // 
            this.PathRecordedPicturesButton.Location = new System.Drawing.Point(324, 3);
            this.PathRecordedPicturesButton.Name = "PathRecordedPicturesButton";
            this.PathRecordedPicturesButton.Size = new System.Drawing.Size(26, 23);
            this.PathRecordedPicturesButton.TabIndex = 2;
            this.PathRecordedPicturesButton.Text = "...";
            this.PathRecordedPicturesButton.UseVisualStyleBackColor = true;
            this.PathRecordedPicturesButton.Click += new System.EventHandler(this.PathRecordedPicturesButton_Click);
            // 
            // InformationLabel
            // 
            this.InformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.InformationLabel.Location = new System.Drawing.Point(350, 545);
            this.InformationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(430, 15);
            this.InformationLabel.TabIndex = 1;
            this.InformationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.ModeTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoPicture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.ModeTabControl.ResumeLayout(false);
            this.VideoRecorderTabPage.ResumeLayout(false);
            this.PictureGrabberTabPage.ResumeLayout(false);
            this.PictureGrabberTabPage.PerformLayout();
            this.CapturedImagesFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image6PictureBox)).EndInit();
            this.VideoControlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeReplayedVideoTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayedVideoPictureBox)).EndInit();
            this.SettingsTabPage.ResumeLayout(false);
            this.SettingsTabPage.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordingDurationNumericUpDown)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ModeTabControl;
        private System.Windows.Forms.TabPage VideoRecorderTabPage;
        private System.Windows.Forms.TabPage PictureGrabberTabPage;
        private System.Windows.Forms.Button RecButton;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button PathRecordedVideoButton;
        private System.Windows.Forms.TextBox PathRecordedVideoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RecordingDurationNumericUpDown;
        private System.Windows.Forms.PictureBox ReplayedVideoPictureBox;
        private System.Windows.Forms.TrackBar TimeReplayedVideoTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel CapturedImagesFlowLayoutPanel;
        private System.Windows.Forms.PictureBox Image1PictureBox;
        private System.Windows.Forms.PictureBox Image2PictureBox;
        private System.Windows.Forms.PictureBox Image3PictureBox;
        private System.Windows.Forms.PictureBox Image4PictureBox;
        private System.Windows.Forms.PictureBox Image5PictureBox;
        private System.Windows.Forms.PictureBox Image6PictureBox;
        private System.Windows.Forms.Label InformationLabel;
        private AForge.Controls.VideoSourcePlayer VideoSourcePlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CameraComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ResolutionCameraComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox FactorCameraVideoComboBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox CouleurCompteurComboBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox PathRecordedPicturesTextBox;
        private System.Windows.Forms.Button PathRecordedPicturesButton;
        private System.Windows.Forms.Button PreviousFrameButton;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button NextFrameButton;
        private System.Windows.Forms.Panel VideoControlsPanel;
    }
}

