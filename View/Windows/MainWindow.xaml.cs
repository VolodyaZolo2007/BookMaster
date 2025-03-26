using BookMaster.View.Pages;
using System.Windows;

namespace BookMaster.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LogoutMI.Visibility = Visibility.Collapsed;
        }

        private void LoginMI_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.ShowDialog();
        }

        private void LogoutMI_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseMI_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BrowseCatalogMI_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new BrowseCatalogPage());
        }

        private void ManageCustomersMI_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new ManageCustomerPage());
        }

        private void CirculationMI_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new CirculationPage());
        }

        private void ReportsMI_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new ReportsPage());
        }
    }
}


#region 1)оконная навигация

//Осуществляет открытие нового экземпляра окна из другого окна или страницы

//Алгоритм для реализации (окно называется TestWindow.xaml)

// 1 - создать экземпляр окна TestWindow.xaml
//у экземпляра окна вызываем метод Show(), данный метод открывает модальное окно(будет возможностьо взаимодействовать с предыдущем окном ). Иначе вызываем ShowDialog() этот метод открывает диалоговое окно (нельзя взаимодействовать с другими окнами)

//TestWindow testwindow = new TestWindow()
//testWindow.Show() или testWindow.ShowDialog()

#endregion


#region  2) Страничная навигация
/*
 * Осуществляет открытике страниц внутри элемента Frame
 * 
 * Алгоритм для реализации (страница называется TestPage.xaml)
 * 
 * - определяет место для элемента Frame (данный элемент принимает и отображает страницы)
 * - Дать имя Frame(MainFrm) В xaml коде
 * - для навигации обратиться к фрейму вызвать метод navigate  и передать в качестве значения экземпляр страницы
 * 
 * => MainFrm.Navigate(new TestPage)
 */
#endregion