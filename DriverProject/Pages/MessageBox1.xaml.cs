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

namespace DriverProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для MessageBox1.xaml
    /// </summary>
    public partial class MessageBox1 : Window
    {
        public MessageBox1(string MBText)
        {
            InitializeComponent();
            TxtMessage.Text = MBText;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
    }
}
