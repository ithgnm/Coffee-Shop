using data_access_layer;
using data_transfer_object;
using System.Data;

namespace business_logic_layer
{
    public class AccountBLL
    {

        public bool login(string userName, string password, Provider provider)
        {
            DataProvider.Instance.provider = provider;
            return AccountDAO.Instance.login(userName, password);
        }

        public Account getAccountByUserName(string userName)
        {
            return AccountDAO.Instance.getAccountByUserName(userName);
        }

        public bool updateAccountPassword(string userName, string password, string newPassword)
        {
            return AccountDAO.Instance.updateAccountPassword(userName, password, newPassword);
        }

        public DataTable getListAccount()
        {
            return AccountDAO.Instance.getListAccount();
        }

        public bool insertAccount(string userName, string displayName, int type, string typename)
        {
            return AccountDAO.Instance.insertAccount(userName, displayName, type, typename);
        }

        public bool updateAccount(string userName, string displayName, int type, string typename)
        {
            return AccountDAO.Instance.updateAccount(userName, displayName, type, typename);
        }

        public bool deleteAccount(string userName)
        {
            return AccountDAO.Instance.deleteAccount(userName);
        }

        public bool resetPasswordAccount(string userName)
        {
            return AccountDAO.Instance.resetPasswordAccount(userName);
        }
    }
}
