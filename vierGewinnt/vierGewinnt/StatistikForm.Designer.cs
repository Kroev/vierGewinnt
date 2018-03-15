namespace vierGewinnt
{
    partial class StatistikForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._Statistik = new System.Windows.Forms.Label();
            this.dataGridStatistik = new System.Windows.Forms.DataGridView();
            this.spielsteuerungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spielsteuerungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _Statistik
            // 
            this._Statistik.AutoSize = true;
            this._Statistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Statistik.Location = new System.Drawing.Point(299, 9);
            this._Statistik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._Statistik.Name = "_Statistik";
            this._Statistik.Size = new System.Drawing.Size(129, 37);
            this._Statistik.TabIndex = 1;
            this._Statistik.Text = "Statistik";
            // 
            // dataGridStatistik
            // 
            this.dataGridStatistik.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStatistik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStatistik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatistik.Location = new System.Drawing.Point(164, 49);
            this.dataGridStatistik.Name = "dataGridStatistik";
            this.dataGridStatistik.Size = new System.Drawing.Size(393, 492);
            this.dataGridStatistik.TabIndex = 2;
            // 
            // spielsteuerungBindingSource
            // 
            this.spielsteuerungBindingSource.DataSource = typeof(vierGewinnt.Spielsteuerung);
            // 
            // StatistikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(766, 563);
            this.Controls.Add(this.dataGridStatistik);
            this.Controls.Add(this._Statistik);
            this.Name = "StatistikForm";
            this.Text = "StatistikForm";
            this.Load += new System.EventHandler(this.StatistikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spielsteuerungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _Statistik;
        private System.Windows.Forms.DataGridView dataGridStatistik;
        private System.Windows.Forms.BindingSource spielsteuerungBindingSource;
    }
}