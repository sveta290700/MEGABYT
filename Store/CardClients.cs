using System;
using System.Windows.Forms;

namespace Store
{
    public partial class CardClients : Form
    {
        public CardClients()
        {
            InitializeComponent();
        }

        private void clientCardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            clientCardBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void CardClients_Load(object sender, EventArgs e)
        {
            discountTableAdapter.Fill(MEGABYTDataSet.Discount);
            clientCardTableAdapter.Fill(MEGABYTDataSet.ClientCard);
        }
    }
}
