using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Store
{
    public partial class PopularGoodsReportViewer : Form
    {
        public PopularGoodsReportViewer()
        {
            InitializeComponent();
        }

        private void PopularGoodsReportViewer_Load(object sender, EventArgs e)
        {
            MEGABYTDataSet.EnforceConstraints = false;
            MEGABYTDataSetTableAdapters.popular_goodsTableAdapter pgTA = new MEGABYTDataSetTableAdapters.popular_goodsTableAdapter();
            pgTA.Fill(MEGABYTDataSet.popular_goods);
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
