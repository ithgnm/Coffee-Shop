using System.Data;

namespace data_transfer_object
{
    public class Area
    {
        private int iD;
        public int ID { get => iD; set => iD = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        public Area(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Area(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }
    }
}
