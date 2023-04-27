using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class DefaultCharakteristic : Form
    {
        string ID;

        public DefaultCharakteristic(string id, string title)
        {
            InitializeComponent();
            ID = id;
            label1.Text = "Категория товаров: " + title;
        }

        private void defaultGoodsInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.defaultGoodsInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.MEGABYTDataSet);
        }

        private void defaultGoodsInfoDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dataGridViewTextBoxColumn2"].Value = ID;            
        }

        private void DefaultCharakteristic_Load(object sender, EventArgs e)
        {
            this.defaultGoodsInfoTableAdapter.Fill(this.MEGABYTDataSet.DefaultGoodsInfo);
            defaultGoodsInfoBindingSource.Filter = "IDKategoryGoods = " + ID;
        }
    }
}
