using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WorldSkills.ApplicationData;
using WorldSkills.Pages.Auth;

namespace WorldSkills.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Bitmap logoImage = Properties.Resources.logo;
            LogoImg.Source = ConvertBitmapToImageSource(logoImage);

            AppConnect.ModelOdb = new WorldSkillsAcademyEntities();
            AppFrame.FrameMain = MainFrame;
            MainFrame.Navigate(new LoginPage());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        private ImageSource ConvertBitmapToImageSource(Bitmap bitmap)
        {
            BitmapImage bitmapImage = new BitmapImage();

            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Png);
                stream.Position = 0;

                bitmapImage.BeginInit();
                bitmapImage.StreamSource = stream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
            }

            return bitmapImage;
        }
    }
}
