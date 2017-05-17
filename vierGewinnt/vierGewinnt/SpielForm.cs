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
    public partial class SpielForm : Form
    {
        public SpielForm()
        {
            InitializeComponent();
            // label1
            // 
            Label label1 = new System.Windows.Forms.Label();
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 68);
            label1.TabIndex = 0;
            label1.Text = "label1";
            this.table.Controls.Add(label1, 0, 0);
        }
    }
}
