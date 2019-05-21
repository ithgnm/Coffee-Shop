using System.Data;

namespace coffee_shop.data_transfer_object
{
    public class BillInfo
    {
        private int iD;
        public int ID { get => iD; set => iD = value; }

        private int iDBill;
        public int IDBill { get => iDBill; set => iDBill = value; }

        private int iDDrink;
        public int IDDrink { get => iDDrink; set => iDDrink = value; }

        private int count;
        public int Count { get => count; set => count = value; }
        
        public BillInfo(int id, int idbill, int iddrink, int count)
        {
            this.ID = id;
            this.IDBill = idbill;
            this.IDDrink = iddrink;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDBill = (int)row["idbill"];
            this.IDDrink = (int)row["iddrink"];
            this.Count = (int)row["count"];
        }
    }
}
