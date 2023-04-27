using System;
using System.Windows.Forms;

namespace Store
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            employeeBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            postsTableAdapter.Fill(MEGABYTDataSet.Posts);
            employeeTableAdapter.Fill(MEGABYTDataSet.Employee);
        }
    }
}
