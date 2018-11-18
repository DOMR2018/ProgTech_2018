using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System.Collections.Generic;

namespace LibraryTests
{
    [TestClass]
    public class CatalogTest
    {
        private ICatalog catalog;

        [TestInitialize()]
        public void SetUp()
        {
            IBookDao dao = new BookDaoBasicImpl();
            this.catalog = new CatalogBasicImpl(dao);
        }

        [TestCleanup()]
        public void TearDown()
        {
            this.catalog = null;
        }

        [TestMethod()]
        public void HappyPath()
        {
            //given
            Book book = new Book(1, "Magic Title", "Harry Potter", "horror");
            //when
            catalog.AddBooks(book);
            //then
            Assert.AreEqual(catalog.GetAllBooks()[0], book);
        }

        [TestMethod()]
        public void ShouldGetBookById()
        {
            //given
            Book book1 = new Book(1, "Title1", "Tset", "Ttse");
            Book book2 = new Book(2, "Title2", "Tset", "Ttse");
            Book book3 = new Book(3, "Title3", "Le", "Ttse");
            catalog.AddBooks(book1, book2, book3);
            //then
            Assert.AreEqual(catalog.GetBook(book2.GetId()), book2);
        }

        [TestMethod()]
        public void ShouldGetBookByAuthor()
        {
            //given
            Book book1 = new Book(1, "Title1", "Tset", "Ttse");
            Book book2 = new Book(2, "Title2", "Tset", "Ttse");
            Book book3 = new Book(3, "Title3", "Le", "Ttse");
            catalog.AddBooks(book1, book2, book3);
            //when
            List<Book> result = catalog.GetBooksByAuthor(book1.GetAuthor());
            //then
            Assert.IsTrue(result.Count == 2);     
            Assert.IsTrue(result.Contains(book1));
            Assert.IsTrue(result.Contains(book2));
        }

        [TestMethod()]
        public void ShouldGetBookByTitle()
        {
            //given
            Book book1 = new Book(1, "Title1", "Test", "Ttse");
            Book book2 = new Book(2, "Title2", "Tset", "Ttse");
            Book book3 = new Book(3, "Title1", "Le", "Ttse");
            catalog.AddBooks(book1, book2, book3);
            //when
            List<Book> result = catalog.GetBooksByTitle(book1.GetTitle());
            //then
            Assert.IsTrue(result.Count == 2);
            Assert.IsTrue(result.Contains(book1));
            Assert.IsTrue(result.Contains(book3));
        }

        [TestMethod()]
        public void ShouldGetBookByGenre()
        {
            //given
            Book book1 = new Book(1, "Title1", "Test", "Horror");
            Book book2 = new Book(2, "Title2", "Tset", "Fiction");
            Book book3 = new Book(3, "Title3", "Le", "History");
            catalog.AddBooks(book1, book2, book3);
            //when
            List<Book> result = catalog.GetBooksByGenre(book1.GetGenre());
            //then
            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.Contains(book1));
        }

        [TestMethod()]
        public void ShouldBorrowBook()
        {
            //given
            Book book1 = new Book(1, "Title1", "Steve Jobs", "fantasy");
            User user = new User(1, "John", "Kowalski");
            catalog.AddBooks(book1);
            //when
            catalog.BorrowBook(book1.GetId(), user);
            //then
            Assert.AreEqual(catalog.GetBook(book1.GetId()).GetUser(), user);
        }

        [TestMethod()]
        public void ShouldReturnBook()
        {
            //given
            Book book1 = new Book(1, "Title1", "George Washington", "horror");
            User user = new User(1, "John", "Kowalski");
            catalog.AddBooks(book1);
            catalog.BorrowBook(book1.GetId(), user);
            //when
            catalog.ReturnBook(book1.GetId(), user);
            //then
            Assert.AreEqual(catalog.GetBook(book1.GetId()).GetUser(), null);
        }

        [TestMethod()]
        public void ShouldGetBookByState()
        {
            //given
            Book book1 = new Book(1, "Title1", "Test", "Ttse");
            Book book2 = new Book(2, "Title2", "Tset", "Ttse");
            Book book3 = new Book(3, "Title3", "Le", "Ttse");
            User user = new User(1, "John", "Kowalski");
            catalog.AddBooks(book1, book2, book3);
            catalog.BorrowBook(book1.GetId(), user);
            //when
            List<Book> available = catalog.GetBooksByState(true);
            List<Book> borrowed = catalog.GetBooksByState(false);
            //then
            Assert.IsTrue(available.Count == 2);
            Assert.IsTrue(available.Contains(book2));
            Assert.IsTrue(available.Contains(book3));
            Assert.IsTrue(borrowed.Count == 1);
            Assert.IsTrue(borrowed.Contains(book1));
        }

        [TestMethod()]
        public void ShouldRemoveBook()
        {
            //given
            Book book1 = new Book(1, "Title1", "Test", "Ttse");
            Book book2 = new Book(2, "Title2", "Tset", "Ttse");
            Book book3 = new Book(3, "Title3", "Le", "Ttse");
            catalog.AddBooks(book1, book2, book3);
            //when
            catalog.RemoveBook(book2.GetId());
            //then
            List<Book> result = catalog.GetAllBooks();
            Assert.IsTrue(result.Count == 2);
            Assert.IsTrue(result.Contains(book1));
            Assert.IsTrue(result.Contains(book3));
        }

    }
}
