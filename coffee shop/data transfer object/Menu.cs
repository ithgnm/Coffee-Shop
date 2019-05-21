using System;
using System.Data;

namespace coffee_shop.data_transfer_object
{
    public class Menu
    {
        private string drinkName;
        public string DrinkName { get => drinkName; set => drinkName = value; }

        private int count;
        public int Count { get => count; set => count = value; }

        private float price;
        public float Price { get => price; set => price = value; }

        private float totalPrice;
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        public Menu(string drinkname, int count, float price, float totalprice = 0)
        {
            this.DrinkName = drinkname;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalprice;
        }

        public Menu(DataRow row)
        {
            this.DrinkName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"]);
            this.TotalPrice = (float)Convert.ToDouble(row["total"]);
        }
    }
}
