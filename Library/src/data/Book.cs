using System;

namespace Library
{
    public class Book
    {
        private int id;
        private String title;
        private String author;
        private String genre;
        private User user; //who borrowed the book; null means its in library

        public Book (int id, String title, String author, String genre)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.genre = genre;
        }

        public int GetId()
        {
            return this.id;
        }

        public String GetTitle()
        {
            return this.title;
        }

        public String GetAuthor()
        {
            return this.author;
        }

        public String GetGenre()
        {
            return this.genre;
        }

        public User GetUser()
        {
            return this.user;
        }

        public void SetUser(User user)
        {
            this.user = user;
        }
    }
}
