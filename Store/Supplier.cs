using System;
using System.Windows.Forms;

namespace Store
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            supplierBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            supplierTableAdapter.Fill(MEGABYTDataSet.Supplier);
        }
    }
}
