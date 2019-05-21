using System;
using System.Data;

namespace coffee_shop.data_transfer_object
{
    public class Drink
    {
        private int iD;
        public int ID { get => iD; set => iD = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private int iDCategory;
        public int IDCategory { get => iDCategory; set => iDCategory = value; }

        private float price;
        public float Price { get => price; set => price = value; }

        public Drink(int id, string name, int idcategory, float price)
        {
            this.ID = id;
            this.Name = name;
            this.IDCategory = idcategory;
            this.Price = price;
        }

        public Drink(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IDCategory = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
    }
}
