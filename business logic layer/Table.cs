using data_access_layer;
using data_transfer_object;
using System.Collections.Generic;

namespace business_logic_layer
{
    public class TableBLL
    {
        public static int tableWidth = 153;
        public static int tableHeight = 88;

        public List<Table> getListTable()
        {
            return TableDAO.Instance.getListTable();
        }

        public List<Table> getListTableByAreaID(int id)
        {
            return TableDAO.Instance.getListTableByAreaID(id);
        }

        public void switchTable(int id1, int id2)
        {
            TableDAO.Instance.switchTable(id1, id2);
        }

        public bool insertTable(string name, int idarea)
        {
            return TableDAO.Instance.insertTable(name, idarea);
        }

        public bool updateTable(int id, string name, string status, int idarea)
        {
            return TableDAO.Instance.updateTable(id, name, status, idarea);
        }

        public bool removeTable(int id)
        {
            return TableDAO.Instance.removeTable(id);
        }

        public bool updateTableStatus(int id, string status)
        {
            return TableDAO.Instance.updateTableStatus(id, status);
        }
    }
}
