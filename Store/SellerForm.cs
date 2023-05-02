using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Discount f = new Discount();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CardClients f = new CardClients();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WarrantyService f = new WarrantyService();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceCenter f = new ServiceCenter();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sale f = new Sale();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FinancialReportReportViewer f = new FinancialReportReportViewer(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KategoriesReportReportViewer f = new KategoriesReportReportViewer(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PopularGoodsReportViewer f = new PopularGoodsReportViewer();
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ServiceCentersStatReportViewer f = new ServiceCentersStatReportViewer();
            f.ShowDialog();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(-62);
            dateTimePicker2.Value = DateTime.Today;
        }
    }
}
