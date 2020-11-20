using System.Windows;
using System.Windows.Input;

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
