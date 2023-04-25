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
            this.MEGABYTDataSet.EnforceConstraints = false;
            MEGABYTDataSetTableAdapters.popular_goodsTableAdapter pgTA = new MEGABYTDataSetTableAdapters.popular_goodsTableAdapter();
            pgTA.Fill(this.MEGABYTDataSet.popular_goods);
            PageSettings pg = new PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.A4;
            pg.PaperSize = size;
            reportViewer1.SetPageSettings(pg);
            this.reportViewer1.RefreshReport();
        }
    }
}
