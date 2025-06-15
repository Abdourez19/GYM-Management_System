namespace GymMS_Project1.Packages
{
    partial class frmPackagesList
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
            this.dgvPackagesList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deletePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTotalPackages = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbAddPackage = new System.Windows.Forms.GroupBox();
            this.txtAddPackagePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddPackageDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddPackageName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagesList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbAddPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(460, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Packages";
            // 
            // dgvPackagesList
            // 
            this.dgvPackagesList.AllowUserToAddRows = false;
            this.dgvPackagesList.AllowUserToDeleteRows = false;
            this.dgvPackagesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPackagesList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPackagesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPackagesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackagesList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackagesList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPackagesList.Location = new System.Drawing.Point(327, 140);
            this.dgvPackagesList.Name = "dgvPackagesList";
            this.dgvPackagesList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPackagesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPackagesList.Size = new System.Drawing.Size(916, 287);
            this.dgvPackagesList.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPackageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deletePackageToolStripMenuItem,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 124);
            // 
            // editPackageToolStripMenuItem
            // 
            this.editPackageToolStripMenuItem.Image = global::GymMS_Project1.Properties.Resources.UpdatePackage;
            this.editPackageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editPackageToolStripMenuItem.Name = "editPackageToolStripMenuItem";
            this.editPackageToolStripMenuItem.Size = new System.Drawing.Size(200, 54);
            this.editPackageToolStripMenuItem.Text = "Edit Package";
            this.editPackageToolStripMenuItem.Click += new System.EventHandler(this.editPackageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 6);
            // 
            // deletePackageToolStripMenuItem
            // 
            this.deletePackageToolStripMenuItem.Image = global::GymMS_Project1.Properties.Resources.DeletePackage;
            this.deletePackageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deletePackageToolStripMenuItem.Name = "deletePackageToolStripMenuItem";
            this.deletePackageToolStripMenuItem.Size = new System.Drawing.Size(200, 54);
            this.deletePackageToolStripMenuItem.Text = "Delete Package";
            this.deletePackageToolStripMenuItem.Click += new System.EventHandler(this.deletePackageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 6);
            // 
            // lblTotalPackages
            // 
            this.lblTotalPackages.AutoSize = true;
            this.lblTotalPackages.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPackages.Location = new System.Drawing.Point(442, 445);
            this.lblTotalPackages.Name = "lblTotalPackages";
            this.lblTotalPackages.Size = new System.Drawing.Size(21, 20);
            this.lblTotalPackages.TabIndex = 8;
            this.lblTotalPackages.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Members:";
            // 
            // gbAddPackage
            // 
            this.gbAddPackage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbAddPackage.Controls.Add(this.txtAddPackagePrice);
            this.gbAddPackage.Controls.Add(this.label5);
            this.gbAddPackage.Controls.Add(this.txtAddPackageDescription);
            this.gbAddPackage.Controls.Add(this.label4);
            this.gbAddPackage.Controls.Add(this.txtAddPackageName);
            this.gbAddPackage.Controls.Add(this.label3);
            this.gbAddPackage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddPackage.Location = new System.Drawing.Point(12, 140);
            this.gbAddPackage.Name = "gbAddPackage";
            this.gbAddPackage.Size = new System.Drawing.Size(286, 287);
            this.gbAddPackage.TabIndex = 10;
            this.gbAddPackage.TabStop = false;
            this.gbAddPackage.Text = "Add Package:";
            // 
            // txtAddPackagePrice
            // 
            this.txtAddPackagePrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPackagePrice.Location = new System.Drawing.Point(35, 239);
            this.txtAddPackagePrice.Name = "txtAddPackagePrice";
            this.txtAddPackagePrice.Size = new System.Drawing.Size(229, 27);
            this.txtAddPackagePrice.TabIndex = 5;
            this.txtAddPackagePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddPackagePrice_KeyPress);
            this.txtAddPackagePrice.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price/Mon:";
            // 
            // txtAddPackageDescription
            // 
            this.txtAddPackageDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPackageDescription.Location = new System.Drawing.Point(35, 112);
            this.txtAddPackageDescription.Multiline = true;
            this.txtAddPackageDescription.Name = "txtAddPackageDescription";
            this.txtAddPackageDescription.Size = new System.Drawing.Size(229, 97);
            this.txtAddPackageDescription.TabIndex = 3;
            this.txtAddPackageDescription.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Package Description:";
            // 
            // txtAddPackageName
            // 
            this.txtAddPackageName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPackageName.Location = new System.Drawing.Point(35, 51);
            this.txtAddPackageName.Name = "txtAddPackageName";
            this.txtAddPackageName.Size = new System.Drawing.Size(229, 27);
            this.txtAddPackageName.TabIndex = 1;
            this.txtAddPackageName.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Package Name:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Image = global::GymMS_Project1.Properties.Resources.btnClose;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1160, 439);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Image = global::GymMS_Project1.Properties.Resources.btnSave;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(220, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Green;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Image = global::GymMS_Project1.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(1138, 88);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 35);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPackagesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1255, 484);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbAddPackage);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTotalPackages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvPackagesList);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1271, 523);
            this.MinimizeBox = false;
            this.Name = "frmPackagesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPackagesList";
            this.Load += new System.EventHandler(this.frmPackagesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagesList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbAddPackage.ResumeLayout(false);
            this.gbAddPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPackagesList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletePackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label lblTotalPackages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbAddPackage;
        private System.Windows.Forms.TextBox txtAddPackageName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddPackagePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddPackageDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}