using DriverProject.AppData;
using DriverProject.Resourse;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DriverProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для Sucsess.xaml
    /// </summary>
    public partial class Sucsess : Page
    {
        public Sucsess()
        {
            InitializeComponent();
            DtGrdDriverList.ItemsSource = ClsFrame.Ent.User.ToList();
            ClsFiltr.TxbClear(TxtFind, "Поиск");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox1 messageBox1 = new MessageBox1("Изменения сохранены (к сожалению, нет)");
            messageBox1.Show();

            ClsFiltr.TxbClear(TxtFind, "Поиск");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.FrmBody.Navigate(new Registration());
            ClsFiltr.TxbClear(TxtFind, "Поиск");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DtGrdDriverList.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < DtGrdDriverList.SelectedItems.Count; i++)
                    {
                        User user = DtGrdDriverList.SelectedItems[i] as User;
                        ClsFrame.Ent.User.Remove(user);
                    }
                    ClsFrame.Ent.SaveChanges();
                    ClsFiltr.FuncError("Пользоваткль удален!");
                }
            }
            catch
            {

            }
            ClsFiltr.TxbClear(TxtFind, "Поиск");
        }

        private void TxbFind_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (TxtFind.Text != "Поиск")
            DtGrdDriverList.ItemsSource = ClsFrame.Ent.User.Where(x => x.FirstName.Contains(TxtFind.Text)).ToList();
        }

        private void TxtFind_GotFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbGot(TxtFind, "Поиск");
        }

        private void TxtFind_LostFocus(object sender, RoutedEventArgs e)
        {
            ClsFiltr.TxbLost(TxtFind, "Поиск");
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printObj = new PrintDialog();

            if (printObj.ShowDialog() == true)
            {
                printObj.PrintVisual(DtGrdDriverList, "");
            }
            else
            {
                ClsFiltr.FuncError("Пользователь прервал печать!");
            }
        }
    }
}
