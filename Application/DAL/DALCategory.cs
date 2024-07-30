using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALCategory
    {
        BookStoreDataContext dalcontext = new BookStoreDataContext();
        public DALCategory() { }

        public List<Category> Categories()
        {
            var categories = dalcontext.Categories.ToList();
            return categories.Select(c => new Category
            {
                id = c.id,
                listCateId = c.listCateId,
                name = c.name,
                createdAt = c.createdAt,
                updatedAt = c.updatedAt
            }).ToList();
        }
        public List<List_Cate> ListCate_cate()
        {
            return dalcontext.List_Cates.Select(c => c).ToList<List_Cate>();
        }
        public void AddCategory(Category category)
        {
            dalcontext.Categories.InsertOnSubmit(category);
            dalcontext.SubmitChanges();
        }

        public void UpdateCategory(Category category)
        {
            var existingCategory = dalcontext.Categories.SingleOrDefault(c => c.id == category.id);
            if (existingCategory != null)
            {
                existingCategory.name = category.name;
                existingCategory.listCateId = category.listCateId;
                existingCategory.updatedAt = DateTime.Now;
                dalcontext.SubmitChanges();
            }
        }

        public void DeleteCategory(int id)
        {
            var category = dalcontext.Categories.SingleOrDefault(c => c.id == id);
            if (category != null)
            {
                dalcontext.Categories.DeleteOnSubmit(category);
                dalcontext.SubmitChanges();
            }
        }
    }
}
