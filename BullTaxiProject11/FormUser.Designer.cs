namespace BullTaxi
{
    partial class FormUser
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ViewButton = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.DriversMapButton = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.RegistrationButton);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 70);
            this.panel5.TabIndex = 7;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.RegistrationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegistrationButton.Location = new System.Drawing.Point(0, 0);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(220, 70);
            this.RegistrationButton.TabIndex = 0;
            this.RegistrationButton.Text = "Реєcтрація користувача";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChangeButton);
            this.panel1.Location = new System.Drawing.Point(238, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 70);
            this.panel1.TabIndex = 7;
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.ChangeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChangeButton.Location = new System.Drawing.Point(0, 0);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(220, 70);
            this.ChangeButton.TabIndex = 0;
            this.ChangeButton.Text = "Зміна даних користувача";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Location = new System.Drawing.Point(464, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 70);
            this.panel2.TabIndex = 7;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(0, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(220, 70);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Видалення користувача";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ViewButton);
            this.panel3.Location = new System.Drawing.Point(690, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 70);
            this.panel3.TabIndex = 7;
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewButton.Location = new System.Drawing.Point(0, 0);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(220, 70);
            this.ViewButton.TabIndex = 0;
            this.ViewButton.Text = "Показ користувачів";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.GridColor = System.Drawing.SystemColors.Control;
            this.Table.Location = new System.Drawing.Point(17, 125);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(1900, 950);
            this.Table.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.DriversMapButton);
            this.panel9.Location = new System.Drawing.Point(916, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(250, 70);
            this.panel9.TabIndex = 15;
            // 
            // DriversMapButton
            // 
            this.DriversMapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(124)))), ((int)(((byte)(142)))));
            this.DriversMapButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriversMapButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DriversMapButton.Location = new System.Drawing.Point(0, 0);
            this.DriversMapButton.Name = "DriversMapButton";
            this.DriversMapButton.Size = new System.Drawing.Size(250, 70);
            this.DriversMapButton.TabIndex = 0;
            this.DriversMapButton.Text = "Карта користувачів";
            this.DriversMapButton.UseVisualStyleBackColor = false;
            this.DriversMapButton.Click += new System.EventHandler(this.DriversMapButton_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1900, 1222);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.Table_Load);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button DriversMapButton;
    }
}