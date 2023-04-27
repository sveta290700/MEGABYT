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

namespace Store
{
    public partial class Sale : Form
    {
        int selectedSaleRow = 0;

        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.MEGABYTDataSet.Employee);
            this.clientCardTableAdapter.Fill(this.MEGABYTDataSet.ClientCard);
            this.catalog_salesTableAdapter.Fill(this.MEGABYTDataSet.catalog_sales);
            this.catalog_salesTableAdapter.Fill(this.MEGABYTDataSet.catalog_sales);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewCell cur_cell = catalogDataGridView.CurrentCell;
            if (cur_cell != null)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedSaleRow = catalogDataGridView.CurrentCell.RowIndex;
                    int selectedSaleID = (int)catalogDataGridView.Rows[selectedSaleRow].Cells[0].Value;
                    SqlConnection myConnection;
                    myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString);
                    SqlCommand cmd1 = new SqlCommand("Empty", myConnection);
                    cmd1.CommandText = "DELETE FROM dbo.Receipt WHERE IDSale=" + selectedSaleID;
                    SqlCommand cmd2 = new SqlCommand("Empty", myConnection);
                    cmd2.CommandText = "DELETE FROM dbo.Sale WHERE IDSale=@IDSale;";
                    cmd2.Parameters.AddWithValue("IDSale", catalogDataGridView.Rows[catalogDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    myConnection.Open();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();
                    myConnection.Close();

                    this.catalog_salesTableAdapter.Fill(this.MEGABYTDataSet.catalog_sales);
                }
            }
            else
                MessageBox.Show(
                    "Не была выбрана продажа к удалению",
                    "Ошибка",
                    MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (catalogDataGridView.Rows.Count > 0)
            {
                EditSales form = new EditSales(catalogDataGridView.Rows[catalogDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                form.ShowDialog();

                this.catalog_salesTableAdapter.Fill(this.MEGABYTDataSet.catalog_sales);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditSales f = new EditSales("0");
            f.ShowDialog();
            this.catalog_salesTableAdapter.Fill(this.MEGABYTDataSet.catalog_sales);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            catalog_salesBindingSource.Filter = "";
            dateTimePicker1.Checked = false; dateTimePicker2.Checked = false; comboBox2.SelectedIndex = -1; comboBox3.SelectedIndex = -1;
            textBox1.Clear(); textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string flt = "";

            if (dateTimePicker1.Checked == true)
            {
                if (flt.Length > 0) { flt += " and "; }
                flt += " Дата >= '" + dateTimePicker1.Value.ToString() + "'";
            }

            if (dateTimePicker2.Checked == true)
            {
                if (flt.Length > 0) { flt += " and "; }
                flt += " Дата <= '" + dateTimePicker2.Value.ToString() + "'";
            }

            if (comboBox2.Text.Length > 0)
            {
                if (flt.Length > 0) { flt += " and "; }
                flt += " [Клиент] = '" + comboBox2.Text.ToString() + "'";
            }

            if (comboBox3.Text.Length > 0)
            {
                if (flt.Length > 0) { flt += " and "; }
                flt += " [Сотрудник] = '" + comboBox3.Text.ToString() + "'";
            }

            if (textBox4.Text.Length > 0)
            {
                if (flt.Length > 0) { flt += " and "; }
                flt += " [Сумма] >=" + textBox4.Text.ToString();
            }

            if (textBox1.Text.Length > 0)
            {
                if (flt.Length > 0) { flt += " and "; }
                flt += " [Сумма] <=" + textBox1.Text.ToString();
            }

            catalog_salesBindingSource.Filter = flt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int selectedSaleID = (int)catalogDataGridView.Rows[selectedSaleRow].Cells[0].Value;
            PackingListReportViewer f = new PackingListReportViewer(selectedSaleID);
            f.ShowDialog();
        }

        private void catalogDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedSaleRow = catalogDataGridView.CurrentCell.RowIndex;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int selectedSaleID = (int)catalogDataGridView.Rows[selectedSaleRow].Cells[0].Value;
            ReceiptReportViewer f = new ReceiptReportViewer(selectedSaleID);
            f.ShowDialog();
        }
    }
}
