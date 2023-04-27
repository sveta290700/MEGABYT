using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Store
{
    public partial class KategoriesReportReportViewer : Form
    {
        DateTime date1;
        DateTime date2;

        public KategoriesReportReportViewer(string date1, string date2)
        {
            InitializeComponent();
            this.date1 = DateTime.Parse(date1);
            this.date2 = DateTime.Parse(date2);
        }

        private void KategoriesReportReportViewer_Load(object sender, EventArgs e)
        {
            this.MEGABYTDataSet.EnforceConstraints = false;
            MEGABYTDataSetTableAdapters.kategories_reportTableAdapter krTA = new MEGABYTDataSetTableAdapters.kategories_reportTableAdapter();
            krTA.Fill(this.MEGABYTDataSet.kategories_report, date1, date2);
            PageSettings pg = new PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.A4;
            pg.PaperSize = size;
            reportViewer1.SetPageSettings(pg);
            ReportParameter rp1 = new ReportParameter("date1", date1.ToString());
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1 });
            ReportParameter rp2 = new ReportParameter("date2", date2.ToString());
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp2 });
            this.reportViewer1.RefreshReport();
        }
    }
}
