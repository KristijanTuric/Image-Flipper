using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ImageFlipper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private RotateTransform rotateTransform = new();

        private void ButtonClick_RotateLeft(object sender, RoutedEventArgs e)
        {
            rotateTransform.Angle += 90;            
            currentImage.RenderTransform = rotateTransform;
        }

        private void ButtonClick_RotateRight(object sender, RoutedEventArgs e)
        {
            rotateTransform.Angle -= 90;
            currentImage.RenderTransform = rotateTransform;
        }

        private void ButtonClick_OpenImage(object sender, RoutedEventArgs e)
        {
            // Opens the file dialog
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Sets the file filter and the default file type
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            // Shows the dialog window
            dlg.ShowDialog();

            // Sets the current image to the image selected in the file dialog
            currentImage.Source = new BitmapImage(new Uri($"{dlg.FileName}", UriKind.Absolute));
        }
    }
}
