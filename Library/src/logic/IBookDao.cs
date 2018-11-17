using System.Collections.Generic;

namespace Library
{
    public interface IBookDao
    {
        List<Book> GetAllBooks();
        //List<Book> GetBooks(String query);
        void AddBook(Book book);
        void RemoveBook(int id);
    }
}
