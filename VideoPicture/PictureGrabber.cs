using AForge.Video.FFMPEG;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Timers;

namespace VideoPicture
{
    public class PictureGrabber
    {
        public event EventHandler<VideoLoadedEventArgs> VideoLoaded;
        public event EventHandler NewFrame;
        public event EventHandler<PlayerStateEventArgs> PlayerStateChanged;

        VideoFileReader _VideoFileReader;
        Logger _Logger;
        Settings _Settings;
        MemoryStream[] _CompressedImageStreams;
        BackgroundWorker _LoadingVideoBackgroundWorker;
        Timer _Timer;
        int _CurrentFrameIndex;
        int _CurrentFrameRate;
        bool _IsPlaying;

        public bool IsPlaying
        {
            get { return _IsPlaying; }
            private set
            {
                if (_IsPlaying != value)
                {
                    _IsPlaying = value;
                    OnStateChanged();
                }
            }
        }

        public PictureGrabber(Logger logger, Settings settings, ISynchronizeInvoke iSynchronizeInvoke)
        {
            _Logger = logger;
            _Settings = settings;

            _VideoFileReader = new VideoFileReader();
            _Timer = new Timer();
            _Timer.SynchronizingObject = iSynchronizeInvoke;
            _Timer.Elapsed += _Timer_Elapsed;

            // TODO gerer cancel de loperation si on decharge ou recharge la video _LoadingVideoBackgroundWorker.WorkerSupportsCancellation = true;
            _LoadingVideoBackgroundWorker = new BackgroundWorker();
            _LoadingVideoBackgroundWorker.DoWork += _LoadingVideoBackgroundWorker_DoWork;
            _LoadingVideoBackgroundWorker.RunWorkerCompleted += _LoadingVideoBackgroundWorker_RunWorkerCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>the number of frames in the loaded video</returns>
        public void LoadRecordedVideo()
        {
            // TODO gérer le cas on annule la tache et on revient
            if (_LoadingVideoBackgroundWorker.IsBusy == false)
                _LoadingVideoBackgroundWorker.RunWorkerAsync();
        }

        private void _LoadingVideoBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_CompressedImageStreams != null && _CompressedImageStreams.Length > 0)
            {
                int numberOfFrames = _CompressedImageStreams.Length;

                if (VideoLoaded != null)
                    VideoLoaded(this, new VideoLoadedEventArgs(numberOfFrames));
            }
        }

        private void _LoadingVideoBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Unload();

            if (!_Settings.HasPathRecordedVideo())
            {
                _Logger.InformUser(Strings.PasDePathRecordVideo);
                return;
            }

            bool error = false;
            try { _VideoFileReader.Open(_Settings.PathNameVideoFile); }
            catch { error = true; }

            if (error || _VideoFileReader.IsOpen == false)
            {
                _Logger.InformUser(Strings.ImpossibleOpenRecordedVideo);
                return;
            }

            _CurrentFrameRate = _VideoFileReader.FrameRate;

            // long to int passe sans verification car avec 1 heure de video max (30 ou 25 img/s) on atteint pas le max de Int.
            int numberFrames = (int)_VideoFileReader.FrameCount;

            _CompressedImageStreams = new MemoryStream[numberFrames];

            for (int i = 0; i < numberFrames; i++)
            {
                MemoryStream stream = new MemoryStream();
                Bitmap bitmap = _VideoFileReader.ReadVideoFrame();

                bitmap.Save(stream, ImageFormat.Jpeg);
                bitmap.Dispose();

                _CompressedImageStreams[i] = stream;
            }

            _VideoFileReader.Close();
        }

        public void Unload()
        {
            Stop();

            if (_VideoFileReader.IsOpen)
                _VideoFileReader.Close();

            if (_CompressedImageStreams != null)
                foreach (MemoryStream stream in _CompressedImageStreams)
                    stream.Dispose();

            _CompressedImageStreams = null;
        }

        public Bitmap GetCurrentFrame()
        {
            if (_CompressedImageStreams != null && IsValidFrameIndex(_CurrentFrameIndex))
                return GetUncompressedImage(_CurrentFrameIndex);
            else
                return null;
        }

        public int GetCurrentFrameIndex()
        {
            return _CurrentFrameIndex;
        }

        public void Play()
        {
            IsPlaying = true;

            if (IsEndOfVideo())
                _CurrentFrameIndex = -1;

            _Timer.Interval = 1000 / _CurrentFrameRate;
            _Timer.Start();
        }

        private void _Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (IsValidFrameIndex(_CurrentFrameIndex + 1))
            {
                _CurrentFrameIndex++;

                OnNewFrame();
            }
            else
                Stop();
        }

        public void Stop()
        {
            _Timer.Stop();
            IsPlaying = false;
        }

        public void NextFrame()
        {
            Stop();

            if (IsValidFrameIndex(_CurrentFrameIndex + 1))
            {
                _CurrentFrameIndex++;

                OnNewFrame();
            }
        }

        public void PreviousFrame()
        {
            Stop();

            if (IsValidFrameIndex(_CurrentFrameIndex - 1))
            {
                _CurrentFrameIndex--;

                OnNewFrame();
            }
        }

        public void GoToFrame(int frame)
        {
            Stop();

            if (IsValidFrameIndex(frame))
            {
                _CurrentFrameIndex = frame;

                OnNewFrame();
            }
        }

        public void SaveCurrentFrame(string numNameImage)
        {
            if (_Settings.HasPathRecordedPictures() && IsValidFrameIndex(_CurrentFrameIndex))
            {
                Bitmap bitmap = GetUncompressedImage(_CurrentFrameIndex);
                bitmap.Save(Path.Combine(_Settings.PathRecordedPictures, numNameImage + ".jpg"), ImageFormat.Jpeg);
                bitmap.Dispose();
            }
        }

        private Bitmap GetUncompressedImage(int numberFrame)
        {
            if (numberFrame < 0 && numberFrame >= _CompressedImageStreams.Length)
                return null;

            MemoryStream compressedImage = _CompressedImageStreams[numberFrame];

            if (compressedImage == null)
                return null;

            compressedImage.Seek(0, SeekOrigin.Begin);

            return new Bitmap(compressedImage);
        }

        private bool IsValidFrameIndex(int index)
        {
            if (_CompressedImageStreams == null)
                return false;

            return index < _CompressedImageStreams.Length && index >= 0;
        }

        private bool IsEndOfVideo()
        {
            if (_CompressedImageStreams == null)
                return true;

            return _CurrentFrameIndex >= _CompressedImageStreams.Length - 1;
        }

        private void OnNewFrame()
        {
            if (NewFrame != null)
                NewFrame(this, EventArgs.Empty);
        }

        private void OnStateChanged()
        {
            if (PlayerStateChanged != null)
                PlayerStateChanged(this, new PlayerStateEventArgs(IsPlaying));
        }
    }

    public class VideoLoadedEventArgs : EventArgs
    {
        public int NumberOfFramesLoaded { get; private set; }

        public VideoLoadedEventArgs(int numberOfFramesLoaded)
        {
            NumberOfFramesLoaded = numberOfFramesLoaded;
        }
    }

    public class PlayerStateEventArgs : EventArgs
    {
        public bool IsPlaying { get; private set; }

        public PlayerStateEventArgs(bool isPlaying)
        {
            IsPlaying = isPlaying;
        }
    }

}
