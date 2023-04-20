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
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.MEGABYTDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.ClientCard". При необходимости она может быть перемещена или удалена.
            this.clientCardTableAdapter.Fill(this.MEGABYTDataSet.ClientCard);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.catalog_sales". При необходимости она может быть перемещена или удалена.
            this.catalog_salesTableAdapter.Fill(this.MEGABYTDataSet.catalog_sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.catalog_sales". При необходимости она может быть перемещена или удалена.
            this.catalog_salesTableAdapter.Fill(this.MEGABYTDataSet.catalog_sales);

        }

        private void catalogDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewCell cur_cell = catalogDataGridView.CurrentCell;
            if (cur_cell != null)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection myConnection;
                    myConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString);
                    SqlCommand cmd = new SqlCommand("Empty", myConnection);

                    cmd.CommandText = "DELETE FROM sale WHERE IDSale = @IDSale;";
                    cmd.Parameters.AddWithValue("IDSale", catalogDataGridView.Rows[catalogDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
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
                //создание и открытие формы формы в режиме редактирования
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
    }
}
