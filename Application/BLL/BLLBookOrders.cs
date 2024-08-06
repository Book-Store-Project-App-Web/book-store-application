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
        public List<Book_Order> GetBookOrdersByMonthAndYear(int year, int month)
        {
            return bllBookOrders.GetBookOrdersByMonthAndYear(year, month);
        }
        public List<(DateTime Date, int Count)> GetBookOrdersSummaryByDate(int year, int month)
        {
            var orders = bllBookOrders.GetBookOrdersByMonthAndYear(year, month);

            return orders.GroupBy(bo => bo.updatedAt.Date).Select(
                g => new
               {
                   Date = g.Key,
                   Count = g.Sum(bo => bo.quantity.GetValueOrDefault())
               })
               .Select(x => (x.Date, x.Count)) // Convert to tuple
               .ToList();
        }
    }
}
