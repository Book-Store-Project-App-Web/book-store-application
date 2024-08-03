using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALInvoice
    {
        BookStoreDataContext dalcontext = new BookStoreDataContext();
        public DALInvoice()
        {

        }

        public List<Order> LoadlistInvoice()
        {
            return dalcontext.Orders.Select(o => o).ToList<Order>();
        }
    }
}
