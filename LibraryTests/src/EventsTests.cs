using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.src.Tests
{
    [TestClass()]
    public class EventsTests
    {
        private EventsBasicImpl eventsList;

        [TestInitialize()]
        public void SetUp()
        {
            this.eventsList = new EventsBasicImpl();
        }

        [TestCleanup()]
        public void TearDown()
        {
            this.eventsList = null;
        }

        [TestMethod()]
        public void ListEventsTest()
        {
            //given
            Book newBook1 = new Book(1, "Borrowed Book", "Developer", "genre");
            Book newBook2 = new Book(2, "Next Book", "Developer", "genre");
            User newUser = new User(1, "Bob", "Ross");
            //when
            eventsList.RegisterEvent(new BorrowBook(newUser, newBook1));
            eventsList.RegisterEvent(new BorrowBook(newUser, newBook2));
            eventsList.RegisterEvent(new ReturnBook(newUser, newBook2));
            //then
            Assert.AreEqual(newBook1.GetUser(), newUser);
            Assert.AreEqual(newBook2.GetUser(), null);
            Assert.IsTrue(newUser.GetAllBooks().Count == 1);
            Assert.IsTrue(eventsList.listEvents().Count == 3);

        }
    }
}