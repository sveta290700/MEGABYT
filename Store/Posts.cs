using System;
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
            Validate();
            postsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void Posts_Load(object sender, EventArgs e)
        {
            postsTableAdapter.Fill(MEGABYTDataSet.Posts);
        }
    }
}
