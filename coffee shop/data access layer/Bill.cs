using coffee_shop.data_transfer_object;
using System;
using System.Data;

namespace coffee_shop.data_access_layer
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO();
                return BillDAO.instance;
            }
            private set => BillDAO.instance = value;
        }

        private BillDAO() { }

        public int getUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.bill where idtable = " + id + "and status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void insertBill(int id)
        {
            DataProvider.Instance.ExecuteQuery("exec usp_insertbill @idtable", new object[] { id });
        }

        public int getMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from dbo.bill");
            }
            catch { return 1; }
        }

        public DataTable getBillListByDate(DateTime checkin, DateTime checkout)
        {
            return DataProvider.Instance.ExecuteQuery("exec usp_getbilllistbydate @checkin , @checkout", new object[] { checkin, checkout });
        }

        public void checkout(int id, int discount, float totalPrice)
        {
            string query = "update dbo.bill set status = 1, checkout = getdate(), " + "discount = " + discount + ", totalprice = " + totalPrice + " where id = " + id;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void deleteBillByIDTable(int id)
        {
            string query = "select * from dbo.bill where idtable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                BillInfoDAO.Instance.deleteBillInfoByIDBill(bill.ID);
                query = "delete dbo.bill where id = " + bill.ID + " and status = 0";
                DataProvider.Instance.ExecuteQuery(query);
            }
        }
    }
}
