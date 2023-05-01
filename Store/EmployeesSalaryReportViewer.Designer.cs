
namespace Store
{
    partial class EmployeesSalaryReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesSalaryReportViewer));
            this.employees_salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MEGABYTDataSet = new Store.MEGABYTDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.employees_salaryTableAdapter = new Store.MEGABYTDataSetTableAdapters.employees_salaryTableAdapter();
            this.employeessalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employees_salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeessalaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employees_salaryBindingSource
            // 
            this.employees_salaryBindingSource.DataMember = "employees_salary";
            this.employees_salaryBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // MEGABYTDataSet
            // 
            this.MEGABYTDataSet.DataSetName = "MEGABYTDataSet";
            this.MEGABYTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "EmployeesSalaryDataSet";
            reportDataSource1.Value = this.employees_salaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Store.EmployeesSalary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(1230, 575);
            this.reportViewer1.TabIndex = 0;
            // 
            // employees_salaryTableAdapter
            // 
            this.employees_salaryTableAdapter.ClearBeforeFill = true;
            // 
            // employeessalaryBindingSource
            // 
            this.employeessalaryBindingSource.DataMember = "employees_salary";
            this.employeessalaryBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // EmployeesSalaryReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 595);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeesSalaryReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр отчета о заработной плате сотрудников";
            this.Load += new System.EventHandler(this.EmployeesSalaryReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employees_salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeessalaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MEGABYTDataSet MEGABYTDataSet;
        private System.Windows.Forms.BindingSource employees_salaryBindingSource;
        private MEGABYTDataSetTableAdapters.employees_salaryTableAdapter employees_salaryTableAdapter;
        private System.Windows.Forms.BindingSource employeessalaryBindingSource;
    }
}