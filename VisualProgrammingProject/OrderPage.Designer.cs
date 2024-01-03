namespace VisualProgrammingProject
{
    partial class OrderPage
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
            this.LstVwMenu = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LstVwOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumericPiece = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.orderbtn = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // LstVwMenu
            // 
            this.LstVwMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnPrice});
            this.LstVwMenu.FullRowSelect = true;
            this.LstVwMenu.HideSelection = false;
            this.LstVwMenu.Location = new System.Drawing.Point(45, 196);
            this.LstVwMenu.Margin = new System.Windows.Forms.Padding(2);
            this.LstVwMenu.Name = "LstVwMenu";
            this.LstVwMenu.Size = new System.Drawing.Size(183, 160);
            this.LstVwMenu.TabIndex = 3;
            this.LstVwMenu.UseCompatibleStateImageBehavior = false;
            this.LstVwMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 34;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 73;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 73;
            // 
            // LstVwOrder
            // 
            this.LstVwOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LstVwOrder.FullRowSelect = true;
            this.LstVwOrder.HideSelection = false;
            this.LstVwOrder.Location = new System.Drawing.Point(377, 196);
            this.LstVwOrder.Margin = new System.Windows.Forms.Padding(2);
            this.LstVwOrder.Name = "LstVwOrder";
            this.LstVwOrder.Size = new System.Drawing.Size(268, 160);
            this.LstVwOrder.TabIndex = 4;
            this.LstVwOrder.UseCompatibleStateImageBehavior = false;
            this.LstVwOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Piece";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            // 
            // NumericPiece
            // 
            this.NumericPiece.Location = new System.Drawing.Point(263, 252);
            this.NumericPiece.Margin = new System.Windows.Forms.Padding(2);
            this.NumericPiece.Name = "NumericPiece";
            this.NumericPiece.Size = new System.Drawing.Size(90, 20);
            this.NumericPiece.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(375, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(436, 392);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(263, 306);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(90, 50);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(377, 362);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 23);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Reduce By One";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(539, 362);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(105, 23);
            this.btnClean.TabIndex = 10;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // orderbtn
            // 
            this.orderbtn.Location = new System.Drawing.Point(540, 391);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(105, 23);
            this.orderbtn.TabIndex = 11;
            this.orderbtn.Text = "Order";
            this.orderbtn.UseVisualStyleBackColor = true;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(137, 391);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 13;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLbl.Location = new System.Drawing.Point(74, 391);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(59, 20);
            this.nameLbl.TabIndex = 12;
            this.nameLbl.Text = "Name :";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.Location = new System.Drawing.Point(45, 28);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(600, 105);
            this.flowLayoutPanel.TabIndex = 14;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 433);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.orderbtn);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericPiece);
            this.Controls.Add(this.LstVwOrder);
            this.Controls.Add(this.LstVwMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderPage";
            this.Text = "OrderPage";
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView LstVwMenu;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ListView LstVwOrder;
        private System.Windows.Forms.NumericUpDown NumericPiece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button orderbtn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}