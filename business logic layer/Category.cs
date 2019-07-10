using data_access_layer;
using data_transfer_object;
using System.Collections.Generic;

namespace business_logic_layer
{
    public class CategoryBLL
    {
        public List<Category> getListCategory()
        {
            return CategoryDAO.Instance.getListCategory();
        }

        public Category getListCategoryByID(int id)
        {
            return CategoryDAO.Instance.getListCategoryByID(id);
        }

        public bool insertCategory(string name)
        {
            return CategoryDAO.Instance.insertCategory(name);
        }

        public bool updateCategory(int id, string name)
        {
            return CategoryDAO.Instance.updateCategory(id, name);
        }

        public bool deleteCategory(int id)
        {
            return CategoryDAO.Instance.deleteCategory(id);
        }
    }
}
