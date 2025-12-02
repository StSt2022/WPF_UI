using System.Windows;

namespace Regard3D_Mobile
{
    public partial class ImageInfoWindow : Window
    {
        public ImageInfoWindow(string fileName, string imageSize, string cameraMake, string cameraModel, string focalLength, string sensorWidth, string gpsInfo)
        {
            InitializeComponent();

            TitleTextBlock.Text = $"Info for {fileName}";
            ImageFileTextBlock.Text = fileName;
            ImageSizeTextBlock.Text = imageSize;
            CameraMakeTextBlock.Text = cameraMake;
            CameraModelTextBlock.Text = cameraModel;
            FocalLengthTextBlock.Text = focalLength;
            SensorWidthTextBlock.Text = sensorWidth;
            GpsInfoTextBlock.Text = gpsInfo;
        }
    }
}