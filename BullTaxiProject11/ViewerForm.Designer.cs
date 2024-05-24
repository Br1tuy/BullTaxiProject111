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
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.panel10.Controls.Add(this.DevelopLabel);
            this.panel10.Controls.Add(this.TaxiNameLabel);
            this.panel10.Controls.Add(this.LogoPictureBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(300, 1150);
            this.panel10.TabIndex = 5;
            // 
            // DevelopLabel
            // 
            this.DevelopLabel.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevelopLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DevelopLabel.Location = new System.Drawing.Point(36, 1107);
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
            this.TaxiNameLabel.Location = new System.Drawing.Point(93, 204);
            this.TaxiNameLabel.Name = "TaxiNameLabel";
            this.TaxiNameLabel.Size = new System.Drawing.Size(125, 32);
            this.TaxiNameLabel.TabIndex = 2;
            this.TaxiNameLabel.Text = "Bull Taxi";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(63, 15);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(198, 191);
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
            this.CloseButton.Location = new System.Drawing.Point(1670, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
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
            this.TurnButton.Location = new System.Drawing.Point(1624, 0);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(40, 40);
            this.TurnButton.TabIndex = 13;
            this.TurnButton.Text = "-";
            this.TurnButton.UseVisualStyleBackColor = true;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 1150);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TurnButton);
            this.Controls.Add(this.panel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewerForm";
            this.Text = "ViewerForm";
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label DevelopLabel;
        private System.Windows.Forms.Label TaxiNameLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button TurnButton;
    }
}