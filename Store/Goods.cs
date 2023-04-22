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
    public partial class Goods : Form
    {
        int selectedGoodsRow = 0;
        public Goods()
        {
            InitializeComponent();
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.MEGABYTDataSet);

            this.infoGoodsTableAdapter.Fill(this.MEGABYTDataSet.InfoGoods);
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            this.defaultGoodsInfoTableAdapter.Fill(this.MEGABYTDataSet.DefaultGoodsInfo);
            this.kategoryGoodsTableAdapter.Fill(this.MEGABYTDataSet.KategoryGoods);
            this.manufacturerTableAdapter.Fill(this.MEGABYTDataSet.Manufacturer);
            this.infoGoodsTableAdapter.Fill(this.MEGABYTDataSet.InfoGoods);
            this.goodsTableAdapter.Fill(this.MEGABYTDataSet.Goods);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int selectedGoodsID = (int)goodsDataGridView.Rows[selectedGoodsRow].Cells[0].Value;
            SqlConnection myConnection;
            myConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("Empty", myConnection);
            cmd1.CommandText = "DELETE FROM dbo.InfoGoods WHERE IDGoods=" + selectedGoodsID;
            SqlCommand cmd2 = new SqlCommand("Empty", myConnection);
            cmd2.CommandText = "DELETE FROM dbo.Goods WHERE IDGoods=" + selectedGoodsID;
            myConnection.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            myConnection.Close();
            this.defaultGoodsInfoTableAdapter.Fill(this.MEGABYTDataSet.DefaultGoodsInfo);
            this.kategoryGoodsTableAdapter.Fill(this.MEGABYTDataSet.KategoryGoods);
            this.manufacturerTableAdapter.Fill(this.MEGABYTDataSet.Manufacturer);
            this.infoGoodsTableAdapter.Fill(this.MEGABYTDataSet.InfoGoods);
            this.goodsTableAdapter.Fill(this.MEGABYTDataSet.Goods);
        }

        private void goodsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedGoodsRow = goodsDataGridView.CurrentCell.RowIndex;
        }
    }
}
