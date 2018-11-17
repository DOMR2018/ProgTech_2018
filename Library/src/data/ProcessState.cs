using System.Collections.Generic;

namespace Library
{
    public class ProcessState
    {
        private IBookDao dao;

        public ProcessState(IBookDao dao)
        {
            this.dao = dao;
        }

        public List<Book> GetCurrentLibraryState()
        {
            return dao.GetAllBooks();
        }
    }
}
