using System.Windows;

namespace Regard3D_Tablet
{
    public partial class CreateDensePointcloud : Window
    {
        public CreateDensePointcloud()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}