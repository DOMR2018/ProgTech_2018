using System;
using System.Collections.Generic;

namespace Library
{
    public interface ICatalog
    {
        Book GetBook(int id);
        List<Book> GetBooksByAuthor(String author);
        List<Book> GetBooksByTitle(String title);
        List<Book> GetBooksByGenre(String genre);
        List<Book> GetBooksByState(bool isAvailable);
        List<Book> GetAllBooks();
        void AddBooks(params Book[] books);
        void RemoveBook(int id);
        void BorrowBook(int id, User client);
        void ReturnBook(int id, User client);
    }
}
