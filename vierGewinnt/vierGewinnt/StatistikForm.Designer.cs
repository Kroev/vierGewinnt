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
            this.SpielerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spielsteuerungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spielendeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spielsteuerungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _Statistik
            // 
            this._Statistik.AutoSize = true;
            this._Statistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Statistik.Location = new System.Drawing.Point(448, 14);
            this._Statistik.Name = "_Statistik";
            this._Statistik.Size = new System.Drawing.Size(190, 55);
            this._Statistik.TabIndex = 1;
            this._Statistik.Text = "Statistik";
            // 
            // dataGridStatistik
            // 
            this.dataGridStatistik.AutoGenerateColumns = false;
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
            this.dataGridStatistik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpielerName,
            this.Elo,
            this.spielendeDataGridViewTextBoxColumn,
            this.aktDataGridViewTextBoxColumn});
            this.dataGridStatistik.DataSource = this.spielsteuerungBindingSource;
            this.dataGridStatistik.Location = new System.Drawing.Point(246, 75);
            this.dataGridStatistik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridStatistik.Name = "dataGridStatistik";
            this.dataGridStatistik.Size = new System.Drawing.Size(590, 757);
            this.dataGridStatistik.TabIndex = 2;
            // 
            // SpielerName
            // 
            this.SpielerName.FillWeight = 250F;
            this.SpielerName.HeaderText = "SpielerName";
            this.SpielerName.Name = "SpielerName";
            this.SpielerName.ReadOnly = true;
            this.SpielerName.Width = 250;
            // 
            // Elo
            // 
            this.Elo.HeaderText = "Elo";
            this.Elo.Name = "Elo";
            this.Elo.ReadOnly = true;
            // 
            // spielsteuerungBindingSource
            // 
            this.spielsteuerungBindingSource.DataSource = typeof(vierGewinnt.Spielsteuerung);
            // 
            // spielendeDataGridViewTextBoxColumn
            // 
            this.spielendeDataGridViewTextBoxColumn.DataPropertyName = "Spielende";
            this.spielendeDataGridViewTextBoxColumn.HeaderText = "Spielende";
            this.spielendeDataGridViewTextBoxColumn.Name = "spielendeDataGridViewTextBoxColumn";
            this.spielendeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktDataGridViewTextBoxColumn
            // 
            this.aktDataGridViewTextBoxColumn.DataPropertyName = "Akt";
            this.aktDataGridViewTextBoxColumn.HeaderText = "Akt";
            this.aktDataGridViewTextBoxColumn.Name = "aktDataGridViewTextBoxColumn";
            this.aktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StatistikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1149, 866);
            this.Controls.Add(this.dataGridStatistik);
            this.Controls.Add(this._Statistik);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SpielerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elo;
        private System.Windows.Forms.DataGridViewTextBoxColumn spielendeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spielsteuerungBindingSource;
    }
}