using System;
using System.Drawing.Printing;
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
            MEGABYTDataSet.EnforceConstraints = false;
            MEGABYTDataSetTableAdapters.service_centers_statTableAdapter scsTA = new MEGABYTDataSetTableAdapters.service_centers_statTableAdapter();
            scsTA.Fill(MEGABYTDataSet.service_centers_stat);
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
