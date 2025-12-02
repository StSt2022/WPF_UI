using System.Windows;
using System.Windows.Input;

namespace Regard3D_Kids
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenPreview_Click(object sender, RoutedEventArgs e)
        {
            OpenPreviewFirst previewWindow = new OpenPreviewFirst();
            previewWindow.ShowDialog();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void OpenMatchesPreview_Click(object sender, RoutedEventArgs e)
        {
            OpenPreviewSecond matchesWindow = new OpenPreviewSecond();
            matchesWindow.ShowDialog();
        }
    }
}