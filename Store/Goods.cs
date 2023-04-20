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
        public Goods()
        {
            InitializeComponent();
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.MEGABYTDataSet);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.InfoGoods". При необходимости она может быть перемещена или удалена.
            this.infoGoodsTableAdapter.Fill(this.MEGABYTDataSet.InfoGoods);


        }

        private void Goods_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.DefaultGoodsInfo". При необходимости она может быть перемещена или удалена.
            this.defaultGoodsInfoTableAdapter.Fill(this.MEGABYTDataSet.DefaultGoodsInfo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.KategoryGoods". При необходимости она может быть перемещена или удалена.
            this.kategoryGoodsTableAdapter.Fill(this.MEGABYTDataSet.KategoryGoods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.MEGABYTDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.InfoGoods". При необходимости она может быть перемещена или удалена.
            this.infoGoodsTableAdapter.Fill(this.MEGABYTDataSet.InfoGoods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MEGABYTDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.MEGABYTDataSet.Goods);

        }
    }
}
