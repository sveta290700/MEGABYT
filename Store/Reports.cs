using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace Store
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Diag f = new Diag(this);
            f.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopularGoodsReportViewer f = new PopularGoodsReportViewer();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuppliersRaitingReportViewer f = new SuppliersRaitingReportViewer();
            f.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ServiceCentersStatReportViewer f = new ServiceCentersStatReportViewer();
            f.ShowDialog();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(-30);
            dateTimePicker2.Value = DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeesSalaryReportViewer f = new EmployeesSalaryReportViewer(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinancialReportReportViewer f = new FinancialReportReportViewer(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            f.ShowDialog();
        }
    }
}
