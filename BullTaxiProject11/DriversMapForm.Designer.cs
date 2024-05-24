namespace BullTaxiProject11
{
    partial class DriversMapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriversMapForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SearhOnMapButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Table = new System.Windows.Forms.DataGridView();
            this.ViewDriverButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TurnButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1699, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 71);
            this.panel2.TabIndex = 34;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.LoginLabel.Location = new System.Drawing.Point(1771, 147);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(87, 32);
            this.LoginLabel.TabIndex = 31;
            this.LoginLabel.Text = "Логін";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.Login.Location = new System.Drawing.Point(55, 10);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(71, 26);
            this.Login.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // SearhOnMapButton
            // 
            this.SearhOnMapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.SearhOnMapButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearhOnMapButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearhOnMapButton.Location = new System.Drawing.Point(1695, 241);
            this.SearhOnMapButton.Name = "SearhOnMapButton";
            this.SearhOnMapButton.Size = new System.Drawing.Size(212, 71);
            this.SearhOnMapButton.TabIndex = 33;
            this.SearhOnMapButton.Text = "Показ на карті ";
            this.SearhOnMapButton.UseVisualStyleBackColor = false;
            this.SearhOnMapButton.Click += new System.EventHandler(this.SearhOnMapButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(1732, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 46);
            this.panel1.TabIndex = 32;
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(269, 49);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(318, 1144);
            this.Table.TabIndex = 30;
            // 
            // ViewDriverButton
            // 
            this.ViewDriverButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.ViewDriverButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewDriverButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewDriverButton.Location = new System.Drawing.Point(1695, 59);
            this.ViewDriverButton.Name = "ViewDriverButton";
            this.ViewDriverButton.Size = new System.Drawing.Size(203, 70);
            this.ViewDriverButton.TabIndex = 25;
            this.ViewDriverButton.Text = "Показ таксистів";
            this.ViewDriverButton.UseVisualStyleBackColor = false;
            this.ViewDriverButton.Click += new System.EventHandler(this.ViewDriverButton_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1703, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 70);
            this.panel3.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TurnButton);
            this.panel6.Controls.Add(this.CloseButton);
            this.panel6.Location = new System.Drawing.Point(2, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1905, 43);
            this.panel6.TabIndex = 27;
            this.panel6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDoubleClick);
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseUp);
            // 
            // TurnButton
            // 
            this.TurnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnButton.FlatAppearance.BorderSize = 0;
            this.TurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnButton.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.TurnButton.Location = new System.Drawing.Point(1816, 3);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(40, 40);
            this.TurnButton.TabIndex = 11;
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
            this.CloseButton.Location = new System.Drawing.Point(1862, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 1159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Develop by Br1tuy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(74, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bull Taxi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.pictureBox1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(267, 1222);
            this.panel10.TabIndex = 26;
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(654, 49);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 2;
            this.Map.MinZoom = 2;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(1031, 1144);
            this.Map.TabIndex = 28;
            this.Map.Zoom = 0D;
            // 
            // DriversMapForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1910, 1222);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.SearhOnMapButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.ViewDriverButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DriversMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriversMapForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button SearhOnMapButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button ViewDriverButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button TurnButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel10;
        private GMap.NET.WindowsForms.GMapControl Map;
    }
}