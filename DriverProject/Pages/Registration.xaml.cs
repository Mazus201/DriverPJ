using DriverProject.AppData;
using System.Windows;
using System.Windows.Controls;

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
            ClsFiltr.TxbBorder(TxbGUID, BdGUID, "Идентификатор (GUID)");
            ClsFiltr.TxbBorder(TxbLName, BdLName, "Фамилия");
            ClsFiltr.TxbBorder(TxbFName, BdFName, "Имя");
            ClsFiltr.TxbBorder(TxbPatr, BdPart, "Отчество");
            ClsFiltr.TxbBorder(TxbPassport, BdPassport, "Паспорт (серия и номер)");
            ClsFiltr.TxbBorder(TxbAdressReg, BdAR, "Адрес регистрации");
            ClsFiltr.TxbBorder(TxbAdressLive, BdAL, "Адрес проживания");
            ClsFiltr.TxbBorder(TxbWorkPlace, BdWP, "Место работы");
            ClsFiltr.TxbBorder(TxbPost, BdPost, "Должность");
            ClsFiltr.TxbBorder(TxbMobile, BdMobile, "Мобильный телефон");
            ClsFiltr.TxbBorder(TxbEmail, BdEmail, "Email");
            ClsFiltr.TxbBorder(TxbPhoto, BdPhoto, "Фотография");
            ClsFiltr.TxbBorder(TxbComment, BdComment, "Замечания");

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
            ClsFiltr.TxbGot(TxbGUID, "Идентификатор (GUID)");
        }

        private void TxbGUID_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbGUID, "Идентификатор (GUID)");
        }

        private void TxbLName_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbLName, "Фамилия");
        }

        private void TxbLName_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbLName, "Фамилия");
        }

        private void TxbFName_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbFName, "Имя");
        }

        private void TxbFName_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbFName, "Имя");
        }

        private void TxbPatr_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbPatr, "Отчество");
        }

        private void TxbPatr_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbPatr, "Отчество");
        }

        private void TxbPassport_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbPassport, "Паспорт (серия и номер)");
        }

        private void TxbPassport_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbPassport, "Паспорт (серия и номер)");
        }

        private void TxbAdressReg_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbAdressReg, "Адрес регистрации");
        }

        private void TxbAdressReg_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbAdressReg, "Адрес регистрации");
        }

        private void TxbAdressLive_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbAdressLive, "Адрес проживания");
        }

        private void TxbAdressLive_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbAdressLive, "Адрес проживания");
        }

        private void TxbWorkPlace_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbWorkPlace, "Место работы");
        }

        private void TxbWorkPlace_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbWorkPlace, "Место работы");
        }

        private void TxbPost_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbPost, "Должность");
        }

        private void TxbPost_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbPost, "Должность");
        }

        private void TxbMobile_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbMobile, "Мобильный телефон");
        }

        private void TxbMobile_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbMobile, "Мобильный телефон");
        }

        private void TxbEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbEmail, "Email");
        }

        private void TxbEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbEmail, "Email");
        }

        private void TxbPhoto_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbPhoto, "Фотография");
        }

        private void TxbPhoto_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbPhoto, "Фотография");
        }

        private void TxbComment_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxbComment, "Замечания");
        }

        private void TxbComment_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxbComment, "Замечания");
        }
    }
}
