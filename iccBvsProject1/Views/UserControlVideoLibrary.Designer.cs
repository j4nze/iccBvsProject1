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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.buttonRetrieveSpecific = new System.Windows.Forms.Button();
            this.buttonRetrieveAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownRentPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRentLimit = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxSynopsis = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownOutQty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotalQty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownInQty = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSubmitNewQty = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownNewQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNewQtyOperation = new System.Windows.Forms.ComboBox();
            this.textBoxVideoIdNewIn = new System.Windows.Forms.TextBox();
            this.dataGridViewVideoLibrary = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentLimit)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInQty)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideoLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "by ID",
            "by Title"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(129, 34);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(200, 31);
            this.comboBoxSearchBy.TabIndex = 26;
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchValue.Location = new System.Drawing.Point(335, 34);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(542, 30);
            this.textBoxSearchValue.TabIndex = 26;
            // 
            // buttonRetrieveSpecific
            // 
            this.buttonRetrieveSpecific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonRetrieveSpecific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetrieveSpecific.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieveSpecific.ForeColor = System.Drawing.Color.White;
            this.buttonRetrieveSpecific.Location = new System.Drawing.Point(883, 23);
            this.buttonRetrieveSpecific.Name = "buttonRetrieveSpecific";
            this.buttonRetrieveSpecific.Size = new System.Drawing.Size(150, 50);
            this.buttonRetrieveSpecific.TabIndex = 6;
            this.buttonRetrieveSpecific.Text = "Find";
            this.buttonRetrieveSpecific.UseVisualStyleBackColor = false;
            this.buttonRetrieveSpecific.Click += new System.EventHandler(this.buttonVideoRetrieve_Click);
            // 
            // buttonRetrieveAll
            // 
            this.buttonRetrieveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonRetrieveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetrieveAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieveAll.ForeColor = System.Drawing.Color.White;
            this.buttonRetrieveAll.Location = new System.Drawing.Point(1042, 23);
            this.buttonRetrieveAll.Name = "buttonRetrieveAll";
            this.buttonRetrieveAll.Size = new System.Drawing.Size(200, 50);
            this.buttonRetrieveAll.TabIndex = 6;
            this.buttonRetrieveAll.Text = "Display All";
            this.buttonRetrieveAll.UseVisualStyleBackColor = false;
            this.buttonRetrieveAll.Click += new System.EventHandler(this.buttonVideoRetrieveAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.buttonCreate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.textBoxSynopsis);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dateTimePickerReleaseDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxDirector);
            this.groupBox2.Controls.Add(this.textBoxTitle);
            this.groupBox2.Controls.Add(this.textBoxId);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(23, 747);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(1219, 408);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETAILS";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.numericUpDownRentPrice);
            this.groupBox5.Controls.Add(this.numericUpDownRentLimit);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.comboBoxFormat);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(301, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox5.Size = new System.Drawing.Size(453, 226);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rental";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 33);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 50);
            this.label15.TabIndex = 34;
            this.label15.Text = "Rent Limit (Day/s)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownRentPrice
            // 
            this.numericUpDownRentPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRentPrice.Location = new System.Drawing.Point(240, 157);
            this.numericUpDownRentPrice.Name = "numericUpDownRentPrice";
            this.numericUpDownRentPrice.Size = new System.Drawing.Size(200, 30);
            this.numericUpDownRentPrice.TabIndex = 33;
            this.numericUpDownRentPrice.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numericUpDownRentLimit
            // 
            this.numericUpDownRentLimit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRentLimit.Location = new System.Drawing.Point(240, 47);
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
            this.numericUpDownRentLimit.Size = new System.Drawing.Size(200, 30);
            this.numericUpDownRentLimit.TabIndex = 35;
            this.numericUpDownRentLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 50);
            this.label14.TabIndex = 26;
            this.label14.Text = "Price";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Items.AddRange(new object[] {
            "VCD",
            "DVD"});
            this.comboBoxFormat.Location = new System.Drawing.Point(240, 101);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(200, 31);
            this.comboBoxFormat.TabIndex = 21;
            this.comboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideoFormat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 50);
            this.label6.TabIndex = 19;
            this.label6.Text = "Format";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Location = new System.Drawing.Point(1106, 199);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 61);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Register\r\nVideo";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreateVideoRecord_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(788, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 50);
            this.label8.TabIndex = 24;
            this.label8.Text = "Synopsis";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonDelete.Location = new System.Drawing.Point(1106, 322);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 50);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonVideoDeleteButton_Click);
            // 
            // textBoxSynopsis
            // 
            this.textBoxSynopsis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSynopsis.Location = new System.Drawing.Point(792, 199);
            this.textBoxSynopsis.Multiline = true;
            this.textBoxSynopsis.Name = "textBoxSynopsis";
            this.textBoxSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSynopsis.Size = new System.Drawing.Size(308, 173);
            this.textBoxSynopsis.TabIndex = 23;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(1106, 266);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 50);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonVideoUpdateRecord_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.numericUpDownOutQty);
            this.groupBox3.Controls.Add(this.numericUpDownTotalQty);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDownInQty);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(13, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(282, 226);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quantity";
            // 
            // numericUpDownOutQty
            // 
            this.numericUpDownOutQty.Enabled = false;
            this.numericUpDownOutQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownOutQty.Location = new System.Drawing.Point(119, 157);
            this.numericUpDownOutQty.Name = "numericUpDownOutQty";
            this.numericUpDownOutQty.Size = new System.Drawing.Size(150, 30);
            this.numericUpDownOutQty.TabIndex = 32;
            // 
            // numericUpDownTotalQty
            // 
            this.numericUpDownTotalQty.Enabled = false;
            this.numericUpDownTotalQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTotalQty.Location = new System.Drawing.Point(119, 47);
            this.numericUpDownTotalQty.Name = "numericUpDownTotalQty";
            this.numericUpDownTotalQty.Size = new System.Drawing.Size(150, 30);
            this.numericUpDownTotalQty.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 50);
            this.label10.TabIndex = 28;
            this.label10.Text = "Out";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 50);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownInQty
            // 
            this.numericUpDownInQty.Enabled = false;
            this.numericUpDownInQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownInQty.Location = new System.Drawing.Point(119, 102);
            this.numericUpDownInQty.Name = "numericUpDownInQty";
            this.numericUpDownInQty.Size = new System.Drawing.Size(150, 30);
            this.numericUpDownInQty.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 50);
            this.label9.TabIndex = 26;
            this.label9.Text = "In";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerReleaseDate
            // 
            this.dateTimePickerReleaseDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReleaseDate.Location = new System.Drawing.Point(944, 101);
            this.dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            this.dateTimePickerReleaseDate.Size = new System.Drawing.Size(262, 30);
            this.dateTimePickerReleaseDate.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(788, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 50);
            this.label5.TabIndex = 18;
            this.label5.Text = "Release Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(788, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 50);
            this.label4.TabIndex = 17;
            this.label4.Text = "Director";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 50);
            this.label3.TabIndex = 16;
            this.label3.Text = "Title";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 50);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirector.Location = new System.Drawing.Point(944, 46);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(262, 30);
            this.textBoxDirector.TabIndex = 8;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(169, 101);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(500, 30);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(169, 46);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(500, 30);
            this.textBoxId.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.buttonSubmitNewQty);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.numericUpDownNewQty);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.comboBoxNewQtyOperation);
            this.groupBox4.Controls.Add(this.textBoxVideoIdNewIn);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(23, 602);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(1219, 122);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "STOCK";
            // 
            // buttonSubmitNewQty
            // 
            this.buttonSubmitNewQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonSubmitNewQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitNewQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitNewQty.ForeColor = System.Drawing.Color.White;
            this.buttonSubmitNewQty.Location = new System.Drawing.Point(1056, 36);
            this.buttonSubmitNewQty.Name = "buttonSubmitNewQty";
            this.buttonSubmitNewQty.Size = new System.Drawing.Size(150, 50);
            this.buttonSubmitNewQty.TabIndex = 28;
            this.buttonSubmitNewQty.Text = "Submit";
            this.buttonSubmitNewQty.UseVisualStyleBackColor = false;
            this.buttonSubmitNewQty.Click += new System.EventHandler(this.buttonSubmitStockQtyOperation_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(804, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 50);
            this.label13.TabIndex = 27;
            this.label13.Text = "Qty";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(449, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 50);
            this.label12.TabIndex = 18;
            this.label12.Text = "Operation";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownNewQty
            // 
            this.numericUpDownNewQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNewQty.Location = new System.Drawing.Point(860, 44);
            this.numericUpDownNewQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNewQty.Name = "numericUpDownNewQty";
            this.numericUpDownNewQty.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownNewQty.TabIndex = 31;
            this.numericUpDownNewQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxNewQtyOperation
            // 
            this.comboBoxNewQtyOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewQtyOperation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNewQtyOperation.FormattingEnabled = true;
            this.comboBoxNewQtyOperation.Items.AddRange(new object[] {
            "Addition",
            "Subtraction"});
            this.comboBoxNewQtyOperation.Location = new System.Drawing.Point(605, 44);
            this.comboBoxNewQtyOperation.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.comboBoxNewQtyOperation.Name = "comboBoxNewQtyOperation";
            this.comboBoxNewQtyOperation.Size = new System.Drawing.Size(176, 31);
            this.comboBoxNewQtyOperation.TabIndex = 26;
            // 
            // textBoxVideoIdNewIn
            // 
            this.textBoxVideoIdNewIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVideoIdNewIn.Location = new System.Drawing.Point(69, 44);
            this.textBoxVideoIdNewIn.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.textBoxVideoIdNewIn.Name = "textBoxVideoIdNewIn";
            this.textBoxVideoIdNewIn.ReadOnly = true;
            this.textBoxVideoIdNewIn.Size = new System.Drawing.Size(357, 30);
            this.textBoxVideoIdNewIn.TabIndex = 16;
            // 
            // dataGridViewVideoLibrary
            // 
            this.dataGridViewVideoLibrary.AllowUserToAddRows = false;
            this.dataGridViewVideoLibrary.AllowUserToDeleteRows = false;
            this.dataGridViewVideoLibrary.AllowUserToOrderColumns = true;
            this.dataGridViewVideoLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewVideoLibrary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewVideoLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVideoLibrary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewVideoLibrary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVideoLibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVideoLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVideoLibrary.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVideoLibrary.Location = new System.Drawing.Point(23, 79);
            this.dataGridViewVideoLibrary.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dataGridViewVideoLibrary.MultiSelect = false;
            this.dataGridViewVideoLibrary.Name = "dataGridViewVideoLibrary";
            this.dataGridViewVideoLibrary.ReadOnly = true;
            this.dataGridViewVideoLibrary.RowHeadersWidth = 51;
            this.dataGridViewVideoLibrary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewVideoLibrary.RowTemplate.Height = 24;
            this.dataGridViewVideoLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVideoLibrary.Size = new System.Drawing.Size(1219, 500);
            this.dataGridViewVideoLibrary.TabIndex = 27;
            this.dataGridViewVideoLibrary.SelectionChanged += new System.EventHandler(this.dataGridViewVideoLibrary_SelectionChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 50);
            this.label11.TabIndex = 30;
            this.label11.Text = "Search";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlVideoLibrary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridViewVideoLibrary);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxSearchValue);
            this.Controls.Add(this.buttonRetrieveAll);
            this.Controls.Add(this.buttonRetrieveSpecific);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlVideoLibrary";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1282, 1175);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentLimit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInQty)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideoLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonRetrieveSpecific;
        private System.Windows.Forms.Button buttonRetrieveAll;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSynopsis;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSubmitNewQty;
        private System.Windows.Forms.NumericUpDown numericUpDownNewQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxNewQtyOperation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVideoIdNewIn;
        private System.Windows.Forms.NumericUpDown numericUpDownRentLimit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownRentPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownOutQty;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownInQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.DataGridView dataGridViewVideoLibrary;
        private System.Windows.Forms.Label label11;
    }
}
