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
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox1 messageBox1 = new MessageBox1("Изменения сохранены (к сожалению, нет)");
            messageBox1.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.FrmBody.Navigate(new Registration());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox1 messageBox1 = new MessageBox1("Водитель удален (к сожалению, нет)");
            messageBox1.Show();
        }

    }
}
