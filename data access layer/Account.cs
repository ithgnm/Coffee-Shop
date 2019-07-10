using data_transfer_object;
using System.Collections.Generic;
using System.Data;

namespace data_access_layer
{
    public class AccountDAO
    {
        string hashSalt = BCrypt.Net.BCrypt.GenerateSalt(12);

        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set => AccountDAO.instance = value;
        }

        private AccountDAO() { }

        public bool login(string userName, string password)
        {
            string query = "select * from dbo.account where username = '" + userName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                try
                {
                    if (BCrypt.Net.BCrypt.Verify(password, acc.Password))
                        return true;
                }
                catch { return false; }
            }
            return false;
        }

        public Account getAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from account where username = '" + userName + "'");
            foreach (DataRow item in data.Rows)
                return new Account(item);
            return null;
        }

        public bool updateAccountPassword(string userName, string password, string newPassword)
        {
            string hashPassword = BCrypt.Net.BCrypt.HashPassword(password, hashSalt);
            string hashNewPassword = BCrypt.Net.BCrypt.HashPassword(newPassword, hashSalt);
            string query = "select * from dbo.account where username = '" + userName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                try
                {
                    if (BCrypt.Net.BCrypt.Verify(password, acc.Password))
                    {
                        query = string.Format("update dbo.account set password = N'{1}' where username = N'{0}'", userName, hashNewPassword);
                        int result = DataProvider.Instance.ExecuteNonQuery(query);
                        return result > 0;
                    }
                }
                catch { return false; }
            }
            return false;
        }

        public DataTable getListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select username as UserName, displayname as DisplayName, typename as TypeName from dbo.account");
        }

        public bool insertAccount(string userName, string displayName, int type, string typename)
        {
            string hashPassword = BCrypt.Net.BCrypt.HashPassword("1", hashSalt);
            string query = string.Format("insert dbo.account (username, displayname, password, type, typename) values (N'{0}', N'{1}', N'{4}', {2}, N'{3}')", userName, displayName, type, typename, hashPassword);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateAccount(string userName, string displayName, int type, string typename)
        {
            string query = string.Format("update dbo.account set username = N'{0}', displayname = N'{1}', type = {2}, typename = N'{3}' where userName = N'{4}'", userName, displayName, type, typename, userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteAccount(string userName)
        {
            string query = string.Format("delete dbo.account where username = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool resetPasswordAccount(string userName)
        {
            string hashPassword = BCrypt.Net.BCrypt.HashPassword("1", hashSalt);
            string query = string.Format("update dbo.account set password = N'{1}' where username = N'{0}'", userName, hashPassword);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
