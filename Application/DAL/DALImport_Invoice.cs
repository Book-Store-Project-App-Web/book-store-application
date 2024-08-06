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
        public List<Import_Invoice> LoadImport_Invoice()
        {
            return dalContext.Import_Invoices.Select(iiv => iiv).ToList<Import_Invoice>();
        }
        public int AddImportInvoice(Import_Invoice importInvoice)
        {
            dalContext.Import_Invoices.InsertOnSubmit(importInvoice);
            dalContext.SubmitChanges();
            return importInvoice.id;
        }
        public List<Import_Invoice> GetImportInvoiceByMonthAndYear(int year, int month)
        {
            return dalContext.Import_Invoices.Where(bo => bo.createdAt.Year == year && bo.createdAt.Month == month).ToList();
        }
    }
}
