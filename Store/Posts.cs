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
    public partial class Posts : Form
    {
        public Posts()
        {
            InitializeComponent();
        }

        private void postsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.MEGABYTDataSet);
        }

        private void Posts_Load(object sender, EventArgs e)
        {
            this.postsTableAdapter.Fill(this.MEGABYTDataSet.Posts);
        }
    }
}
