using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryImageSlicePixelCounter
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;
        private int _binaryThreshold = 100;
        private bool _bonusFeaturesEnabled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(1);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
            thresholdTrackBar.Value = _binaryThreshold;
            bonusFeaturesEnabledCBox.Checked = _bonusFeaturesEnabled;
            nextInstructionLbl.Text = "";
        }

        private void DisplayWebcam()
        {
            while (_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();

                // resize to PictureBox aspect ratio
                int newHeight = (frame.Size.Height * origImagePictureBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(origImagePictureBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);

                // display original image on form:
                origImagePictureBox.Image = frame.Bitmap;

                // grayscale and binary threshold image:
                Mat grayFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                Mat binaryFrame = new Mat();
                CvInvoke.Threshold(grayFrame, binaryFrame, _binaryThreshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                // display binary threshold image:
                binaryImagePictureBox.Image = binaryFrame.Bitmap;

                // convert Mat to Image then count pixels:
                Image<Gray, byte> binaryImage = binaryFrame.ToImage<Gray, byte>();
                int sliceWidth = binaryFrame.Width / 5;
                List<int> pixelCounts = new List<int>();
                for(int slice = 0; slice < 5; slice++)
                {
                    pixelCounts.Add(0);
                    for(int x = slice * sliceWidth; x < (slice * sliceWidth) + sliceWidth; x++)
                    {
                        for (int y = 0; y < binaryImage.Height; y++)
                        {
                            if (binaryImage.Data[y, x, 0] == 255) pixelCounts[slice]++;
                        }
                    }
                }

                // print pixel counts to labels:
                Invoke(new Action(() => {
                    lfPixelCtLbl.Text = pixelCounts[0].ToString();
                    lPixelCtLbl.Text = pixelCounts[1].ToString();
                    cPixelCtLbl.Text = pixelCounts[2].ToString();
                    rPixelCtLbl.Text = pixelCounts[3].ToString();
                    rfPixelCtLbl.Text = pixelCounts[4].ToString();
                }));

                // process bonus features (show motor instruction):
                if (_bonusFeaturesEnabled)
                {
                    int mostPopulatedSlice = 0;
                    int mostPopulatedSliceCount = 0;
                    for (int slice = 0; slice < 5; slice++)
                    {
                        if (pixelCounts[slice] > mostPopulatedSliceCount)
                        {
                            mostPopulatedSlice = slice;
                            mostPopulatedSliceCount = pixelCounts[slice];
                        }
                    }

                    Invoke(new Action(() => {
                        if (mostPopulatedSlice == 0)
                        {
                            nextInstructionLbl.Text = "HARD TO PORT!!!";
                        }
                        else if (mostPopulatedSlice == 1)
                        {
                            nextInstructionLbl.Text = "Nudge to the left";
                        }
                        else if (mostPopulatedSlice == 2)
                        {
                            nextInstructionLbl.Text = "ONWARD!!!";
                        }
                        else if (mostPopulatedSlice == 3)
                        {
                            nextInstructionLbl.Text = "Nudge to the right";
                        }
                        else if (mostPopulatedSlice == 4)
                        {
                            nextInstructionLbl.Text = "HARD TO STARBOARD!!!";
                        }
                    }));
                }
            }
        }

        private void thresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            _binaryThreshold = thresholdTrackBar.Value;
        }

        private void bonusFeaturesEnabledCBox_CheckedChanged(object sender, EventArgs e)
        {
            _bonusFeaturesEnabled = bonusFeaturesEnabledCBox.Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }
    }
}
