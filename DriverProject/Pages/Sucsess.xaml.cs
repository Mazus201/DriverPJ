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
    /// Логика взаимодействия для Sucsess.xaml
    /// </summary>
    public partial class Sucsess : Page
    {
        public Sucsess()
        {
            InitializeComponent();
            DtGrdDriverList.ItemsSource = ClsFrame.Ent.User.ToList();
            TxbClear(TxtFind, "Поиск");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox1 messageBox1 = new MessageBox1("Изменения сохранены (к сожалению, нет)");
            messageBox1.Show();

            TxbClear(TxtFind, "Поиск");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.FrmBody.Navigate(new Registration());
            TxbClear(TxtFind, "Поиск");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox1 messageBox1 = new MessageBox1("Водитель удален (к сожалению, нет)");
            messageBox1.Show();
            TxbClear(TxtFind, "Поиск");
        }

        private void TxbFind_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (TxtFind.Text != "Поиск")
            DtGrdDriverList.ItemsSource = ClsFrame.Ent.User.Where(x => x.FirstName.Contains(TxtFind.Text)).ToList();
        }

        private void TxtFind_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbGot(TxtFind, "Поиск");
        }

        private void TxtFind_LostFocus(object sender, RoutedEventArgs e)
        {
            TxbLost(TxtFind, "Поиск");
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
    }
}
