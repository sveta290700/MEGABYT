using System;
using System.Windows.Forms;

namespace Store
{
    public partial class SupplyManagerForm : Form
    {
        public SupplyManagerForm(string login)
        {
            InitializeComponent();
            label1.Text = label1.Text + login + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier f = new Supplier();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Supply f = new Supply();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Goods f = new Goods();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manufacturer f = new Manufacturer();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KategoryGoods f = new KategoryGoods();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SuppliersRaitingReportViewer f = new SuppliersRaitingReportViewer();
            f.ShowDialog();
        }
    }
}
