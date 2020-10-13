using DriverProject.Resourse;
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

        bool CorrectData = true;

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            TxbBorder(TxbGUID, BdGUID, "Идентификатор (GUID)");
            TxbBorder(TxbLName, BdLName, "Фамилия");
            TxbBorder(TxbFName, BdFName, "Имя");
            TxbBorder(TxbPatr, BdPart, "Отчество");
            TxbBorder(TxbPassport, BdPassport, "Паспорт (серия и номер)");
            TxbBorder(TxbAdressReg, BdAR, "Адрес регистрации");
            TxbBorder(TxbAdressLive, BdAL, "Адрес проживания");
            TxbBorder(TxbWorkPlace, BdWP, "Место работы");
            TxbBorder(TxbPost, BdPost, "Должность");
            TxbBorder(TxbMobile, BdMobile, "Мобильный телефон");
            TxbBorder(TxbEmail, BdEmail, "Email");
            TxbBorder(TxbPhoto, BdPhoto, "Фотография");
            TxbBorder(TxbComment, BdComment, "Замечания");

            if (TxbGUID.Text != "Идентификатор (GUID)" || TxbLName.Text != "Фамилия" || TxbFName.Text != "Имя" ||
                TxbPatr.Text != "Отчество" || TxbPassport.Text != "Паспорт (серия и номер)" || TxbAdressReg.Text != "Адрес регистрации" ||
                TxbAdressLive.Text != "Адрес проживания" || TxbWorkPlace.Text != "Место работы" || TxbPost.Text != "Должность" ||
                TxbMobile.Text != "Мобильный телефон" || TxbEmail.Text != "Email" || TxbPhoto.Text != "Фотография")
            {
                MessageBox1 messageBox1 = new MessageBox1($"Пользователь {TxbFName.Text} добавлен! (К сожалению, нет, не хватило времени :с)");
                messageBox1.Show();
            }
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

        private void TxbBorder (TextBox textBox, Border border, string Text)
        {
            if (textBox.Text == Text)
            {
                border.Visibility = Visibility.Visible;
                CorrectData = false;
            }
            else
                CorrectData = true;
        }
        private void TxbBorderHide(Border border)
        {
            border.Visibility = Visibility.Hidden;
        }

        private void TxbPhoto_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
