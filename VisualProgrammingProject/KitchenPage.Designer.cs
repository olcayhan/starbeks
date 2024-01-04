namespace VisualProgrammingProject
{
    partial class KitchenPage
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
            this.lblDrink = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.liViewKitchen = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDrink.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDrink.Location = new System.Drawing.Point(-95, 217);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(49, 20);
            this.lblDrink.TabIndex = 22;
            this.lblDrink.Text = "Drink";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmount.Location = new System.Drawing.Point(-95, 154);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 20);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Amount";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(-95, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            // 
            // btnPrepare
            // 
            this.btnPrepare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.btnPrepare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrepare.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrepare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnPrepare.Location = new System.Drawing.Point(965, 240);
            this.btnPrepare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(148, 59);
            this.btnPrepare.TabIndex = 26;
            this.btnPrepare.Text = "Preparing";
            this.btnPrepare.UseVisualStyleBackColor = false;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReady.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnReady.Location = new System.Drawing.Point(965, 383);
            this.btnReady.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(148, 59);
            this.btnReady.TabIndex = 25;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.btnQueue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQueue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnQueue.Location = new System.Drawing.Point(965, 102);
            this.btnQueue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(148, 59);
            this.btnQueue.TabIndex = 24;
            this.btnQueue.Text = "In Queue";
            this.btnQueue.UseVisualStyleBackColor = false;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // liViewKitchen
            // 
            this.liViewKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.liViewKitchen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6});
            this.liViewKitchen.FullRowSelect = true;
            this.liViewKitchen.HideSelection = false;
            this.liViewKitchen.Location = new System.Drawing.Point(96, 113);
            this.liViewKitchen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.liViewKitchen.MultiSelect = false;
            this.liViewKitchen.Name = "liViewKitchen";
            this.liViewKitchen.Size = new System.Drawing.Size(757, 336);
            this.liViewKitchen.TabIndex = 23;
            this.liViewKitchen.UseCompatibleStateImageBehavior = false;
            this.liViewKitchen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Situtaion";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time";
            this.columnHeader6.Width = 128;
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.btnOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderDetails.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnOrderDetails.Location = new System.Drawing.Point(371, 470);
            this.btnOrderDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(148, 59);
            this.btnOrderDetails.TabIndex = 27;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = false;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // KitchenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 569);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnPrepare);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.liViewKitchen);
            this.Controls.Add(this.lblDrink);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KitchenPage";
            this.Text = "Kitchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.ListView liViewKitchen;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnOrderDetails;
    }
}