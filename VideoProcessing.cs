﻿using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emgu_Test
{
	public class FrameEventArgs : EventArgs
	{
		public double FrameCount { get; set; }
		public double CurrentFrame { get; set; }
	}
	public class VideoProcessing
	{
		public delegate void FrameEventHandler(object sender, FrameEventArgs e);
		public FrameEventHandler CurrentFrame;
		public event EventHandler<Bitmap> ImageSent;
		public event EventHandler<string> MessageSent;

		VideoSettings _settings;
        VideoCapture _videoCapture;

        double _currentFrameNo = 0;
		double _totalFrames = 0;
		double _fps = 0;

		public VideoProcessing() {

        }
        void OnMessageSent(string message) => MessageSent.Invoke(this, message);

        void OnImageSent(Bitmap e) => ImageSent.Invoke(this, e);

		void OnCurrentFrameSent(FrameEventArgs e) => CurrentFrame.Invoke(this, e);

		public void SendFrameValue( double frame, double total)
		{
			OnCurrentFrameSent(new FrameEventArgs
			{
				CurrentFrame = frame,
				FrameCount = total
			});
		}

		public void LoadVideo(VideoSettings settings)
        {
            _settings = settings;
            _videoCapture = new VideoCapture(_settings.FileName);

			_fps = _videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps);
			_totalFrames = _videoCapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount);

			SendFrameValue(1 , _totalFrames);
			OnMessageSent("Video Loaded: " + _settings.FileName);
		}

        public void ProcessSingleFrame(int frameIndex)
		{
            _videoCapture.Set(Emgu.CV.CvEnum.CapProp.PosFrames, frameIndex);

            var frame = _videoCapture.QueryFrame();
			ProcessFrame(frame);
		}

		public void ScrubFrame(int frameIndex)
		{
			_videoCapture.Set(Emgu.CV.CvEnum.CapProp.PosFrames, frameIndex);

			var frame = _videoCapture.QueryFrame();
            OnImageSent(frame.ToBitmap());
        }

		public void ProcessVideo()
        {
			while (_currentFrameNo < _totalFrames)
			{
				var frame = _videoCapture.QueryFrame();
				if (frame == null)
				{
					break;
				}
                ProcessFrame(frame);
				SendFrameValue(_currentFrameNo, _totalFrames);
				_currentFrameNo += 1;
				Task.Delay(Convert.ToInt32(1000.0 / _fps));
			}
		}

		void ProcessFrame(Mat frame_in)
		{
			//https://learnopencv.com/blob-detection-using-opencv-python-c/

			//blur before grey
			if (_settings.BlurSize != 0)
			{
				//must be odd so round evens to odds
				int odd_blur = ((_settings.BlurSize / 2) * 2) + 1;
				CvInvoke.GaussianBlur(frame_in, frame_in, new Size(odd_blur, odd_blur), 0);
			}

			//convert to greyscale
			Mat grey = new Mat();
            CvInvoke.CvtColor(frame_in, grey, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

			//CvInvoke.Threshold(grey, grey, _settings.GreyThreshold, 255, ThresholdType.Binary);

			if (_settings.ErodeSize != 0)
			{
				CvInvoke.Erode(grey, grey, null, new Point(-1, -1), _settings.ErodeSize, BorderType.Default, new MCvScalar(1));
				//CvInvoke.Erode(grey, grey, new ScalarArray(_settings.ErodeSize), new Point(-1, -1), 1, BorderType.Constant, new MCvScalar(255, 255, 255));
			}

			if (_settings.DilateSize != 0)
			{
				CvInvoke.Dilate(grey, grey, null, new Point(-1, -1), _settings.DilateSize, BorderType.Constant, new MCvScalar(1));
			}

			SimpleBlobDetectorParams EMparams = new SimpleBlobDetectorParams();
            SimpleBlobDetector detector;

            EMparams.MinThreshold = _settings.GreyThreshold;
            EMparams.MaxThreshold = 255;

            EMparams.FilterByArea = true;
            EMparams.MinArea = _settings.MinBlobSize;
            EMparams.MaxArea = _settings.MaxBlobSize;

			EMparams.FilterByCircularity = true;
			EMparams.MinCircularity = _settings.MinCircularity;
			EMparams.MaxCircularity = 1.00F;

			//Filter by Convexity
			EMparams.FilterByConvexity = true;
			EMparams.MinConvexity = _settings.MinConvexity;
			EMparams.MaxConvexity = 1.00F;

			// Filter by Inertia
			EMparams.FilterByInertia = true;
			EMparams.MinInertiaRatio = _settings.MinInertiaRatio;
			EMparams.MaxInertiaRatio = 1.00F;

			EMparams.FilterByColor = true;
            EMparams.blobColor = _settings.Color;

            VectorOfKeyPoint keyPoints = new VectorOfKeyPoint();

            Mat im = new Mat();

            detector = new SimpleBlobDetector(EMparams);

            detector.DetectRaw(grey, keyPoints);

            Mat im_with_keypoints = new Mat();
            Bgr color = new Bgr(0, 0, 255);
            Features2DToolbox.DrawKeypoints(frame_in, keyPoints, im_with_keypoints, color, Features2DToolbox.KeypointDrawType.DrawRichKeypoints);

            // Show blobs
            OnImageSent(im_with_keypoints.ToBitmap());

            //CvInvoke.Imshow("Blob Detector " + keyPoints.Size, grey);
        }
    }
}