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

        DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
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
                author = b.author,
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

        public List<dynamic> Top10BookofMonth()
        {
            //SELECT TOP 10 b.id, b.image, b.name, b.sold
            //FROM Book_Orders od JOIN Books b ON od.bookId = b.id
            //JOIN Orders o ON od.orderId = o.id
            //WHERE o.createdAt >= DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0)-- Ngày đầu tiên của tháng hiện tại
            //  AND o.createdAt < DATEADD(month, DATEDIFF(month, 0, GETDATE()) + 1, 0)-- Ngày đầu tiên của tháng tiếp theo
            //ORDER BY b.sold DESC
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(1);


            var topSellingProducts = bt.Book_Orders
              .Join(bt.Books,
                bo => bo.bookId,
                b => b.id,
                (bo,b) => new { bo, b })
              .Join(bt.Orders,
                bob => bob.bo.orderId,
                o => o.id,
                (bob, o) => new {
                    bob.bo,
                    bob.b,
                    o
                })
               .Where(x => x.o.createdAt >= firstDayOfMonth && x.o.createdAt < firstDayOfNextMonth)
               .Select(g => new
               {
                   g.b.id,
                   g.b.image,
                   g.b.name,
                   g.b.sold
               })
                .OrderByDescending(x => x.sold)
                .Take(10)
                .ToList<dynamic>();

            return topSellingProducts;
        }

        public List<dynamic> TotalOrder()
        {

            //SELECT o.totalOrderPrice
            //FROM Orders o
            //WHERE o.createdAt >= DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0)
            //  AND o.createdAt < DATEADD(month, DATEDIFF(month, 0, GETDATE()) + 1, 0)
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(1);

            return bt.Orders.Where(o => o.createdAt >= firstDayOfMonth && o.createdAt < firstDayOfNextMonth).Select(x => x).ToList<dynamic>();
        }

        public List<Book> GetbooksByIdSuppliers(int idSuppler)
        {
            return bt.Books.Where(b => b.supplierId == idSuppler).ToList();
        }

        public Book GetBookById(int idBook)
        {
            return bt.Books.FirstOrDefault(b => b.id == idBook);
        }
    }
}
