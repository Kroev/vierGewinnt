namespace vierGewinnt
{
    partial class AuswahlForm
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
            this._Name1 = new System.Windows.Forms.Label();
            this._Name2 = new System.Windows.Forms.Label();
            this.txbName1 = new System.Windows.Forms.TextBox();
            this.txbName2 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnStatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _Name1
            // 
            this._Name1.AutoSize = true;
            this._Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Name1.Location = new System.Drawing.Point(34, 37);
            this._Name1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._Name1.Name = "_Name1";
            this._Name1.Size = new System.Drawing.Size(163, 26);
            this._Name1.TabIndex = 0;
            this._Name1.Text = "Name Spieler 1";
            // 
            // _Name2
            // 
            this._Name2.AutoSize = true;
            this._Name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Name2.Location = new System.Drawing.Point(34, 89);
            this._Name2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._Name2.Name = "_Name2";
            this._Name2.Size = new System.Drawing.Size(163, 26);
            this._Name2.TabIndex = 1;
            this._Name2.Text = "Name Spieler 2";
            // 
            // txbName1
            // 
            this.txbName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName1.Location = new System.Drawing.Point(224, 32);
            this.txbName1.Margin = new System.Windows.Forms.Padding(2);
            this.txbName1.Name = "txbName1";
            this.txbName1.Size = new System.Drawing.Size(219, 32);
            this.txbName1.TabIndex = 2;
            this.txbName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // txbName2
            // 
            this.txbName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName2.Location = new System.Drawing.Point(224, 89);
            this.txbName2.Margin = new System.Windows.Forms.Padding(2);
            this.txbName2.Name = "txbName2";
            this.txbName2.Size = new System.Drawing.Size(219, 32);
            this.txbName2.TabIndex = 3;
            this.txbName2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(396, 256);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 66);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // btnStatistik
            // 
            this.btnStatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistik.Location = new System.Drawing.Point(39, 256);
            this.btnStatistik.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistik.Name = "btnStatistik";
            this.btnStatistik.Size = new System.Drawing.Size(140, 66);
            this.btnStatistik.TabIndex = 5;
            this.btnStatistik.Text = "Statistik";
            this.btnStatistik.UseVisualStyleBackColor = true;
            this.btnStatistik.Click += new System.EventHandler(this.btnStatistik_Click);
            // 
            // AuswahlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 351);
            this.Controls.Add(this.btnStatistik);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txbName2);
            this.Controls.Add(this.txbName1);
            this.Controls.Add(this._Name2);
            this.Controls.Add(this._Name1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AuswahlForm";
            this.Text = "AuswahlForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _Name1;
        private System.Windows.Forms.Label _Name2;
        private System.Windows.Forms.TextBox txbName1;
        private System.Windows.Forms.TextBox txbName2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnStatistik;
    }
}