using Library.src.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Context main = new Context(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LibraryContext; Integrated Security = SSPI; AttachDBFilename=|DataDirectory|\LibraryContext.mdf");
            //AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            //List<Book> Books = main.Books.ToList();

            using (var ctx = new Context())
            {
                var bk = new Book() { author = "Frank", genre = "horror", title = "My Book" };
                ctx.Books.Add(bk);
                ctx.SaveChanges();
            }
        }
    }
}
