using System;
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
            Validate();
            defaultGoodsInfoBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void defaultGoodsInfoDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dataGridViewTextBoxColumn2"].Value = ID;            
        }

        private void DefaultCharakteristic_Load(object sender, EventArgs e)
        {
            defaultGoodsInfoTableAdapter.Fill(MEGABYTDataSet.DefaultGoodsInfo);
            defaultGoodsInfoBindingSource.Filter = "IDKategoryGoods = " + ID;
        }
    }
}
