using data_transfer_object;
using System.Collections.Generic;
using System.Data;

namespace data_access_layer
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;
        public static DrinkDAO Instance
        {
            get
            {
                if (instance == null) instance = new DrinkDAO();
                return DrinkDAO.instance;
            }
            private set => DrinkDAO.instance = value;
        }

        private DrinkDAO() { }

        public List<Drink> getDrinkByIDCatogery(int id)
        {
            List<Drink> list = new List<Drink>();
            string query = "select * from dbo.drink where idcategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                list.Add(drink);
            }
            return list;
        }

        public List<Drink> getListDrink()
        {
            List<Drink> list = new List<Drink>();
            string query = "select * from dbo.drink";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                list.Add(drink);
            }
            return list;
        }

        public bool insertDrink(int id, string name, float price)
        {
            string query = string.Format("insert dbo.drink (idcategory, name, price) values ({0}, N'{1}', {2})", id, name, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateDrink(int idDrink, int id, string name, float price)
        {
            string query = string.Format("update dbo.drink set name = N'{0}', idcategory = {1}, price = {2} where id = {3}", name, id, price, idDrink);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteDrink(int idDrink)
        {
            BillInfoDAO.Instance.deleteBillInfoByIDDrink(idDrink);
            string query = "delete dbo.drink where id = " + idDrink;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public void deleteDrinkByIDCategory(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.drink where idcategory = " + id);
            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                deleteDrink(drink.ID);
            }
        }

        public List<Drink> searchDrinkByName(string name)
        {
            List<Drink> list = new List<Drink>();
            string query = "select * from dbo.drink where name like N'%" + name + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                list.Add(drink);
            }
            return list;
        }
    }
}
