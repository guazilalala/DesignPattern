using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 策略模式
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double total = 0.0d; //用于总计
        private void btnOk_Click(object sender, EventArgs e)
        {
            CashContext csuper = new CashContext(cbxType.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = csuper.GetResult(Convert.ToDouble(txtPrice.Text) *
                Convert.ToDouble(txtNum.Text));
            total = total + totalPrices;
            lbxList.Items.Add($"单价:{txtPrice.Text} 数量:{txtNum.Text} {cbxType.SelectedItem} 合计:{totalPrices.ToString()}");
            lblResult.Text = total.ToString();
        }
    }
}
