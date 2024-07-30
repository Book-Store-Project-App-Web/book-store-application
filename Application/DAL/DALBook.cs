using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALBook
    {
        BookStoreDataContext bt = new BookStoreDataContext();
        public DALBook () { }
        public string GenerateSlug(string phrase)
        {
            string str = phrase.ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }
        public List<BookDK> ListBooks()
        {
            return bt.Books.Join(bt.Suppliers, b => b.supplierId, s => s.id, (b, s) => new BookDK
            {
                image = b.image,
                name = b.name,
                price = b.price,
                discount = b.discount,
                stock = b.stock,
                pageNumber = b.pageNumber,
                publishingYear = b.publishingYear,
                supplier = s.name,
                totalRating = b.totalRating,
                ratingsAverage = b.ratingsAverage,
                id = b.id
            }).ToList();

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
            _book.pageNumber = book.pageNumber;
            _book.publishingYear = book.publishingYear;
            _book.slug = GenerateSlug(book.name);
            _book.totalRating = 0;
            _book.sold = 0;
            _book.ratingsAverage = 0;
            _book.createdAt = DateTime.Now;
            _book.updatedAt = DateTime.Now;

            bt.Books.InsertOnSubmit(_book);
            bt.SubmitChanges();
            return _book;
        }

        public List<Category> ListCateBook()
        {
            return bt.Categories.Select(c => c).ToList<Category>();
        }
        public List<Supplier> ListSupBook()
        {
            return bt.Suppliers.Select(c => c).ToList<Supplier>();
        }
        public Book CheckExistBook(string name)
        {
            return bt.Books.Where(b => b.name == name).FirstOrDefault();
        }
        public bool DeleteBook(int id)
        {
            var book =  bt.Books.Where(b => b.id == id).FirstOrDefault();
            if(book != null)
            {
                bt.Books.DeleteOnSubmit(book);
                bt.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool UpdateBook(int id, Book book)
        {
              Book _book =  bt.Books.Where(b => b.id == id).FirstOrDefault();
            if (_book != null)
            {
                _book.image = book.image;
                _book.name = book.name;
                _book.supplierId = book.supplierId;
                _book.categoryId = book.categoryId;
                _book.price = book.price;
                _book.discount = book.discount;
                _book.stock = book.stock;
                _book.pageNumber = book.pageNumber;
                _book.publishingYear = book.publishingYear;
                _book.slug = GenerateSlug(book.name);
                _book.totalRating = 0;
                _book.sold = 0;
                _book.ratingsAverage = 3.5;
                _book.createdAt = DateTime.Now;
                _book.updatedAt = DateTime.Now;

                bt.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
