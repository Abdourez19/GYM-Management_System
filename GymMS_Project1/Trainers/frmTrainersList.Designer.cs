namespace GymMS_Project1.Trainers
{
    partial class frmTrainersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTarinersCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTrainersList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewTrainer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainersList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(179, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Trainers";
            // 
            // lblTarinersCount
            // 
            this.lblTarinersCount.AutoSize = true;
            this.lblTarinersCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarinersCount.Location = new System.Drawing.Point(29, 424);
            this.lblTarinersCount.Name = "lblTarinersCount";
            this.lblTarinersCount.Size = new System.Drawing.Size(79, 17);
            this.lblTarinersCount.TabIndex = 8;
            this.lblTarinersCount.Text = "Total PLans:";
            this.lblTarinersCount.Click += new System.EventHandler(this.lblTarinersCount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTrainersList);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 226);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trainers List";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvTrainersList
            // 
            this.dgvTrainersList.AllowUserToAddRows = false;
            this.dgvTrainersList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTrainersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTrainersList.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTrainersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrainersList.ColumnHeadersHeight = 30;
            this.dgvTrainersList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTrainersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrainersList.Location = new System.Drawing.Point(3, 21);
            this.dgvTrainersList.Name = "dgvTrainersList";
            this.dgvTrainersList.ReadOnly = true;
            this.dgvTrainersList.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTrainersList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrainersList.Size = new System.Drawing.Size(681, 202);
            this.dgvTrainersList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetails,
            this.toolStripMenuItem1,
            this.tsmiAddNew,
            this.tsmiUpdate,
            this.toolStripMenuItem2,
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 232);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Image = global::GymMS_Project1.Properties.Resources.personInfo;
            this.tsmiShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(173, 54);
            this.tsmiShowDetails.Text = "Show Details";
            this.tsmiShowDetails.Click += new System.EventHandler(this.tsmiShowDetails_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // tsmiAddNew
            // 
            this.tsmiAddNew.Image = global::GymMS_Project1.Properties.Resources.member_ADD;
            this.tsmiAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddNew.Name = "tsmiAddNew";
            this.tsmiAddNew.Size = new System.Drawing.Size(173, 54);
            this.tsmiAddNew.Text = "Add New";
            this.tsmiAddNew.Click += new System.EventHandler(this.tsmiAddNew_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Image = global::GymMS_Project1.Properties.Resources.Edit_Member;
            this.tsmiUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(173, 54);
            this.tsmiUpdate.Text = "Update";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = global::GymMS_Project1.Properties.Resources.member_DELETE;
            this.tsmiDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(173, 54);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // btnAddNewTrainer
            // 
            this.btnAddNewTrainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnAddNewTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTrainer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTrainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewTrainer.Image = global::GymMS_Project1.Properties.Resources.plus;
            this.btnAddNewTrainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewTrainer.Location = new System.Drawing.Point(596, 133);
            this.btnAddNewTrainer.Name = "btnAddNewTrainer";
            this.btnAddNewTrainer.Size = new System.Drawing.Size(100, 35);
            this.btnAddNewTrainer.TabIndex = 11;
            this.btnAddNewTrainer.Text = "AddNew";
            this.btnAddNewTrainer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewTrainer.UseVisualStyleBackColor = false;
            this.btnAddNewTrainer.Click += new System.EventHandler(this.btnAddNewTrainer_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Image = global::GymMS_Project1.Properties.Resources.btnClose;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(613, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTrainersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.btnAddNewTrainer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTarinersCount);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(724, 489);
            this.Name = "frmTrainersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainers List";
            this.Load += new System.EventHandler(this.frmTrainersList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainersList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTarinersCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTrainersList;
        private System.Windows.Forms.Button btnAddNewTrainer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}