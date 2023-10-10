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

namespace TopAcademyPrize
{
    /// <summary>
    /// Логика взаимодействия для YourPrize.xaml
    /// </summary>
    public partial class YourPrize : Page
    {
        public YourPrize()
        {
            InitializeComponent();
            int sch = 1;
            bool b = false;
            try
            {
                do
                {

                    sch = 0;
                    for (int j = 0; j < buffer.list.Count; j++)
                    {
                        sch += buffer.list[j].Value;
                    }

                    if (sch == 0)
                    {
                        b = true;
                        NameP.Text = "Призы закончились(((";
                        string path = Directory.GetCurrentDirectory();

                        var bi = new BitmapImage();
                        bi.BeginInit();
                        bi.UriSource = new Uri(path + "/UseSprites/Top.jpg");
                        bi.EndInit();

                        //var img = new Image();
                        imageTop.Source = bi;
                    }
                    Random random = new Random();
                    int a = random.Next(0, buffer.list.Count);
                    //if (sch == 1)
                    //{
                    //    sch = 0;
                    //    for (int j = 0; j < buffer.list.Count; j++)
                    //    {
                    //        sch += buffer.list[j].Value;
                    //        if (sch == 1)
                    //        {
                    //            a = j;
                    //            break;
                    //        }
                    //    }
                    //}
                    if (buffer.list[a].Value != 0)
                    {
                        NameP.Text = buffer.list[a].Name;
                        var bi = new BitmapImage();
                        bi.BeginInit();
                        bi.UriSource = new Uri(buffer.list[a].Put);
                        bi.EndInit();

                        //var img = new Image();
                        imageTop.Source = bi;
                        buffer.list[a].Value -= 1;
                        b = true;
                        Code.Text = Convert.ToString(32 * (a+2));
                        break;
                    }
                }
                while (!b);
            }
            catch { }
            
            
        }
        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Check());
        }
    }
}
