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
            this.label3 = new System.Windows.Forms.Label();
            this.lstviewFatura = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOde = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecilen = new System.Windows.Forms.TextBox();
            this.btnÖde = new System.Windows.Forms.Button();
            this.lstVwName = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 69);
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
            this.lstviewFatura.FullRowSelect = true;
            this.lstviewFatura.HideSelection = false;
            this.lstviewFatura.Location = new System.Drawing.Point(401, 102);
            this.lstviewFatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstviewFatura.Name = "lstviewFatura";
            this.lstviewFatura.Size = new System.Drawing.Size(339, 237);
            this.lstviewFatura.TabIndex = 3;
            this.lstviewFatura.UseCompatibleStateImageBehavior = false;
            this.lstviewFatura.View = System.Windows.Forms.View.Details;
            this.lstviewFatura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstviewFatura_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İçecek";
            this.columnHeader1.Width = 122;
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
            this.btnOde.Location = new System.Drawing.Point(656, 401);
            this.btnOde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label4.Location = new System.Drawing.Point(415, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Toplam:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(525, 395);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seçilen Tutar:";
            // 
            // txtSecilen
            // 
            this.txtSecilen.BackColor = System.Drawing.SystemColors.Control;
            this.txtSecilen.Location = new System.Drawing.Point(525, 356);
            this.txtSecilen.Name = "txtSecilen";
            this.txtSecilen.Size = new System.Drawing.Size(100, 22);
            this.txtSecilen.TabIndex = 8;
            // 
            // btnÖde
            // 
            this.btnÖde.Location = new System.Drawing.Point(656, 353);
            this.btnÖde.Name = "btnÖde";
            this.btnÖde.Size = new System.Drawing.Size(75, 23);
            this.btnÖde.TabIndex = 9;
            this.btnÖde.Text = "Öde";
            this.btnÖde.UseVisualStyleBackColor = true;
            this.btnÖde.Click += new System.EventHandler(this.btnÖde_Click);
            // 
            // lstVwName
            // 
            this.lstVwName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lstVwName.FullRowSelect = true;
            this.lstVwName.HideSelection = false;
            this.lstVwName.Location = new System.Drawing.Point(34, 102);
            this.lstVwName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstVwName.Name = "lstVwName";
            this.lstVwName.Size = new System.Drawing.Size(339, 237);
            this.lstVwName.TabIndex = 10;
            this.lstVwName.UseCompatibleStateImageBehavior = false;
            this.lstVwName.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sipariş No";
            this.columnHeader4.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 122;
            // 
            // checkoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstVwName);
            this.Controls.Add(this.btnÖde);
            this.Controls.Add(this.txtSecilen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lstviewFatura);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "checkoutPage";
            this.Text = "checkoutPage";
            this.Load += new System.EventHandler(this.checkoutPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstviewFatura;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecilen;
        private System.Windows.Forms.Button btnÖde;
        private System.Windows.Forms.ListView lstVwName;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}