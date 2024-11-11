namespace iccBvsProject1.Views
{
    partial class UserControlDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRental = new System.Windows.Forms.DataGridView();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRetrieveAll = new System.Windows.Forms.Button();
            this.buttonRetrieveSpecific = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRental
            // 
            this.dataGridViewRental.AllowUserToAddRows = false;
            this.dataGridViewRental.AllowUserToDeleteRows = false;
            this.dataGridViewRental.AllowUserToOrderColumns = true;
            this.dataGridViewRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRental.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRental.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRental.Location = new System.Drawing.Point(23, 252);
            this.dataGridViewRental.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dataGridViewRental.Name = "dataGridViewRental";
            this.dataGridViewRental.ReadOnly = true;
            this.dataGridViewRental.RowHeadersWidth = 51;
            this.dataGridViewRental.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewRental.RowTemplate.Height = 24;
            this.dataGridViewRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRental.Size = new System.Drawing.Size(1457, 500);
            this.dataGridViewRental.TabIndex = 33;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "by Rental ID",
            "by Video Title",
            "by Customer Name"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(129, 207);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(250, 31);
            this.comboBoxSearchBy.TabIndex = 30;
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchValue.Location = new System.Drawing.Point(385, 207);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(733, 30);
            this.textBoxSearchValue.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 50);
            this.label11.TabIndex = 32;
            this.label11.Text = "Search";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRetrieveAll
            // 
            this.buttonRetrieveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonRetrieveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetrieveAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieveAll.ForeColor = System.Drawing.Color.White;
            this.buttonRetrieveAll.Location = new System.Drawing.Point(1280, 196);
            this.buttonRetrieveAll.Name = "buttonRetrieveAll";
            this.buttonRetrieveAll.Size = new System.Drawing.Size(200, 50);
            this.buttonRetrieveAll.TabIndex = 28;
            this.buttonRetrieveAll.Text = "Display All";
            this.buttonRetrieveAll.UseVisualStyleBackColor = false;
            // 
            // buttonRetrieveSpecific
            // 
            this.buttonRetrieveSpecific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonRetrieveSpecific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetrieveSpecific.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieveSpecific.ForeColor = System.Drawing.Color.White;
            this.buttonRetrieveSpecific.Location = new System.Drawing.Point(1124, 196);
            this.buttonRetrieveSpecific.Name = "buttonRetrieveSpecific";
            this.buttonRetrieveSpecific.Size = new System.Drawing.Size(150, 50);
            this.buttonRetrieveSpecific.TabIndex = 29;
            this.buttonRetrieveSpecific.Text = "Find";
            this.buttonRetrieveSpecific.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 48, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 150);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.panel2.Location = new System.Drawing.Point(324, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 48, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 150);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.panel3.Location = new System.Drawing.Point(1230, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 150);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.panel4.Location = new System.Drawing.Point(929, 23);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 48, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 150);
            this.panel4.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.panel5.Location = new System.Drawing.Point(625, 23);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 48, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 150);
            this.panel5.TabIndex = 35;
            // 
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewRental);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.textBoxSearchValue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonRetrieveAll);
            this.Controls.Add(this.buttonRetrieveSpecific);
            this.Name = "UserControlDashboard";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1503, 1175);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRental;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRetrieveAll;
        private System.Windows.Forms.Button buttonRetrieveSpecific;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
