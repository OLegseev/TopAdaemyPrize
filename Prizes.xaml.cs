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
using Path = System.IO.Path;

namespace TopAcademyPrize
{
    /// <summary>
    /// Логика взаимодействия для Prizes.xaml
    /// </summary>
    public partial class Prizes : Page
    {
        public Prizes()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory();


            var dir = new DirectoryInfo(path + "/PrizesTop"); // папка с файлами 
            
            string[] mass = new string[dir.GetFiles().Length];
            int o = 0;
            foreach (FileInfo file in dir.GetFiles())
            {
                mass[o] = Path.GetFileNameWithoutExtension(file.FullName);
                o++;
            }
            Com.ItemsSource = mass;
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Check());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                string[] second = Directory.GetFiles(path + "/PrizesTop");


                var dir = new DirectoryInfo(path + "/PrizesTop"); // папка с файлами 

                string[] mass = new string[dir.GetFiles().Length];
                int o = 0;
                foreach (FileInfo file in dir.GetFiles())
                {
                    mass[o] = Path.GetFileNameWithoutExtension(file.FullName);
                    o++;
                }

                int p = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    if (Com.Text == mass[i])
                    {
                        p = i;
                        break;
                    }
                }

                buffer.list.Add(new buffer.set { Value = Convert.ToInt32(num.Text), Name = mass[p], Put = second[p] });
                Com.Text = "";
            }
            catch { }
        }
    }
}
