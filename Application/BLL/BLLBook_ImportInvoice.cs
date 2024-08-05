using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLBook_ImportInvoice
    {
        DALBook_ImportInvoice bllBook_ImportInvoice = new DALBook_ImportInvoice();
        public BLLBook_ImportInvoice() { }

        public Book_ImportInvoice GetbyIdBook(int idBook)
        {
            return bllBook_ImportInvoice.GetByIdBook(idBook);
        }
        public void AddBook_ImportInvoice(Book_ImportInvoice bookImportInvoice)
        {
            bllBook_ImportInvoice.AddBook_ImportInvoice(bookImportInvoice);
        }
    }
}
