namespace Store
{
    partial class Supply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supply));
            this.MEGABYTDataSet = new Store.MEGABYTDataSet();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyTableAdapter = new Store.MEGABYTDataSetTableAdapters.SupplyTableAdapter();
            this.tableAdapterManager = new Store.MEGABYTDataSetTableAdapters.TableAdapterManager();
            this.scopeDeliveryTableAdapter = new Store.MEGABYTDataSetTableAdapters.ScopeDeliveryTableAdapter();
            this.supplyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.supplyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.supplyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MEGABYTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scopeDeliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.iDScopeDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countSupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceSupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scopeDeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Store.MEGABYTDataSetTableAdapters.EmployeeTableAdapter();
            this.supplierTableAdapter = new Store.MEGABYTDataSetTableAdapters.SupplierTableAdapter();
            this.goodsTableAdapter = new Store.MEGABYTDataSetTableAdapters.GoodsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingNavigator)).BeginInit();
            this.supplyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scopeDeliveryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scopeDeliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MEGABYTDataSet
            // 
            this.MEGABYTDataSet.DataSetName = "MEGABYTDataSet";
            this.MEGABYTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataMember = "Supply";
            this.supplyBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // supplyTableAdapter
            // 
            this.supplyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientCardTableAdapter = null;
            this.tableAdapterManager.DefaultGoodsInfoTableAdapter = null;
            this.tableAdapterManager.DiscountTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.InfoGoodsTableAdapter = null;
            this.tableAdapterManager.KategoryGoodsTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = null;
            this.tableAdapterManager.ProfileTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.ScopeDeliveryTableAdapter = this.scopeDeliveryTableAdapter;
            this.tableAdapterManager.ServiceCenterTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.SupplyTableAdapter = this.supplyTableAdapter;
            this.tableAdapterManager.TransferRepairTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store.MEGABYTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarrantyServiceTableAdapter = null;
            // 
            // scopeDeliveryTableAdapter
            // 
            this.scopeDeliveryTableAdapter.ClearBeforeFill = true;
            // 
            // supplyBindingNavigator
            // 
            this.supplyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supplyBindingNavigator.BindingSource = this.supplyBindingSource;
            this.supplyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supplyBindingNavigator.DeleteItem = null;
            this.supplyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.supplyBindingNavigatorSaveItem});
            this.supplyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.supplyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supplyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supplyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supplyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supplyBindingNavigator.Name = "supplyBindingNavigator";
            this.supplyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supplyBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.supplyBindingNavigator.TabIndex = 0;
            this.supplyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // supplyBindingNavigatorSaveItem
            // 
            this.supplyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supplyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supplyBindingNavigatorSaveItem.Image")));
            this.supplyBindingNavigatorSaveItem.Name = "supplyBindingNavigatorSaveItem";
            this.supplyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.supplyBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.supplyBindingNavigatorSaveItem.Click += new System.EventHandler(this.supplyBindingNavigatorSaveItem_Click);
            // 
            // supplyDataGridView
            // 
            this.supplyDataGridView.AutoGenerateColumns = false;
            this.supplyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.supplyDataGridView.DataSource = this.supplyBindingSource;
            this.supplyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplyDataGridView.Location = new System.Drawing.Point(0, 25);
            this.supplyDataGridView.Name = "supplyDataGridView";
            this.supplyDataGridView.Size = new System.Drawing.Size(800, 530);
            this.supplyDataGridView.TabIndex = 1;
            this.supplyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplyDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDSupply";
            this.dataGridViewTextBoxColumn1.HeaderText = "№ поставки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDEmployee";
            this.dataGridViewTextBoxColumn2.DataSource = this.employeeBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Сотрудник";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IDEmployee";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDSupplier";
            this.dataGridViewTextBoxColumn3.DataSource = this.supplierBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "NameSupplier";
            this.dataGridViewTextBoxColumn3.HeaderText = "Поставщик";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDSupplier";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.MEGABYTDataSetBindingSource;
            // 
            // MEGABYTDataSetBindingSource
            // 
            this.MEGABYTDataSetBindingSource.DataSource = this.MEGABYTDataSet;
            this.MEGABYTDataSetBindingSource.Position = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateSupply";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scopeDeliveryDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 310);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Состав поставки";
            // 
            // scopeDeliveryDataGridView
            // 
            this.scopeDeliveryDataGridView.AutoGenerateColumns = false;
            this.scopeDeliveryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scopeDeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scopeDeliveryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDScopeDeliveryDataGridViewTextBoxColumn,
            this.iDSupplyDataGridViewTextBoxColumn,
            this.iDGoodsDataGridViewTextBoxColumn,
            this.countSupplyDataGridViewTextBoxColumn,
            this.priceSupplyDataGridViewTextBoxColumn,
            this.summPositionDataGridViewTextBoxColumn});
            this.scopeDeliveryDataGridView.DataSource = this.scopeDeliveryBindingSource;
            this.scopeDeliveryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scopeDeliveryDataGridView.Location = new System.Drawing.Point(3, 16);
            this.scopeDeliveryDataGridView.Name = "scopeDeliveryDataGridView";
            this.scopeDeliveryDataGridView.Size = new System.Drawing.Size(794, 291);
            this.scopeDeliveryDataGridView.TabIndex = 0;
            // 
            // iDScopeDeliveryDataGridViewTextBoxColumn
            // 
            this.iDScopeDeliveryDataGridViewTextBoxColumn.DataPropertyName = "IDScopeDelivery";
            this.iDScopeDeliveryDataGridViewTextBoxColumn.HeaderText = "IDScopeDelivery";
            this.iDScopeDeliveryDataGridViewTextBoxColumn.Name = "iDScopeDeliveryDataGridViewTextBoxColumn";
            this.iDScopeDeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDScopeDeliveryDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSupplyDataGridViewTextBoxColumn
            // 
            this.iDSupplyDataGridViewTextBoxColumn.DataPropertyName = "IDSupply";
            this.iDSupplyDataGridViewTextBoxColumn.HeaderText = "IDSupply";
            this.iDSupplyDataGridViewTextBoxColumn.Name = "iDSupplyDataGridViewTextBoxColumn";
            this.iDSupplyDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDGoodsDataGridViewTextBoxColumn
            // 
            this.iDGoodsDataGridViewTextBoxColumn.DataPropertyName = "IDGoods";
            this.iDGoodsDataGridViewTextBoxColumn.DataSource = this.goodsBindingSource;
            this.iDGoodsDataGridViewTextBoxColumn.DisplayMember = "ModelGood";
            this.iDGoodsDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.iDGoodsDataGridViewTextBoxColumn.Name = "iDGoodsDataGridViewTextBoxColumn";
            this.iDGoodsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDGoodsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDGoodsDataGridViewTextBoxColumn.ValueMember = "IDGoods";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.MEGABYTDataSet;
            // 
            // countSupplyDataGridViewTextBoxColumn
            // 
            this.countSupplyDataGridViewTextBoxColumn.DataPropertyName = "CountSupply";
            this.countSupplyDataGridViewTextBoxColumn.FillWeight = 50F;
            this.countSupplyDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countSupplyDataGridViewTextBoxColumn.Name = "countSupplyDataGridViewTextBoxColumn";
            // 
            // priceSupplyDataGridViewTextBoxColumn
            // 
            this.priceSupplyDataGridViewTextBoxColumn.DataPropertyName = "PriceSupply";
            this.priceSupplyDataGridViewTextBoxColumn.FillWeight = 50F;
            this.priceSupplyDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.priceSupplyDataGridViewTextBoxColumn.Name = "priceSupplyDataGridViewTextBoxColumn";
            // 
            // summPositionDataGridViewTextBoxColumn
            // 
            this.summPositionDataGridViewTextBoxColumn.DataPropertyName = "SummPosition";
            this.summPositionDataGridViewTextBoxColumn.FillWeight = 50F;
            this.summPositionDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summPositionDataGridViewTextBoxColumn.Name = "summPositionDataGridViewTextBoxColumn";
            this.summPositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scopeDeliveryBindingSource
            // 
            this.scopeDeliveryBindingSource.DataMember = "Supply_BeDescribed_ScopeDelivery";
            this.scopeDeliveryBindingSource.DataSource = this.supplyBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // Supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.supplyDataGridView);
            this.Controls.Add(this.supplyBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Supply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставка";
            this.Load += new System.EventHandler(this.Supply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingNavigator)).EndInit();
            this.supplyBindingNavigator.ResumeLayout(false);
            this.supplyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEGABYTDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scopeDeliveryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scopeDeliveryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MEGABYTDataSet MEGABYTDataSet;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private MEGABYTDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter;
        private MEGABYTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supplyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton supplyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView supplyDataGridView;
        private MEGABYTDataSetTableAdapters.ScopeDeliveryTableAdapter scopeDeliveryTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource scopeDeliveryBindingSource;
        private System.Windows.Forms.DataGridView scopeDeliveryDataGridView;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MEGABYTDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource MEGABYTDataSetBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private MEGABYTDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private MEGABYTDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDScopeDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSupplyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countSupplyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceSupplyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summPositionDataGridViewTextBoxColumn;
    }
}