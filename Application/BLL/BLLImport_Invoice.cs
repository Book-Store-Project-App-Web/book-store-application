using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLImport_Invoice
    {
        DALImport_Invoice bllImport_Invoice = new DALImport_Invoice();
        public BLLImport_Invoice() { }
        public List<Import_Invoice> LoadImport_Invoice()
        {
            return bllImport_Invoice.LoadImport_Invoice();
        }
        public int AddImportInvoice(Import_Invoice importInvoice)
        {
            return bllImport_Invoice.AddImportInvoice(importInvoice);
        }
        public List<Import_Invoice> GetImportInvoiceByMonthAndYear(int year, int month)
        {
            return bllImport_Invoice.GetImportInvoiceByMonthAndYear(year, month);
        }
        public List<(DateTime Date, double Count)> GetImportInvoiceSummaryByDate(int year, int month)
        {
            var import_invoice = bllImport_Invoice.GetImportInvoiceByMonthAndYear(year, month);

            return import_invoice
                .GroupBy(bo => bo.createdAt.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    Count = (double)g.Sum(bo => bo.totalInvoice)
                })
                .Select(x => (x.Date, x.Count))
                .ToList();
        }
    }
}
