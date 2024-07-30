using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using Slugify;


namespace BLL
{
    public class BLLBook
    {
        DALBook dalBook = new DALBook();
        SlugHelper helper = new SlugHelper();

        public BLLBook() { }

        public List<BookDK> ListBooks()
        {
            return dalBook.ListBooks();
        }
        public Book CreatNewBook(Book book)
        {
            Book _book = new Book();
            _book.image = book.image;
            _book.name = book.name;
            _book.supplierId = book.supplierId;
            _book.categoryId = book.categoryId;
            _book.price = book.price;
            _book.discount = book.discount;
            _book.stock = book.stock;
            //_book.author = book.author;
            _book.pageNumber = book.pageNumber;
            _book.publishingYear = book.publishingYear;
            _book.slug = helper.GenerateSlug(book.name);
            _book.totalRating = 0;
            _book.sold = 0;
            _book.ratingsAverage = 3.5;
            _book.createdAt = DateTime.Now;
            _book.updatedAt = DateTime.Now;

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
        public Book UpdateBook(int id, Book book)
        {
            Book _book = dalBook.CheckUpdateBook(id);
            if (_book != null)
            {
                _book.name = book.name;
                _book.supplierId = book.supplierId;
                _book.categoryId = book.categoryId;
                _book.price = book.price;
                _book.discount = book.discount;
                _book.stock = book.stock;
                //_book.author = book.author;
                _book.pageNumber = book.pageNumber;
                _book.publishingYear = book.publishingYear;
                _book.slug = helper.GenerateSlug(book.name);
                _book.createdAt = DateTime.Now;
                _book.updatedAt = DateTime.Now;
            }
            return dalBook.UpdateBook(id, _book);
        }
    }
}
