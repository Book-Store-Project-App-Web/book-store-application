using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DTO;

namespace DAL
{
    public class DALBook
    {
        BookStoreDataContext bt = new BookStoreDataContext();
        public DALBook() { }
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
                //author = b.author,
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
            bt.Books.InsertOnSubmit(book);
            bt.SubmitChanges();
            return book;
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
        public Book CheckUpdateBook(int id)
        {
            return bt.Books.Where(b => b.id == id).FirstOrDefault();
        }
        public bool DeleteBook(int id)
        {
            var book = bt.Books.Where(b => b.id == id).FirstOrDefault();
            if (book != null)
            {
                bt.Books.DeleteOnSubmit(book);
                bt.SubmitChanges();
                return true;
            }
            return false;
        }
        public Book UpdateBook(int id, Book book)
        {
            bt.SubmitChanges();
            return book;
        }
    }
}
