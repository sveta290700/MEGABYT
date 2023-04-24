using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class PackingListReportViewer : Form
    {
        int SaleID;
        public PackingListReportViewer(int SaleID)
        {
            InitializeComponent();
            this.SaleID = SaleID;
        }

        private void PackingListReportViewer_Load(object sender, EventArgs e)
        {
            this.MEGABYTDataSet.EnforceConstraints = false;
            /*SqlConnection myConnection;
            myConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString);
            string sql = "SELECT Sale.IDSale, Sale.DateSale, Receipt.IDReceipt, Goods.ModelGood, Receipt.CountGood, Receipt.PriceGood, Receipt.PriceGoodDiscount, Employee.SName, Employee.FName," + 
                " Employee.Patronym, ClientCard.FullName FROM dbo.Employee AS Employee INNER JOIN" +
                " dbo.ClientCard AS ClienCard INNER JOIN" +
                " dbo.Receipt AS Receipt INNER JOIN" +
                " dbo.Goods AS Goods ON Receipt.IDGoods = Goods.IDGoods INNER JOIN Sale ON Receipt.IDSale = Sale.IDSale ON ClientCard.IDClientCard = Sale.IDClientCard ON Employee.IDEmployee = Sale.IDEmployee WHERE(Sale.IDSale =" + SaleID;
            SqlCommand cmd = new SqlCommand(sql, myConnection); 
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();*/
            MEGABYTDataSetTableAdapters.packing_listTableAdapter plTA = new MEGABYTDataSetTableAdapters.packing_listTableAdapter();
            plTA.Fill(this.MEGABYTDataSet.packing_list, SaleID);
            this.reportViewer1.RefreshReport();
        }
    }
}
