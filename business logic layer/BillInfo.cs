using data_access_layer;
using data_transfer_object;
using System.Collections.Generic;

namespace business_logic_layer
{
    public class BillInfoBLL
    {
        public List<BillInfo> getListBillInfo(int id)
        {
            return BillInfoDAO.Instance.getListBillInfo(id);
        }

        public void insertBillInfo(int idbill, int iddrink, int count)
        {
            BillInfoDAO.Instance.insertBillInfo(idbill, iddrink, count);
        }

        public void deleteBillInfoByIDDrink(int id)
        {
            BillInfoDAO.Instance.deleteBillInfoByIDDrink(id);
        }

        public void deleteBillInfoByIDBill(int id)
        {
            BillInfoDAO.Instance.deleteBillInfoByIDBill(id);
        }
    }
}
