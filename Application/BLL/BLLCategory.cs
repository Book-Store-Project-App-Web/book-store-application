using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLCategory
    {
        DALCategory dalcategory = new DALCategory();
        public BLLCategory() { }

        public List<Category> LoadCategories()
        {
            return dalcategory.Categories();
        }

        public List<List_Cate> Listcate_cate()
        {
            return dalcategory.ListCate_cate();
        }

        public void AddCategory(Category category)
        {
            dalcategory.AddCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            dalcategory.UpdateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            dalcategory.DeleteCategory(id);
        }
    }
}
