using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLInvoice
    {
        DALInvoice bllInvoice = new DALInvoice();
        public BLLInvoice() { }

        public List<Order> LoadInvoice()
        {
            return bllInvoice.LoadlistInvoice();
        }
    }
}
