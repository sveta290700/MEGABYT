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
    public partial class Goods : Form
    {

        int sellNow = 0;
        public Goods()
        {
            InitializeComponent();
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.MEGABYTDataSet);

            this.infoGoodsTableAdapter.Fill(this.MEGABYTDataSet.InfoGoods);
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            this.defaultGoodsInfoTableAdapter.Fill(this.MEGABYTDataSet.DefaultGoodsInfo);
            this.kategoryGoodsTableAdapter.Fill(this.MEGABYTDataSet.KategoryGoods);
            this.manufacturerTableAdapter.Fill(this.MEGABYTDataSet.Manufacturer);
            this.infoGoodsTableAdapter.Fill(this.MEGABYTDataSet.InfoGoods);
            this.goodsTableAdapter.Fill(this.MEGABYTDataSet.Goods);
        }

        private void goodsDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            sellNow = goodsDataGridView.CurrentCell.RowIndex;
        }
    }
}
