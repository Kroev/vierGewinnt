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
        private List<VGLabel> spielfeld;
        private Spielsteuerung control;
        private Label akt;
        private Label SP1;
        private Label SP2;
        //Aufruf des Base Konstruktors
        public SpielForm(String name1, String name2):base() 
        {
            this.spielfeld = new List<VGLabel>();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.control = new Spielsteuerung(7, 6, name1, name2);
            InitializeComponent();

            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            //Spalten
            this.table.ColumnCount = 9;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.28572F));
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
                btn.BackColor = Color.Gray;
                btn.Click += new System.EventHandler(this.btnClick);
                this.table.Controls.Add(btn, x,0);
                
            }

            // label1
            // 
            for (x = 0; x < 7; x++)
            {
                for (int y = 1; y < 7; y++)
                {
                    {
                        VGLabel label = new VGLabel(y-1,x);
                        this.spielfeld.Add(label);

                        Image imageKreis = Image.FromFile("..\\..\\..\\img\\Kreis.png");
                        label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
                        label.AutoSize = true;
                        label.Location = new System.Drawing.Point(3, 0);

                        label.Name = "label";
                        label.Size = new Size(imageKreis.Width, imageKreis.Height);
                        label.Image = imageKreis;
                        label.TabIndex = 0;
                        this.table.Controls.Add(label, x, y);
                    }
                } 
            }

            //Erzeugen des Symbols für aktuellen Spieler
            Image imageKreis2;
            if (control.Akt == 1)
            {
                imageKreis2 = Image.FromFile("..\\..\\..\\img\\KreisRot.png");
            }
            else
            {
                imageKreis2 = Image.FromFile("..\\..\\..\\img\\KreisGelb.png");
            }
            this.akt = this.initLabel("label", "", imageKreis2.Width, imageKreis2.Height);
            this.akt.Image = imageKreis2;
            this.table.Controls.Add(this.akt, 7, 2);

            //Erzeugen des Labels des Symbols von Spieler 1
            Image imgKreisSp1 = Image.FromFile("..\\..\\..\\img\\KreisRot.png");
            Label lblSp1 = this.initLabel("label", "", imgKreisSp1.Width, imgKreisSp1.Height);
            lblSp1.Image = imgKreisSp1;
            this.table.Controls.Add(lblSp1, 7, 4);

            //Erzeugen des Labels des Symbols von Spieler 2
            Image imgKreisSp2 = Image.FromFile("..\\..\\..\\img\\KreisGelb.png");
            Label lblSp2 = this.initLabel("label", "", imgKreisSp2.Width, imgKreisSp2.Height);
            lblSp2.Image = imgKreisSp2;
            this.table.Controls.Add(lblSp2, 7, 5);

            //Erzeugen des Labels mit dem Namen des aktuellen Spielers
            Label lblSpAktName = this.initLabel("label", "aktueller Spieler");
            this.table.Controls.Add(lblSpAktName, 8, 2);

            //Erzeugen des Labels mit dem Namen von Spieler 1

            this.SP1 = this.initLabel("label", name1);
            this.table.Controls.Add(this.SP1, 8, 4);

            //Erzeugen des Labels mit dem Namen von Spieler 2

            this.SP2 = this.initLabel("label", name2);
            this.table.Controls.Add(this.SP2, 8, 5);


            this.BackColor = Color.FromArgb(255,0,0,190);

        }

        private void btnClick(Object sender, EventArgs e)
        {
            //Typ von Sender zu VGButton geändert
            VGButton btn = (VGButton)sender;
            int x = btn.Column;
            int akt = this.control.Akt;
            int y = this.control.spielzug(x);
            if (y < 0)
            {
                return;
            }
            VGLabel lbl = findLabel(x, y);
            if (lbl!=null)
            {
                Image imgKreisLbl;
                if (akt == 1)
                {
                    imgKreisLbl = Image.FromFile("..\\..\\..\\img\\KreisRot.png");
                }
                else 
                {
                    imgKreisLbl = Image.FromFile("..\\..\\..\\img\\KreisGelb.png");
                }
                lbl.Image = imgKreisLbl;
            }
            akt = this.control.Akt;
            Image imgAktLbl;
            if (akt == 1)
            {
                imgAktLbl = Image.FromFile("..\\..\\..\\img\\KreisRot.png");
            }
            else
            {
                imgAktLbl = Image.FromFile("..\\..\\..\\img\\KreisGelb.png");
            }
            this.akt.Image = imgAktLbl;
            if (this.control.Spielende == 1)
            {
                MessageBox.Show(this.SP1.Text + " hat gewonnen.");
                this.Close();
            }
            else if (this.control.Spielende == 2)
            {
                MessageBox.Show(this.SP2.Text + " hat gewonnen.");
                this.Close();
            }
            else if (this.control.Spielende == -2)
            {
                MessageBox.Show("Unentschieden");
                this.Close();
            }

        }

        private VGLabel findLabel(int x,int y)
        {
            foreach (VGLabel label in this.spielfeld)
            {
                if (label.Column==x & label.Row==y)
                {
                    return label;
                }
            }
            //Null Pointer wird zurückgegeben; man kann nicht drauf zugreifen
            return null;
        }
        private Label initLabel(String name, String text,int sizeX, int sizeY)
        {

            Label lbl = new System.Windows.Forms.Label();

            lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            lbl.AutoSize = false;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Location = new System.Drawing.Point(3, 0);
            lbl.Name = name;
            lbl.Size = new System.Drawing.Size(sizeX, sizeY);
            lbl.TabIndex = 0;
            lbl.Text = text;
            lbl.Font = new Font(lbl.Font.FontFamily, 25);

            return lbl;
        }
        private Label initLabel(String name, String text)
        {
            return this.initLabel(name, text, 79, 68);
        }
    }
}
