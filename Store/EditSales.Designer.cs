namespace Store
{
    partial class EditSales
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label id_employeeLabel;
            System.Windows.Forms.Label id_clientLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSales));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MEGABYTDataSet = new Store.MEGABYTDataSet();
            this.clientCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receiptDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientCardTableAdapter = new Store.MEGABYTDataSetTableAdapters.ClientCardTableAdapter();
            this.saleTableAdapter = new Store.MEGABYTDataSetTableAdapters.SaleTableAdapter();
            this.employeeTableAdapter = new Store.MEGABYTDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new Store.MEGABYTDataSetTableAdapters.TableAdapterManager();
            this.receiptTableAdapter = new Store.MEGABYTDataSetTableAdapters.ReceiptTableAdapter();
            this.goodsTableAdapter = new Store.MEGABYTDataSetTableAdapters.GoodsTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            id_employeeLabel = new System.Windows.Forms.Label();
            id_clientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(647, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 13);
            label1.TabIndex = 20;
            label1.Text = "Итого";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(51, 76);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 15;
            dateLabel.Text = "Дата";
            // 
            // id_employeeLabel
            // 
            id_employeeLabel.AutoSize = true;
            id_employeeLabel.Location = new System.Drawing.Point(24, 47);
            id_employeeLabel.Name = "id_employeeLabel";
            id_employeeLabel.Size = new System.Drawing.Size(60, 13);
            id_employeeLabel.TabIndex = 14;
            id_employeeLabel.Text = "Сотрудник";
            // 
            // id_clientLabel
            // 
            id_clientLabel.AutoSize = true;
            id_clientLabel.Location = new System.Drawing.Point(41, 18);
            id_clientLabel.Name = "id_clientLabel";
            id_clientLabel.Size = new System.Drawing.Size(43, 13);
            id_clientLabel.TabIndex = 13;
            id_clientLabel.Text = "Клиент";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(610, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.saleBindingSource, "IDClientCard", true));
            this.comboBox2.DataSource = this.clientCardBindingSource;
            this.comboBox2.DisplayMember = "FullName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(273, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.TabStop = false;
            this.comboBox2.ValueMember = "IDClientCard";
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // MEGABYTDataSet
            // 
            this.MEGABYTDataSet.DataSetName = "MEGABYTDataSet";
            this.MEGABYTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientCardBindingSource
            // 
            this.clientCardBindingSource.DataMember = "ClientCard";
            this.clientCardBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.saleBindingSource, "IDEmployee", true));
            this.comboBox1.DataSource = this.employeeBindingSource;
            this.comboBox1.DisplayMember = "FullName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.TabStop = false;
            this.comboBox1.ValueMember = "IDEmployee";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.saleBindingSource, "DateSale", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.receiptDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 393);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Состав продажи";
            // 
            // receiptDataGridView
            // 
            this.receiptDataGridView.AutoGenerateColumns = false;
            this.receiptDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receiptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.receiptDataGridView.DataSource = this.receiptBindingSource;
            this.receiptDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptDataGridView.Location = new System.Drawing.Point(3, 16);
            this.receiptDataGridView.Name = "receiptDataGridView";
            this.receiptDataGridView.RowHeadersWidth = 62;
            this.receiptDataGridView.Size = new System.Drawing.Size(794, 374);
            this.receiptDataGridView.TabIndex = 0;
            this.receiptDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptDataGridView_CellClick);
            this.receiptDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptDataGridView_CellValueChanged);
            this.receiptDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.receiptDataGridView_DefaultValuesNeeded);
            this.receiptDataGridView.Enter += new System.EventHandler(this.receiptDataGridView_Enter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDReceipt";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDReceipt";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDGoods";
            this.dataGridViewTextBoxColumn2.DataSource = this.goodsBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "ModelGood";
            this.dataGridViewTextBoxColumn2.HeaderText = "Товар";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IDGoods";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDSale";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDSale";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CountGood";
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PriceGood";
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PriceGoodDiscount";
            this.dataGridViewTextBoxColumn6.FillWeight = 50F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена со скидкой";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SuumaPos";
            this.dataGridViewTextBoxColumn7.FillWeight = 50F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // clientCardTableAdapter
            // 
            this.clientCardTableAdapter.ClearBeforeFill = true;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientCardTableAdapter = this.clientCardTableAdapter;
            this.tableAdapterManager.DefaultGoodsInfoTableAdapter = null;
            this.tableAdapterManager.DiscountTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.InfoGoodsTableAdapter = null;
            this.tableAdapterManager.KategoryGoodsTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.ProfileTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = this.saleTableAdapter;
            this.tableAdapterManager.ScopeDeliveryTableAdapter = null;
            this.tableAdapterManager.ServiceCenterTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.SupplyTableAdapter = null;
            this.tableAdapterManager.TransferRepairTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store.MEGABYTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarrantyServiceTableAdapter = null;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(667, 18);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 42);
            this.button7.TabIndex = 28;
            this.button7.TabStop = false;
            this.button7.Text = "Чек продажи";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(553, 18);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 42);
            this.button6.TabIndex = 27;
            this.button6.TabStop = false;
            this.button6.Text = "Товарная накладная";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // EditSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(dateLabel);
            this.Controls.Add(id_employeeLabel);
            this.Controls.Add(id_clientLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/редактирование продажи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSales_FormClosing);
            this.Load += new System.EventHandler(this.EditSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MEGABYTDataSet MEGABYTDataSet;
        private System.Windows.Forms.BindingSource clientCardBindingSource;
        private MEGABYTDataSetTableAdapters.ClientCardTableAdapter clientCardTableAdapter;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private MEGABYTDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MEGABYTDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MEGABYTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private MEGABYTDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.DataGridView receiptDataGridView;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private MEGABYTDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}