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
    public partial class Supply : Form
    {
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
    }
}
