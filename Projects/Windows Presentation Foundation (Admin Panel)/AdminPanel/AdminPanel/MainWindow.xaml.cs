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

namespace AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возможность перетаскивать окно с помощью ЛКМ.
        /// </summary>
        /// <param name="sender"> Ссылка на объект. </param>
        /// <param name="e"> Передача объекта. </param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        /// <summary>
        /// Скрыть окно.
        /// </summary>
        /// <param name="sender"> Ссылка на объект. </param>
        /// <param name="e"> Передача объекта. </param>
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Закрыть приложение.
        /// </summary>
        /// <param name="sender"> Ссылка на объект. </param>
        /// <param name="e"> Передача объекта. </param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        /// <summary>
        /// Войти в аккаунт.
        /// </summary>
        /// <param name="sender"> Ссылка на объект. </param>
        /// <param name="e"> Передача объекта. </param>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Переход к форме смены пароля.
        /// </summary>
        /// <param name="sender"> Ссылка на объект. </param>
        /// <param name="e"> Передача объекта. </param>
        private void ChangePasswordBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
