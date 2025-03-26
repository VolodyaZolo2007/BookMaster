using BookMaster.Model;
using System.Windows;

namespace BookMaster
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Создаем контекс данных.
        public static BookMasterEntities contex = new BookMasterEntities();
    }
}
