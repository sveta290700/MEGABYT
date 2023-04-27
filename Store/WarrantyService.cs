using System;
using System.Configuration;
using System.Data.SqlClient;
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
            Validate();
            warrantyServiceBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void WarrantyService_Load(object sender, EventArgs e)
        {
            transferRepairTableAdapter.Fill(MEGABYTDataSet.TransferRepair);
            serviceCenterTableAdapter.Fill(MEGABYTDataSet.ServiceCenter);
            receiptTableAdapter.Fill(MEGABYTDataSet.Receipt);
            transferRepairTableAdapter.Fill(MEGABYTDataSet.TransferRepair);
            warrantyServiceTableAdapter.Fill(MEGABYTDataSet.WarrantyService);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int selectedWarrantyServiceID = (int)warrantyServiceDataGridView.Rows[selectedWarrantyServiceRow].Cells[0].Value;
            SqlConnection myConnection;
            myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("Empty", myConnection);
            cmd1.CommandText = "DELETE FROM dbo.TransferRepair WHERE IDWarrantyService=" + selectedWarrantyServiceID;
            SqlCommand cmd2 = new SqlCommand("Empty", myConnection);
            cmd2.CommandText = "DELETE FROM dbo.WarrantyService WHERE IDWarrantyService=" + selectedWarrantyServiceID;
            myConnection.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            myConnection.Close();
            transferRepairTableAdapter.Fill(MEGABYTDataSet.TransferRepair);
            serviceCenterTableAdapter.Fill(MEGABYTDataSet.ServiceCenter);
            receiptTableAdapter.Fill(MEGABYTDataSet.Receipt);
            transferRepairTableAdapter.Fill(MEGABYTDataSet.TransferRepair);
            warrantyServiceTableAdapter.Fill(MEGABYTDataSet.WarrantyService);
        }

        private void warrantyServiceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedWarrantyServiceRow = warrantyServiceDataGridView.CurrentCell.RowIndex;
        }
    }
}