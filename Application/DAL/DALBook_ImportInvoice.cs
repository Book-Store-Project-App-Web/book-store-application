using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALBook_ImportInvoice
    {
        BookStoreDataContext dtContext = new BookStoreDataContext();
        public DALBook_ImportInvoice() { }

        public Book_ImportInvoice GetByIdBook(int idBook)
        {
            return dtContext.Book_ImportInvoices.FirstOrDefault(bi => bi.bookId == idBook);
        }
        public void AddBook_ImportInvoice(Book_ImportInvoice bookImportInvoice)
        {
            dtContext.Book_ImportInvoices.InsertOnSubmit(bookImportInvoice);
            dtContext.SubmitChanges();
        }
        public void UpdateImport_Book(Book book)
        {
            var existingBook = dtContext.Books.SingleOrDefault(b => b.id == book.id);
            if (existingBook != null)
            {
                existingBook.stock = book.stock;
                existingBook.price = book.price;
                dtContext.SubmitChanges();
            }
        }
    }
}
