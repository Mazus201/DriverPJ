using DriverProject.AppData;
using DriverProject.Pages;
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

namespace DriverProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool SizeWindow { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            ClsFrame.Ent = new DriverDBEntities();

            ClsFrame.FrmBody = FrmCenter;
            FrmCenter.Navigate(new Auth());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrmCenter.GoBack();
            }
            catch
            {
                this.Close();
            }
        }
        /// <summary>
        /// кнопка сварачивания окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// кнопка закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCLose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// кнопка увеличения и уменьшения окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (SizeWindow == false) //проверяем открыто ли окно на весь экран
            {
                this.WindowState = WindowState.Maximized; //если нет, то увеличиваем
                SizeWindow = true;
            }
            else //и наоборот
            {
                this.WindowState = WindowState.Normal;
                SizeWindow = false;
            }
        }

        /// <summary>
        /// перетаскивание окна, держассь за фон
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
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
