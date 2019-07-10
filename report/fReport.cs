using business_logic_layer;
using CrystalDecisions.CrystalReports.Engine;
using report;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace crystal_report
{
    public partial class fReport : Form
    {
        private int idtable;
        private string tableName;
        private string staffName;
        private int discount;
        private double totalPrice;

        public int Idtable { get => idtable; set => idtable = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public int Discount { get => discount; set => discount = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        MenuBLL mnBLL = new MenuBLL();
        crReport report = new crReport();

        public fReport(int idtable, string tableName, string staffName, int discount, double totalPrice)
        {
            InitializeComponent();
            this.Idtable = idtable;
            this.TableName = tableName;
            this.StaffName = staffName;
            this.Discount = discount;
            this.TotalPrice = totalPrice;
            setTextBoxIntoReport();
            loadReportItems();
        }

        public fReport() { }

        public void loadReportItems()
        {
            DataTable dt = mnBLL.getReportByTable(Idtable);
            report.SetDataSource(dt);
            crvReport.ReportSource = report;
            crvReport.Refresh();
        }

        public void setTextBoxIntoReport()
        {
            CultureInfo culture = new CultureInfo("vni-vn");
            ReportObjects objs = report.ReportDefinition.ReportObjects;
            TextObject txtTableName = (TextObject)objs["tableName"];
            txtTableName.Text = TableName;
            TextObject txtStaffName = (TextObject)objs["staffName"];
            txtStaffName.Text = StaffName;
            TextObject txtDiscount = (TextObject)objs["discount"];
            txtDiscount.Text = Discount.ToString() + "%";
            TextObject txtTotalPrice = (TextObject)objs["totalPrice"];
            txtTotalPrice.Text = TotalPrice.ToString("c", culture);
        }
    }
}
