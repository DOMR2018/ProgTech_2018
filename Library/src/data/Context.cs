using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Library.src.data
{
    public class Context : DbContext
    {
        //public LibraryContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString) { }
        //public LibraryContext(string text) : base(text) { }
        public Context() : base() { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
