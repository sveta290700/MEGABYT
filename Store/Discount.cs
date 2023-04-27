using System;
using System.Windows.Forms;

namespace Store
{
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
        }

        private void discountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            discountBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void Discount_Load(object sender, EventArgs e)
        {
            discountTableAdapter.Fill(MEGABYTDataSet.Discount);
        }
    }
}
