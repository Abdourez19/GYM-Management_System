namespace GymMS_Project1.Plans
{
    partial class frmTrainerDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrainerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.crtlPersonCard1 = new GymMS_Project1.Global.ctrlPersonCard();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trainer Details";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSpecialty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTrainerID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trainer Info";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(562, 32);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(92, 35);
            this.txtSalary.TabIndex = 7;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salary: ";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(406, 32);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(92, 35);
            this.txtRate.TabIndex = 5;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rate (*/10): ";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialty.Location = new System.Drawing.Point(185, 32);
            this.txtSpecialty.Multiline = true;
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.ReadOnly = true;
            this.txtSpecialty.Size = new System.Drawing.Size(146, 35);
            this.txtSpecialty.TabIndex = 3;
            this.txtSpecialty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specialty: ";
            // 
            // txtTrainerID
            // 
            this.txtTrainerID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerID.Location = new System.Drawing.Point(42, 32);
            this.txtTrainerID.Multiline = true;
            this.txtTrainerID.Name = "txtTrainerID";
            this.txtTrainerID.ReadOnly = true;
            this.txtTrainerID.Size = new System.Drawing.Size(72, 35);
            this.txtTrainerID.TabIndex = 1;
            this.txtTrainerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Image = global::GymMS_Project1.Properties.Resources.btnClose;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(600, 600);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 35);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // crtlPersonCard1
            // 
            this.crtlPersonCard1.BackColor = System.Drawing.Color.White;
            this.crtlPersonCard1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtlPersonCard1.Location = new System.Drawing.Point(13, 65);
            this.crtlPersonCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.crtlPersonCard1.MaximumSize = new System.Drawing.Size(684, 483);
            this.crtlPersonCard1.Name = "crtlPersonCard1";
            this.crtlPersonCard1.Size = new System.Drawing.Size(684, 443);
            this.crtlPersonCard1.TabIndex = 0;
            // 
            // frmTrainerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(705, 642);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crtlPersonCard1);
            this.Name = "frmTrainerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTrainerDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Global.ctrlPersonCard crtlPersonCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrainerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label5;
    }
}