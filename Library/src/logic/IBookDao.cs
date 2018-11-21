using System.Collections.Generic;

namespace Library
{
    public interface IBookDao
    {
        List<Book> GetAllBooks();
        void AddBook(Book book);
        void RemoveBook(int id);
    }
}
