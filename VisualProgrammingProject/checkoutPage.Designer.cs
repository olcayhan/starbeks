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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChoose = new System.Windows.Forms.TextBox();
            this.lstVwName = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnPay = new System.Windows.Forms.Button();
            this.BtnPayAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bill";
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
            this.columnHeader1.Text = "Drink";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total:";
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
            this.label2.Location = new System.Drawing.Point(398, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected amount:";
            // 
            // txtChoose
            // 
            this.txtChoose.BackColor = System.Drawing.SystemColors.Control;
            this.txtChoose.Location = new System.Drawing.Point(525, 356);
            this.txtChoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChoose.Name = "txtChoose";
            this.txtChoose.Size = new System.Drawing.Size(100, 22);
            this.txtChoose.TabIndex = 8;
            // 
            // lstVwName
            // 
            this.lstVwName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lstVwName.FullRowSelect = true;
            this.lstVwName.HideSelection = false;
            this.lstVwName.Location = new System.Drawing.Point(35, 102);
            this.lstVwName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstVwName.MultiSelect = false;
            this.lstVwName.Name = "lstVwName";
            this.lstVwName.Size = new System.Drawing.Size(339, 237);
            this.lstVwName.TabIndex = 10;
            this.lstVwName.UseCompatibleStateImageBehavior = false;
            this.lstVwName.View = System.Windows.Forms.View.Details;
            this.lstVwName.SelectedIndexChanged += new System.EventHandler(this.lstVwName_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order Id";
            this.columnHeader4.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 122;
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(665, 356);
            this.BtnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(75, 22);
            this.BtnPay.TabIndex = 11;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // BtnPayAll
            // 
            this.BtnPayAll.Location = new System.Drawing.Point(640, 394);
            this.BtnPayAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPayAll.Name = "BtnPayAll";
            this.BtnPayAll.Size = new System.Drawing.Size(113, 23);
            this.BtnPayAll.TabIndex = 12;
            this.BtnPayAll.Text = "Pay the Bill";
            this.BtnPayAll.UseVisualStyleBackColor = true;
            this.BtnPayAll.Click += new System.EventHandler(this.BtnPayAll_Click);
            // 
            // checkoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPayAll);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.lstVwName);
            this.Controls.Add(this.txtChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstviewFatura);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "checkoutPage";
            this.Text = "checkoutPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstviewFatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChoose;
        private System.Windows.Forms.ListView lstVwName;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.Button BtnPayAll;
    }
}