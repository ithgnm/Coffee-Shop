using System.Data;

namespace data_transfer_object
{
    public class Account
    {
        private int iD;
        private string userName;
        private string displayName;
        private string password;
        private int type;

        public int ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }

        public Account(int iD, string userName, string displayName, int type, string password = null)
        {
            this.ID = iD;
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.ID = (int)row["id"];
            this.UserName = row["username"].ToString();
            this.DisplayName = row["displayname"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["password"].ToString();
        }
    }
}
