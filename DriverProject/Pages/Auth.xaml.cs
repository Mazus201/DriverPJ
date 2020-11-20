using DriverProject.AppData;
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
            

            if (TxbLogin.Text == "Инспектор" || TxbPass.Text == "Пароль")
            {
                BdLogin.Visibility = Visibility.Visible;
                BdPass.Visibility = Visibility.Visible;
                CountTry++;
                if (CountTry == 3)
                {
                    FuncError("Вы не ввели данные!");
                    CountTry = 0;
                }
            }

            else if (TxbPass.Text == "inspector" && TxbLogin.Text == "inspector") //авторизацию через БД добавлю позже
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
                    Properties.Settings.Default.SaveData += 1;
                    WinBlock block = new WinBlock();
                    block.ShowDialog();
                    CountTry = 0;
                }
            }

            ClsFiltr.TxbClear(TxbLogin, "Инспектор");
            ClsFiltr.TxbClear(TxbPass, "Пароль");
        }

        private void TxbLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbLogin, "Инспектор");
        }

        private void TxbLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbLogin, "Инспектор");
        }

        private void TxbPass_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbPass, "Пароль");
        }

        private void TxbPass_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbPass, "Пароль");
        }

        private void FuncError(string ErrorText)
        {
            MessageBox1 box1 = new MessageBox1($"{ErrorText}");
            box1.ShowDialog();

            ClsFiltr.TxbClear(TxbLogin, "Инспектор");
            ClsFiltr.TxbClear(TxbPass, "Пароль");
        }
    }
}