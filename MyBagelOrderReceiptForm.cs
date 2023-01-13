using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBagelShop_22233517_Menghua_Guo
{
    public partial class MyBagelOrderReceiptForm : Form
    {
        public MyBagelOrderReceiptForm()
        {
            InitializeComponent();
        }

        private void LoadReceiptForm()
        {

        }

        // Close receipt form
        private void ButtonReciptExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
