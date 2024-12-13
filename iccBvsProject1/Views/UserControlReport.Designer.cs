namespace iccBvsProject1.Views
{
    partial class UserControlReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cartesianChartRevenue = new LiveCharts.WinForms.CartesianChart();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRevenueFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRevenueToYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRevenueFromYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1241, 733);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cartesianChartRevenue);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonRevenueFilter);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxRevenueToYear);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBoxRevenueFromYear);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1215, 400);
            this.panel2.TabIndex = 0;
            // 
            // cartesianChartRevenue
            // 
            this.cartesianChartRevenue.Location = new System.Drawing.Point(214, 8);
            this.cartesianChartRevenue.Name = "cartesianChartRevenue";
            this.cartesianChartRevenue.Size = new System.Drawing.Size(991, 382);
            this.cartesianChartRevenue.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonRevenueFilter
            // 
            this.buttonRevenueFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.buttonRevenueFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRevenueFilter.ForeColor = System.Drawing.Color.White;
            this.buttonRevenueFilter.Location = new System.Drawing.Point(8, 227);
            this.buttonRevenueFilter.Name = "buttonRevenueFilter";
            this.buttonRevenueFilter.Size = new System.Drawing.Size(200, 36);
            this.buttonRevenueFilter.TabIndex = 4;
            this.buttonRevenueFilter.Text = "Filter";
            this.buttonRevenueFilter.UseVisualStyleBackColor = false;
            this.buttonRevenueFilter.Click += new System.EventHandler(this.buttonRevenueFilter_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxRevenueToYear
            // 
            this.comboBoxRevenueToYear.FormattingEnabled = true;
            this.comboBoxRevenueToYear.Location = new System.Drawing.Point(8, 185);
            this.comboBoxRevenueToYear.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.comboBoxRevenueToYear.Name = "comboBoxRevenueToYear";
            this.comboBoxRevenueToYear.Size = new System.Drawing.Size(200, 36);
            this.comboBoxRevenueToYear.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxRevenueFromYear
            // 
            this.comboBoxRevenueFromYear.FormattingEnabled = true;
            this.comboBoxRevenueFromYear.Location = new System.Drawing.Point(8, 100);
            this.comboBoxRevenueFromYear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.comboBoxRevenueFromYear.Name = "comboBoxRevenueFromYear";
            this.comboBoxRevenueFromYear.Size = new System.Drawing.Size(200, 36);
            this.comboBoxRevenueFromYear.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "REVENUE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlReport";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1261, 753);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRevenueFromYear;
        private System.Windows.Forms.Button buttonRevenueFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRevenueToYear;
        private System.Windows.Forms.Button button1;
        private LiveCharts.WinForms.CartesianChart cartesianChartRevenue;
        private System.Windows.Forms.Label label3;
    }
}
