
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class CatalogBasicImpl : ICatalog
    {
        private IBookDao dao;

        public CatalogBasicImpl(IBookDao dao)
        {
            this.dao = dao;
        }

        public Book GetBook(int id)
        {
            return dao.GetAllBooks().Select(book => book).Where(book => id == book.GetId()).ToArray()[0];
        }

        public List<Book> GetBooksByAuthor(String author)
        {
            return dao.GetAllBooks().Select(book => book).Where(book => book.GetAuthor().Equals(author)).ToList();
        }

        public List<Book> GetBooksByTitle(String title)
        {
            return dao.GetAllBooks().Select(book => book).Where(book => book.GetTitle().Equals(title)).ToList();
        }

        public List<Book> GetBooksByGenre(String genre)
        {
            return dao.GetAllBooks().Select(book => book).Where(book => book.GetGenre().Equals(genre)).ToList();
        }

        public List<Book> GetBooksByState(bool isAvailable)
        {
            return dao.GetAllBooks().Select(book => book).Where(book => (book.GetUser() == null) == isAvailable).ToList();
        }

        public List<Book> GetAllBooks()
        {
            return dao.GetAllBooks();
        }

        public void AddBooks(params Book[] books)
        {
            foreach(Book book in books){
                dao.AddBook(book);
            }
        }

        public void RemoveBook(int id)
        {
            dao.RemoveBook(id);
        }

        public void BorrowBook(int id, User client)
        {
            this.GetBook(id).SetUser(client);
        }

        public void ReturnBook(int id, User client)
        {
            if (client.Equals(GetBook(id).GetUser()))
            {
                this.GetBook(id).SetUser(null);
            }
        }
    }
}
