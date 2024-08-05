using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALSuppliers
    {
        BookStoreDataContext dtContext = new BookStoreDataContext();
        public DALSuppliers() { }

        public List<Supplier> ListSuppliers()
        {
            return dtContext.Suppliers.Select(spl => spl).ToList<Supplier>();
        }
        public Supplier GetSupplierById(int id)
        {
            return dtContext.Suppliers.FirstOrDefault(spl => spl.id == id);
        }
    }
}
