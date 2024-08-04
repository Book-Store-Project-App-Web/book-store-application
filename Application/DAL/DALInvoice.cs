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
            return dalcontext.Orders.Select(iv => iv).ToList<Order>();
        }
        public void AddInvoice(Order order)
        {
            dalcontext.Orders.InsertOnSubmit(order);
            dalcontext.SubmitChanges();
        }
        public void DeleteInvoice(int id)
        {
            var order = dalcontext.Orders.SingleOrDefault(u => u.id == id);
            if (order != null)
            {
                dalcontext.Orders.DeleteOnSubmit(order);
                dalcontext.SubmitChanges();
            }
        }
        public void UpdateInvoice(Order order)
        {
            var existingInvoice = dalcontext.Orders.SingleOrDefault(u => u.id == order.id);
            if (existingInvoice != null)
            {
                existingInvoice.userId = order.userId;
                existingInvoice.fullName = order.fullName;
                existingInvoice.phone = order.phone;
                existingInvoice.address = order.address;
                existingInvoice.totalOrderPrice = order.totalOrderPrice;
                existingInvoice.updatedAt = DateTime.Now;
                dalcontext.SubmitChanges();
            }
        }
    }
}
