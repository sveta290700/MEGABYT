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
    public partial class Supply : Form
    {
        int selectedSupplyRow = 0;
        public Supply()
        {
            InitializeComponent();
        }

        private void supplyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.MEGABYTDataSet);
        }

        private void Supply_Load(object sender, EventArgs e)
        {
            this.goodsTableAdapter.Fill(this.MEGABYTDataSet.Goods);
            this.supplierTableAdapter.Fill(this.MEGABYTDataSet.Supplier);
            this.employeeTableAdapter.Fill(this.MEGABYTDataSet.Employee);
            this.scopeDeliveryTableAdapter.Fill(this.MEGABYTDataSet.ScopeDelivery);
            this.supplyTableAdapter.Fill(this.MEGABYTDataSet.Supply);
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
            this.goodsTableAdapter.Fill(this.MEGABYTDataSet.Goods);
            this.supplierTableAdapter.Fill(this.MEGABYTDataSet.Supplier);
            this.employeeTableAdapter.Fill(this.MEGABYTDataSet.Employee);
            this.scopeDeliveryTableAdapter.Fill(this.MEGABYTDataSet.ScopeDelivery);
            this.supplyTableAdapter.Fill(this.MEGABYTDataSet.Supply);
        }

        private void supplyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedSupplyRow = supplyDataGridView.CurrentCell.RowIndex;
        }
    }
}
