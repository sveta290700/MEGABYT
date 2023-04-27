using System;
using System.Windows.Forms;

namespace Store
{
    public partial class Manufacturer : Form
    {
        public Manufacturer()
        {
            InitializeComponent();
        }

        private void manufacturerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            manufacturerBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void Manufacturer_Load(object sender, EventArgs e)
        {
            manufacturerTableAdapter.Fill(MEGABYTDataSet.Manufacturer);
        }
    }
}
