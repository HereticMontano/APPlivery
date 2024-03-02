using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPF_AppLivery.CustomControllers
{
    /// <summary>
    /// Interaction logic for ImageAndName.xaml
    /// </summary>
    public partial class ImageAndName : UserControl
    {
        public string? Title { get; set; }
        public string? PathImage { get; set; }
        public ImageAndName(string title, string pathImage)
        {
            Title = title;
            PathImage = pathImage;
            InitializeComponent();
           
            LblCont.Content = title;
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(PathImage, UriKind.Absolute);
            bi.EndInit();
            ImgCont.Source = bi;
        }

    }
}
