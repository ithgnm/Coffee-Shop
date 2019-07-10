using data_transfer_object;
using System.Collections.Generic;
using System.Data;

namespace data_access_layer
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

        private TableDAO() { }

        public List<Table> getListTable()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec dbo.usp_gettablelist");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public List<Table> getListTableByAreaID(int id)
        {
            List<Table> tableList = new List<Table>();
            string query = "select* from dbo.cftable where idarea = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
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

        public bool insertTable(string name, int idarea)
        {
            string query = "insert dbo.cftable (name, status, idarea) values (N'" + name + "', 'Empty', " + idarea + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateTable(int id, string name, string status, int idarea)
        {
            string query = "update dbo.cftable set name = N'" + name + "', status = N'" + status + "', idarea = " + idarea + " where id = " + id;
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

        public bool updateTableStatus(int id, string status)
        {
            string query = "update dbo.cftable set status = N'" + status + "' where id = " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public void removeTableByIDArea(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.cftable where idarea = " + id);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                removeTable(table.ID);
            }
        }
    }
}
