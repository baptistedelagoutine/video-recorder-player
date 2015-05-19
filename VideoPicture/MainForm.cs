using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VideoPicture
{
    public partial class MainForm : Form
    {
        VideoRecorder _VideoRecorder;
        PictureGrabber _PictureGrabber;
        Settings _Settings;
        Logger _Logger;
        Timer _Timer;
        FolderBrowserDialog _FolderBrowserDialog;
        int _Counter;
        Font _FontCounter;
        Point _PointCounter;

        public MainForm()
        {
            InitializeComponent();

            _Timer = new Timer();
            _Timer.Interval = 1000;
            _Timer.Tick += _Timer_Tick;

            _FolderBrowserDialog = new FolderBrowserDialog();

            _FontCounter = new Font("Arial", 72, FontStyle.Bold);
            _PointCounter = new Point(20, 20);

            VideoSourcePlayer.KeepAspectRatio = true;

            _Settings = new Settings();

            _Logger = new Logger(InformationLabel);

            _VideoRecorder = new VideoRecorder(_Logger, _Settings, VideoSourcePlayer, this);
            _VideoRecorder.FrameRateChanged += _VideoRecorder_FrameRateChanged;

            _PictureGrabber = new PictureGrabber(_Logger, _Settings, this);
            _PictureGrabber.VideoLoaded += _PictureGrabber_VideoLoaded;
            _PictureGrabber.NewFrame += _PictureGrabber_NewFrame;
            _PictureGrabber.PlayerStateChanged += _PictureGrabber_PlayerStateChanged;

            TimeReplayedVideoTrackBar.ValueChanged += TimeReplayedVideoTrackBar_ValueChanged;

        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if (_Settings.FormMaximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.Size = _Settings.SizeForm;

            StartModeVideoRecorder();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopModePictureGrabber();
            StopModeVideoRecorder();

            _Settings.FormMaximized = this.WindowState == FormWindowState.Maximized;

            if (this.WindowState == FormWindowState.Normal)
                _Settings.SizeForm = this.Size;

            _Settings.Save();
        }

        private void ModeTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (IsModeVideoRecorder())
                StartMode(Mode.VideoRecorder);
            else if (IsModePictureGrabber())
                StartMode(Mode.PictureGrabber);
            else if (IsModeSettings())
                StartMode(Mode.Settings);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (IsModeVideoRecorder() && RecButton.Enabled)
                    StartStopRecordingAlternate();
                if (IsModePictureGrabber() && VideoControlsPanel.Enabled)
                    PlayPauseAlternate();
            }

            if (e.KeyCode == Keys.Enter && IsModePictureGrabber() && VideoControlsPanel.Enabled)
            {
                PictureBox box = FindNextEmptyPictureBox();

                SaveImageAndUpdatePictureBox(box);
            }

            if (e.KeyCode == Keys.F1 && IsModeVideoRecorder() == false)
                ModeTabControl.SelectedTab = VideoRecorderTabPage;

            if (e.KeyCode == Keys.F2 && IsModePictureGrabber() == false)
                ModeTabControl.SelectedTab = PictureGrabberTabPage;

            if (e.KeyCode == Keys.Tab && IsModeVideoRecorder())
                _VideoRecorder.DisplayPropertyPage();

            e.Handled = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && IsModePictureGrabber() && VideoControlsPanel.Enabled)
                _PictureGrabber.PreviousFrame();

            if (e.KeyCode == Keys.Right && IsModePictureGrabber() && VideoControlsPanel.Enabled)
                _PictureGrabber.NextFrame();

            e.Handled = true;
        }

        // -- -- events video recorder tab -- --

        private void RecButton_MouseClick(object sender, MouseEventArgs e)
        {
            StartStopRecordingAlternate();
        }

        private void _Timer_Tick(object sender, System.EventArgs e)
        {
            _Counter++;

            if (_Counter >= _Settings.RecordingDuration)
                StopRecording();
        }

        private void _VideoRecorder_FrameRateChanged(object sender, EventArgs e)
        {
            _Logger.InformUser(_VideoRecorder.FrameRate + " f/s");
        }

        private void VideoSourcePlayer_Paint(object sender, PaintEventArgs e)
        {
            if (_VideoRecorder.IsRecording)
                TextRenderer.DrawText(e.Graphics, _Counter.ToString(), _FontCounter, _PointCounter, _Settings.CounterColor);
        }

        // -- -- events picture grabber tab -- --

        private void ImagePictureBox_Click(object sender, System.EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            SaveImageAndUpdatePictureBox(pictureBox);
        }

        private void SaveImageAndUpdatePictureBox(PictureBox pictureBox)
        {
            if (pictureBox != null)
            {
                string numNameImage = string.Empty;

                if (pictureBox == Image1PictureBox)
                    numNameImage = "1";
                if (pictureBox == Image2PictureBox)
                    numNameImage = "2";
                if (pictureBox == Image3PictureBox)
                    numNameImage = "3";
                if (pictureBox == Image4PictureBox)
                    numNameImage = "4";
                if (pictureBox == Image5PictureBox)
                    numNameImage = "5";
                if (pictureBox == Image6PictureBox)
                    numNameImage = "6";

                _PictureGrabber.SaveCurrentFrame(numNameImage);

                DisposeImagePictureBox(pictureBox);
                pictureBox.Image = (Image)ReplayedVideoPictureBox.Image.Clone();
            }
        }

        private PictureBox FindNextEmptyPictureBox()
        {
            if (Image1PictureBox.Image == null)
                return Image1PictureBox;
            if (Image2PictureBox.Image == null)
                return Image2PictureBox;
            if (Image3PictureBox.Image == null)
                return Image3PictureBox;
            if (Image4PictureBox.Image == null)
                return Image4PictureBox;
            if (Image5PictureBox.Image == null)
                return Image5PictureBox;
            if (Image6PictureBox.Image == null)
                return Image6PictureBox;

            return null;
        }

        private void TimeReplayedVideoTrackBar_ValueChanged(object sender, System.EventArgs e)
        {
            _PictureGrabber.GoToFrame(TimeReplayedVideoTrackBar.Value);
        }

        private void _PictureGrabber_NewFrame(object sender, EventArgs e)
        {
            DisposeImagePictureBox(ReplayedVideoPictureBox);
            ReplayedVideoPictureBox.Image = _PictureGrabber.GetCurrentFrame();

            TimeReplayedVideoTrackBarSetValue(_PictureGrabber.GetCurrentFrameIndex());
        }

        private void _PictureGrabber_PlayerStateChanged(object sender, PlayerStateEventArgs e)
        {
            UpdatePlayPauseButton();
        }

        private void PlayPauseButton_MouseClick(object sender, MouseEventArgs e)
        {
            PlayPauseAlternate();
        }

        private void PreviousFrameButton_MouseClick(object sender, MouseEventArgs e)
        {
            _PictureGrabber.PreviousFrame();
        }

        private void NextFrameButton_MouseClick(object sender, MouseEventArgs e)
        {
            _PictureGrabber.NextFrame();
        }

        // -- -- events settings tab -- --

        void CameraComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string monikerString = CameraComboBox.SelectedValue as string;

            if (string.IsNullOrEmpty(monikerString) == false)
            {
                _Settings.CameraMonikerString = monikerString;

                LoadCameraResolution();
            }
        }

        void ResolutionCameraComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBoxItem item = ResolutionCameraComboBox.SelectedItem as ComboBoxItem;
            Size? cameraResolution = item.Value as Size?;

            if (cameraResolution.HasValue && cameraResolution.Value.IsEmpty == false)
                _Settings.ResolutionCamera = cameraResolution.Value;
        }

        void FactorCameraVideoComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            float value = (float)FactorCameraVideoComboBox.SelectedItem;

            _Settings.FactorResolutionCameraVideo = value;
        }

        void RecordingDurationNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            _Settings.RecordingDuration = Convert.ToInt32(RecordingDurationNumericUpDown.Value);
        }

        void CouleurCompteurComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Color color = (Color)CouleurCompteurComboBox.SelectedItem;

            _Settings.CounterColor = color;
        }

        private void PathRecordedVideoButton_Click(object sender, EventArgs e)
        {
            _FolderBrowserDialog.SelectedPath = _Settings.PathRecordedVideo;

            if (_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _Settings.PathRecordedVideo = _FolderBrowserDialog.SelectedPath;

                PathRecordedVideoTextBox.Text = _Settings.PathRecordedVideo;
            }
        }

        private void PathRecordedPicturesButton_Click(object sender, EventArgs e)
        {
            _FolderBrowserDialog.SelectedPath = _Settings.PathRecordedPictures;

            if (_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _Settings.PathRecordedPictures = _FolderBrowserDialog.SelectedPath;

                PathRecordedPicturesTextBox.Text = _Settings.PathRecordedPictures;
            }
        }

        // -- -- Partie Controller (en quelques sortes) -- --

        private void StartModeVideoRecorder()
        {
            RecButton.Text = Strings.StartRecVideo;
            RecButton.Enabled = false;

            if (_VideoRecorder.Connect())
                RecButton.Enabled = true;
        }

        private void StopModeVideoRecorder()
        {
            if (_VideoRecorder.IsRecording)
                StopRecording();

            _VideoRecorder.Disconnect();
            RecButton.Enabled = false;
        }

        private void StartStopRecordingAlternate()
        {
            if (_VideoRecorder.IsRecording)
                StopRecording();
            else
                StartRecording();
        }

        private void StartRecording()
        {
            RecButton.Text = Strings.StopRecVideo;
            RecButton.BackColor = Color.Red;

            _VideoRecorder.StartRecordingVideo();

            _Counter = 0;
            _Timer.Start();
        }

        private void StopRecording()
        {
            RecButton.Text = Strings.StartRecVideo;
            RecButton.BackColor = Color.Transparent;

            _VideoRecorder.StopRecordingVideo();

            _Timer.Stop();
        }

        private void StartModePictureGrabber()
        {
            LockModePictureGrabberUi(true);

            if (!_Settings.HasPathRecordedPictures())
            {
                _Logger.InformUser(Strings.PasDePathRecordPictures);
                return;
            }

            _PictureGrabber.LoadRecordedVideo();
        }

        private void _PictureGrabber_VideoLoaded(object sender, VideoLoadedEventArgs e)
        {
            LockModePictureGrabberUi(false);

            TimeReplayedVideoTrackBar.Maximum = e.NumberOfFramesLoaded - 1;
            TimeReplayedVideoTrackBarSetValue(0);

            ReplayedVideoPictureBox.Image = _PictureGrabber.GetCurrentFrame();
        }

        private void PlayPauseAlternate()
        {
            if (_PictureGrabber.IsPlaying)
                _PictureGrabber.Stop();
            else
                _PictureGrabber.Play();
        }

        private void UpdatePlayPauseButton()
        {
            PlayPauseButton.Image = _PictureGrabber.IsPlaying ? Properties.Resources.pause : Properties.Resources.play;
        }

        private void LockModePictureGrabberUi(bool locked)
        {
            TimeReplayedVideoTrackBarSetValue(0);
            VideoControlsPanel.Enabled = !locked;
            CapturedImagesFlowLayoutPanel.Enabled = !locked;
        }

        private void TimeReplayedVideoTrackBarSetValue(int value)
        {
            TimeReplayedVideoTrackBar.ValueChanged -= TimeReplayedVideoTrackBar_ValueChanged;
            TimeReplayedVideoTrackBar.Value = value;
            TimeReplayedVideoTrackBar.ValueChanged += TimeReplayedVideoTrackBar_ValueChanged;
        }

        private void StopModePictureGrabber()
        {
            DisposeImagePictureBox(ReplayedVideoPictureBox);
            DisposeImagePictureBox(Image1PictureBox);
            DisposeImagePictureBox(Image2PictureBox);
            DisposeImagePictureBox(Image3PictureBox);
            DisposeImagePictureBox(Image4PictureBox);
            DisposeImagePictureBox(Image5PictureBox);
            DisposeImagePictureBox(Image6PictureBox);

            _PictureGrabber.Unload();
        }

        private void DisposeImagePictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
                pictureBox.Image.Dispose();

            pictureBox.Image = null;
        }

        private void LoadSettingsValues()
        {
            LoadCameraComboBoxSettingsValues();

            //load video resolution
            FactorCameraVideoComboBox.SelectedIndexChanged -= FactorCameraVideoComboBox_SelectedIndexChanged;
            float[] factors = new float[] { 1, 1.5f, 2, 3 };
            FactorCameraVideoComboBox.DataSource = factors;
            FactorCameraVideoComboBox.SelectedItem = _Settings.FactorResolutionCameraVideo;
            FactorCameraVideoComboBox.SelectedIndexChanged += FactorCameraVideoComboBox_SelectedIndexChanged;

            //load color counter
            CouleurCompteurComboBox.SelectedIndexChanged -= CouleurCompteurComboBox_SelectedIndexChanged;
            Color[] colors = new Color[] { Color.White, Color.Black, Color.Blue, Color.Orange };
            CouleurCompteurComboBox.DataSource = colors;
            CouleurCompteurComboBox.SelectedItem = _Settings.CounterColor;
            CouleurCompteurComboBox.SelectedIndexChanged += CouleurCompteurComboBox_SelectedIndexChanged;

            //load time to record
            RecordingDurationNumericUpDown.ValueChanged -= RecordingDurationNumericUpDown_ValueChanged;
            RecordingDurationNumericUpDown.Value = Convert.ToDecimal(_Settings.RecordingDuration);
            RecordingDurationNumericUpDown.ValueChanged += RecordingDurationNumericUpDown_ValueChanged;

            //load path to record video
            PathRecordedVideoTextBox.Text = _Settings.PathRecordedVideo;

            //load path to record pictures
            PathRecordedPicturesTextBox.Text = _Settings.PathRecordedPictures;

        }

        private void LoadCameraComboBoxSettingsValues()
        {
            CameraComboBox.SelectedIndexChanged -= CameraComboBox_SelectedIndexChanged;

            ResolutionCameraComboBox.Enabled = false;

            FilterInfoCollection videoDevicesInfo = _VideoRecorder.GetVideoDevicesInfo();

            if (videoDevicesInfo != null || videoDevicesInfo.Count > 0)
            {
                CameraComboBox.DataSource = videoDevicesInfo;
                CameraComboBox.DisplayMember = "Name";
                CameraComboBox.ValueMember = "MonikerString";
                if (_Settings.HasCameraMonikerString())
                {
                    // si la camera n'est pas trouvé dans la combobox, selectedvalue = null
                    CameraComboBox.SelectedValue = _Settings.CameraMonikerString;

                    if (CameraComboBox.SelectedValue != null)
                        LoadCameraResolution();
                }
                else
                    CameraComboBox.SelectedIndex = -1;

                CameraComboBox.SelectedIndexChanged += CameraComboBox_SelectedIndexChanged;
            }
            else
            {
                CameraComboBox.Items.Add(Strings.NoCamera);
                CameraComboBox.SelectedIndex = 0;
                CameraComboBox.Enabled = false;
            }
        }

        private void LoadCameraResolution()
        {
            ResolutionCameraComboBox.SelectedIndexChanged -= ResolutionCameraComboBox_SelectedIndexChanged;
            ResolutionCameraComboBox.Items.Clear();

            VideoCaptureDevice videoCaptureDevice = new VideoCaptureDevice(_Settings.CameraMonikerString);
            if (videoCaptureDevice == null)
                return;

            VideoCapabilities[] videoCapabilities = videoCaptureDevice.VideoCapabilities;
            if (videoCapabilities == null || videoCapabilities.Length == 0)
                return;

            ResolutionCameraComboBox.DisplayMember = "Text";
            ResolutionCameraComboBox.SelectedItem = -1;

            foreach (VideoCapabilities cap in videoCapabilities)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = cap.FrameSize.Width + " x " + cap.FrameSize.Height;
                item.Value = cap.FrameSize;

                ResolutionCameraComboBox.Items.Add(item);

                if (_Settings.ResolutionCamera.Equals(cap.FrameSize))
                    ResolutionCameraComboBox.SelectedItem = item;
            }

            ResolutionCameraComboBox.SelectedIndexChanged += ResolutionCameraComboBox_SelectedIndexChanged;
            ResolutionCameraComboBox.Enabled = true;
        }

        private bool IsModeVideoRecorder()
        {
            return ModeTabControl.SelectedTab == VideoRecorderTabPage;
        }

        private bool IsModePictureGrabber()
        {
            return ModeTabControl.SelectedTab == PictureGrabberTabPage;
        }

        private bool IsModeSettings()
        {
            return ModeTabControl.SelectedTab == SettingsTabPage;
        }

        enum Mode
        {
            VideoRecorder,
            PictureGrabber,
            Settings
        }

        private void StartMode(Mode mode)
        {
            _Logger.Clear();

            StopModeVideoRecorder();
            StopModePictureGrabber();

            switch (mode)
            {
                case Mode.VideoRecorder:
                    StartModeVideoRecorder();
                    break;
                case Mode.PictureGrabber:
                    StartModePictureGrabber();
                    break;
                case Mode.Settings:
                    LoadSettingsValues();
                    break;
                default:
                    break;
            }
        }

    }
}
