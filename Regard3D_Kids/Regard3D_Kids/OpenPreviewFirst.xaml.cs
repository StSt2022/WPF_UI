using System.Windows;

namespace Regard3D_Kids
{
    public partial class OpenPreviewFirst : Window
    {
        public OpenPreviewFirst()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}