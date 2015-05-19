using AForge.Controls;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;

namespace VideoPicture
{
    public class VideoRecorder
    {
        public event EventHandler FrameRateChanged;

        VideoFileWriter _VideoFileWriter;
        VideoSourcePlayer _VideoSourcePlayer;
        VideoCaptureDevice _VideoCaptureDevice;
        Logger _Logger;
        Settings _Settings;
        bool _IsRecording;
        Size _VideoSize;
        Timer _Timer;

        public int FrameRate { get; private set; }

        public bool IsRecording { get { return _IsRecording; } }

        public VideoRecorder(Logger logger, Settings settings, VideoSourcePlayer videoSourcePlayer, ISynchronizeInvoke iSynchronizeInvoke)
        {
            _Logger = logger;
            _Settings = settings;
            _VideoSourcePlayer = videoSourcePlayer;

            _VideoFileWriter = new VideoFileWriter();

            _Timer = new Timer();
            _Timer.SynchronizingObject = iSynchronizeInvoke;
            _Timer.Interval = 1000;
            _Timer.Elapsed += _Timer_Elapsed;
        }

        public bool Connect()
        {
            if (!_Settings.HasCameraMonikerString())
            {
                _Logger.InformUser(Strings.PasDeCameraConfig);
                return false;
            }

            _VideoCaptureDevice = new VideoCaptureDevice(_Settings.CameraMonikerString);

            if (_VideoCaptureDevice == null)
            {
                _Logger.InformUser(Strings.ImpossibleCreerVCDevice);
                return false;
            }

            VideoCapabilities[] videoCapabilities = _VideoCaptureDevice.VideoCapabilities;

            if (videoCapabilities == null || videoCapabilities.Length == 0)
            {
                _Logger.InformUser(Strings.NoVCapabilitiesFound);
                return false;
            }

            if (!_Settings.HasResolutionCamera())
            {
                _Logger.InformUser(Strings.PasDeResolutionCamConfig);
                return false;
            }

            int indexResolution = 0;
            bool found = false;

            while (indexResolution < videoCapabilities.Length && found == false)
            {
                VideoCapabilities capability = videoCapabilities[indexResolution];
                if (capability.FrameSize.Equals(_Settings.ResolutionCamera))
                    found = true;
                else
                    indexResolution++;
            }

            if (!found)
            {
                _Logger.InformUser(Strings.PasDeResolutionCorrespondante);
                return false;
            }

            _VideoCaptureDevice.VideoResolution = videoCapabilities[indexResolution];
            _VideoSourcePlayer.VideoSource = _VideoCaptureDevice;
            _VideoSourcePlayer.Start();

            _Timer.Start();

            return true;
        }

        public void Disconnect()
        {
            StopRecordingVideo();

            _Timer.Stop();

            _VideoSourcePlayer.SignalToStop();
            _VideoSourcePlayer.WaitForStop();
            _VideoSourcePlayer.VideoSource = null;

            _VideoCaptureDevice = null;
        }

        public void DisplayPropertyPage()
        {
            if (_VideoCaptureDevice != null)
                _VideoCaptureDevice.DisplayPropertyPage(IntPtr.Zero);
        }

        private void _Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_VideoCaptureDevice != null)
            {
                FrameRate = _VideoCaptureDevice.FramesReceived;

                if (FrameRateChanged != null)
                    FrameRateChanged(this, EventArgs.Empty);
            }
        }

        public FilterInfoCollection GetVideoDevicesInfo()
        {
            return new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        public void StartRecordingVideo()
        {
            if (_IsRecording == false)
            {
                if (_VideoCaptureDevice == null && _VideoFileWriter != null)
                {
                    _Logger.InformUser(Strings.ImpossibleRecordVideo);
                    return;
                }

                if (!_Settings.HasPathRecordedVideo())
                {
                    _Logger.InformUser(Strings.PasDePathRecordVideo);
                    return;
                }

                _VideoSize = GetVideoSize(_VideoCaptureDevice.VideoResolution.FrameSize);

                _VideoFileWriter.Open(_Settings.PathNameVideoFile, _VideoSize.Width, _VideoSize.Height, FrameRate, VideoCodec.Raw);

                _VideoCaptureDevice.NewFrame += RecordingVideoNewFrameEvent;

                _IsRecording = true;
            }
        }

        private void RecordingVideoNewFrameEvent(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            if (_VideoFileWriter != null && _VideoFileWriter.IsOpen && eventArgs.Frame != null)
            {
                Bitmap resizedBitmap = new Bitmap(eventArgs.Frame, _VideoSize);

                _VideoFileWriter.WriteVideoFrame(resizedBitmap);

                resizedBitmap.Dispose();
                eventArgs.Frame.Dispose();
            }
        }

        public void StopRecordingVideo()
        {
            if (_IsRecording)
            {
                if (_VideoCaptureDevice != null && _VideoFileWriter != null)
                {
                    _VideoCaptureDevice.NewFrame -= RecordingVideoNewFrameEvent;

                    _VideoFileWriter.Close();

                    _IsRecording = false;
                }
            }
        }

        private Size GetVideoSize(Size cameraSize)
        {
            float factor = _Settings.FactorResolutionCameraVideo;

            if (factor == 1f)
                return cameraSize;

            int width = Convert.ToInt32(cameraSize.Width / factor);
            int height = Convert.ToInt32(cameraSize.Height / factor);

            if (!IsEven(width))
                width += 1;

            if (!IsEven(height))
                height += 1;

            return new Size(width, height);
        }

        private static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}
