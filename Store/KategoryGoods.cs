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
    public partial class KategoryGoods : Form
    {
        public KategoryGoods()
        {
            InitializeComponent();
        }

        private void kategoryGoodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kategoryGoodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.MEGABYTDataSet);
        }

        private void KategoryGoods_Load(object sender, EventArgs e)
        {
            this.kategoryGoodsTableAdapter.Fill(this.MEGABYTDataSet.KategoryGoods);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: проверка на индексы???
            DataGridViewCell cur_cell = kategoryGoodsDataGridView.CurrentCell;
            if (cur_cell != null)
            {
                DefaultCharakteristic f = new DefaultCharakteristic(kategoryGoodsDataGridView.Rows[kategoryGoodsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString(), kategoryGoodsDataGridView.Rows[kategoryGoodsDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString());
                f.ShowDialog();
            }
            else
                MessageBox.Show(
                    "Не была корректно выбрана категория товара",
                    "Ошибка",
                    MessageBoxButtons.OK);
        }

        private void kategoryGoodsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            
        }
    }
}
