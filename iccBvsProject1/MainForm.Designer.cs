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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucRental = new iccBvsProject1.Views.UserControlRental();
            this.ucCustomerLib = new iccBvsProject1.Views.UserControlCustomerLibrary();
            this.ucVideoLib = new iccBvsProject1.Views.UserControlVideoLibrary();
            this.SidebarPanel.SuspendLayout();
            this.contextMenuStripLibrary.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(300, 653);
            this.SidebarPanel.TabIndex = 0;
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.ContextMenuStrip = this.contextMenuStripLibrary;
            this.buttonLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLibrary.FlatAppearance.BorderSize = 0;
            this.buttonLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibrary.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonLibrary.Location = new System.Drawing.Point(0, 350);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(300, 100);
            this.buttonLibrary.TabIndex = 5;
            this.buttonLibrary.Text = "Library >";
            this.buttonLibrary.UseVisualStyleBackColor = true;
            this.buttonLibrary.Click += new System.EventHandler(this.buttonLibrary_Click);
            // 
            // contextMenuStripLibrary
            // 
            this.contextMenuStripLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.contextMenuStripLibrary.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.contextMenuStripLibrary.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.contextMenuStripLibrary.Name = "contextMenuStrip1";
            this.contextMenuStripLibrary.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripLibrary.Size = new System.Drawing.Size(177, 60);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
            this.videoToolStripMenuItem.Text = "Video";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // buttonRental
            // 
            this.buttonRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRental.FlatAppearance.BorderSize = 0;
            this.buttonRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRental.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonRental.Location = new System.Drawing.Point(0, 250);
            this.buttonRental.Name = "buttonRental";
            this.buttonRental.Size = new System.Drawing.Size(300, 100);
            this.buttonRental.TabIndex = 4;
            this.buttonRental.Text = "Rental";
            this.buttonRental.UseVisualStyleBackColor = true;
            this.buttonRental.Click += new System.EventHandler(this.buttonRental_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonDashboard.Location = new System.Drawing.Point(0, 150);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(300, 100);
            this.buttonDashboard.TabIndex = 3;
            this.buttonDashboard.Text = "DASHBOARD";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonExitMainForm
            // 
            this.buttonExitMainForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExitMainForm.FlatAppearance.BorderSize = 0;
            this.buttonExitMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitMainForm.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitMainForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.buttonExitMainForm.Location = new System.Drawing.Point(0, 603);
            this.buttonExitMainForm.Name = "buttonExitMainForm";
            this.buttonExitMainForm.Size = new System.Drawing.Size(300, 50);
            this.buttonExitMainForm.TabIndex = 2;
            this.buttonExitMainForm.Text = "EXIT";
            this.buttonExitMainForm.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 150);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(303, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 550);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(306, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // ucRental
            // 
            this.ucRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ucRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRental.Location = new System.Drawing.Point(300, 0);
            this.ucRental.Name = "ucRental";
            this.ucRental.Size = new System.Drawing.Size(982, 653);
            this.ucRental.TabIndex = 3;
            // 
            // ucCustomerLib
            // 
            this.ucCustomerLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ucCustomerLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomerLib.Location = new System.Drawing.Point(300, 0);
            this.ucCustomerLib.Name = "ucCustomerLib";
            this.ucCustomerLib.Size = new System.Drawing.Size(982, 653);
            this.ucCustomerLib.TabIndex = 2;
            // 
            // ucVideoLib
            // 
            this.ucVideoLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ucVideoLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVideoLib.Location = new System.Drawing.Point(300, 0);
            this.ucVideoLib.Name = "ucVideoLib";
            this.ucVideoLib.Size = new System.Drawing.Size(982, 653);
            this.ucVideoLib.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.ucRental);
            this.Controls.Add(this.ucCustomerLib);
            this.Controls.Add(this.ucVideoLib);
            this.Controls.Add(this.SidebarPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BVS Management System";
            this.SidebarPanel.ResumeLayout(false);
            this.contextMenuStripLibrary.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExitMainForm;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Button buttonRental;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Views.UserControlVideoLibrary ucVideoLib;
        private Views.UserControlCustomerLibrary ucCustomerLib;
        private Views.UserControlRental ucRental;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLibrary;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
    }
}

