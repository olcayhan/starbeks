namespace VisualProgrammingProject
{
    partial class ClientPage
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
            this.orderBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.OrderDetailsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderBtn
            // 
            this.orderBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderBtn.Location = new System.Drawing.Point(12, 428);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(407, 65);
            this.orderBtn.TabIndex = 0;
            this.orderBtn.Text = "Let\'s Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Welcome to Starbeks,";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLbl.Location = new System.Drawing.Point(273, 262);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(75, 27);
            this.NameLbl.TabIndex = 8;
            this.NameLbl.Text = "Name";
            this.NameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // OrderDetailsBtn
            // 
            this.OrderDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OrderDetailsBtn.Location = new System.Drawing.Point(12, 336);
            this.OrderDetailsBtn.Name = "OrderDetailsBtn";
            this.OrderDetailsBtn.Size = new System.Drawing.Size(407, 65);
            this.OrderDetailsBtn.TabIndex = 9;
            this.OrderDetailsBtn.Text = "Orders";
            this.OrderDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisualProgrammingProject.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(437, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OrderDetailsBtn);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderBtn);
            this.Name = "ClientPage";
            this.Text = "ClientPage";
            this.Load += new System.EventHandler(this.ClientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button OrderDetailsBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}