using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLSuppliers
    {
        DALSuppliers dalSuppliers = new DALSuppliers();
        public BLLSuppliers() { }

        public List<Supplier> ListSuppliers()
        {
            return dalSuppliers.ListSuppliers();
        }

        public Supplier GetSupplierById(int id)
        {
            return dalSuppliers.GetSupplierById(id);
        }
    }
}
