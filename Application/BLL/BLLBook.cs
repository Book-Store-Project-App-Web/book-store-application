using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BLL
{
    public class BLLBook
    {
        DALBook dalBook = new DALBook();
        public BLLBook() { }

        public List<BookDK> ListBooks()
        {
            return dalBook.ListBooks();
        }
        public Book CreatNewBook(Book _book)
        {
            return dalBook.CreatNewBook(_book);
        }

        public List<Category> ListCateBook()
        {
            return dalBook.ListCateBook();
        }
        public List<Supplier> ListSupBook()
        {
            return dalBook.ListSupBook();
        }
        public Book CheckExistBook(string name)
        {
            return dalBook.CheckExistBook(name);
        }
        public bool DeleteBook(int id)
        {
            return dalBook.DeleteBook(id);
        }
        public bool UpdateBook(int id, Book _book)
        {
            return dalBook.UpdateBook(id, _book);
        }
    }
}
