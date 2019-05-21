using coffee_shop.data_transfer_object;
using System.Collections.Generic;
using System.Data;

namespace coffee_shop.data_access_layer
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return TableDAO.instance;
            }
            private set => TableDAO.instance = value;
        }

        public static int tableWidth = 156;
        public static int tableHeight = 96;

        private TableDAO() { }
        
        public List<Table> loadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec dbo.usp_gettablelist");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public void switchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("usp_switchtable @idtable1 , @idtable2", new object[] { id1, id2 });
        }

        public bool insertTable(string name)
        {
            string query = "insert dbo.cftable (name, status) values (N'" + name + "', 'Empty')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateTable(int id, string name, string status)
        {
            string query = "update dbo.cftable set name = N'" + name + "', status = N'" + status + "' where id = " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool removeTable(int id)
        {
            BillDAO.Instance.deleteBillByIDTable(id);
            string query = "delete dbo.cftable where id = " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
