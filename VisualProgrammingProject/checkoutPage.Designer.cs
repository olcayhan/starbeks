namespace VisualProgrammingProject
{
    partial class checkoutPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSprNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstviewFatura = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOde = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş No:";
            // 
            // lblSprNo
            // 
            this.lblSprNo.AutoSize = true;
            this.lblSprNo.Location = new System.Drawing.Point(124, 39);
            this.lblSprNo.Name = "lblSprNo";
            this.lblSprNo.Size = new System.Drawing.Size(63, 16);
            this.lblSprNo.TabIndex = 1;
            this.lblSprNo.Text = "00000001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fatura";
            // 
            // lstviewFatura
            // 
            this.lstviewFatura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstviewFatura.HideSelection = false;
            this.lstviewFatura.Location = new System.Drawing.Point(218, 125);
            this.lstviewFatura.Name = "lstviewFatura";
            this.lstviewFatura.Size = new System.Drawing.Size(310, 237);
            this.lstviewFatura.TabIndex = 3;
            this.lstviewFatura.UseCompatibleStateImageBehavior = false;
            this.lstviewFatura.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İçecek";
            this.columnHeader1.Width = 171;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(533, 393);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(113, 23);
            this.btnOde.TabIndex = 4;
            this.btnOde.Text = "Hesabı Öde";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Toplam:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(356, 389);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // checkoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lstviewFatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSprNo);
            this.Controls.Add(this.label1);
            this.Name = "checkoutPage";
            this.Text = "checkoutPage";
            this.Load += new System.EventHandler(this.checkoutPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSprNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstviewFatura;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}