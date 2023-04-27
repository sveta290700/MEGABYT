
namespace Store
{
    partial class KategoriesReportReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriesReportReportViewer));
            this.kategories_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MEGABYTDataSet = new Store.MEGABYTDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kategories_reportTableAdapter = new Store.MEGABYTDataSetTableAdapters.kategories_reportTableAdapter();
            this.kategoriesreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kategories_reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriesreportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kategories_reportBindingSource
            // 
            this.kategories_reportBindingSource.DataMember = "kategories_report";
            this.kategories_reportBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // MEGABYTDataSet
            // 
            this.MEGABYTDataSet.DataSetName = "MEGABYTDataSet";
            this.MEGABYTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "KategoriesReportDataSet";
            reportDataSource1.Value = this.kategories_reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Store.KategoriesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(1230, 575);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // kategories_reportTableAdapter
            // 
            this.kategories_reportTableAdapter.ClearBeforeFill = true;
            // 
            // kategoriesreportBindingSource
            // 
            this.kategoriesreportBindingSource.DataMember = "kategories_report";
            this.kategoriesreportBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // KategoriesReportReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 595);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KategoriesReportReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр диаграммы потребления товаров (в разрезе категорий)";
            this.Load += new System.EventHandler(this.KategoriesReportReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategories_reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriesreportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MEGABYTDataSet MEGABYTDataSet;
        private System.Windows.Forms.BindingSource kategories_reportBindingSource;
        private MEGABYTDataSetTableAdapters.kategories_reportTableAdapter kategories_reportTableAdapter;
        private System.Windows.Forms.BindingSource kategoriesreportBindingSource;
    }
}