
namespace Store
{
    partial class PopularGoodsReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopularGoodsReportViewer));
            this.MEGABYTDataSet = new Store.MEGABYTDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.popular_goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popular_goodsTableAdapter = new Store.MEGABYTDataSetTableAdapters.popular_goodsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular_goodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MEGABYTDataSet
            // 
            this.MEGABYTDataSet.DataSetName = "MEGABYTDataSet";
            this.MEGABYTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PopularGoodsDataSet";
            reportDataSource1.Value = this.popular_goodsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Store.PopularGoods.rdlc";
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
            // popular_goodsBindingSource
            // 
            this.popular_goodsBindingSource.DataMember = "popular_goods";
            this.popular_goodsBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // popular_goodsTableAdapter
            // 
            this.popular_goodsTableAdapter.ClearBeforeFill = true;
            // 
            // PopularGoodsReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 595);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopularGoodsReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр списка популярных товаров";
            this.Load += new System.EventHandler(this.PopularGoodsReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular_goodsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MEGABYTDataSet MEGABYTDataSet;
        private System.Windows.Forms.BindingSource popular_goodsBindingSource;
        private MEGABYTDataSetTableAdapters.popular_goodsTableAdapter popular_goodsTableAdapter;
    }
}