using data_access_layer;
using data_transfer_object;
using System.Collections.Generic;
using System.Data;

namespace business_logic_layer
{
    public class MenuBLL
    {
        public List<Menu> getListMenuByTable(int id)
        {
            return MenuDAO.Instance.getListMenuByTable(id);
        }

        public DataTable getReportByTable(int id)
        {
            return MenuDAO.Instance.getReportByTable(id);
        }
    }
}
