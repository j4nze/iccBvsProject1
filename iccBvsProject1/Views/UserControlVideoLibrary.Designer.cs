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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewVideoLibrary = new System.Windows.Forms.DataGridView();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRetrieveSpecific = new System.Windows.Forms.Button();
            this.buttonRetrieveAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownRentLimit = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownRentPrice = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonVideoDeleteButton = new System.Windows.Forms.Button();
            this.textBoxSynopsis = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownOutQty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInQty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotalQty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.dateTimePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSubmitNewQty = new System.Windows.Forms.Button();
            this.numericUpDownNewInQty = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxNewInOperation = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVideoIdNewIn = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideoLibrary)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentPrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalQty)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewInQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewVideoLibrary);
            this.groupBox1.Controls.Add(this.comboBoxSearchBy);
            this.groupBox1.Controls.Add(this.textBoxSearchValue);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.buttonRetrieveSpecific);
            this.groupBox1.Controls.Add(this.buttonRetrieveAll);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(132)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 319);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIST";
            // 
            // dataGridViewVideoLibrary
            // 
            this.dataGridViewVideoLibrary.AllowUserToAddRows = false;
            this.dataGridViewVideoLibrary.AllowUserToDeleteRows = false;
            this.dataGridViewVideoLibrary.AllowUserToOrderColumns = true;
            this.dataGridViewVideoLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVideoLibrary.Location = new System.Drawing.Point(6, 65);
            this.dataGridViewVideoLibrary.Name = "dataGridViewVideoLibrary";
            this.dataGridViewVideoLibrary.ReadOnly = true;
            this.dataGridViewVideoLibrary.RowHeadersWidth = 51;
            this.dataGridViewVideoLibrary.RowTemplate.Height = 24;
            this.dataGridViewVideoLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVideoLibrary.Size = new System.Drawing.Size(964, 248);
            this.dataGridViewVideoLibrary.TabIndex = 27;
            this.dataGridViewVideoLibrary.SelectionChanged += new System.EventHandler(this.dataGridViewVideoLibrary_SelectionChanged);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "by ID",
            "by Title"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(94, 28);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(170, 30);
            this.comboBoxSearchBy.TabIndex = 26;
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchValue.Location = new System.Drawing.Point(270, 29);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(448, 30);
            this.textBoxSearchValue.TabIndex = 26;
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
            // buttonRetrieveSpecific
            // 
            this.buttonRetrieveSpecific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonRetrieveSpecific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetrieveSpecific.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieveSpecific.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonRetrieveSpecific.Location = new System.Drawing.Point(724, 29);
            this.buttonRetrieveSpecific.Name = "buttonRetrieveSpecific";
            this.buttonRetrieveSpecific.Size = new System.Drawing.Size(80, 30);
            this.buttonRetrieveSpecific.TabIndex = 6;
            this.buttonRetrieveSpecific.Text = "Find";
            this.buttonRetrieveSpecific.UseVisualStyleBackColor = false;
            this.buttonRetrieveSpecific.Click += new System.EventHandler(this.buttonVideoRetrieve_Click);
            // 
            // buttonRetrieveAll
            // 
            this.buttonRetrieveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonRetrieveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetrieveAll.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonRetrieveAll.Location = new System.Drawing.Point(810, 29);
            this.buttonRetrieveAll.Name = "buttonRetrieveAll";
            this.buttonRetrieveAll.Size = new System.Drawing.Size(160, 30);
            this.buttonRetrieveAll.TabIndex = 6;
            this.buttonRetrieveAll.Text = "Display All";
            this.buttonRetrieveAll.UseVisualStyleBackColor = false;
            this.buttonRetrieveAll.Click += new System.EventHandler(this.buttonVideoRetrieveAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownRentLimit);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.numericUpDownRentPrice);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.buttonCreate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonVideoDeleteButton);
            this.groupBox2.Controls.Add(this.textBoxSynopsis);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.comboBoxFormat);
            this.groupBox2.Controls.Add(this.dateTimePickerReleaseDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxDirector);
            this.groupBox2.Controls.Add(this.textBoxTitle);
            this.groupBox2.Controls.Add(this.textBoxId);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(132)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETAILS";
            // 
            // numericUpDownRentLimit
            // 
            this.numericUpDownRentLimit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRentLimit.Location = new System.Drawing.Point(238, 173);
            this.numericUpDownRentLimit.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRentLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRentLimit.Name = "numericUpDownRentLimit";
            this.numericUpDownRentLimit.Size = new System.Drawing.Size(271, 30);
            this.numericUpDownRentLimit.TabIndex = 35;
            this.numericUpDownRentLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 23);
            this.label15.TabIndex = 34;
            this.label15.Text = "Rent Limit (Day/s)";
            // 
            // numericUpDownRentPrice
            // 
            this.numericUpDownRentPrice.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRentPrice.Location = new System.Drawing.Point(118, 208);
            this.numericUpDownRentPrice.Name = "numericUpDownRentPrice";
            this.numericUpDownRentPrice.Size = new System.Drawing.Size(130, 30);
            this.numericUpDownRentPrice.TabIndex = 33;
            this.numericUpDownRentPrice.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 23);
            this.label14.TabIndex = 26;
            this.label14.Text = "Price";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonCreate.Location = new System.Drawing.Point(840, 65);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(130, 84);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create\r\nNew\r\nRecord";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreateVideoRecord_Click);
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
            // buttonVideoDeleteButton
            // 
            this.buttonVideoDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonVideoDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoDeleteButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideoDeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonVideoDeleteButton.Location = new System.Drawing.Point(840, 304);
            this.buttonVideoDeleteButton.Name = "buttonVideoDeleteButton";
            this.buttonVideoDeleteButton.Size = new System.Drawing.Size(130, 40);
            this.buttonVideoDeleteButton.TabIndex = 25;
            this.buttonVideoDeleteButton.Text = "Delete";
            this.buttonVideoDeleteButton.UseVisualStyleBackColor = false;
            this.buttonVideoDeleteButton.Click += new System.EventHandler(this.buttonVideoDeleteButton_Click);
            // 
            // textBoxSynopsis
            // 
            this.textBoxSynopsis.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSynopsis.Location = new System.Drawing.Point(515, 65);
            this.textBoxSynopsis.Multiline = true;
            this.textBoxSynopsis.Name = "textBoxSynopsis";
            this.textBoxSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSynopsis.Size = new System.Drawing.Size(319, 279);
            this.textBoxSynopsis.TabIndex = 23;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonUpdate.Location = new System.Drawing.Point(840, 258);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(130, 40);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonVideoUpdateRecord_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownOutQty);
            this.groupBox3.Controls.Add(this.numericUpDownInQty);
            this.groupBox3.Controls.Add(this.numericUpDownTotalQty);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(132)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 63);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quantity";
            // 
            // numericUpDownOutQty
            // 
            this.numericUpDownOutQty.Enabled = false;
            this.numericUpDownOutQty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownOutQty.Location = new System.Drawing.Point(397, 27);
            this.numericUpDownOutQty.Name = "numericUpDownOutQty";
            this.numericUpDownOutQty.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownOutQty.TabIndex = 32;
            // 
            // numericUpDownInQty
            // 
            this.numericUpDownInQty.Enabled = false;
            this.numericUpDownInQty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownInQty.Location = new System.Drawing.Point(239, 28);
            this.numericUpDownInQty.Name = "numericUpDownInQty";
            this.numericUpDownInQty.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownInQty.TabIndex = 31;
            // 
            // numericUpDownTotalQty
            // 
            this.numericUpDownTotalQty.Enabled = false;
            this.numericUpDownTotalQty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTotalQty.Location = new System.Drawing.Point(82, 27);
            this.numericUpDownTotalQty.Name = "numericUpDownTotalQty";
            this.numericUpDownTotalQty.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownTotalQty.TabIndex = 30;
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
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Items.AddRange(new object[] {
            "VCD",
            "DVD"});
            this.comboBoxFormat.Location = new System.Drawing.Point(379, 209);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(130, 30);
            this.comboBoxFormat.TabIndex = 21;
            this.comboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideoFormat_SelectedIndexChanged);
            // 
            // dateTimePickerReleaseDate
            // 
            this.dateTimePickerReleaseDate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReleaseDate.Location = new System.Drawing.Point(166, 137);
            this.dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            this.dateTimePickerReleaseDate.Size = new System.Drawing.Size(343, 30);
            this.dateTimePickerReleaseDate.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Release Date";
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
            // textBoxDirector
            // 
            this.textBoxDirector.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirector.Location = new System.Drawing.Point(118, 101);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(391, 30);
            this.textBoxDirector.TabIndex = 8;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(118, 65);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(391, 30);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(118, 29);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(391, 30);
            this.textBoxId.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSubmitNewQty);
            this.groupBox4.Controls.Add(this.numericUpDownNewInQty);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.comboBoxNewInOperation);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxVideoIdNewIn);
            this.groupBox4.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(132)))));
            this.groupBox4.Location = new System.Drawing.Point(3, 381);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(976, 68);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "STOCK";
            // 
            // buttonSubmitNewQty
            // 
            this.buttonSubmitNewQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonSubmitNewQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitNewQty.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitNewQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonSubmitNewQty.Location = new System.Drawing.Point(880, 32);
            this.buttonSubmitNewQty.Name = "buttonSubmitNewQty";
            this.buttonSubmitNewQty.Size = new System.Drawing.Size(90, 30);
            this.buttonSubmitNewQty.TabIndex = 28;
            this.buttonSubmitNewQty.Text = "Submit";
            this.buttonSubmitNewQty.UseVisualStyleBackColor = false;
            this.buttonSubmitNewQty.Click += new System.EventHandler(this.buttonSubmitStockQtyOperation_Click);
            // 
            // numericUpDownNewInQty
            // 
            this.numericUpDownNewInQty.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNewInQty.Location = new System.Drawing.Point(763, 32);
            this.numericUpDownNewInQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNewInQty.Name = "numericUpDownNewInQty";
            this.numericUpDownNewInQty.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownNewInQty.TabIndex = 31;
            this.numericUpDownNewInQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(711, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "Qty";
            // 
            // comboBoxNewInOperation
            // 
            this.comboBoxNewInOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewInOperation.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNewInOperation.FormattingEnabled = true;
            this.comboBoxNewInOperation.Items.AddRange(new object[] {
            "Addition",
            "Subtraction"});
            this.comboBoxNewInOperation.Location = new System.Drawing.Point(529, 32);
            this.comboBoxNewInOperation.Name = "comboBoxNewInOperation";
            this.comboBoxNewInOperation.Size = new System.Drawing.Size(176, 30);
            this.comboBoxNewInOperation.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(405, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 23);
            this.label12.TabIndex = 18;
            this.label12.Text = "Operation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // textBoxVideoIdNewIn
            // 
            this.textBoxVideoIdNewIn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVideoIdNewIn.Location = new System.Drawing.Point(46, 32);
            this.textBoxVideoIdNewIn.Name = "textBoxVideoIdNewIn";
            this.textBoxVideoIdNewIn.ReadOnly = true;
            this.textBoxVideoIdNewIn.Size = new System.Drawing.Size(350, 30);
            this.textBoxVideoIdNewIn.TabIndex = 16;
            // 
            // UserControlVideoLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlVideoLibrary";
            this.Size = new System.Drawing.Size(982, 799);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideoLibrary)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentPrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalQty)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewInQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonRetrieveSpecific;
        private System.Windows.Forms.Button buttonRetrieveAll;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSynopsis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonVideoDeleteButton;
        private System.Windows.Forms.NumericUpDown numericUpDownOutQty;
        private System.Windows.Forms.NumericUpDown numericUpDownInQty;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalQty;
        private System.Windows.Forms.DataGridView dataGridViewVideoLibrary;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSubmitNewQty;
        private System.Windows.Forms.NumericUpDown numericUpDownNewInQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxNewInOperation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVideoIdNewIn;
        private System.Windows.Forms.NumericUpDown numericUpDownRentLimit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownRentPrice;
        private System.Windows.Forms.Label label14;
    }
}
