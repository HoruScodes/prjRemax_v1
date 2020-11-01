namespace prjRemax.GUI
{
    partial class frmSearchAgent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAgentID = new System.Windows.Forms.ComboBox();
            this.chkAgentID = new System.Windows.Forms.CheckBox();
            this.GridAgent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAgentID);
            this.groupBox1.Controls.Add(this.chkAgentID);
            this.groupBox1.Location = new System.Drawing.Point(113, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // comboBoxAgentID
            // 
            this.comboBoxAgentID.FormattingEnabled = true;
            this.comboBoxAgentID.Location = new System.Drawing.Point(157, 39);
            this.comboBoxAgentID.Name = "comboBoxAgentID";
            this.comboBoxAgentID.Size = new System.Drawing.Size(192, 24);
            this.comboBoxAgentID.TabIndex = 3;
            this.comboBoxAgentID.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgentID_SelectedIndexChanged);
            // 
            // chkAgentID
            // 
            this.chkAgentID.AutoSize = true;
            this.chkAgentID.Location = new System.Drawing.Point(42, 41);
            this.chkAgentID.Name = "chkAgentID";
            this.chkAgentID.Size = new System.Drawing.Size(84, 21);
            this.chkAgentID.TabIndex = 1;
            this.chkAgentID.Text = "Agent ID";
            this.chkAgentID.UseVisualStyleBackColor = true;
            this.chkAgentID.CheckedChanged += new System.EventHandler(this.chkAgentID_CheckedChanged);
            //this.chkAgentID.CheckStateChanged += new System.EventHandler(this.chkAgentID_CheckStateChanged);
            // 
            // GridAgent
            // 
            this.GridAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAgent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.GridAgent.Location = new System.Drawing.Point(41, 176);
            this.GridAgent.Name = "GridAgent";
            this.GridAgent.RowHeadersWidth = 51;
            this.GridAgent.RowTemplate.Height = 24;
            this.GridAgent.Size = new System.Drawing.Size(719, 220);
            this.GridAgent.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Agent ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone Number";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // frmSearchAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridAgent);
            this.Name = "frmSearchAgent";
            this.Text = "frmSearchAgent";
            this.Load += new System.EventHandler(this.frmSearchAgent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAgent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxAgentID;
        private System.Windows.Forms.CheckBox chkAgentID;
        private System.Windows.Forms.DataGridView GridAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}