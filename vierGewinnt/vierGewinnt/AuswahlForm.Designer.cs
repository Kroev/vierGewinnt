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
            this.SuspendLayout();
            // 
            // _Name1
            // 
            this._Name1.AutoSize = true;
            this._Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Name1.Location = new System.Drawing.Point(46, 45);
            this._Name1.Name = "_Name1";
            this._Name1.Size = new System.Drawing.Size(210, 32);
            this._Name1.TabIndex = 0;
            this._Name1.Text = "Name Spieler 1";
            // 
            // _Name2
            // 
            this._Name2.AutoSize = true;
            this._Name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Name2.Location = new System.Drawing.Point(46, 110);
            this._Name2.Name = "_Name2";
            this._Name2.Size = new System.Drawing.Size(210, 32);
            this._Name2.TabIndex = 1;
            this._Name2.Text = "Name Spieler 2";
            // 
            // txbName1
            // 
            this.txbName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName1.Location = new System.Drawing.Point(298, 39);
            this.txbName1.Name = "txbName1";
            this.txbName1.Size = new System.Drawing.Size(291, 38);
            this.txbName1.TabIndex = 2;
            // 
            // txbName2
            // 
            this.txbName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName2.Location = new System.Drawing.Point(298, 110);
            this.txbName2.Name = "txbName2";
            this.txbName2.Size = new System.Drawing.Size(291, 38);
            this.txbName2.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(528, 315);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(186, 81);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // AuswahlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 432);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txbName2);
            this.Controls.Add(this.txbName1);
            this.Controls.Add(this._Name2);
            this.Controls.Add(this._Name1);
            this.Name = "AuswahlForm";
            this.Text = "AuswahlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _Name1;
        private System.Windows.Forms.Label _Name2;
        private System.Windows.Forms.TextBox txbName1;
        private System.Windows.Forms.TextBox txbName2;
        private System.Windows.Forms.Button btnOk;
    }
}