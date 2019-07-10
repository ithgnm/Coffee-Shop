using System.Data;

namespace data_transfer_object
{
    public class Table
    {
        private int iD;
        public int ID { get => iD; set => iD = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string status;
        public string Status { get => status; set => status = value; }

        private int iDArea;
        public int IDArea { get => iDArea; set => iDArea = value; }

        public Table(int id, string name, string status, int idarea)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
            this.IDArea = idarea;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
            this.IDArea = (int)row["idarea"];
        }
    }
}
