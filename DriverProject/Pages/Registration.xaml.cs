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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void TxbGUID_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbGUID, "Идентификатор (GUID)");
        }

        private void TxbGUID_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbGUID, "Идентификатор (GUID)");
        }

        private void TxbLName_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbLName, "Фамилия");
        }

        private void TxbLName_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbLName, "Фамилия");
        }

        private void TxbFName_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbFName, "Имя");
        }

        private void TxbFName_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbFName, "Имя");
        }

        private void TxbPatr_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbPatr, "Отчество");
        }

        private void TxbPatr_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbPatr, "Отчество");
        }

        private void TxbPassport_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbPassport, "Паспорт (серия и номер)");
        }

        private void TxbPassport_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbPassport, "Паспорт (серия и номер)");
        }

        private void TxbAdressReg_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbAdressReg, "Адрес регистрации");
        }

        private void TxbAdressReg_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbAdressReg, "Адрес регистрации");
        }

        private void TxbAdressLive_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbAdressLive, "Адрес проживания");
        }

        private void TxbAdressLive_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbAdressLive, "Адрес проживания");
        }

        private void TxbWorkPlace_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbWorkPlace, "Место работы");
        }

        private void TxbWorkPlace_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbWorkPlace, "Место работы");
        }

        private void TxbPost_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbPost, "Должность");
        }

        private void TxbPost_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbPost, "Должность");
        }

        private void TxbMobile_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbMobile, "Мобильный телефон");
        }

        private void TxbMobile_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbMobile, "Мобильный телефон");
        }

        private void TxbEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbEmail, "Email");
        }

        private void TxbEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbEmail, "Email");
        }

        private void TxbPhoto_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbPhoto, "Фотография");
        }

        private void TxbPhoto_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbPhoto, "Фотография");
        }

        private void TxbComment_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxbComment, "Замечания");
        }

        private void TxbComment_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxbComment, "Замечания");
        }

        private void TxbGot(TextBox textBox, string text)
        {
            if (textBox.Text == text)
            {
                textBox.Text = null;
                textBox.Foreground = Brushes.Black;
            }
        }
        private void TxbLost(TextBox textBox, string text)
        {
            if (textBox.Text == "")
            {
                textBox.Text = text;
                textBox.Foreground = Brushes.LightGray;
            }
        }
    }
}
