namespace BullTaxiProject11
{
    partial class MainOperatorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainOperatorForm));
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.FullSizeButton = new System.Windows.Forms.Button();
            this.TurnButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.SidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.SidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 1);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(53, 39);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 14;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // FullSizeButton
            // 
            this.FullSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullSizeButton.FlatAppearance.BorderSize = 0;
            this.FullSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullSizeButton.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullSizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.FullSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("FullSizeButton.Image")));
            this.FullSizeButton.Location = new System.Drawing.Point(1850, 4);
            this.FullSizeButton.Name = "FullSizeButton";
            this.FullSizeButton.Size = new System.Drawing.Size(35, 35);
            this.FullSizeButton.TabIndex = 13;
            this.FullSizeButton.UseVisualStyleBackColor = true;
            // 
            // TurnButton
            // 
            this.TurnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnButton.FlatAppearance.BorderSize = 0;
            this.TurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnButton.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.TurnButton.Location = new System.Drawing.Point(1804, 3);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(40, 40);
            this.TurnButton.TabIndex = 12;
            this.TurnButton.Text = "-";
            this.TurnButton.UseVisualStyleBackColor = true;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.CloseButton.Location = new System.Drawing.Point(1882, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuLabel.Location = new System.Drawing.Point(50, 8);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(133, 23);
            this.MenuLabel.TabIndex = 2;
            this.MenuLabel.Text = "Bull Taxi | Mеню";
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.SidebarPanel.Controls.Add(this.LogoPictureBox);
            this.SidebarPanel.Controls.Add(this.panel2);
            this.SidebarPanel.Controls.Add(this.panel5);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 43);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(199, 1177);
            this.SidebarPanel.TabIndex = 5;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(195, 132);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 7;
            this.LogoPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OrdersButton);
            this.panel2.Location = new System.Drawing.Point(3, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 47);
            this.panel2.TabIndex = 3;
            // 
            // OrdersButton
            // 
            this.OrdersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.OrdersButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersButton.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdersButton.Image")));
            this.OrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersButton.Location = new System.Drawing.Point(-5, -7);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.OrdersButton.Size = new System.Drawing.Size(203, 58);
            this.OrdersButton.TabIndex = 2;
            this.OrdersButton.Text = "        Замовлення";
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ExitButton);
            this.panel5.Location = new System.Drawing.Point(3, 194);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 47);
            this.panel5.TabIndex = 5;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(-4, -7);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ExitButton.Size = new System.Drawing.Size(202, 59);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "        Вихід";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.White;
            this.UpperPanel.Controls.Add(this.btnHam);
            this.UpperPanel.Controls.Add(this.FullSizeButton);
            this.UpperPanel.Controls.Add(this.TurnButton);
            this.UpperPanel.Controls.Add(this.CloseButton);
            this.UpperPanel.Controls.Add(this.MenuLabel);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1925, 43);
            this.UpperPanel.TabIndex = 4;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // MainOperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1925, 1220);
            this.ControlBox = false;
            this.Controls.Add(this.SidebarPanel);
            this.Controls.Add(this.UpperPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainOperatorForm";
            this.Text = "MainOperatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.SidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Button FullSizeButton;
        private System.Windows.Forms.Button TurnButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.FlowLayoutPanel SidebarPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}