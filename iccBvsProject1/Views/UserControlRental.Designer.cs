namespace iccBvsProject1.Views
{
    partial class UserControlRental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRental = new System.Windows.Forms.DataGridView();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRetrieveSpecific = new System.Windows.Forms.Button();
            this.buttonRetrieveAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownOverdueDayCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOverduePrice = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRentalId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRentalDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxVideoTitle = new System.Windows.Forms.ComboBox();
            this.textBoxVideoId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVideoFormat = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownRentPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRentLimit = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.buttonRent = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOverdueDayCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOverduePrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRental
            // 
            this.dataGridViewRental.AllowUserToAddRows = false;
            this.dataGridViewRental.AllowUserToDeleteRows = false;
            this.dataGridViewRental.AllowUserToOrderColumns = true;
            this.dataGridViewRental.AllowUserToResizeColumns = false;
            this.dataGridViewRental.AllowUserToResizeRows = false;
            this.dataGridViewRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRental.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRental.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRental.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRental.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRental.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRental.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewRental.Location = new System.Drawing.Point(23, 79);
            this.dataGridViewRental.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.dataGridViewRental.MultiSelect = false;
            this.dataGridViewRental.Name = "dataGridViewRental";
            this.dataGridViewRental.ReadOnly = true;
            this.dataGridViewRental.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRental.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewRental.RowHeadersWidth = 51;
            this.dataGridViewRental.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewRental.RowTemplate.Height = 24;
            this.dataGridViewRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRental.Size = new System.Drawing.Size(1219, 500);
            this.dataGridViewRental.TabIndex = 27;
            this.dataGridViewRental.SelectionChanged += new System.EventHandler(this.dataGridViewRental_SelectionChanged);
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
            this.comboBoxSearchBy.Location = new System.Drawing.Point(129, 34);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(250, 31);
            this.comboBoxSearchBy.TabIndex = 26;
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchValue.Location = new System.Drawing.Point(395, 34);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(485, 30);
            this.textBoxSearchValue.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 50);
            this.label11.TabIndex = 26;
            this.label11.Text = "Search";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRetrieveSpecific
            // 
            this.buttonRetrieveSpecific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonRetrieveSpecific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetrieveSpecific.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieveSpecific.ForeColor = System.Drawing.Color.White;
            this.buttonRetrieveSpecific.Location = new System.Drawing.Point(886, 23);
            this.buttonRetrieveSpecific.Name = "buttonRetrieveSpecific";
            this.buttonRetrieveSpecific.Size = new System.Drawing.Size(150, 50);
            this.buttonRetrieveSpecific.TabIndex = 6;
            this.buttonRetrieveSpecific.Text = "Find";
            this.buttonRetrieveSpecific.UseVisualStyleBackColor = false;
            this.buttonRetrieveSpecific.Click += new System.EventHandler(this.buttonRetrieveSpecific_Click);
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
            this.buttonRetrieveAll.Click += new System.EventHandler(this.buttonRetrieveAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDownOverdueDayCount);
            this.groupBox2.Controls.Add(this.numericUpDownTotalPrice);
            this.groupBox2.Controls.Add(this.numericUpDownOverduePrice);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxStatus);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxRentalId);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePickerReturnDate);
            this.groupBox2.Controls.Add(this.dateTimePickerRentalDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxNotes);
            this.groupBox2.Controls.Add(this.buttonRent);
            this.groupBox2.Controls.Add(this.buttonReturn);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(23, 602);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(1219, 619);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETAILS";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 50);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownOverdueDayCount
            // 
            this.numericUpDownOverdueDayCount.Enabled = false;
            this.numericUpDownOverdueDayCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownOverdueDayCount.Location = new System.Drawing.Point(185, 509);
            this.numericUpDownOverdueDayCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownOverdueDayCount.Name = "numericUpDownOverdueDayCount";
            this.numericUpDownOverdueDayCount.Size = new System.Drawing.Size(150, 30);
            this.numericUpDownOverdueDayCount.TabIndex = 56;
            // 
            // numericUpDownTotalPrice
            // 
            this.numericUpDownTotalPrice.Enabled = false;
            this.numericUpDownTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTotalPrice.Location = new System.Drawing.Point(495, 509);
            this.numericUpDownTotalPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTotalPrice.Name = "numericUpDownTotalPrice";
            this.numericUpDownTotalPrice.Size = new System.Drawing.Size(150, 30);
            this.numericUpDownTotalPrice.TabIndex = 55;
            // 
            // numericUpDownOverduePrice
            // 
            this.numericUpDownOverduePrice.Enabled = false;
            this.numericUpDownOverduePrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownOverduePrice.Location = new System.Drawing.Point(185, 564);
            this.numericUpDownOverduePrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownOverduePrice.Name = "numericUpDownOverduePrice";
            this.numericUpDownOverduePrice.Size = new System.Drawing.Size(150, 30);
            this.numericUpDownOverduePrice.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 552);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(250, 50);
            this.label16.TabIndex = 54;
            this.label16.Text = "Overdue Price";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(389, 552);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 50);
            this.label13.TabIndex = 53;
            this.label13.Text = "Status";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Enabled = false;
            this.textBoxStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(495, 563);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(150, 30);
            this.textBoxStatus.TabIndex = 51;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 497);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 50);
            this.label12.TabIndex = 50;
            this.label12.Text = "Overdue Day/s";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 50);
            this.label10.TabIndex = 49;
            this.label10.Text = "Total";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRentalId
            // 
            this.textBoxRentalId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRentalId.Location = new System.Drawing.Point(119, 46);
            this.textBoxRentalId.Name = "textBoxRentalId";
            this.textBoxRentalId.ReadOnly = true;
            this.textBoxRentalId.Size = new System.Drawing.Size(1087, 30);
            this.textBoxRentalId.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.comboBoxCustomerName);
            this.groupBox3.Controls.Add(this.textBoxCustomerId);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(671, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(535, 171);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer";
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(119, 101);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(400, 31);
            this.comboBoxCustomerName.TabIndex = 42;
            this.comboBoxCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerName_SelectedIndexChanged);
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerId.Location = new System.Drawing.Point(119, 44);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.ReadOnly = true;
            this.textBoxCustomerId.Size = new System.Drawing.Size(400, 30);
            this.textBoxCustomerId.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 50);
            this.label4.TabIndex = 38;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 50);
            this.label7.TabIndex = 37;
            this.label7.Text = "ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 442);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 50);
            this.label9.TabIndex = 47;
            this.label9.Text = "Expected Return Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Enabled = false;
            this.dateTimePickerReturnDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(269, 450);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(376, 30);
            this.dateTimePickerReturnDate.TabIndex = 46;
            // 
            // dateTimePickerRentalDate
            // 
            this.dateTimePickerRentalDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRentalDate.Location = new System.Drawing.Point(269, 395);
            this.dateTimePickerRentalDate.Name = "dateTimePickerRentalDate";
            this.dateTimePickerRentalDate.Size = new System.Drawing.Size(376, 30);
            this.dateTimePickerRentalDate.TabIndex = 45;
            this.dateTimePickerRentalDate.ValueChanged += new System.EventHandler(this.dateTimePickerRentalDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 387);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 50);
            this.label8.TabIndex = 44;
            this.label8.Text = "Rental Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.comboBoxVideoTitle);
            this.groupBox5.Controls.Add(this.textBoxVideoId);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBoxVideoFormat);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.numericUpDownRentPrice);
            this.groupBox5.Controls.Add(this.numericUpDownRentLimit);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(13, 96);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox5.Size = new System.Drawing.Size(632, 281);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Video";
            // 
            // comboBoxVideoTitle
            // 
            this.comboBoxVideoTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVideoTitle.FormattingEnabled = true;
            this.comboBoxVideoTitle.Location = new System.Drawing.Point(219, 99);
            this.comboBoxVideoTitle.Name = "comboBoxVideoTitle";
            this.comboBoxVideoTitle.Size = new System.Drawing.Size(400, 31);
            this.comboBoxVideoTitle.TabIndex = 42;
            this.comboBoxVideoTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideoTitle_SelectedIndexChanged);
            this.comboBoxVideoTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxVideoTitle_KeyDown);
            this.comboBoxVideoTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxVideoTitle_KeyPress);
            this.comboBoxVideoTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxVideoTitle_KeyUp);
            // 
            // textBoxVideoId
            // 
            this.textBoxVideoId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVideoId.Location = new System.Drawing.Point(219, 44);
            this.textBoxVideoId.Name = "textBoxVideoId";
            this.textBoxVideoId.ReadOnly = true;
            this.textBoxVideoId.Size = new System.Drawing.Size(400, 30);
            this.textBoxVideoId.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 50);
            this.label3.TabIndex = 38;
            this.label3.Text = "Title";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxVideoFormat
            // 
            this.textBoxVideoFormat.Enabled = false;
            this.textBoxVideoFormat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVideoFormat.Location = new System.Drawing.Point(219, 154);
            this.textBoxVideoFormat.Name = "textBoxVideoFormat";
            this.textBoxVideoFormat.Size = new System.Drawing.Size(150, 30);
            this.textBoxVideoFormat.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 50);
            this.label15.TabIndex = 34;
            this.label15.Text = "Rent Limit (Day/s)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownRentPrice
            // 
            this.numericUpDownRentPrice.Enabled = false;
            this.numericUpDownRentPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRentPrice.Location = new System.Drawing.Point(469, 210);
            this.numericUpDownRentPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRentPrice.Name = "numericUpDownRentPrice";
            this.numericUpDownRentPrice.Size = new System.Drawing.Size(150, 30);
            this.numericUpDownRentPrice.TabIndex = 33;
            // 
            // numericUpDownRentLimit
            // 
            this.numericUpDownRentLimit.Enabled = false;
            this.numericUpDownRentLimit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRentLimit.Location = new System.Drawing.Point(219, 210);
            this.numericUpDownRentLimit.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRentLimit.Name = "numericUpDownRentLimit";
            this.numericUpDownRentLimit.Size = new System.Drawing.Size(150, 30);
            this.numericUpDownRentLimit.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(465, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 50);
            this.label14.TabIndex = 26;
            this.label14.Text = "Price";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 50);
            this.label6.TabIndex = 19;
            this.label6.Text = "Format";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(667, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 50);
            this.label5.TabIndex = 39;
            this.label5.Text = "Note/s";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotes.Location = new System.Drawing.Point(671, 344);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(399, 262);
            this.textBoxNotes.TabIndex = 38;
            // 
            // buttonRent
            // 
            this.buttonRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRent.ForeColor = System.Drawing.Color.White;
            this.buttonRent.Location = new System.Drawing.Point(1076, 500);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(130, 50);
            this.buttonRent.TabIndex = 3;
            this.buttonRent.Text = "Rent";
            this.buttonRent.UseVisualStyleBackColor = false;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(1076, 556);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(130, 50);
            this.buttonReturn.TabIndex = 25;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // UserControlRental
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewRental);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.textBoxSearchValue);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonRetrieveAll);
            this.Controls.Add(this.buttonRetrieveSpecific);
            this.Name = "UserControlRental";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1282, 1265);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOverdueDayCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOverduePrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRental;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRetrieveSpecific;
        private System.Windows.Forms.Button buttonRetrieveAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxRentalId;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownRentPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownRentLimit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVideoId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVideoFormat;
        private System.Windows.Forms.ComboBox comboBoxVideoTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerRentalDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownOverduePrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownOverdueDayCount;
        private System.Windows.Forms.Label label2;
    }
}
