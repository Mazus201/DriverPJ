using DriverProject.AppData;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine($"{TxbPass.Password} {TxbLogin.Text}");

            var user = ClsFrame.Ent.Police.FirstOrDefault(x => x.Password == TxbPass.Password && x.Login == TxbLogin.Text);

            if (TxbLogin.Text == "Инспектор" /*|| TxbPass.Text == "Пароль"*/)
            {
                BdLogin.Visibility = Visibility.Visible;
                BdPass.Visibility = Visibility.Visible;
                CountTry++;
                if (CountTry == 3)
                {
                    ClsFiltr.FuncError("Вы не ввели данные!");
                    ClsFiltr.TxbClear(TxbLogin, "Инспектор");
                    //ClsFiltr.TxbClear(TxbPass, "Пароль");
                    CountTry = 0;
                }
            }

            else if (user == null)
            {
                BdLogin.Visibility = Visibility.Visible;
                BdPass.Visibility = Visibility.Visible;
                CountTry++;

                if (CountTry == 3)
                {
                    Properties.Settings.Default.SaveData += 1;
                    WinBlock block = new WinBlock();
                    block.ShowDialog();
                    CountTry = 0;
                }
            }
            else
            {
                ClsFrame.FrmBody.Navigate(new Sucsess());
                BdLogin.Visibility = Visibility.Hidden;
                BdPass.Visibility = Visibility.Hidden;
                CountTry = 0;
            }

            ClsFiltr.TxbClear(TxbLogin, "Инспектор");
            TxbPass.Clear();
            //ClsFiltr.TxbClear(TxbPass, "Пароль");
        }

        private void TxbLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbLogin, "Инспектор");
        }

        private void TxbLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbLogin, "Инспектор");
        }

        //private void TxbPass_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    ClsFiltr.TxbGot(TxbPass, "Пароль");
        //}

        //private void TxbPass_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    ClsFiltr.TxbLost(TxbPass, "Пароль");
        //}

    }
}