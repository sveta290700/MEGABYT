using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Store
{
    public partial class FinancialReportReportViewer : Form
    {
        DateTime date1;
        DateTime date2;

        public FinancialReportReportViewer(string date1, string date2)
        {
            InitializeComponent();
            this.date1 = DateTime.Parse(date1);
            this.date2 = DateTime.Parse(date2);
        }

        private void FinancialReportReportViewer_Load(object sender, EventArgs e)
        {
            MEGABYTDataSet.EnforceConstraints = false;
            MEGABYTDataSetTableAdapters.financial_reportTableAdapter frTA = new MEGABYTDataSetTableAdapters.financial_reportTableAdapter();
            frTA.Fill(MEGABYTDataSet.financial_report, date1, date2);
            PageSettings pg = new PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            PaperSize size = new PaperSize
            {
                RawKind = (int)PaperKind.A4
            };
            pg.PaperSize = size;
            reportViewer1.SetPageSettings(pg);
            ReportParameter rp1 = new ReportParameter("date1", date1.ToString());
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1 });
            ReportParameter rp2 = new ReportParameter("date2", date2.ToString());
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp2 });
            reportViewer1.RefreshReport();
        }
    }
}
