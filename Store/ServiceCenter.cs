using System;
using System.Windows.Forms;

namespace Store
{
    public partial class ServiceCenter : Form
    {
        public ServiceCenter()
        {
            InitializeComponent();
        }

        private void serviceCenterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            serviceCenterBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void ServiceCenter_Load(object sender, EventArgs e)
        {
            manufacturerTableAdapter.Fill(MEGABYTDataSet.Manufacturer);
            serviceCenterTableAdapter.Fill(MEGABYTDataSet.ServiceCenter);
        }
    }
}
