using System;
using System.Collections.Generic;

namespace Library.src
{
    public class Library
    {
        private ICatalog catalog;
        private ProcessState processState;
        private IUsers users;
        private IEvents events;

        public Library(IBookDao dao)
        {
            this.catalog = new CatalogBasicImpl(dao);
            this.processState = new ProcessState(dao);
            this.users = new UsersBasicImpl();
            this.events = new EventsBasicImpl();
        }

        public List<Book> GetAllBooks()
        {
            return catalog.GetAllBooks();
        }

        public Book GetBook(int id)
        {
            return catalog.GetBook(id);
        }

        public List<Book> GetBooksByAuthor(String author)
        {
            return catalog.GetBooksByAuthor(author);
        }

        public List<Book> GetBooksByTitle(String title)
        {
            return catalog.GetBooksByTitle(title);
        }

        public List<Book> GetBooksByGenre(String genre)
        {
            return catalog.GetBooksByGenre(genre);
        }

        public List<Book> GetBooksByState(bool isAvailable)
        {
            return catalog.GetBooksByState(isAvailable);
        }

        public void AddBook(String title, String author, String genre)
        {
            int i = 0;
            while(catalog.GetBook(i) != null)
                i++;

            catalog.AddBooks(new Book(i, title, author, genre));
        }

        public void RemoveBook(int id)
        {
            catalog.RemoveBook(id);
        }

        public void BorrowBook(int clientId, int bookId)
        {
            Book book = catalog.GetBook(bookId);
            User client = users.GetUserById(clientId);
            if(book != null)
            {
                if(client != null)
                {
                    if (book.GetUser() != null)
                    {
                        Console.WriteLine("Book is not available");
                        return;
                    }
                    else
                    {
                        events.RegisterEvent(new BorrowBook(client, book));
                    }
                }
                else
                {
                    Console.WriteLine("Client not found");
                }
            }     
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public void ReturnBook(int clientId, int bookId)
        {
            Book book = catalog.GetBook(bookId);
            User client = users.GetUserById(clientId);

            if (book != null)
            {
                if (client != null)
                {
                    if (book.GetUser() != client)
                    {
                        Console.WriteLine("Book is not borrowed by this client");
                        return;
                    }
                    else
                    {
                        events.RegisterEvent(new ReturnBook(client, book));
                    }
                }
                else
                {
                    Console.WriteLine("Client not found");
                }
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
  

        public List<User> GetUsers()
        {
            return users.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return users.GetUserById(id);
        }

        public User GetUserByFirstName(String firstName)
        {
            return users.GetUserByFirstName(firstName);
        }

        public User GetUserByLastName(String lastName)
        {
            return users.GetUserByLastName(lastName);
        }

        public void AddUser(String firstName, String lastName)
        {
            int i = 0;
            while (users.GetUserById(i) != null)
                i++;

            User newUser = new User(i, firstName, lastName);
            users.AddUser(newUser); //add new user to the userlist
            events.RegisterEvent(new NewUser(newUser)); //register the fact that there's new user
        }

        public bool RemoveUser(int id)
        {
            return users.RemoveUser(id);
        }

        public bool UpdateUser(User user)
        {
            return users.UpdateUser(user);
        }


        public List<Event> GetEvents()
        {
            return events.listEvents();
        }


        public List<Book> GetCurrentLibraryState()
        {
            return processState.GetCurrentLibraryState();
        }
    }
}
