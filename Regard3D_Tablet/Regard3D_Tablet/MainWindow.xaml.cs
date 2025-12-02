using System.Windows;

namespace Regard3D_Tablet
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateDenseCloud_Click(object sender, RoutedEventArgs e)
        {
            CreateDensePointcloud denseWindow = new CreateDensePointcloud();
            denseWindow.ShowDialog();
        }
    }
}