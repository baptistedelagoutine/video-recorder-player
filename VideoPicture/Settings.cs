
using System;
using System.Drawing;
using System.IO;
namespace VideoPicture
{
    public class Settings
    {
        public Settings()
        {
            LoadOrSetDefault();
        }

        private void LoadOrSetDefault()
        {
            CameraMonikerString = Properties.Settings.Default.CameraMonikerString;

            ResolutionCamera = Properties.Settings.Default.ResolutionCamera;

            CounterColor = Properties.Settings.Default.CounterColor;

            if (Properties.Settings.Default.FactorResolutionCameraVideo == 0)
                FactorResolutionCameraVideo = 1f;
            else
                FactorResolutionCameraVideo = Properties.Settings.Default.FactorResolutionCameraVideo;

            if (Properties.Settings.Default.PathRecordedPictures == string.Empty)
                PathRecordedPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            else
                PathRecordedPictures = Properties.Settings.Default.PathRecordedPictures;

            if (Properties.Settings.Default.PathRecordedVideo == string.Empty)
                PathRecordedVideo = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            else
                PathRecordedVideo = Properties.Settings.Default.PathRecordedVideo;

            if (Properties.Settings.Default.RecordingDuration == 0)
                RecordingDuration = 30;
            else
                RecordingDuration = Properties.Settings.Default.RecordingDuration;

            if (Properties.Settings.Default.SizeForm == Size.Empty)
                SizeForm = new Size(800, 600);
            else
                SizeForm = Properties.Settings.Default.SizeForm;

            FormMaximized = Properties.Settings.Default.FormMaximized;
        }

        public string CameraMonikerString { get; set; }

        public bool HasCameraMonikerString()
        {
            return string.IsNullOrEmpty(CameraMonikerString) == false;
        }

        public Color CounterColor { get; set; }

        public string PathRecordedPictures { get; set; }

        public bool HasPathRecordedPictures()
        {
            return string.IsNullOrEmpty(PathRecordedPictures) == false && Directory.Exists(PathRecordedPictures);
        }

        public string PathRecordedVideo { get; set; }

        public bool HasPathRecordedVideo()
        {
            return string.IsNullOrEmpty(PathRecordedVideo) == false && Directory.Exists(PathRecordedVideo);
        }

        public string PathNameVideoFile { get { return Path.Combine(PathRecordedVideo, "VideoPicture.avi"); } }

        public int RecordingDuration { get; set; }

        public Size ResolutionCamera { get; set; }

        public bool HasResolutionCamera()
        {
            return ResolutionCamera != Size.Empty;
        }

        public float FactorResolutionCameraVideo { get; set; }

        public Size SizeForm { get; set; }

        public bool FormMaximized { get; set; }

        public void Save()
        {
            Properties.Settings.Default.CameraMonikerString = CameraMonikerString;
            Properties.Settings.Default.CounterColor = CounterColor;
            Properties.Settings.Default.PathRecordedPictures = PathRecordedPictures;
            Properties.Settings.Default.PathRecordedVideo = PathRecordedVideo;
            Properties.Settings.Default.RecordingDuration = RecordingDuration;
            Properties.Settings.Default.ResolutionCamera = ResolutionCamera;
            Properties.Settings.Default.FactorResolutionCameraVideo = FactorResolutionCameraVideo;
            Properties.Settings.Default.SizeForm = SizeForm;
            Properties.Settings.Default.FormMaximized = FormMaximized;

            Properties.Settings.Default.Save();
        }
    }
}
