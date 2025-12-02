using System.Windows;

namespace Regard3D
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateNewProject_Click(object sender, RoutedEventArgs e)
        {
            CreateProjectWindow projectWindow = new CreateProjectWindow();
            projectWindow.Owner = this;
            projectWindow.ShowDialog();
        }

        private void OpenProperties_Click(object sender, RoutedEventArgs e)
        {
            PropertiesWindow propertiesWin = new PropertiesWindow();
            propertiesWin.Owner = this;
            propertiesWin.ShowDialog();
        }

        private void OpenCameraDB_Click(object sender, RoutedEventArgs e)
        {
            CameraDBWindow cameraDbWin = new CameraDBWindow();
            cameraDbWin.Owner = this;
            cameraDbWin.ShowDialog();
        }

        private void OpenConsoleOutput_Click(object sender, RoutedEventArgs e)
        {
            ConsoleOutputWindow consoleWin = new ConsoleOutputWindow();
            consoleWin.Owner = this;
            consoleWin.ShowDialog();
        }
        private void OpenAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWin = new AboutWindow();
            aboutWin.Owner = this;
            aboutWin.ShowDialog();
        }
    }
}