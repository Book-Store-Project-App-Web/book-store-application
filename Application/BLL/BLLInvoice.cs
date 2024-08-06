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
        public List<Order> GetOrdersByMonthAndYear(int year, int month)
        {
            return bllInvoice.GetOrdersByMonthAndYear(year, month);
        }
        public List<(DateTime Date, double Count)> GetBookOrdersSummaryByDate(int year, int month)
        {
            var orders = bllInvoice.GetOrdersByMonthAndYear(year, month);

            return orders
                .GroupBy(bo => bo.updatedAt.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    Count = (double)g.Sum(bo => bo.totalOrderPrice)
        })
                .Select(x => (x.Date, x.Count))
                .ToList();
        }
    }
}
