﻿namespace VisualProgrammingProject
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
            this.btnHot = new System.Windows.Forms.Button();
            this.BtnCold = new System.Windows.Forms.Button();
            this.BtnMilky = new System.Windows.Forms.Button();
            this.LstVwMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LstVwOrder = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumericPiece = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHot
            // 
            this.btnHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHot.Location = new System.Drawing.Point(71, 57);
            this.btnHot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHot.Name = "btnHot";
            this.btnHot.Size = new System.Drawing.Size(211, 112);
            this.btnHot.TabIndex = 0;
            this.btnHot.Text = "Hot";
            this.btnHot.UseVisualStyleBackColor = true;
            this.btnHot.Click += new System.EventHandler(this.btnHot_Click);
            // 
            // BtnCold
            // 
            this.BtnCold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCold.Location = new System.Drawing.Point(352, 57);
            this.BtnCold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCold.Name = "BtnCold";
            this.BtnCold.Size = new System.Drawing.Size(211, 112);
            this.BtnCold.TabIndex = 1;
            this.BtnCold.Text = "Cold";
            this.BtnCold.UseVisualStyleBackColor = true;
            this.BtnCold.Click += new System.EventHandler(this.BtnCold_Click);
            // 
            // BtnMilky
            // 
            this.BtnMilky.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMilky.Location = new System.Drawing.Point(633, 57);
            this.BtnMilky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMilky.Name = "BtnMilky";
            this.BtnMilky.Size = new System.Drawing.Size(211, 112);
            this.BtnMilky.TabIndex = 2;
            this.BtnMilky.Text = "Milky";
            this.BtnMilky.UseVisualStyleBackColor = true;
            this.BtnMilky.Click += new System.EventHandler(this.BtnMilky_Click);
            // 
            // LstVwMenu
            // 
            this.LstVwMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LstVwMenu.FullRowSelect = true;
            this.LstVwMenu.HideSelection = false;
            this.LstVwMenu.Location = new System.Drawing.Point(60, 241);
            this.LstVwMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstVwMenu.Name = "LstVwMenu";
            this.LstVwMenu.Size = new System.Drawing.Size(252, 196);
            this.LstVwMenu.TabIndex = 3;
            this.LstVwMenu.UseCompatibleStateImageBehavior = false;
            this.LstVwMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Coffees";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 50;
            // 
            // LstVwOrder
            // 
            this.LstVwOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LstVwOrder.FullRowSelect = true;
            this.LstVwOrder.HideSelection = false;
            this.LstVwOrder.Location = new System.Drawing.Point(503, 241);
            this.LstVwOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstVwOrder.Name = "LstVwOrder";
            this.LstVwOrder.Size = new System.Drawing.Size(356, 196);
            this.LstVwOrder.TabIndex = 4;
            this.LstVwOrder.UseCompatibleStateImageBehavior = false;
            this.LstVwOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Coffees";
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
            this.NumericPiece.Location = new System.Drawing.Point(351, 310);
            this.NumericPiece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumericPiece.Name = "NumericPiece";
            this.NumericPiece.Size = new System.Drawing.Size(120, 22);
            this.NumericPiece.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(579, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(696, 485);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 7;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(351, 377);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(120, 62);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(503, 446);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(140, 28);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Reduce By One";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(719, 446);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(140, 28);
            this.btnClean.TabIndex = 10;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 533);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericPiece);
            this.Controls.Add(this.LstVwOrder);
            this.Controls.Add(this.LstVwMenu);
            this.Controls.Add(this.BtnMilky);
            this.Controls.Add(this.BtnCold);
            this.Controls.Add(this.btnHot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderPage";
            this.Text = "OrderPage";
            ((System.ComponentModel.ISupportInitialize)(this.NumericPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHot;
        private System.Windows.Forms.Button BtnCold;
        private System.Windows.Forms.Button BtnMilky;
        private System.Windows.Forms.ListView LstVwMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
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
    }
}