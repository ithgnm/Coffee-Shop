using data_access_layer;
using data_transfer_object;
using System.Collections.Generic;

namespace business_logic_layer
{
    public class AreaBLL
    {
        public List<Area> getListArea()
        {
            return AreaDAO.Instance.getListArea();
        }

        public Area getListAreaByID(int id)
        {
            return AreaDAO.Instance.getListAreaByID(id);
        }

        public bool insertArea(string name)
        {
            return AreaDAO.Instance.insertArea(name);
        }

        public bool deleteArea(int id)
        {
            return AreaDAO.Instance.deleteArea(id);
        }

        public bool updateArea(int id, string name)
        {
            return AreaDAO.Instance.updateArea(id, name);
        }
    }
}
