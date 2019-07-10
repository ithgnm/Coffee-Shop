using data_transfer_object;
using System.Collections.Generic;
using System.Data;

namespace data_access_layer
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
            private set => BillInfoDAO.instance = value;
        }

        private BillInfoDAO() { }

        public List<BillInfo> getListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.billinfo where idbill = " + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }

        public void insertBillInfo(int idbill, int iddrink, int count)
        {
            DataProvider.Instance.ExecuteQuery("exec usp_insertbillinfo @idbill , @iddrink , @count", new object[] { idbill, iddrink, count });
        }

        public void deleteBillInfoByIDDrink(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.billinfo where iddrink = " + id);
        }

        public void deleteBillInfoByIDBill(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.billinfo where idbill = " + id);
        }
    }
}
