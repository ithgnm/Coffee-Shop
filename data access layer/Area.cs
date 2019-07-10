using data_transfer_object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access_layer
{
    public class AreaDAO
    {
        private static AreaDAO instance;
        public static AreaDAO Instance
        {
            get
            {
                if (instance == null) instance = new AreaDAO();
                return AreaDAO.instance;
            }
            private set => AreaDAO.instance = value;
        }

        private AreaDAO() { }

        public List<Area> getListArea()
        {
            List<Area> list = new List<Area>();
            string query = "select * from dbo.area";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Area area = new Area(item);
                list.Add(area);
            }
            return list;
        }

        public Area getListAreaByID(int id)
        {
            Area area = null;
            string query = "select * from dbo.area where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                area = new Area(item);
                return area;
            }
            return area;
        }

        public bool insertArea(string name)
        {
            string query = "insert dbo.area (name) values (N'" + name + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateArea(int id, string name)
        {
            string query = string.Format("update dbo.area set name = N'{0}' where id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteArea(int id)
        {
            TableDAO.Instance.removeTableByIDArea(id);
            string query = string.Format("delete dbo.area where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
