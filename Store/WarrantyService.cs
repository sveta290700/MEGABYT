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
    public partial class WarrantyService : Form
    {
        int selectedWarrantyServiceRow = 0;

        public WarrantyService()
        {
            InitializeComponent();
        }

        private void warrantyServiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warrantyServiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.MEGABYTDataSet);
        }

        private void WarrantyService_Load(object sender, EventArgs e)
        {
            this.transferRepairTableAdapter.Fill(this.MEGABYTDataSet.TransferRepair);
            this.serviceCenterTableAdapter.Fill(this.MEGABYTDataSet.ServiceCenter);
            this.receiptTableAdapter.Fill(this.MEGABYTDataSet.Receipt);
            this.transferRepairTableAdapter.Fill(this.MEGABYTDataSet.TransferRepair);
            this.warrantyServiceTableAdapter.Fill(this.MEGABYTDataSet.WarrantyService);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int selectedWarrantyServiceID = (int)warrantyServiceDataGridView.Rows[selectedWarrantyServiceRow].Cells[0].Value;
            SqlConnection myConnection;
            myConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("Empty", myConnection);
            cmd1.CommandText = "DELETE FROM dbo.TransferRepair WHERE IDWarrantyService=" + selectedWarrantyServiceID;
            SqlCommand cmd2 = new SqlCommand("Empty", myConnection);
            cmd2.CommandText = "DELETE FROM dbo.WarrantyService WHERE IDWarrantyService=" + selectedWarrantyServiceID;
            myConnection.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            myConnection.Close();
            this.transferRepairTableAdapter.Fill(this.MEGABYTDataSet.TransferRepair);
            this.serviceCenterTableAdapter.Fill(this.MEGABYTDataSet.ServiceCenter);
            this.receiptTableAdapter.Fill(this.MEGABYTDataSet.Receipt);
            this.transferRepairTableAdapter.Fill(this.MEGABYTDataSet.TransferRepair);
            this.warrantyServiceTableAdapter.Fill(this.MEGABYTDataSet.WarrantyService);
        }

        private void warrantyServiceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedWarrantyServiceRow = warrantyServiceDataGridView.CurrentCell.RowIndex;
        }
    }
}