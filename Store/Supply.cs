using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Store
{
    public partial class Supply : Form
    {
        int selectedSupplyRow = 0;

        public Supply()
        {
            InitializeComponent();
        }

        private void supplyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            supplyBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void Supply_Load(object sender, EventArgs e)
        {
            goodsTableAdapter.Fill(MEGABYTDataSet.Goods);
            supplierTableAdapter.Fill(MEGABYTDataSet.Supplier);
            employeeTableAdapter.Fill(MEGABYTDataSet.Employee);
            scopeDeliveryTableAdapter.Fill(MEGABYTDataSet.ScopeDelivery);
            supplyTableAdapter.Fill(MEGABYTDataSet.Supply);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int selectedSupplyID = (int)supplyDataGridView.Rows[selectedSupplyRow].Cells[0].Value;
            SqlConnection myConnection;
            myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("Empty", myConnection);
            cmd1.CommandText = "DELETE FROM dbo.ScopeDelivery WHERE IDSupply=" + selectedSupplyID;
            SqlCommand cmd2 = new SqlCommand("Empty", myConnection);
            cmd2.CommandText = "DELETE FROM dbo.Supply WHERE IDSupply=" + selectedSupplyID;
            myConnection.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            myConnection.Close();
            goodsTableAdapter.Fill(MEGABYTDataSet.Goods);
            supplierTableAdapter.Fill(MEGABYTDataSet.Supplier);
            employeeTableAdapter.Fill(MEGABYTDataSet.Employee);
            scopeDeliveryTableAdapter.Fill(MEGABYTDataSet.ScopeDelivery);
            supplyTableAdapter.Fill(MEGABYTDataSet.Supply);
        }

        private void supplyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedSupplyRow = supplyDataGridView.CurrentCell.RowIndex;
        }
    }
}
