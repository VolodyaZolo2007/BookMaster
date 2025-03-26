using BookMaster.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace BookMaster.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для BrowseCatalogPage.xaml
    /// </summary>
    public partial class BrowseCatalogPage : Page
    {
        private List<BookAuthor> _bookAuthors = App.contex.BookAuthor.ToList();


        public BrowseCatalogPage()
        {
            InitializeComponent();

            BookAuthorLv.ItemsSource = _bookAuthors;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BookAuthorLv.ItemsSource = _bookAuthors.Where(bookAuthor => bookAuthor.Book.Title.ToLower().Contains(SearchByBookTitleNametb.Text.ToLower()) && bookAuthor.Author.Name.ToLower().Contains(SearchByAuthorNametb.Text.ToLower()));
        }
    }
}
