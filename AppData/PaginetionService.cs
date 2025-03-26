using BookMaster.Model;
using System.Collections.Generic;
using System.Linq;

namespace BookMaster.AppData
{
    public class PaginetionService
    {
        //Определяем поля для хранения данных
        private const int PAGE_SIZE = 50;
        private readonly List<Book> _books;
        private int _currentPageIndex;
        private int _currentPageNumber;

        //Определяем свойства для вычесления и хранения данных
        public int BooksCount => _books.Count;
        public int totalPages => (BooksCount + PAGE_SIZE - 1) / PAGE_SIZE;
        public List<Book> CurrentPageOfBook => _books.Skip(_currentPageIndex * PAGE_SIZE).Take(PAGE_SIZE).ToList();


    }
}
