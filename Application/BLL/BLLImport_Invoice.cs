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
        public int AddImportInvoice(Import_Invoice importInvoice)
        {
            return bllImport_Invoice.AddImportInvoice(importInvoice);
        }
    }
}
