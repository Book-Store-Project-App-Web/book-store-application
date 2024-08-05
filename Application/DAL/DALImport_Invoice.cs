using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALImport_Invoice
    {
        BookStoreDataContext dalContext = new BookStoreDataContext();
        public DALImport_Invoice() { }
        public int AddImportInvoice(Import_Invoice importInvoice)
        {
            dalContext.Import_Invoices.InsertOnSubmit(importInvoice);
            dalContext.SubmitChanges();
            return importInvoice.id;
        }
    }
}
