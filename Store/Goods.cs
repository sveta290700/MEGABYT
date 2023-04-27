using System;
using System.Configuration;
using System.Data.SqlClient;
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
            Validate();
            goodsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
            infoGoodsTableAdapter.Fill(MEGABYTDataSet.InfoGoods);
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            defaultGoodsInfoTableAdapter.Fill(MEGABYTDataSet.DefaultGoodsInfo);
            kategoryGoodsTableAdapter.Fill(MEGABYTDataSet.KategoryGoods);
            manufacturerTableAdapter.Fill(MEGABYTDataSet.Manufacturer);
            infoGoodsTableAdapter.Fill(MEGABYTDataSet.InfoGoods);
            goodsTableAdapter.Fill(MEGABYTDataSet.Goods);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int selectedGoodsID = (int)goodsDataGridView.Rows[selectedGoodsRow].Cells[0].Value;
            SqlConnection myConnection;
            myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("Empty", myConnection);
            cmd1.CommandText = "DELETE FROM dbo.InfoGoods WHERE IDGoods=" + selectedGoodsID;
            SqlCommand cmd2 = new SqlCommand("Empty", myConnection);
            cmd2.CommandText = "DELETE FROM dbo.Goods WHERE IDGoods=" + selectedGoodsID;
            myConnection.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            myConnection.Close();
            defaultGoodsInfoTableAdapter.Fill(MEGABYTDataSet.DefaultGoodsInfo);
            kategoryGoodsTableAdapter.Fill(MEGABYTDataSet.KategoryGoods);
            manufacturerTableAdapter.Fill(MEGABYTDataSet.Manufacturer);
            infoGoodsTableAdapter.Fill(MEGABYTDataSet.InfoGoods);
            goodsTableAdapter.Fill(MEGABYTDataSet.Goods);
        }

        private void goodsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedGoodsRow = goodsDataGridView.CurrentCell.RowIndex;
        }
    }
}
