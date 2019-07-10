using data_access_layer;
using data_transfer_object;
using System.Collections.Generic;

namespace business_logic_layer
{
    public class DrinkBLL
    {
        public static int drinkWidth = 150;
        public static int drinkHeight = 48;

        public List<Drink> getDrinkByIDCatogery(int id)
        {
            return DrinkDAO.Instance.getDrinkByIDCatogery(id);
        }

        public List<Drink> getListDrink()
        {
            return DrinkDAO.Instance.getListDrink();
        }

        public bool insertDrink(int id, string name, float price)
        {
            return DrinkDAO.Instance.insertDrink(id, name, price);
        }

        public bool updateDrink(int idDrink, int id, string name, float price)
        {
            return DrinkDAO.Instance.updateDrink(idDrink, id, name, price);
        }

        public bool deleteDrink(int idDrink)
        {
            return DrinkDAO.Instance.deleteDrink(idDrink);
        }

        public void deleteDrinkByIDCategory(int id)
        {
            DrinkDAO.Instance.deleteDrinkByIDCategory(id);
        }

        public List<Drink> searchDrinkByName(string name)
        {
            return DrinkDAO.Instance.searchDrinkByName(name);
        }
    }
}
