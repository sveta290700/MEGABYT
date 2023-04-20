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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.MEGABYTDataSet.Goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.MEGABYTDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.MEGABYTDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.ScopeDelivery". При необходимости она может быть перемещена или удалена.
            this.scopeDeliveryTableAdapter.Fill(this.MEGABYTDataSet.ScopeDelivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.Supply". При необходимости она может быть перемещена или удалена.
            this.supplyTableAdapter.Fill(this.MEGABYTDataSet.Supply);

        }
    }
}
