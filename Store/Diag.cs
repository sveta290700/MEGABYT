using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Diag : Form
    {
        Reports f;
        public Diag( Reports F)
        {
            InitializeComponent();
            f = F;
        }

        private static DataTable GetData(string query)
        {
            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString; ;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        private void Diag_Load(object sender, EventArgs e)
        {
            string query = "SELECT kg.NameKategory as Категория, COUNT(r.IDReceipt) as Количество"
                +" FROM dbo.KategoryGoods kg INNER JOIN goods g ON g.IDKategoryGoods = kg.IDKategoryGoods"
                +" INNER JOIN dbo.Receipt r ON r.IDGood = g.IDGood"
                +" INNER JOIN dbo.Sale s ON s.IDSale = r.IDSale"
                +" WHERE s.DateSale between '"+f.dateTimePicker1.Value.ToString()+"' and '" + f.dateTimePicker2.Value.ToString() + "'"
                +" GROUP BY kg.NameKategory";
            DataTable dt = GetData(query);

            string[] x = (from p in dt.AsEnumerable()
                          orderby p.Field<string>("Категория") ascending
                          select p.Field<string>("Категория")).ToArray();

            int[] y = (from p in dt.AsEnumerable()
                       orderby p.Field<string>("Категория") ascending
                       select p.Field<int>("Количество")).ToArray();

            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.Legends[0].Enabled = true;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
    }
}
