using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALBookOrders
    {
        BookStoreDataContext dalcontext = new BookStoreDataContext();
        public DALBookOrders() { }
        public List<Book_Order> LoadBookOrders()
        {
            return dalcontext.Book_Orders.ToList();
        }

        public List<Book_Order> GetBookOrdersByOrderId(int orderId)
        {
            return dalcontext.Book_Orders.Where(bo => bo.orderId == orderId).ToList();
        }

        public List<Book_Order> GetBookOrdersByMonthAndYear(int year, int month)
        {
            return dalcontext.Book_Orders.Where(bo => bo.updatedAt.Year == year && bo.updatedAt.Month == month) .ToList();
        }
    }
}
