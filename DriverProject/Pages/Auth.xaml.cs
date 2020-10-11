using DriverProject.AppData;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DriverProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }
        int CountTry = 0;

        private void HLReg_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.FrmBody.Navigate(new Registration());

            TxbClear(TxbLogin, "Инспектор");
            TxbClear(TxbPass, "Пароль");
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            if (TxbLogin.Text == "Инспектор" || TxbPass.Text == "Пароль")
            {
                BdLogin.Visibility = Visibility.Visible;
                BdPass.Visibility = Visibility.Visible;
                CountTry++;
            }

            else if (TxbPass.Text == "1" && TxbLogin.Text == "1")
            {
                ClsFrame.FrmBody.Navigate(new Sucsess());
                BdLogin.Visibility = Visibility.Hidden;
                BdPass.Visibility = Visibility.Hidden;
                CountTry = 0;
            }

            else
            {
                BdLogin.Visibility = Visibility.Visible;
                BdPass.Visibility = Visibility.Visible;
                CountTry++;

                if (CountTry == 3)
                {
                    FuncError("Вы заблокированы на 1 минуту!");

                }
            }

            TxbClear(TxbLogin, "Инспектор");
            TxbClear(TxbPass, "Пароль");
        }

        private void TxbLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbLogin, "Инспектор");
        }

        private void TxbLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbLogin, "Инспектор");
        }

        private void TxbPass_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbPass, "Пароль");
        }

        private void TxbPass_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbPass, "Пароль");
        }

        private void TxbGot(TextBox textBox, string Text)
        {
            if (textBox.Text == Text)
            {
                textBox.Text = null;
                textBox.Foreground = Brushes.Black;
            }
        }
        private void TxbLost(TextBox textBox, string Text)
        {
            if (textBox.Text == "")
            {
                textBox.Text = Text;
                textBox.Foreground = Brushes.LightGray;
            }
        }

        private void TxbClear(TextBox textBox1, string Text)
        {
            textBox1.Foreground = Brushes.LightGray;
            textBox1.Text = Text;
        }

        private void FuncError(string ErrorText)
        {
            MessageBox1 box1 = new MessageBox1($"{ErrorText}");
            box1.Show();

            TxbClear(TxbLogin, "Инспектор");
            TxbClear(TxbPass, "Пароль");
        }
    }
}
