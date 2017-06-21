using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vierGewinnt
{
    public partial class AuswahlForm : Form
    {
        public AuswahlForm()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            SpielForm spf = new SpielForm(txbName1.Text, txbName2.Text);
            spf.ShowDialog();
        }
    }
}
