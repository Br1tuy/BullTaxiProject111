namespace BullTaxiProject11
{
    partial class ViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.panel10 = new System.Windows.Forms.Panel();
            this.DevelopLabel = new System.Windows.Forms.Label();
            this.TaxiNameLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TurnButton = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ViewCompletedOrderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FullSizeButton = new System.Windows.Forms.Button();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Controls.Add(this.DevelopLabel);
            this.panel10.Controls.Add(this.TaxiNameLabel);
            this.panel10.Controls.Add(this.LogoPictureBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(300, 1194);
            this.panel10.TabIndex = 5;
            // 
            // DevelopLabel
            // 
            this.DevelopLabel.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevelopLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DevelopLabel.Location = new System.Drawing.Point(35, 1160);
            this.DevelopLabel.Name = "DevelopLabel";
            this.DevelopLabel.Size = new System.Drawing.Size(225, 34);
            this.DevelopLabel.TabIndex = 3;
            this.DevelopLabel.Text = "Develop by Br1tuy";
            // 
            // TaxiNameLabel
            // 
            this.TaxiNameLabel.AutoSize = true;
            this.TaxiNameLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxiNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TaxiNameLabel.Location = new System.Drawing.Point(74, 200);
            this.TaxiNameLabel.Name = "TaxiNameLabel";
            this.TaxiNameLabel.Size = new System.Drawing.Size(125, 32);
            this.TaxiNameLabel.TabIndex = 2;
            this.TaxiNameLabel.Text = "Bull Taxi";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(44, 11);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(197, 191);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.CloseButton.Location = new System.Drawing.Point(1883, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 39);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TurnButton
            // 
            this.TurnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnButton.FlatAppearance.BorderSize = 0;
            this.TurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnButton.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.TurnButton.Location = new System.Drawing.Point(1803, 0);
            this.TurnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(40, 39);
            this.TurnButton.TabIndex = 13;
            this.TurnButton.Text = "-";
            this.TurnButton.UseVisualStyleBackColor = true;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(317, 137);
            this.Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(1595, 1046);
            this.Table.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ViewCompletedOrderButton);
            this.panel3.Location = new System.Drawing.Point(317, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 70);
            this.panel3.TabIndex = 15;
            // 
            // ViewCompletedOrderButton
            // 
            this.ViewCompletedOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.ViewCompletedOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewCompletedOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewCompletedOrderButton.Location = new System.Drawing.Point(-3, 0);
            this.ViewCompletedOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewCompletedOrderButton.Name = "ViewCompletedOrderButton";
            this.ViewCompletedOrderButton.Size = new System.Drawing.Size(251, 70);
            this.ViewCompletedOrderButton.TabIndex = 0;
            this.ViewCompletedOrderButton.Text = "Показ завершених замовленнь";
            this.ViewCompletedOrderButton.UseVisualStyleBackColor = false;
            this.ViewCompletedOrderButton.Click += new System.EventHandler(this.ViewCompletedOrderButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1923, 43);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bull Taxi | Mеню";
            // 
            // FullSizeButton
            // 
            this.FullSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullSizeButton.FlatAppearance.BorderSize = 0;
            this.FullSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullSizeButton.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullSizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.FullSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("FullSizeButton.Image")));
            this.FullSizeButton.Location = new System.Drawing.Point(1842, 5);
            this.FullSizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullSizeButton.Name = "FullSizeButton";
            this.FullSizeButton.Size = new System.Drawing.Size(35, 34);
            this.FullSizeButton.TabIndex = 16;
            this.FullSizeButton.UseVisualStyleBackColor = true;
            this.FullSizeButton.Click += new System.EventHandler(this.FullSizeButton_Click);
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1194);
            this.Controls.Add(this.FullSizeButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TurnButton);
            this.Controls.Add(this.panel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label DevelopLabel;
        private System.Windows.Forms.Label TaxiNameLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button TurnButton;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ViewCompletedOrderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FullSizeButton;
    }
}