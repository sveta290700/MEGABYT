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
    public partial class ServiceCenter : Form
    {
        public ServiceCenter()
        {
            InitializeComponent();
        }

        private void serviceCenterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceCenterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.MEGABYTDataSet);
        }

        private void ServiceCenter_Load(object sender, EventArgs e)
        {
            this.manufacturerTableAdapter.Fill(this.MEGABYTDataSet.Manufacturer);
            this.serviceCenterTableAdapter.Fill(this.MEGABYTDataSet.ServiceCenter);
        }
    }
}
