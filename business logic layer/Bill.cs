using data_access_layer;
using System;
using System.Data;

namespace business_logic_layer
{
    public class BillBLL
    {
        public int getUncheckBillIDByTableID(int id)
        {
            return BillDAO.Instance.getUncheckBillIDByTableID(id);
        }

        public void insertBill(int id)
        {
            BillDAO.Instance.insertBill(id);
        }

        public int getMaxIDBill()
        {
            return BillDAO.Instance.getMaxIDBill();
        }

        public DataTable getBillListByDate(DateTime checkin, DateTime checkout)
        {
            return BillDAO.Instance.getBillListByDate(checkin, checkout);
        }

        public void checkout(int id, int discount, float totalPrice)
        {
            BillDAO.Instance.checkout(id, discount, totalPrice);
        }

        public void deleteBillByIDTable(int id)
        {
            BillDAO.Instance.deleteBillByIDTable(id);
        }
    }
}
