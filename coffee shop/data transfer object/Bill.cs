using System;
using System.Data;

namespace coffee_shop.data_transfer_object
{
    public class Bill
    {
        private int iD;
        public int ID { get => iD; set => iD = value; }

        private DateTime? checkin;
        public DateTime? Checkin { get => checkin; set => checkin = value; }

        private DateTime? checkout;
        public DateTime? Checkout { get => checkout; set => checkout = value; }
        
        private int status;
        public int Status { get => status; set => status = value; }

        private int discount;
        public int Discount { get => discount; set => discount = value; }

        public Bill(int id, DateTime? checkin, DateTime? checkout, int status, int discount = 0)
        {
            this.ID = id;
            this.Checkin = checkin;
            this.Checkout = checkout;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Checkin = (DateTime?)row["checkin"];
            var checkoutTemp = row["checkout"];
            if (checkoutTemp.ToString() != "")
                this.Checkout = (DateTime?)row["checkout"];
            this.Status = (int)row["status"];
            if (row["discount"].ToString() != "") this.Discount = (int)row["discount"];
        }
    }
}
