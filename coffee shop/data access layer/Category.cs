using coffee_shop.data_transfer_object;
using System.Collections.Generic;
using System.Data;

namespace coffee_shop.data_access_layer
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new CategoryDAO();
                return CategoryDAO.instance;
            }
            private set => CategoryDAO.instance = value;
        }

        private CategoryDAO() { }

        public List<Category> getListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from dbo.category";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }

        public Category getListCategoryByID(int id)
        {
            Category category = null;
            string query = "select * from dbo.category where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }

        public bool insertCategory(string name)
        {
            string query = "insert dbo.category (name) values (N'" + name + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateCategory(int id, string name)
        {
            string query = string.Format("update dbo.category set name = N'{0}' where id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteCategory(int id)
        {
            DrinkDAO.Instance.deleteDrinkByIDCategory(id);
            string query = string.Format("delete dbo.category where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
