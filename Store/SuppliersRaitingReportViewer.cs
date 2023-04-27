using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Store
{
    public partial class SuppliersRaitingReportViewer : Form
    {
        public SuppliersRaitingReportViewer()
        {
            InitializeComponent();
        }

        private void SuppliersRaitingReportViewer_Load(object sender, EventArgs e)
        {
            MEGABYTDataSet.EnforceConstraints = false;
            MEGABYTDataSetTableAdapters.suppliers_raitingTableAdapter srTA = new MEGABYTDataSetTableAdapters.suppliers_raitingTableAdapter();
            srTA.Fill(MEGABYTDataSet.suppliers_raiting);
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
            reportViewer1.RefreshReport();
        }
    }
}
