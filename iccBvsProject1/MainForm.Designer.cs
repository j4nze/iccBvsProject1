namespace iccBvsProject1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.contextMenuStripLibrary = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRental = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonExitMainForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSectionHeader = new System.Windows.Forms.Label();
            this.ucDashboard = new iccBvsProject1.Views.UserControlDashboard();
            this.ucRental = new iccBvsProject1.Views.UserControlRental();
            this.ucCustomerLibrary = new iccBvsProject1.Views.UserControlCustomerLibrary();
            this.ucVideoLibrary = new iccBvsProject1.Views.UserControlVideoLibrary();
            this.SidebarPanel.SuspendLayout();
            this.contextMenuStripLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.SidebarPanel.Controls.Add(this.buttonLibrary);
            this.SidebarPanel.Controls.Add(this.buttonRental);
            this.SidebarPanel.Controls.Add(this.buttonDashboard);
            this.SidebarPanel.Controls.Add(this.buttonExitMainForm);
            this.SidebarPanel.Controls.Add(this.panel1);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(400, 853);
            this.SidebarPanel.TabIndex = 0;
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.ContextMenuStrip = this.contextMenuStripLibrary;
            this.buttonLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLibrary.FlatAppearance.BorderSize = 0;
            this.buttonLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibrary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibrary.ForeColor = System.Drawing.Color.White;
            this.buttonLibrary.Location = new System.Drawing.Point(0, 504);
            this.buttonLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Padding = new System.Windows.Forms.Padding(69, 0, 0, 0);
            this.buttonLibrary.Size = new System.Drawing.Size(400, 144);
            this.buttonLibrary.TabIndex = 5;
            this.buttonLibrary.Text = "LIBRARY";
            this.buttonLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLibrary.UseVisualStyleBackColor = true;
            this.buttonLibrary.Click += new System.EventHandler(this.buttonLibrary_Click);
            // 
            // contextMenuStripLibrary
            // 
            this.contextMenuStripLibrary.AutoSize = false;
            this.contextMenuStripLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.contextMenuStripLibrary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripLibrary.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.contextMenuStripLibrary.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStripLibrary.Name = "contextMenuStrip1";
            this.contextMenuStripLibrary.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripLibrary.ShowImageMargin = false;
            this.contextMenuStripLibrary.Size = new System.Drawing.Size(200, 105);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.AutoSize = false;
            this.videoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.videoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(200, 50);
            this.videoToolStripMenuItem.Text = "VIDEO";
            this.videoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.videoToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.AutoSize = false;
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(200, 50);
            this.customerToolStripMenuItem.Text = "CUSTOMER";
            this.customerToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // buttonRental
            // 
            this.buttonRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRental.FlatAppearance.BorderSize = 0;
            this.buttonRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRental.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRental.ForeColor = System.Drawing.Color.White;
            this.buttonRental.Location = new System.Drawing.Point(0, 360);
            this.buttonRental.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRental.Name = "buttonRental";
            this.buttonRental.Padding = new System.Windows.Forms.Padding(69, 0, 0, 0);
            this.buttonRental.Size = new System.Drawing.Size(400, 144);
            this.buttonRental.TabIndex = 4;
            this.buttonRental.Text = "RENTAL";
            this.buttonRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRental.UseVisualStyleBackColor = true;
            this.buttonRental.Click += new System.EventHandler(this.buttonRental_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 216);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(69, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(400, 144);
            this.buttonDashboard.TabIndex = 3;
            this.buttonDashboard.Text = "DASHBOARD";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonExitMainForm
            // 
            this.buttonExitMainForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExitMainForm.FlatAppearance.BorderSize = 0;
            this.buttonExitMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitMainForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitMainForm.ForeColor = System.Drawing.Color.White;
            this.buttonExitMainForm.Location = new System.Drawing.Point(0, 709);
            this.buttonExitMainForm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitMainForm.Name = "buttonExitMainForm";
            this.buttonExitMainForm.Padding = new System.Windows.Forms.Padding(69, 0, 0, 0);
            this.buttonExitMainForm.Size = new System.Drawing.Size(400, 144);
            this.buttonExitMainForm.TabIndex = 2;
            this.buttonExitMainForm.Text = "EXIT";
            this.buttonExitMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExitMainForm.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 216);
            this.panel1.TabIndex = 1;
            // 
            // labelSectionHeader
            // 
            this.labelSectionHeader.BackColor = System.Drawing.Color.White;
            this.labelSectionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSectionHeader.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.labelSectionHeader.Location = new System.Drawing.Point(400, 0);
            this.labelSectionHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSectionHeader.Name = "labelSectionHeader";
            this.labelSectionHeader.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.labelSectionHeader.Size = new System.Drawing.Size(1282, 108);
            this.labelSectionHeader.TabIndex = 2;
            this.labelSectionHeader.Text = "Header";
            this.labelSectionHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucDashboard
            // 
            this.ucDashboard.AutoScroll = true;
            this.ucDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucDashboard.BackColor = System.Drawing.Color.White;
            this.ucDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDashboard.Location = new System.Drawing.Point(400, 108);
            this.ucDashboard.Margin = new System.Windows.Forms.Padding(6);
            this.ucDashboard.Name = "ucDashboard";
            this.ucDashboard.Padding = new System.Windows.Forms.Padding(20);
            this.ucDashboard.Size = new System.Drawing.Size(1282, 745);
            this.ucDashboard.TabIndex = 6;
            // 
            // ucRental
            // 
            this.ucRental.AutoScroll = true;
            this.ucRental.AutoSize = true;
            this.ucRental.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucRental.BackColor = System.Drawing.Color.White;
            this.ucRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRental.Location = new System.Drawing.Point(400, 108);
            this.ucRental.Margin = new System.Windows.Forms.Padding(4);
            this.ucRental.Name = "ucRental";
            this.ucRental.Padding = new System.Windows.Forms.Padding(28, 29, 28, 29);
            this.ucRental.Size = new System.Drawing.Size(1282, 745);
            this.ucRental.TabIndex = 5;
            this.ucRental.UCV = null;
            // 
            // ucCustomerLibrary
            // 
            this.ucCustomerLibrary.AutoScroll = true;
            this.ucCustomerLibrary.AutoSize = true;
            this.ucCustomerLibrary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucCustomerLibrary.BackColor = System.Drawing.Color.White;
            this.ucCustomerLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomerLibrary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCustomerLibrary.Location = new System.Drawing.Point(400, 108);
            this.ucCustomerLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.ucCustomerLibrary.Name = "ucCustomerLibrary";
            this.ucCustomerLibrary.Padding = new System.Windows.Forms.Padding(28, 29, 28, 29);
            this.ucCustomerLibrary.Size = new System.Drawing.Size(1282, 745);
            this.ucCustomerLibrary.TabIndex = 4;
            this.ucCustomerLibrary.UCR = null;
            // 
            // ucVideoLibrary
            // 
            this.ucVideoLibrary.AutoScroll = true;
            this.ucVideoLibrary.AutoSize = true;
            this.ucVideoLibrary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucVideoLibrary.BackColor = System.Drawing.Color.White;
            this.ucVideoLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVideoLibrary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucVideoLibrary.Location = new System.Drawing.Point(400, 108);
            this.ucVideoLibrary.Margin = new System.Windows.Forms.Padding(6);
            this.ucVideoLibrary.Name = "ucVideoLibrary";
            this.ucVideoLibrary.Padding = new System.Windows.Forms.Padding(28, 29, 28, 29);
            this.ucVideoLibrary.Size = new System.Drawing.Size(1282, 745);
            this.ucVideoLibrary.TabIndex = 3;
            this.ucVideoLibrary.UCR = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1682, 853);
            this.Controls.Add(this.ucDashboard);
            this.Controls.Add(this.ucRental);
            this.Controls.Add(this.ucCustomerLibrary);
            this.Controls.Add(this.ucVideoLibrary);
            this.Controls.Add(this.labelSectionHeader);
            this.Controls.Add(this.SidebarPanel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BVS Management System";
            this.SidebarPanel.ResumeLayout(false);
            this.contextMenuStripLibrary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExitMainForm;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Button buttonRental;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLibrary;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.Label labelSectionHeader;
        private Views.UserControlVideoLibrary ucVideoLibrary;
        private Views.UserControlCustomerLibrary ucCustomerLibrary;
        private Views.UserControlRental ucRental;
        private Views.UserControlDashboard ucDashboard;
    }
}

