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
    public partial class CardClients : Form
    {
        public CardClients()
        {
            InitializeComponent();
        }

        private void clientCardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientCardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.MEGABYTDataSet);

        }

        private void CardClients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.Discount". При необходимости она может быть перемещена или удалена.
            this.discountTableAdapter.Fill(this.MEGABYTDataSet.Discount);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.ClientCard". При необходимости она может быть перемещена или удалена.
            this.clientCardTableAdapter.Fill(this.MEGABYTDataSet.ClientCard);

        }
    }
}
