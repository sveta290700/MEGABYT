
namespace Store
{
    partial class SuppliersRaitingReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersRaitingReportViewer));
            this.suppliers_raitingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MEGABYTDataSet = new Store.MEGABYTDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.suppliers_raitingTableAdapter = new Store.MEGABYTDataSetTableAdapters.suppliers_raitingTableAdapter();
            this.suppliersraitingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_raitingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersraitingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliers_raitingBindingSource
            // 
            this.suppliers_raitingBindingSource.DataMember = "suppliers_raiting";
            this.suppliers_raitingBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // MEGABYTDataSet
            // 
            this.MEGABYTDataSet.DataSetName = "MEGABYTDataSet";
            this.MEGABYTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "SuppliersRaitingDataSet";
            reportDataSource1.Value = this.suppliers_raitingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Store.SuppliersRaiting.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(1230, 575);
            this.reportViewer1.TabIndex = 0;
            // 
            // suppliers_raitingTableAdapter
            // 
            this.suppliers_raitingTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersraitingBindingSource
            // 
            this.suppliersraitingBindingSource.DataMember = "suppliers_raiting";
            this.suppliersraitingBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // SuppliersRaitingReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 595);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuppliersRaitingReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр рейтинга поставщиков";
            this.Load += new System.EventHandler(this.SuppliersRaitingReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_raitingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersraitingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MEGABYTDataSet MEGABYTDataSet;
        private System.Windows.Forms.BindingSource suppliers_raitingBindingSource;
        private MEGABYTDataSetTableAdapters.suppliers_raitingTableAdapter suppliers_raitingTableAdapter;
        private System.Windows.Forms.BindingSource suppliersraitingBindingSource;
    }
}