
namespace data_transfer_object
{
    public class Provider
    {
        private string server;
        private string database;
        private string userID;
        private string password;

        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }

        public Provider() { }

        public Provider(string server, string database, string userID, string password)
        {
            this.Server = server;
            this.Database = database;
            this.UserID = userID;
            this.Password = password;
        }
    }
}
