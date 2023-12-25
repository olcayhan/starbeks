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
            this.lblOrder = new System.Windows.Forms.Label();
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
            this.lblOrderId.Location = new System.Drawing.Point(41, 72);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(92, 25);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(41, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrder.Location = new System.Drawing.Point(41, 188);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(68, 25);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Order:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(41, 506);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // lblOrderIDResponse
            // 
            this.lblOrderIDResponse.AutoSize = true;
            this.lblOrderIDResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderIDResponse.Location = new System.Drawing.Point(150, 72);
            this.lblOrderIDResponse.Name = "lblOrderIDResponse";
            this.lblOrderIDResponse.Size = new System.Drawing.Size(33, 25);
            this.lblOrderIDResponse.TabIndex = 4;
            this.lblOrderIDResponse.Text = "---";
            // 
            // lblNameresponse
            // 
            this.lblNameresponse.AutoSize = true;
            this.lblNameresponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameresponse.Location = new System.Drawing.Point(150, 127);
            this.lblNameresponse.Name = "lblNameresponse";
            this.lblNameresponse.Size = new System.Drawing.Size(33, 25);
            this.lblNameresponse.TabIndex = 5;
            this.lblNameresponse.Text = "---";
            // 
            // lblStatusResponse
            // 
            this.lblStatusResponse.AutoSize = true;
            this.lblStatusResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusResponse.Location = new System.Drawing.Point(150, 506);
            this.lblStatusResponse.Name = "lblStatusResponse";
            this.lblStatusResponse.Size = new System.Drawing.Size(33, 25);
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
            this.listView1.Location = new System.Drawing.Point(155, 188);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(279, 303);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 674);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblStatusResponse);
            this.Controls.Add(this.lblNameresponse);
            this.Controls.Add(this.lblOrderIDResponse);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblOrderId);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOrder;
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