using System;

namespace Library.src
{
    public class Event
    {
        private User user;
        private Book book;
        private String createdAt;

        public Event(User user)
        {
            this.user = user;
            this.createdAt = DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy hh:mm:ss");
        }
    }

    public class NewUser : Event
    {
        public NewUser(User user) : base(user)
        {
            //we're just registering a new user for the first time, all we need is in the base constructor

        }
    }

    public class BorrowBook : Event
    {
        private Book book;
        public BorrowBook(User user, Book book) : base(user)
        {
            this.book = book;
            book.SetUser(user);
            user.AddBook(book);
        }
    }

    public class ReturnBook : Event
    {
        private Book book;
        public ReturnBook(User user, Book book) : base(user)
        {
            this.book = book;
            book.SetUser(null);
            user.RemoveBook(book);
        }
    }
}
