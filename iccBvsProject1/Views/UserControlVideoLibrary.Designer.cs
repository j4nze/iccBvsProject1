namespace iccBvsProject1.Views
{
    partial class UserControlVideoLibrary
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCreateVideoRecord = new System.Windows.Forms.Button();
            this.buttonVideoRetrieveAll = new System.Windows.Forms.Button();
            this.buttonVideoRetrieve = new System.Windows.Forms.Button();
            this.textBoxVideoId = new System.Windows.Forms.TextBox();
            this.textBoxVideoTitle = new System.Windows.Forms.TextBox();
            this.textBoxVideoDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerVideoReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVideoFormat = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxVideoSynopsis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonVideoUpdateRecord = new System.Windows.Forms.Button();
            this.buttonVideoDeleteButton = new System.Windows.Forms.Button();
            this.numericUpDownVideoTotalQty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVideoInQty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVideoOutQty = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxVideoSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewVideoLibrary = new System.Windows.Forms.DataGridView();
            this.comboBoxVideoSearchBy = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoTotalQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoInQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoOutQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideoLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = " VIDEO LIBRARY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewVideoLibrary);
            this.groupBox1.Controls.Add(this.comboBoxVideoSearchBy);
            this.groupBox1.Controls.Add(this.textBoxVideoSearch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.buttonVideoRetrieve);
            this.groupBox1.Controls.Add(this.buttonVideoRetrieveAll);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(132)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 319);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIST";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCreateVideoRecord);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonVideoDeleteButton);
            this.groupBox2.Controls.Add(this.textBoxVideoSynopsis);
            this.groupBox2.Controls.Add(this.buttonVideoUpdateRecord);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.comboBoxVideoFormat);
            this.groupBox2.Controls.Add(this.dateTimePickerVideoReleaseDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxVideoDirector);
            this.groupBox2.Controls.Add(this.textBoxVideoTitle);
            this.groupBox2.Controls.Add(this.textBoxVideoId);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(132)))));
            this.groupBox2.Location = new System.Drawing.Point(7, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 247);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETAILS";
            // 
            // buttonCreateVideoRecord
            // 
            this.buttonCreateVideoRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonCreateVideoRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateVideoRecord.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateVideoRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonCreateVideoRecord.Location = new System.Drawing.Point(836, 65);
            this.buttonCreateVideoRecord.Name = "buttonCreateVideoRecord";
            this.buttonCreateVideoRecord.Size = new System.Drawing.Size(130, 84);
            this.buttonCreateVideoRecord.TabIndex = 3;
            this.buttonCreateVideoRecord.Text = "Create \r\nNew \r\nRecord";
            this.buttonCreateVideoRecord.UseVisualStyleBackColor = false;
            // 
            // buttonVideoRetrieveAll
            // 
            this.buttonVideoRetrieveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonVideoRetrieveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoRetrieveAll.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideoRetrieveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonVideoRetrieveAll.Location = new System.Drawing.Point(810, 29);
            this.buttonVideoRetrieveAll.Name = "buttonVideoRetrieveAll";
            this.buttonVideoRetrieveAll.Size = new System.Drawing.Size(160, 30);
            this.buttonVideoRetrieveAll.TabIndex = 6;
            this.buttonVideoRetrieveAll.Text = "Display All";
            this.buttonVideoRetrieveAll.UseVisualStyleBackColor = false;
            // 
            // buttonVideoRetrieve
            // 
            this.buttonVideoRetrieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonVideoRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoRetrieve.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideoRetrieve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonVideoRetrieve.Location = new System.Drawing.Point(724, 29);
            this.buttonVideoRetrieve.Name = "buttonVideoRetrieve";
            this.buttonVideoRetrieve.Size = new System.Drawing.Size(80, 30);
            this.buttonVideoRetrieve.TabIndex = 6;
            this.buttonVideoRetrieve.Text = "Find";
            this.buttonVideoRetrieve.UseVisualStyleBackColor = false;
            // 
            // textBoxVideoId
            // 
            this.textBoxVideoId.Enabled = false;
            this.textBoxVideoId.Location = new System.Drawing.Point(118, 29);
            this.textBoxVideoId.Name = "textBoxVideoId";
            this.textBoxVideoId.Size = new System.Drawing.Size(391, 30);
            this.textBoxVideoId.TabIndex = 6;
            // 
            // textBoxVideoTitle
            // 
            this.textBoxVideoTitle.Location = new System.Drawing.Point(118, 65);
            this.textBoxVideoTitle.Name = "textBoxVideoTitle";
            this.textBoxVideoTitle.Size = new System.Drawing.Size(391, 30);
            this.textBoxVideoTitle.TabIndex = 7;
            // 
            // textBoxVideoDirector
            // 
            this.textBoxVideoDirector.Location = new System.Drawing.Point(118, 101);
            this.textBoxVideoDirector.Name = "textBoxVideoDirector";
            this.textBoxVideoDirector.Size = new System.Drawing.Size(391, 30);
            this.textBoxVideoDirector.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Director";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Release";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Format";
            // 
            // dateTimePickerVideoReleaseDate
            // 
            this.dateTimePickerVideoReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVideoReleaseDate.Location = new System.Drawing.Point(118, 137);
            this.dateTimePickerVideoReleaseDate.Name = "dateTimePickerVideoReleaseDate";
            this.dateTimePickerVideoReleaseDate.Size = new System.Drawing.Size(175, 30);
            this.dateTimePickerVideoReleaseDate.TabIndex = 20;
            // 
            // comboBoxVideoFormat
            // 
            this.comboBoxVideoFormat.FormattingEnabled = true;
            this.comboBoxVideoFormat.Items.AddRange(new object[] {
            "VCD",
            "DVD"});
            this.comboBoxVideoFormat.Location = new System.Drawing.Point(409, 137);
            this.comboBoxVideoFormat.Name = "comboBoxVideoFormat";
            this.comboBoxVideoFormat.Size = new System.Drawing.Size(100, 31);
            this.comboBoxVideoFormat.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownVideoOutQty);
            this.groupBox3.Controls.Add(this.numericUpDownVideoInQty);
            this.groupBox3.Controls.Add(this.numericUpDownVideoTotalQty);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(132)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 63);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total";
            // 
            // textBoxVideoSynopsis
            // 
            this.textBoxVideoSynopsis.Location = new System.Drawing.Point(515, 65);
            this.textBoxVideoSynopsis.Multiline = true;
            this.textBoxVideoSynopsis.Name = "textBoxVideoSynopsis";
            this.textBoxVideoSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxVideoSynopsis.Size = new System.Drawing.Size(315, 176);
            this.textBoxVideoSynopsis.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(515, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Synopsis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(199, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "In";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(345, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Out";
            // 
            // buttonVideoUpdateRecord
            // 
            this.buttonVideoUpdateRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonVideoUpdateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoUpdateRecord.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideoUpdateRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonVideoUpdateRecord.Location = new System.Drawing.Point(836, 155);
            this.buttonVideoUpdateRecord.Name = "buttonVideoUpdateRecord";
            this.buttonVideoUpdateRecord.Size = new System.Drawing.Size(130, 40);
            this.buttonVideoUpdateRecord.TabIndex = 7;
            this.buttonVideoUpdateRecord.Text = "Update";
            this.buttonVideoUpdateRecord.UseVisualStyleBackColor = false;
            // 
            // buttonVideoDeleteButton
            // 
            this.buttonVideoDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonVideoDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoDeleteButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideoDeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonVideoDeleteButton.Location = new System.Drawing.Point(836, 201);
            this.buttonVideoDeleteButton.Name = "buttonVideoDeleteButton";
            this.buttonVideoDeleteButton.Size = new System.Drawing.Size(130, 40);
            this.buttonVideoDeleteButton.TabIndex = 25;
            this.buttonVideoDeleteButton.Text = "Delete";
            this.buttonVideoDeleteButton.UseVisualStyleBackColor = false;
            // 
            // numericUpDownVideoTotalQty
            // 
            this.numericUpDownVideoTotalQty.Enabled = false;
            this.numericUpDownVideoTotalQty.Location = new System.Drawing.Point(82, 27);
            this.numericUpDownVideoTotalQty.Name = "numericUpDownVideoTotalQty";
            this.numericUpDownVideoTotalQty.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownVideoTotalQty.TabIndex = 30;
            // 
            // numericUpDownVideoInQty
            // 
            this.numericUpDownVideoInQty.Enabled = false;
            this.numericUpDownVideoInQty.Location = new System.Drawing.Point(239, 28);
            this.numericUpDownVideoInQty.Name = "numericUpDownVideoInQty";
            this.numericUpDownVideoInQty.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownVideoInQty.TabIndex = 31;
            // 
            // numericUpDownVideoOutQty
            // 
            this.numericUpDownVideoOutQty.Enabled = false;
            this.numericUpDownVideoOutQty.Location = new System.Drawing.Point(397, 27);
            this.numericUpDownVideoOutQty.Name = "numericUpDownVideoOutQty";
            this.numericUpDownVideoOutQty.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownVideoOutQty.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Search";
            // 
            // textBoxVideoSearch
            // 
            this.textBoxVideoSearch.Enabled = false;
            this.textBoxVideoSearch.Location = new System.Drawing.Point(270, 29);
            this.textBoxVideoSearch.Name = "textBoxVideoSearch";
            this.textBoxVideoSearch.Size = new System.Drawing.Size(448, 30);
            this.textBoxVideoSearch.TabIndex = 26;
            // 
            // dataGridViewVideoLibrary
            // 
            this.dataGridViewVideoLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVideoLibrary.Location = new System.Drawing.Point(6, 65);
            this.dataGridViewVideoLibrary.Name = "dataGridViewVideoLibrary";
            this.dataGridViewVideoLibrary.RowHeadersWidth = 51;
            this.dataGridViewVideoLibrary.RowTemplate.Height = 24;
            this.dataGridViewVideoLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVideoLibrary.Size = new System.Drawing.Size(964, 248);
            this.dataGridViewVideoLibrary.TabIndex = 27;
            // 
            // comboBoxVideoSearchBy
            // 
            this.comboBoxVideoSearchBy.FormattingEnabled = true;
            this.comboBoxVideoSearchBy.Items.AddRange(new object[] {
            "VCD",
            "DVD"});
            this.comboBoxVideoSearchBy.Location = new System.Drawing.Point(94, 28);
            this.comboBoxVideoSearchBy.Name = "comboBoxVideoSearchBy";
            this.comboBoxVideoSearchBy.Size = new System.Drawing.Size(170, 31);
            this.comboBoxVideoSearchBy.TabIndex = 26;
            this.comboBoxVideoSearchBy.Text = "by ID";
            // 
            // UserControlVideoLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlVideoLibrary";
            this.Size = new System.Drawing.Size(982, 653);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoTotalQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoInQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVideoOutQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideoLibrary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCreateVideoRecord;
        private System.Windows.Forms.Button buttonVideoRetrieve;
        private System.Windows.Forms.Button buttonVideoRetrieveAll;
        private System.Windows.Forms.TextBox textBoxVideoDirector;
        private System.Windows.Forms.TextBox textBoxVideoTitle;
        private System.Windows.Forms.TextBox textBoxVideoId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerVideoReleaseDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVideoSynopsis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxVideoFormat;
        private System.Windows.Forms.Button buttonVideoUpdateRecord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonVideoDeleteButton;
        private System.Windows.Forms.NumericUpDown numericUpDownVideoOutQty;
        private System.Windows.Forms.NumericUpDown numericUpDownVideoInQty;
        private System.Windows.Forms.NumericUpDown numericUpDownVideoTotalQty;
        private System.Windows.Forms.DataGridView dataGridViewVideoLibrary;
        private System.Windows.Forms.TextBox textBoxVideoSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxVideoSearchBy;
    }
}
