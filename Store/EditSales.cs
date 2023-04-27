using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Store
{
    public partial class EditSales : Form
    {
        string ID;
        bool firstFlag = false;

        public EditSales(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void EditSales_Load(object sender, EventArgs e)
        {
            goodsTableAdapter.Fill(MEGABYTDataSet.Goods);
            receiptTableAdapter.Fill(MEGABYTDataSet.Receipt);
            receiptTableAdapter.Fill(MEGABYTDataSet.Receipt);
            employeeTableAdapter.Fill(MEGABYTDataSet.Employee);
            saleTableAdapter.Fill(MEGABYTDataSet.Sale);
            clientCardTableAdapter.Fill(MEGABYTDataSet.ClientCard);
            if (ID == "0")
            {
                SqlConnection myConnection;
                myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString);
                myConnection.Open();
                string sql = "SELECT IDENT_CURRENT('dbo.Sale')+1";
                SqlCommand cmd = new SqlCommand(sql, myConnection);
                ID = cmd.ExecuteScalar().ToString();
                if (ID == "")
                {
                    ID = "1";
                    firstFlag = true;
                }
                myConnection.Close();
                saleBindingSource.AddNew();
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                saleBindingSource.Filter = "IDSale=" + ID;
            }
            receiptBindingSource.Filter = "IDSale= " + ID;
            if (!firstFlag)
                calcsum();
            else
                textBox1.Text = "0";
        }

        private void calcsum()
        {
            decimal sum = 0;
            for (int i = 0; i < receiptDataGridView.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(receiptDataGridView.Rows[i].Cells[6].Value);
            }
            textBox1.Text = sum.ToString();
        }

        private void receiptDataGridView_Enter(object sender, EventArgs e)
        {
            if (comboBox2.Text.Length == 0) { MessageBox.Show("Укажите клиента"); comboBox2.Focus(); return; }
            if (comboBox1.Text.Length == 0) { MessageBox.Show("Укажите сотрудника"); comboBox1.Focus(); return; }
            saleTableAdapter.Update(MEGABYTDataSet.Sale);
        }

        private void receiptDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dataGridViewTextBoxColumn3"].Value = ID;
            e.Row.Cells["dataGridViewTextBoxColumn4"].Value = 1;
            e.Row.Cells["dataGridViewTextBoxColumn5"].Value = 0;
            e.Row.Cells["dataGridViewTextBoxColumn6"].Value = 0;
        }

        private void EditSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Validate();
            try
            {
                saleBindingSource.EndEdit();
                saleBindingSource.EndEdit();
                saleTableAdapter.Update(MEGABYTDataSet.Sale);

                Validate();
                receiptBindingSource.EndEdit();
                receiptTableAdapter.Update(MEGABYTDataSet.Receipt);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Попытка добавления некорректных данных", 
                    "Ошибка", 
                    MessageBoxButtons.OK);
            }
        }

        private void receiptDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex < 0) || (e.RowIndex < 0)) { return; }
            DataGridViewCell MyCell = receiptDataGridView[e.ColumnIndex, e.RowIndex];
            if (MyCell == null)
            {
                return;
            }
            if (MyCell.Value == null)
            {
                return;
            }
            DataTable tres = new DataTable();
            float price = 0;
            float discount = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("SELECT PriceGood FROM dbo.Goods WHERE IDGoods=" + receiptDataGridView.Rows[receiptDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString(), conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "result_name");
                    tres = ds.Tables["result_name"];
                    foreach (DataRow row in tres.Rows)
                    {
                        price = float.Parse(row["PriceGood"].ToString());
                    }
                }
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("SELECT PercentDiscount FROM dbo.Discount AS Discount INNER JOIN dbo.ClientCard AS ClientCard ON ClientCard.IDDiscount = Discount.IDDiscount WHERE ClientCard.IDClientCard=" + comboBox2.SelectedValue.ToString(), conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "result_name");
                    tres = ds.Tables["result_name"];
                    foreach (DataRow row in tres.Rows)
                    {
                        discount = float.Parse(row["PercentDiscount"].ToString());
                    }
                }
            }
            var grid = sender as DataGridView;
            if (e.RowIndex != -1 && ((e.ColumnIndex == 1) || (e.ColumnIndex == 3)))
            {
                grid.Rows[e.RowIndex].Cells[4].Value = price;
                grid.Rows[e.RowIndex].Cells[5].Value = price - (price * discount / 100);
            }
            calcsum();
        }

        private void receiptDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            calcsum();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int selectedSaleID = int.Parse(ID);
            PackingListReportViewer f = new PackingListReportViewer(selectedSaleID);
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int selectedSaleID = int.Parse(ID);
            ReceiptReportViewer f = new ReceiptReportViewer(selectedSaleID);
            f.ShowDialog();
        }
    }
}
