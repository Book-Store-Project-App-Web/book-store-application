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
        public void AddInvoice(Order order)
        {
            bllInvoice.AddInvoice(order);
        }
        public void DeleteInvoice(int id)
        {
            bllInvoice.DeleteInvoice(id);
        }
        public void UpdateInvoice(Order order)
        {
            bllInvoice.UpdateInvoice(order);
        }
    }
}
