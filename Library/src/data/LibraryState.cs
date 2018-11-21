using System.Collections.Generic;

namespace Library
{
    public class LibraryState
    {
        private IBookDao dao;

        public LibraryState(IBookDao dao)
        {
            this.dao = dao;
        }

        public List<Book> GetCurrentLibraryState()
        {
            return dao.GetAllBooks();
        }
    }
}
