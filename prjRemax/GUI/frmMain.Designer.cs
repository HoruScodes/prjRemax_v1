namespace prjRemax.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.agentsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.houseTS = new System.Windows.Forms.ToolStripMenuItem();
            this.salesTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutTS = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTS = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTS = new System.Windows.Forms.ToolStripMenuItem();
            this.searchhouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchagentsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.searchTS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminsTS,
            this.agentsTS,
            this.clientsTS,
            this.houseTS,
            this.salesTS,
            this.toolStripSeparator1,
            this.logOutTS,
            this.exitTS});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // adminsTS
            // 
            this.adminsTS.Image = ((System.Drawing.Image)(resources.GetObject("adminsTS.Image")));
            this.adminsTS.Name = "adminsTS";
            this.adminsTS.Size = new System.Drawing.Size(224, 26);
            this.adminsTS.Text = "Administrators";
            this.adminsTS.Click += new System.EventHandler(this.adminsTS_Click);
            // 
            // agentsTS
            // 
            this.agentsTS.Image = ((System.Drawing.Image)(resources.GetObject("agentsTS.Image")));
            this.agentsTS.Name = "agentsTS";
            this.agentsTS.Size = new System.Drawing.Size(224, 26);
            this.agentsTS.Text = "Agents";
            this.agentsTS.Click += new System.EventHandler(this.agentsTS_Click);
            // 
            // clientsTS
            // 
            this.clientsTS.Image = ((System.Drawing.Image)(resources.GetObject("clientsTS.Image")));
            this.clientsTS.Name = "clientsTS";
            this.clientsTS.Size = new System.Drawing.Size(224, 26);
            this.clientsTS.Text = "Clients";
            this.clientsTS.Click += new System.EventHandler(this.clientsTS_Click);
            // 
            // houseTS
            // 
            this.houseTS.Image = ((System.Drawing.Image)(resources.GetObject("houseTS.Image")));
            this.houseTS.Name = "houseTS";
            this.houseTS.Size = new System.Drawing.Size(224, 26);
            this.houseTS.Text = "Houses";
            this.houseTS.Click += new System.EventHandler(this.houseTS_Click);
            // 
            // salesTS
            // 
            this.salesTS.Image = ((System.Drawing.Image)(resources.GetObject("salesTS.Image")));
            this.salesTS.Name = "salesTS";
            this.salesTS.Size = new System.Drawing.Size(224, 26);
            this.salesTS.Text = "Sales";
            this.salesTS.Click += new System.EventHandler(this.salesTS_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // logOutTS
            // 
            this.logOutTS.Image = ((System.Drawing.Image)(resources.GetObject("logOutTS.Image")));
            this.logOutTS.Name = "logOutTS";
            this.logOutTS.Size = new System.Drawing.Size(224, 26);
            this.logOutTS.Text = "Log Out";
            this.logOutTS.Click += new System.EventHandler(this.logOutTS_Click);
            // 
            // exitTS
            // 
            this.exitTS.Image = ((System.Drawing.Image)(resources.GetObject("exitTS.Image")));
            this.exitTS.Name = "exitTS";
            this.exitTS.Size = new System.Drawing.Size(224, 26);
            this.exitTS.Text = "Exit";
            this.exitTS.Click += new System.EventHandler(this.exitTS_Click);
            // 
            // searchTS
            // 
            this.searchTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchhouseToolStripMenuItem,
            this.searchagentsTS});
            this.searchTS.Name = "searchTS";
            this.searchTS.Size = new System.Drawing.Size(67, 24);
            this.searchTS.Text = "Search";
            // 
            // searchhouseToolStripMenuItem
            // 
            this.searchhouseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchhouseToolStripMenuItem.Image")));
            this.searchhouseToolStripMenuItem.Name = "searchhouseToolStripMenuItem";
            this.searchhouseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchhouseToolStripMenuItem.Text = "Houses";
            this.searchhouseToolStripMenuItem.Click += new System.EventHandler(this.searchhouseToolStripMenuItem_Click);
            // 
            // searchagentsTS
            // 
            this.searchagentsTS.Image = ((System.Drawing.Image)(resources.GetObject("searchagentsTS.Image")));
            this.searchagentsTS.Name = "searchagentsTS";
            this.searchagentsTS.Size = new System.Drawing.Size(224, 26);
            this.searchagentsTS.Text = "Agents";
            this.searchagentsTS.Click += new System.EventHandler(this.searchagentsTS_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminsTS;
        private System.Windows.Forms.ToolStripMenuItem agentsTS;
        private System.Windows.Forms.ToolStripMenuItem clientsTS;
        private System.Windows.Forms.ToolStripMenuItem houseTS;
        private System.Windows.Forms.ToolStripMenuItem salesTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logOutTS;
        private System.Windows.Forms.ToolStripMenuItem exitTS;
        private System.Windows.Forms.ToolStripMenuItem searchTS;
        private System.Windows.Forms.ToolStripMenuItem searchhouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchagentsTS;
    }
}