using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class WarrantyService : Form
    {
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.TransferRepair". При необходимости она может быть перемещена или удалена.
            this.transferRepairTableAdapter.Fill(this.MEGABYTDataSet.TransferRepair);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.ServiceCenter". При необходимости она может быть перемещена или удалена.
            this.serviceCenterTableAdapter.Fill(this.MEGABYTDataSet.ServiceCenter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.Receipt". При необходимости она может быть перемещена или удалена.
            this.receiptTableAdapter.Fill(this.MEGABYTDataSet.Receipt);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.TransferRepair". При необходимости она может быть перемещена или удалена.
            this.transferRepairTableAdapter.Fill(this.MEGABYTDataSet.TransferRepair);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.WarrantyService". При необходимости она может быть перемещена или удалена.
            this.warrantyServiceTableAdapter.Fill(this.MEGABYTDataSet.WarrantyService);

        }
    }
}
