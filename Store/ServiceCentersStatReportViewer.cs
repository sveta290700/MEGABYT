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
    public partial class ServiceCentersStatReportViewer : Form
    {
        public ServiceCentersStatReportViewer()
        {
            InitializeComponent();
        }

        private void ServiceCentersStatReportViewer_Load(object sender, EventArgs e)
        {
            this.MEGABYTDataSet.EnforceConstraints = false;
            MEGABYTDataSetTableAdapters.service_centers_statTableAdapter scsTA = new MEGABYTDataSetTableAdapters.service_centers_statTableAdapter();
            scsTA.Fill(this.MEGABYTDataSet.service_centers_stat);
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
