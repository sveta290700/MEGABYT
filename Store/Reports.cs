using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Diag f = new Diag(this);
            f.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT kg.NameKategory as Категория, g.ModelGood as Модель, COUNT(r.IDReceipt) as Количество"
                +" FROM dbo.KategoryGoods kg INNER JOIN goods g ON g.IDKategoryGoods = kg.IDKategoryGoods"
                +" INNER JOIN dbo.Receipt r ON r.IDGood = g.IDGood"
                +" INNER JOIN dbo.Sale s ON s.IDSale = r.IDSale"
                +" GROUP BY kg.NameKategory, ModelGood"
                +" ORDER BY COUNT(r.IDReceipt) DESC", conn);
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            // создаем пустую книгу и объявляем переменные
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            foreach (DataColumn col in dt.Columns)
            {
                xlWorkSheet.Cells[1, dt.Columns.IndexOf(col) + 1] = col.ColumnName.ToString();
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    xlWorkSheet.Cells[dt.Rows.IndexOf(row) + 2, dt.Columns.IndexOf(col) + 1] = row[dt.Columns.IndexOf(col)];
                }
            }

            xlWorkSheet.Columns["A:G"].Hidden = true;

            //автовыравнивание колонок
            xlWorkSheet.Columns["A:G"].AutoFit();

            //границы таблицы
            Excel.Range xlWorkSheet_rng = xlWorkSheet.get_Range("A1", "C" + (dt.Rows.Count + 1).ToString());
            xlWorkSheet_rng.Borders.ColorIndex = 0;
            xlWorkSheet_rng.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlWorkSheet_rng.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //сделать первую строку жирной
            xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT s.NameSupplier as Поставщик, Count(su.IDSupply) as 'Количество поставок', SUM(CountSupply*PriceSupply) as 'На сумму'"
                +" FROM Supplier s INNER JOIN Supply su ON s.IDSupplier = su.IDSupplier"
                +" INNER JOIN dbo.ScopeDelivery sc ON sc.IDSupply = su.IDSupply"
                +" GROUP BY s.NameSupplier"
                +" ORDER BY SUM(CountSupply * PriceSupply) DESC, Count(su.IDSupply) DESC", conn);
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            // создаем пустую книгу и объявляем переменные
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            foreach (DataColumn col in dt.Columns)
            {
                xlWorkSheet.Cells[1, dt.Columns.IndexOf(col) + 1] = col.ColumnName.ToString();
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    xlWorkSheet.Cells[dt.Rows.IndexOf(row) + 2, dt.Columns.IndexOf(col) + 1] = row[dt.Columns.IndexOf(col)];
                }
            }

            xlWorkSheet.Columns["A:G"].Hidden = true;

            //автовыравнивание колонок
            xlWorkSheet.Columns["A:G"].AutoFit();

            //границы таблицы
            Excel.Range xlWorkSheet_rng = xlWorkSheet.get_Range("A1", "C" + (dt.Rows.Count + 1).ToString());
            xlWorkSheet_rng.Borders.ColorIndex = 0;
            xlWorkSheet_rng.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlWorkSheet_rng.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //сделать первую строку жирной
            xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT Производитель,Адрес, [Зарегистрировано], [В работе], [Ремонт выполнен], [Ремонт невозможен], [Отмена]"
                +" FROM("
                +" SELECT m.NameManufacturer as Производитель, sc.AddressCenter as Адрес, tr.Status as Статус, COUNT(IDTransferRepair) as cnt"
                +" FROM dbo.ServiceCenter sc INNER JOIN dbo.TransferRepair tr ON tr.IDServiceCenter = sc.IDServiceCenter"
                +" INNER JOIN dbo.Manufacturer m ON m.IDManufacturer = sc.IDManufacturer"
                +" INNER JOIN dbo.WarrantyService ws ON ws.IDWarrantyService = tr.IDWarrantyService"
                +" GROUP BY m.NameManufacturer, sc.AddressCenter, tr.Status) t"
                +" PIVOT"
                +" ("
                +" COUNT(cnt)"
                +" FOR статус IN([Зарегистрировано], [В работе], [Ремонт выполнен], [Ремонт невозможен], [Отмена])"
                +" ) AS PivotTable; ", conn);
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            // создаем пустую книгу и объявляем переменные
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            foreach (DataColumn col in dt.Columns)
            {
                xlWorkSheet.Cells[1, dt.Columns.IndexOf(col) + 1] = col.ColumnName.ToString();
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    xlWorkSheet.Cells[dt.Rows.IndexOf(row) + 2, dt.Columns.IndexOf(col) + 1] = row[dt.Columns.IndexOf(col)];
                }
            }

            xlWorkSheet.Columns["A:G"].Hidden = true;

            //автовыравнивание колонок
            xlWorkSheet.Columns["A:G"].AutoFit();

            //границы таблицы
            Excel.Range xlWorkSheet_rng = xlWorkSheet.get_Range("A1", "G" + (dt.Rows.Count + 1).ToString());
            xlWorkSheet_rng.Borders.ColorIndex = 0;
            xlWorkSheet_rng.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlWorkSheet_rng.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //сделать первую строку жирной
            xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(-15);
            dateTimePicker2.Value = DateTime.Today.AddDays(15);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT e.SName+' '+FName+' '+Patronym as ФИО, SUM(PriceGoodDiscount*CountGood) as 'Сумма продаж',"
                +" p.SalaryPost as 'Ставка', PercentSale as 'Процент от продаж', SUM(PriceGoodDiscount * CountGood) * PercentSale / 100 as 'Доплата',"
                +" SUM(PriceGoodDiscount * CountGood) * PercentSale / 100 + p.SalaryPost as 'К выдаче'"
                +" FROM Employee e INNER JOIN dbo.Sale s ON e.IDEmployee = s.IDEmployee"
                +" INNER JOIN dbo.Receipt r ON r.IDSale = s.IDSale"
                +" INNER JOIN dbo.Posts p ON p.IDpost = e.IDpost"
                + " WHERE s.DateSale between '" + dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "'"
                + " GROUP BY  e.SName + ' ' + FName + ' ' + Patronym, p.SalaryPost, PercentSale", conn);
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            // создаем пустую книгу и объявляем переменные
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            foreach (DataColumn col in dt.Columns)
            {
                xlWorkSheet.Cells[1, dt.Columns.IndexOf(col) + 1] = col.ColumnName.ToString();
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    xlWorkSheet.Cells[dt.Rows.IndexOf(row) + 2, dt.Columns.IndexOf(col) + 1] = row[dt.Columns.IndexOf(col)];
                }
            }

            xlWorkSheet.Columns["A:G"].Hidden = true;

            //автовыравнивание колонок
            xlWorkSheet.Columns["A:G"].AutoFit();

            //границы таблицы
            Excel.Range xlWorkSheet_rng = xlWorkSheet.get_Range("A1", "G" + (dt.Rows.Count + 1).ToString());
            xlWorkSheet_rng.Borders.ColorIndex = 0;
            xlWorkSheet_rng.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlWorkSheet_rng.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //сделать первую строку жирной
            xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT *,[Сумма продаж] - [Сумма поставок] as Дельта"
                +" FROM("
                +" SELECT cast(DateSale as date) as Дата, coalesce(SUM(CountGood * PriceGoodDiscount), 0) as 'Сумма продаж'"
                +" , coalesce((SELECT SUM(CountSupply * PriceSupply) FROM Supply s INNER JOIN dbo.ScopeDelivery sc ON sc.IDSupply = s.IDSupply WHERE cast(DateSupply as date) = cast(DateSale as date)), 0) as 'Сумма поставок'"
                +" FROM dbo.Sale s INNER JOIN dbo.Receipt r ON r.IDSale = s.IDSale"
                + " WHERE s.DateSale between '" + dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "'"
                + " GROUP BY cast(DateSale as date)) t", conn);
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            // создаем пустую книгу и объявляем переменные
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            foreach (DataColumn col in dt.Columns)
            {
                xlWorkSheet.Cells[1, dt.Columns.IndexOf(col) + 1] = col.ColumnName.ToString();
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    xlWorkSheet.Cells[dt.Rows.IndexOf(row) + 2, dt.Columns.IndexOf(col) + 1] = row[dt.Columns.IndexOf(col)];
                }
            }

            xlWorkSheet.Columns["A:G"].Hidden = true;

            //автовыравнивание колонок
            xlWorkSheet.Columns["A:G"].AutoFit();

            //границы таблицы
            Excel.Range xlWorkSheet_rng = xlWorkSheet.get_Range("A1", "G" + (dt.Rows.Count + 1).ToString());
            xlWorkSheet_rng.Borders.ColorIndex = 0;
            xlWorkSheet_rng.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlWorkSheet_rng.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //сделать первую строку жирной
            xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;
        }
    }
}
