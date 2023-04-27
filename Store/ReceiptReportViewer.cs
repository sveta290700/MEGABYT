using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Store
{
    public partial class ReceiptReportViewer : Form
    {
        int SaleID;
        public ReceiptReportViewer(int SaleID)
        {
            InitializeComponent();
            this.SaleID = SaleID;
        }

        private void ReceiptReportViewer_Load(object sender, EventArgs e)
        {
            MEGABYTDataSet.EnforceConstraints = false;
            MEGABYTDataSetTableAdapters.packing_listTableAdapter plTA = new MEGABYTDataSetTableAdapters.packing_listTableAdapter();
            plTA.Fill(MEGABYTDataSet.packing_list, SaleID);
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
