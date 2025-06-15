namespace GymMS_Project1.Members
{
    partial class frmMembersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsDataGridOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteMember = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSendSMS = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvMembersList = new System.Windows.Forms.DataGridView();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmsDataGridOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDataGridOptions
            // 
            this.cmsDataGridOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDataGridOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewDetails,
            this.toolStripMenuItem1,
            this.tsmiUpdateMember,
            this.tsmiAddNew,
            this.tsmiDeleteMember,
            this.toolStripMenuItem2,
            this.tsmiSendEmail,
            this.tsmiSendSMS});
            this.cmsDataGridOptions.Name = "contextMenuStrip1";
            this.cmsDataGridOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsDataGridOptions.Size = new System.Drawing.Size(213, 362);
            // 
            // tsmiViewDetails
            // 
            this.tsmiViewDetails.Image = global::GymMS_Project1.Properties.Resources.personInfo;
            this.tsmiViewDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiViewDetails.Name = "tsmiViewDetails";
            this.tsmiViewDetails.Size = new System.Drawing.Size(212, 54);
            this.tsmiViewDetails.Text = "View Details";
            this.tsmiViewDetails.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
            // 
            // tsmiUpdateMember
            // 
            this.tsmiUpdateMember.Image = global::GymMS_Project1.Properties.Resources.Edit_Member;
            this.tsmiUpdateMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUpdateMember.Name = "tsmiUpdateMember";
            this.tsmiUpdateMember.Size = new System.Drawing.Size(212, 54);
            this.tsmiUpdateMember.Text = "Update Member";
            this.tsmiUpdateMember.Click += new System.EventHandler(this.tsmiUpdateMember_Click);
            // 
            // tsmiAddNew
            // 
            this.tsmiAddNew.Image = global::GymMS_Project1.Properties.Resources.member_ADD;
            this.tsmiAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddNew.Name = "tsmiAddNew";
            this.tsmiAddNew.Size = new System.Drawing.Size(212, 54);
            this.tsmiAddNew.Text = "Add New";
            this.tsmiAddNew.Click += new System.EventHandler(this.tsmiAddNew_Click);
            // 
            // tsmiDeleteMember
            // 
            this.tsmiDeleteMember.Image = global::GymMS_Project1.Properties.Resources.member_DELETE;
            this.tsmiDeleteMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDeleteMember.Name = "tsmiDeleteMember";
            this.tsmiDeleteMember.Size = new System.Drawing.Size(212, 54);
            this.tsmiDeleteMember.Text = "Delete Member";
            this.tsmiDeleteMember.Click += new System.EventHandler(this.tsmiDeleteMember_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 6);
            // 
            // tsmiSendEmail
            // 
            this.tsmiSendEmail.Image = global::GymMS_Project1.Properties.Resources.send_sms;
            this.tsmiSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSendEmail.Name = "tsmiSendEmail";
            this.tsmiSendEmail.Size = new System.Drawing.Size(212, 54);
            this.tsmiSendEmail.Text = "Send Email";
            // 
            // tsmiSendSMS
            // 
            this.tsmiSendSMS.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiSendSMS.Image = global::GymMS_Project1.Properties.Resources.send_email;
            this.tsmiSendSMS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSendSMS.Name = "tsmiSendSMS";
            this.tsmiSendSMS.Size = new System.Drawing.Size(212, 54);
            this.tsmiSendSMS.Text = "Send SMS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(212, 61);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dgvMembersList
            // 
            this.dgvMembersList.AllowUserToAddRows = false;
            this.dgvMembersList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMembersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvMembersList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMembersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembersList.ContextMenuStrip = this.cmsDataGridOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembersList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMembersList.Location = new System.Drawing.Point(18, 89);
            this.dgvMembersList.Name = "dgvMembersList";
            this.dgvMembersList.ReadOnly = true;
            this.dgvMembersList.RowHeadersVisible = false;
            this.dgvMembersList.Size = new System.Drawing.Size(1177, 294);
            this.dgvMembersList.TabIndex = 3;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Member ID",
            "First Name",
            "Last Name",
            "Phone"});
            this.cbFilterBy.Location = new System.Drawing.Point(81, 61);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 25);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.TextChanged += new System.EventHandler(this.cbFilterBy_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.cbFilterBy);
            this.groupBox1.Controls.Add(this.dgvMembersList);
            this.groupBox1.Controls.Add(this.btnAddNewMember);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1213, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members List";
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnAddNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewMember.Image = global::GymMS_Project1.Properties.Resources.plus;
            this.btnAddNewMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewMember.Location = new System.Drawing.Point(1090, 26);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(105, 35);
            this.btnAddNewMember.TabIndex = 2;
            this.btnAddNewMember.Text = "AddNew";
            this.btnAddNewMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewMember.UseVisualStyleBackColor = false;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Members:";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMembers.Location = new System.Drawing.Point(145, 528);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(21, 20);
            this.lblTotalMembers.TabIndex = 4;
            this.lblTotalMembers.Text = "??";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Image = global::GymMS_Project1.Properties.Resources.btnClose;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1112, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(451, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "Manage Members";
            // 
            // frmMembersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1237, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalMembers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1253, 593);
            this.Name = "frmMembersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members List";
            this.Load += new System.EventHandler(this.frmMembersList_Load);
            this.cmsDataGridOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsDataGridOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteMember;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendSMS;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateMember;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMembersList;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
    }
}