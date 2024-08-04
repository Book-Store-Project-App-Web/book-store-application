using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLBookOrders
    {
        DALBookOrders bllBookOrders = new DALBookOrders();
        public List<Book_Order> LoadBookOrders()
        {
            return bllBookOrders.LoadBookOrders();
        }

        public List<Book_Order> GetBookOrdersByOrderId(int orderId)
        {
            return bllBookOrders.GetBookOrdersByOrderId(orderId);
        }
    }
}
