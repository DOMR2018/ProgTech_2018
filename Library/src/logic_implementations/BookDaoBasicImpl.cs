using System.Collections.Generic;

namespace Library
{
    public class BookDaoBasicImpl : IBookDao
    {
        private List<Book> allBooks = new List<Book>();

        public List<Book> GetAllBooks()
        {
            return allBooks;
        }

        //public List<Book> GetBooks(String query)
        //{
        //    throw new NotSupportedException();
        //}

        public void AddBook(Book book)
        {
            allBooks.Add(book);
        }

        public void RemoveBook(int id)
        {
            foreach (Book book in allBooks)
            {
                if (book.GetId() == id)
                {
                    allBooks.Remove(book);
                    return;
                }
            }
        }
    }
}
