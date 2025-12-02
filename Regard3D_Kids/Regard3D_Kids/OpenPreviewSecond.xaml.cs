using System.Windows;

namespace Regard3D_Kids
{
    public partial class OpenPreviewSecond : Window
    {
        public OpenPreviewSecond()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}