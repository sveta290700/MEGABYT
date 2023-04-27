using System;
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
            Validate();
            kategoryGoodsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(MEGABYTDataSet);
        }

        private void KategoryGoods_Load(object sender, EventArgs e)
        {
            kategoryGoodsTableAdapter.Fill(MEGABYTDataSet.KategoryGoods);
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
