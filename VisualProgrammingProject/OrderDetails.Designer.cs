namespace VisualProgrammingProject
{
    partial class OrderDetails
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOrderIDResponse = new System.Windows.Forms.Label();
            this.lblNameresponse = new System.Windows.Forms.Label();
            this.lblStatusResponse = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderId.Location = new System.Drawing.Point(114, 54);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(74, 20);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(113, 95);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(114, 321);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // lblOrderIDResponse
            // 
            this.lblOrderIDResponse.AutoSize = true;
            this.lblOrderIDResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderIDResponse.Location = new System.Drawing.Point(196, 54);
            this.lblOrderIDResponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderIDResponse.Name = "lblOrderIDResponse";
            this.lblOrderIDResponse.Size = new System.Drawing.Size(24, 20);
            this.lblOrderIDResponse.TabIndex = 4;
            this.lblOrderIDResponse.Text = "---";
            // 
            // lblNameresponse
            // 
            this.lblNameresponse.AutoSize = true;
            this.lblNameresponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameresponse.Location = new System.Drawing.Point(194, 95);
            this.lblNameresponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameresponse.Name = "lblNameresponse";
            this.lblNameresponse.Size = new System.Drawing.Size(24, 20);
            this.lblNameresponse.TabIndex = 5;
            this.lblNameresponse.Text = "---";
            // 
            // lblStatusResponse
            // 
            this.lblStatusResponse.AutoSize = true;
            this.lblStatusResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusResponse.Location = new System.Drawing.Point(196, 321);
            this.lblStatusResponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusResponse.Name = "lblStatusResponse";
            this.lblStatusResponse.Size = new System.Drawing.Size(24, 20);
            this.lblStatusResponse.TabIndex = 6;
            this.lblStatusResponse.Text = "---";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProduct,
            this.columnAmount,
            this.columnPrice});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(118, 146);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 166);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnProduct
            // 
            this.columnProduct.Text = "Product";
            this.columnProduct.Width = 92;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            this.columnAmount.Width = 82;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 93;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 430);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblStatusResponse);
            this.Controls.Add(this.lblNameresponse);
            this.Controls.Add(this.lblOrderIDResponse);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblOrderId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOrderIDResponse;
        private System.Windows.Forms.Label lblNameresponse;
        private System.Windows.Forms.Label lblStatusResponse;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnProduct;
        private System.Windows.Forms.ColumnHeader columnPrice;
    }
}