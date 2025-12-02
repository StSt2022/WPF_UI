using System.Windows;
using System.Windows.Controls;

namespace Regard3D_Mobile
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DragWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void OpenGallery_Click(object sender, RoutedEventArgs e)
        {
            GalleryWindow galleryWin = new GalleryWindow();
            galleryWin.Owner = this;
            galleryWin.ShowDialog();
        }

        private void OpenCamera_Click(object sender, RoutedEventArgs e)
        {
            CameraWindow cameraWin = new CameraWindow();
            cameraWin.Owner = this;
            cameraWin.ShowDialog();
        }

        private void OpenImageInfo_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string pictureId = button.CommandParameter.ToString();

            ImageInfoWindow infoWin = null;

            switch (pictureId)
            {
                case "1":
                    infoWin = new ImageInfoWindow(
                        "IMG_2025_01.jpg", "4032x3024", "Google", "Pixel 8 Pro",
                        "6.81mm", "7.6mm", "49.8397° N, 24.0297° E");
                    break;
                case "2":
                    infoWin = new ImageInfoWindow(
                        "DSC_0125.arw", "6000x4000", "SONY", "ILCE-7M3",
                        "50.0mm", "35.6mm", "50.4501° N, 30.5234° E");
                    break;
                case "3":
                    infoWin = new ImageInfoWindow(
                        "DJI_0012.dng", "5472x3648", "DJI", "Mavic Air 2",
                        "4.5mm", "6.4mm", "46.4825° N, 30.7233° E");
                    break;
            }

            if (infoWin != null)
            {
                infoWin.Owner = this;
                infoWin.ShowDialog();
            }
        }
    }
}