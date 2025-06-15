namespace GymMS_Project1.Packages
{
    partial class frmEditPackage
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
            this.btnSave = new System.Windows.Forms.Button();
            this.gbAddPackage = new System.Windows.Forms.GroupBox();
            this.txtPackagePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPackageDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit Packages";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Image = global::GymMS_Project1.Properties.Resources.btnSave;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(257, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbAddPackage
            // 
            this.gbAddPackage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbAddPackage.Controls.Add(this.txtPackagePrice);
            this.gbAddPackage.Controls.Add(this.label5);
            this.gbAddPackage.Controls.Add(this.txtPackageDescription);
            this.gbAddPackage.Controls.Add(this.label4);
            this.gbAddPackage.Controls.Add(this.txtPackageName);
            this.gbAddPackage.Controls.Add(this.label3);
            this.gbAddPackage.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddPackage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbAddPackage.Location = new System.Drawing.Point(16, 93);
            this.gbAddPackage.Name = "gbAddPackage";
            this.gbAddPackage.Size = new System.Drawing.Size(329, 332);
            this.gbAddPackage.TabIndex = 12;
            this.gbAddPackage.TabStop = false;
            this.gbAddPackage.Text = "Package Info:";
            // 
            // txtPackagePrice
            // 
            this.txtPackagePrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackagePrice.Location = new System.Drawing.Point(35, 268);
            this.txtPackagePrice.Name = "txtPackagePrice";
            this.txtPackagePrice.Size = new System.Drawing.Size(255, 27);
            this.txtPackagePrice.TabIndex = 5;
            this.txtPackagePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPackagePrice_KeyPress);
            this.txtPackagePrice.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBoxValidating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price/Mon:";
            // 
            // txtPackageDescription
            // 
            this.txtPackageDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageDescription.Location = new System.Drawing.Point(35, 130);
            this.txtPackageDescription.Multiline = true;
            this.txtPackageDescription.Name = "txtPackageDescription";
            this.txtPackageDescription.Size = new System.Drawing.Size(255, 97);
            this.txtPackageDescription.TabIndex = 3;
            this.txtPackageDescription.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBoxValidating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Package Description:";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(35, 61);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(255, 27);
            this.txtPackageName.TabIndex = 1;
            this.txtPackageName.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBoxValidating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Package Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Image = global::GymMS_Project1.Properties.Resources.btnClose;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(163, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(360, 504);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbAddPackage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 543);
            this.Name = "frmEditPackage";
            this.Text = "Edit Package";
            this.Load += new System.EventHandler(this.frmEditPackage_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBoxValidating);
            this.gbAddPackage.ResumeLayout(false);
            this.gbAddPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbAddPackage;
        private System.Windows.Forms.TextBox txtPackagePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPackageDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}