using System;
using System.Collections;
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
            this.table = new System.Windows.Forms.TableLayoutPanel();

            InitializeComponent();

            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            //Spalten
            this.table.ColumnCount = 9;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.28572F));
            this.table.Location = new System.Drawing.Point(1, 1);
            this.table.Name = "table";
            //Zeilen
            this.table.RowCount = 7;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.Size = new System.Drawing.Size(900, 413);
            this.table.TabIndex = 0;
            this.Controls.Add(this.table);

            //Buttons
            int x = 0;
            for (;x<7;x++)
            {
                VGButton btn = new VGButton(x);
                btn.TabIndex = 0;
                this.table.Controls.Add(btn, x,0);
            }

            // label1
            // 
            for (x = 0; x < 7; x++)
            {
                for (int y = 1; y < 7; y++)
                {
                    {
                       Label label = new System.Windows.Forms.Label();

                        Image imageKreis = Image.FromFile("..\\..\\..\\img\\Kreis.png");
                        label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
                        label.AutoSize = true;
                        label.Location = new System.Drawing.Point(3, 0);

                        label.Name = "label";
                        label.Size = new Size(imageKreis.Width, imageKreis.Height);
                        label.Image = imageKreis;
                        //label.Size = new System.Drawing.Size(79, 68);
                        label.TabIndex = 0;
                        label.Text = "label" + y + x;
                        this.table.Controls.Add(label, x, y);
                    }
                } 
            }
            Label lblSpAkt = new System.Windows.Forms.Label();

            Image imageKreis2 = Image.FromFile("..\\..\\..\\img\\Kreis.png");
            lblSpAkt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            lblSpAkt.AutoSize = true;
            lblSpAkt.Location = new System.Drawing.Point(3, 0);

            lblSpAkt.Name = "label";
            lblSpAkt.Size = new Size(imageKreis2.Width, imageKreis2.Height);
            lblSpAkt.Image = imageKreis2;
            //label.Size = new System.Drawing.Size(79, 68);
            lblSpAkt.TabIndex = 0;
            lblSpAkt.Text = "label 72";
            this.table.Controls.Add(lblSpAkt, 7, 2);

            Label lblSp1 = new System.Windows.Forms.Label();

            Image imgKreisSp1 = Image.FromFile("..\\..\\..\\img\\KreisRot.png");
            lblSp1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            lblSp1.AutoSize = true;
            lblSp1.Location = new System.Drawing.Point(3, 0);

            lblSp1.Name = "label";
            lblSp1.Size = new Size(imgKreisSp1.Width, imgKreisSp1.Height);
            lblSp1.Image = imgKreisSp1;
            //label.Size = new System.Drawing.Size(79, 68);
            lblSp1.TabIndex = 0;
            lblSp1.Text = "label 72";
            this.table.Controls.Add(lblSp1, 7, 4);

            Label lblSp2 = new System.Windows.Forms.Label();

            Image imgKreisSp2 = Image.FromFile("..\\..\\..\\img\\KreisGelb.png");
            lblSp2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            lblSp2.AutoSize = true;
            lblSp2.Location = new System.Drawing.Point(3, 0);

            lblSp2.Name = "label";
            lblSp2.Size = new Size(imgKreisSp2.Width, imgKreisSp2.Height);
            lblSp2.Image = imgKreisSp2;
            //label.Size = new System.Drawing.Size(79, 68);
            lblSp2.TabIndex = 0;
            lblSp2.Text = "label 72";
            this.table.Controls.Add(lblSp2, 7, 5);
        }
    }
}
