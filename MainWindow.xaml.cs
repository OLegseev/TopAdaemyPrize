using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace TopAcademyPrize
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory();

            var bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(path + "/UseSprites/Top.jpg");
            bi.EndInit();

            //var img = new Image();
            imageTop.Source = bi;
            fram.NavigationService.Navigate(new Prizes());
        }
    }
}
