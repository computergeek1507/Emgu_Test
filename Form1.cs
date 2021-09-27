using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emgu_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                readVideo(openFileDialog1.FileName);
            }
        }

        void readVideo(string filename) 
        {
            VideoCapture videoCapture = new VideoCapture(filename);

            double FPS = videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps);
            double totalFrames = videoCapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount);
            int currentFrameNo = 0;
           
            while (currentFrameNo < totalFrames)
            {
                var frame = videoCapture.QueryFrame();
                var detect = DetectBlobs(frame, 0);
                pictureBox1.Image = detect.ToBitmap();
                Application.DoEvents();
               //pr
                currentFrameNo += 1;
                Task.Delay(Convert.ToInt32(1000.0 / FPS));
            }

        }

        Mat DetectBlobs(Mat im_in, int c)
        {
            /*
                 cv::cvtColor( processFrame, processFrame, cv::COLOR_RGB2GRAY );
    int odd_blur = ( ( m_blur / 2 ) * 2 ) + 1;
    cv::GaussianBlur( processFrame, processFrame, cv::Size( odd_blur, odd_blur ), 0 );
    cv::threshold( processFrame, processFrame, m_threshold, 255, cv::THRESH_BINARY );

    //auto erodeType = cv::Mat::ones( cv::Size( 5, 5 ), cv::Mat::uint8 ) 
    cv::erode( processFrame, processFrame, cv::getStructuringElement( cv::MORPH_RECT, cv::Size( m_erode, m_erode ) ) );
    cv::dilate( processFrame, processFrame, cv::getStructuringElement( cv::MORPH_RECT, cv::Size( m_dilate, m_dilate ) ) );

	cv::SimpleBlobDetector::Params params;
    // Change thresholds
    params.minThreshold = 0;
    params.maxThreshold = 255;

    params.filterByArea = true;
    params.minArea      = m_greySize;
    params.maxArea      = 100000;

    params.filterByCircularity = false;
    params.filterByConvexity = false;
    params.filterByInertia = false;
    params.filterByColor = false; 
             
             * */
            Mat grey = new Mat();
            CvInvoke.CvtColor(im_in, grey, ColorConversion.Bgr2Gray);

            //CvInvoke.GaussianBlur(grey, grey, Size(5, 5), 0);
            int minA = 125; // Minimum area in pixels
            int maxA = 5000; // Maximum area in pixels

            SimpleBlobDetectorParams EMparams = new SimpleBlobDetectorParams();
            SimpleBlobDetector detector;

            EMparams.MinThreshold = 100;
            EMparams.MaxThreshold = 255;

            if (minA < 1) minA = 1;
            EMparams.FilterByArea = true;
            EMparams.MinArea = minA;
            EMparams.MaxArea = maxA;


            //EMparams.FilterByInertia = true;
            //EMparams.MinInertiaRatio = 0.01F;

            EMparams.FilterByColor = true;
            EMparams.blobColor = 0;

            VectorOfKeyPoint keyPoints = new VectorOfKeyPoint();

            Mat im = new Mat();

            detector = new SimpleBlobDetector(EMparams);
            CvInvoke.Threshold(im_in, im, 40, 255, Emgu.CV.CvEnum.ThresholdType.BinaryInv);  // 60, 255, 1


            detector.DetectRaw(im, keyPoints);

            Mat im_with_keypoints = new Mat();
            Bgr color = new Bgr(0, 0, 255);
            Features2DToolbox.DrawKeypoints(im_in, keyPoints, im_with_keypoints, color, Features2DToolbox.KeypointDrawType.DrawRichKeypoints);
            return im_with_keypoints;
            // Show blobs

            //CvInvoke.Imshow("Blob Detector " + keyPoints.Size, im_with_keypoints);


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
