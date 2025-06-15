namespace GymMS_Project1.Users
{
    partial class frmUsersList
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(332, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Users ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Controls.Add(this.txtUserSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.dgvUsersList);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users List";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Username",
            "First Name",
            "Last Name"});
            this.cbFilter.Location = new System.Drawing.Point(74, 38);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 25);
            this.cbFilter.TabIndex = 18;
            this.cbFilter.TextChanged += new System.EventHandler(this.cbFilter_TextChanged);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearch.Location = new System.Drawing.Point(209, 38);
            this.txtUserSearch.Multiline = true;
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(127, 25);
            this.txtUserSearch.TabIndex = 16;
            this.txtUserSearch.TextChanged += new System.EventHandler(this.txtUserSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filter By:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNew.Image = global::GymMS_Project1.Properties.Resources.plus;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(817, 28);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(105, 35);
            this.btnAddNew.TabIndex = 14;
            this.btnAddNew.Text = "AddNew";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUsersList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsersList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsersList.Location = new System.Drawing.Point(3, 72);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersVisible = false;
            this.dgvUsersList.Size = new System.Drawing.Size(922, 206);
            this.dgvUsersList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 254);
            // 
            // userDetailsToolStripMenuItem
            // 
            this.userDetailsToolStripMenuItem.Image = global::GymMS_Project1.Properties.Resources.UserDetails;
            this.userDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userDetailsToolStripMenuItem.Name = "userDetailsToolStripMenuItem";
            this.userDetailsToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.userDetailsToolStripMenuItem.Text = "User Details";
            this.userDetailsToolStripMenuItem.Click += new System.EventHandler(this.userDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::GymMS_Project1.Properties.Resources.UserEdit;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Image = global::GymMS_Project1.Properties.Resources.UserAdd;
            this.addNewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::GymMS_Project1.Properties.Resources.UserDelete;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.AutoSize = true;
            this.lblUsersCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersCount.Location = new System.Drawing.Point(30, 438);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(77, 17);
            this.lblUsersCount.TabIndex = 11;
            this.lblUsersCount.Text = "Total Users:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Image = global::GymMS_Project1.Properties.Resources.btnClose;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(846, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 476);
            this.Controls.Add(this.lblUsersCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 515);
            this.Name = "frmUsersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users List";
            this.Load += new System.EventHandler(this.frmUsersList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUsersCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label label2;
    }
}