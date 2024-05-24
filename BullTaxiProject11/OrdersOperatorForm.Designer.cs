namespace BullTaxiProject11
{
    partial class OrdersOperatorForm
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
            this.ActiveOrdersMapButton = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.ViewCompletedOrderButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ViewActiveOrderButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChangeActiveOrderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AddActiveOrderButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DriversMapButton = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.AddCompletedOrderButton = new System.Windows.Forms.Button();
            this.DeleteActiveOrderButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActiveOrdersMapButton
            // 
            this.ActiveOrdersMapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.ActiveOrdersMapButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveOrdersMapButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ActiveOrdersMapButton.Location = new System.Drawing.Point(0, 0);
            this.ActiveOrdersMapButton.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveOrdersMapButton.Name = "ActiveOrdersMapButton";
            this.ActiveOrdersMapButton.Size = new System.Drawing.Size(188, 57);
            this.ActiveOrdersMapButton.TabIndex = 0;
            this.ActiveOrdersMapButton.Text = "Карта активних замовлень";
            this.ActiveOrdersMapButton.UseVisualStyleBackColor = false;
            this.ActiveOrdersMapButton.Click += new System.EventHandler(this.ActiveOrdersMapButton_Click);
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(18, 162);
            this.Table.Margin = new System.Windows.Forms.Padding(2);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(1256, 762);
            this.Table.TabIndex = 23;
            // 
            // ViewCompletedOrderButton
            // 
            this.ViewCompletedOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.ViewCompletedOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewCompletedOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewCompletedOrderButton.Location = new System.Drawing.Point(0, 0);
            this.ViewCompletedOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewCompletedOrderButton.Name = "ViewCompletedOrderButton";
            this.ViewCompletedOrderButton.Size = new System.Drawing.Size(188, 57);
            this.ViewCompletedOrderButton.TabIndex = 0;
            this.ViewCompletedOrderButton.Text = "Показ завершених замовленнь";
            this.ViewCompletedOrderButton.UseVisualStyleBackColor = false;
            this.ViewCompletedOrderButton.Click += new System.EventHandler(this.ViewCompletedOrderButton_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ViewCompletedOrderButton);
            this.panel8.Location = new System.Drawing.Point(7, 72);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(186, 57);
            this.panel8.TabIndex = 22;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.ActiveOrdersMapButton);
            this.panel9.Location = new System.Drawing.Point(538, 10);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(188, 57);
            this.panel9.TabIndex = 20;
            // 
            // ViewActiveOrderButton
            // 
            this.ViewActiveOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.ViewActiveOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewActiveOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewActiveOrderButton.Location = new System.Drawing.Point(-2, 0);
            this.ViewActiveOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewActiveOrderButton.Name = "ViewActiveOrderButton";
            this.ViewActiveOrderButton.Size = new System.Drawing.Size(188, 57);
            this.ViewActiveOrderButton.TabIndex = 0;
            this.ViewActiveOrderButton.Text = "Показ активних замовленнь";
            this.ViewActiveOrderButton.UseVisualStyleBackColor = false;
            this.ViewActiveOrderButton.Click += new System.EventHandler(this.ViewActiveOrderButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ViewActiveOrderButton);
            this.panel3.Location = new System.Drawing.Point(9, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 57);
            this.panel3.TabIndex = 17;
            // 
            // ChangeActiveOrderButton
            // 
            this.ChangeActiveOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.ChangeActiveOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeActiveOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChangeActiveOrderButton.Location = new System.Drawing.Point(0, 0);
            this.ChangeActiveOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeActiveOrderButton.Name = "ChangeActiveOrderButton";
            this.ChangeActiveOrderButton.Size = new System.Drawing.Size(165, 57);
            this.ChangeActiveOrderButton.TabIndex = 0;
            this.ChangeActiveOrderButton.Text = "Змінити активне замовлення";
            this.ChangeActiveOrderButton.UseVisualStyleBackColor = false;
            this.ChangeActiveOrderButton.Click += new System.EventHandler(this.ChangeActiveOrderButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChangeActiveOrderButton);
            this.panel1.Location = new System.Drawing.Point(368, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 57);
            this.panel1.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.AddActiveOrderButton);
            this.panel5.Location = new System.Drawing.Point(199, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 57);
            this.panel5.TabIndex = 14;
            // 
            // AddActiveOrderButton
            // 
            this.AddActiveOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.AddActiveOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddActiveOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddActiveOrderButton.Location = new System.Drawing.Point(0, 0);
            this.AddActiveOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddActiveOrderButton.Name = "AddActiveOrderButton";
            this.AddActiveOrderButton.Size = new System.Drawing.Size(165, 57);
            this.AddActiveOrderButton.TabIndex = 0;
            this.AddActiveOrderButton.Text = "Додати активне замовлення";
            this.AddActiveOrderButton.UseVisualStyleBackColor = false;
            this.AddActiveOrderButton.Click += new System.EventHandler(this.AddActiveOrderButton_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DriversMapButton);
            this.panel7.Location = new System.Drawing.Point(538, 72);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(188, 57);
            this.panel7.TabIndex = 24;
            // 
            // DriversMapButton
            // 
            this.DriversMapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.DriversMapButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriversMapButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DriversMapButton.Location = new System.Drawing.Point(0, 0);
            this.DriversMapButton.Margin = new System.Windows.Forms.Padding(2);
            this.DriversMapButton.Name = "DriversMapButton";
            this.DriversMapButton.Size = new System.Drawing.Size(188, 57);
            this.DriversMapButton.TabIndex = 0;
            this.DriversMapButton.Text = "Карта таксистів";
            this.DriversMapButton.UseVisualStyleBackColor = false;
            this.DriversMapButton.Click += new System.EventHandler(this.DriversMapButton_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.AddCompletedOrderButton);
            this.panel10.Location = new System.Drawing.Point(199, 72);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(164, 57);
            this.panel10.TabIndex = 11;
            // 
            // AddCompletedOrderButton
            // 
            this.AddCompletedOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.AddCompletedOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCompletedOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddCompletedOrderButton.Location = new System.Drawing.Point(0, 0);
            this.AddCompletedOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddCompletedOrderButton.Name = "AddCompletedOrderButton";
            this.AddCompletedOrderButton.Size = new System.Drawing.Size(164, 57);
            this.AddCompletedOrderButton.TabIndex = 0;
            this.AddCompletedOrderButton.Text = "Додати завершене замовлення";
            this.AddCompletedOrderButton.UseVisualStyleBackColor = false;
            this.AddCompletedOrderButton.Click += new System.EventHandler(this.AddCompletedOrderButton_Click);
            // 
            // DeleteActiveOrderButton
            // 
            this.DeleteActiveOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.DeleteActiveOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteActiveOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteActiveOrderButton.Location = new System.Drawing.Point(0, 0);
            this.DeleteActiveOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteActiveOrderButton.Name = "DeleteActiveOrderButton";
            this.DeleteActiveOrderButton.Size = new System.Drawing.Size(164, 57);
            this.DeleteActiveOrderButton.TabIndex = 0;
            this.DeleteActiveOrderButton.Text = "Видалити активне замовлення";
            this.DeleteActiveOrderButton.UseVisualStyleBackColor = false;
            this.DeleteActiveOrderButton.Click += new System.EventHandler(this.DeleteActiveOrderButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DeleteActiveOrderButton);
            this.panel2.Location = new System.Drawing.Point(367, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 57);
            this.panel2.TabIndex = 15;
            // 
            // OrdersOperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.ControlBox = false;
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdersOperatorForm";
            this.Text = "OrdersOperatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActiveOrdersMapButton;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button ViewCompletedOrderButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button ViewActiveOrderButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ChangeActiveOrderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button AddActiveOrderButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button DriversMapButton;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button AddCompletedOrderButton;
        private System.Windows.Forms.Button DeleteActiveOrderButton;
        private System.Windows.Forms.Panel panel2;
    }
}