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
    public partial class SellerForm : Form
    {
        public SellerForm(string login)
        {
            InitializeComponent();
            label1.Text = label1.Text + login + "!";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void категорияТовароыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoryGoods f = new KategoryGoods();
            f.ShowDialog();
        }

        private void дисконтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Discount f = new Discount();
            f.ShowDialog();
        }

        private void картыКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardClients f = new CardClients();
            f.ShowDialog();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posts f = new Posts();
            f.ShowDialog();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee f = new Employee();
            f.ShowDialog();
        }

        private void производителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manufacturer f = new Manufacturer();
            f.ShowDialog();
        }

        private void сервисныеЦентрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceCenter f = new ServiceCenter();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Goods f = new Goods();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supply f = new Supply();
            f.ShowDialog();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier f = new Supplier();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sale f = new Sale();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WarrantyService f = new WarrantyService();
            f.ShowDialog();
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports f = new Reports();
            f.ShowDialog();
        }
    }
}
