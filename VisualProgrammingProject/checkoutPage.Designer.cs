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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkoutPage));
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
            this.orderLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(134, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bill";
            // 
            // lstviewFatura
            // 
            this.lstviewFatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.lstviewFatura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstviewFatura.FullRowSelect = true;
            this.lstviewFatura.HideSelection = false;
            this.lstviewFatura.Location = new System.Drawing.Point(22, 47);
            this.lstviewFatura.Margin = new System.Windows.Forms.Padding(2);
            this.lstviewFatura.Name = "lstviewFatura";
            this.lstviewFatura.Size = new System.Drawing.Size(254, 191);
            this.lstviewFatura.TabIndex = 3;
            this.lstviewFatura.UseCompatibleStateImageBehavior = false;
            this.lstviewFatura.View = System.Windows.Forms.View.Details;
            this.lstviewFatura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstviewFatura_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Drink";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.label4.Location = new System.Drawing.Point(77, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total :";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.txtPrice.Location = new System.Drawing.Point(135, 55);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(133, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected Price :";
            // 
            // txtChoose
            // 
            this.txtChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.txtChoose.Location = new System.Drawing.Point(135, 21);
            this.txtChoose.Margin = new System.Windows.Forms.Padding(2);
            this.txtChoose.Name = "txtChoose";
            this.txtChoose.Size = new System.Drawing.Size(133, 20);
            this.txtChoose.TabIndex = 8;
            // 
            // lstVwName
            // 
            this.lstVwName.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstVwName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.lstVwName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lstVwName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstVwName.FullRowSelect = true;
            this.lstVwName.HideSelection = false;
            this.lstVwName.Location = new System.Drawing.Point(26, 47);
            this.lstVwName.Margin = new System.Windows.Forms.Padding(2);
            this.lstVwName.MultiSelect = false;
            this.lstVwName.Name = "lstVwName";
            this.lstVwName.Size = new System.Drawing.Size(248, 191);
            this.lstVwName.TabIndex = 10;
            this.lstVwName.UseCompatibleStateImageBehavior = false;
            this.lstVwName.View = System.Windows.Forms.View.Details;
            this.lstVwName.SelectedIndexChanged += new System.EventHandler(this.lstVwName_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order ID";
            this.columnHeader4.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 122;
            // 
            // BtnPay
            // 
            this.BtnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.BtnPay.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.BtnPay.Location = new System.Drawing.Point(301, 14);
            this.BtnPay.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(135, 33);
            this.BtnPay.TabIndex = 11;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = false;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // BtnPayAll
            // 
            this.BtnPayAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.BtnPayAll.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPayAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.BtnPayAll.Location = new System.Drawing.Point(301, 56);
            this.BtnPayAll.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPayAll.Name = "BtnPayAll";
            this.BtnPayAll.Size = new System.Drawing.Size(135, 32);
            this.BtnPayAll.TabIndex = 12;
            this.BtnPayAll.Text = "Pay the Bill";
            this.BtnPayAll.UseVisualStyleBackColor = false;
            this.BtnPayAll.Click += new System.EventHandler(this.BtnPayAll_Click);
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.orderLbl.Location = new System.Drawing.Point(107, 16);
            this.orderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(77, 29);
            this.orderLbl.TabIndex = 13;
            this.orderLbl.Text = "Order";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.orderLbl);
            this.panel1.Controls.Add(this.lstVwName);
            this.panel1.Location = new System.Drawing.Point(49, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 268);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.txtChoose);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BtnPayAll);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.BtnPay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(240, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 100);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.lstviewFatura);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(375, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 268);
            this.panel3.TabIndex = 16;
            // 
            // checkoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 454);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "checkoutPage";
            this.Text = "checkoutPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}