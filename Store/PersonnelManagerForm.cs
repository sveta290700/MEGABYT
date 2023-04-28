using System;
using System.Windows.Forms;

namespace Store
{
    public partial class PersonnelManagerForm : Form
    {
        public PersonnelManagerForm(string login)
        {
            InitializeComponent();
            label1.Text = label1.Text + login + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Posts f = new Posts();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee f = new Employee();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeesSalaryReportViewer f = new EmployeesSalaryReportViewer(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeesSalesReportViewer f = new EmployeesSalesReportViewer(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            f.ShowDialog();
        }

        private void PersonalManagerForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(-31);
            dateTimePicker2.Value = DateTime.Today;
        }
    }
}
