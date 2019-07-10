using data_transfer_object;
using System.Collections.Generic;
using System.Data;

namespace data_access_layer
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get
            {
                if (instance == null) instance = new MenuDAO();
                return MenuDAO.instance;
            }
            private set => MenuDAO.instance = value;
        }

        private MenuDAO() { }

        public List<Menu> getListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "select d.name, bi.count, d.price, d.price*bi.count as total from dbo.billinfo as bi, dbo.bill as b, dbo.drink as d where bi.idbill = b.id and bi.iddrink = d.id and b.status = 0 and b.idtable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }

        public DataTable getReportByTable(int id)
        {
            string query = "select d.name, bi.count, d.price, d.price*bi.count as total from dbo.billinfo as bi, dbo.bill as b, dbo.drink as d where bi.idbill = b.id and bi.iddrink = d.id and b.status = 0 and b.idtable = " + id;
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
