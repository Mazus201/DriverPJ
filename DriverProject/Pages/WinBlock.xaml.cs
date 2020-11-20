using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DriverProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для WinBlock.xaml
    /// </summary>
    public partial class WinBlock : Window
    {
        public WinBlock()
        {
            InitializeComponent();

            BtnOk.IsEnabled = false;
            Properties.Settings.Default.SaveTime = 60;
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += new EventHandler(timer_Tick);
            dt.Start();
        }

        private void OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.System && e.SystemKey == Key.F4)
            {
                e.Handled = true;
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            tbSec.Text = Properties.Settings.Default.SaveTime.ToString();
            Properties.Settings.Default.SaveTime -= 1;
            if (Properties.Settings.Default.SaveTime <= 0)
            {
                Properties.Settings.Default.SaveTime = 0;
                tbSec.Text = "0";
                BtnOk.IsEnabled = true;

            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch
            {

            }
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
