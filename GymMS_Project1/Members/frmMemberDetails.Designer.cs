namespace GymMS_Project1.Members
{
    partial class frmMemberDetails
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
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.crtlPersonCard2 = new GymMS_Project1.Global.ctrlPersonCard();
            this.tcMemberInfo = new System.Windows.Forms.TabControl();
            this.tpMembershipInfo = new System.Windows.Forms.TabPage();
            this.lblNoTrainoerSelected = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlTrainer = new System.Windows.Forms.Panel();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.txtTrainerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlanDescription = new System.Windows.Forms.TextBox();
            this.txtPlanDuration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lalala = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPackageDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.tpPersonInfo.SuspendLayout();
            this.tcMemberInfo.SuspendLayout();
            this.tpMembershipInfo.SuspendLayout();
            this.pnlTrainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(195, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Details";
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.Transparent;
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.btnCancel);
            this.tpPersonInfo.Controls.Add(this.crtlPersonCard2);
            this.tpPersonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpPersonInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(690, 499);
            this.tpPersonInfo.TabIndex = 1;
            this.tpPersonInfo.Text = "Person Info";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Image = global::GymMS_Project1.Properties.Resources.next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(334, 450);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 35);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Image = global::GymMS_Project1.Properties.Resources.btnClose;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(243, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Close";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // crtlPersonCard2
            // 
            this.crtlPersonCard2.BackColor = System.Drawing.Color.White;
            this.crtlPersonCard2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtlPersonCard2.Location = new System.Drawing.Point(7, 3);
            this.crtlPersonCard2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.crtlPersonCard2.MaximumSize = new System.Drawing.Size(684, 483);
            this.crtlPersonCard2.Name = "crtlPersonCard2";
            this.crtlPersonCard2.Size = new System.Drawing.Size(679, 441);
            this.crtlPersonCard2.TabIndex = 6;
            // 
            // tcMemberInfo
            // 
            this.tcMemberInfo.Controls.Add(this.tpPersonInfo);
            this.tcMemberInfo.Controls.Add(this.tpMembershipInfo);
            this.tcMemberInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMemberInfo.ItemSize = new System.Drawing.Size(70, 25);
            this.tcMemberInfo.Location = new System.Drawing.Point(3, 90);
            this.tcMemberInfo.Name = "tcMemberInfo";
            this.tcMemberInfo.SelectedIndex = 0;
            this.tcMemberInfo.Size = new System.Drawing.Size(698, 532);
            this.tcMemberInfo.TabIndex = 6;
            // 
            // tpMembershipInfo
            // 
            this.tpMembershipInfo.BackColor = System.Drawing.Color.Transparent;
            this.tpMembershipInfo.Controls.Add(this.lblNoTrainoerSelected);
            this.tpMembershipInfo.Controls.Add(this.pnlTrainer);
            this.tpMembershipInfo.Controls.Add(this.btnPrevious);
            this.tpMembershipInfo.Controls.Add(this.panel2);
            this.tpMembershipInfo.Controls.Add(this.label12);
            this.tpMembershipInfo.Controls.Add(this.panel1);
            this.tpMembershipInfo.Controls.Add(this.label3);
            this.tpMembershipInfo.Controls.Add(this.btnClose2);
            this.tpMembershipInfo.Controls.Add(this.label11);
            this.tpMembershipInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpMembershipInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tpMembershipInfo.Location = new System.Drawing.Point(4, 29);
            this.tpMembershipInfo.Name = "tpMembershipInfo";
            this.tpMembershipInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMembershipInfo.Size = new System.Drawing.Size(690, 499);
            this.tpMembershipInfo.TabIndex = 2;
            this.tpMembershipInfo.Text = "Membership Info";
            // 
            // lblNoTrainoerSelected
            // 
            this.lblNoTrainoerSelected.AutoSize = true;
            this.lblNoTrainoerSelected.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTrainoerSelected.ForeColor = System.Drawing.Color.Red;
            this.lblNoTrainoerSelected.Location = new System.Drawing.Point(196, 309);
            this.lblNoTrainoerSelected.Name = "lblNoTrainoerSelected";
            this.lblNoTrainoerSelected.Size = new System.Drawing.Size(245, 17);
            this.lblNoTrainoerSelected.TabIndex = 12;
            this.lblNoTrainoerSelected.Text = "\"There Is no trainer for This Member!\"";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(0, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Trainer: ";
            // 
            // pnlTrainer
            // 
            this.pnlTrainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.pnlTrainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrainer.Controls.Add(this.txtSpecialty);
            this.pnlTrainer.Controls.Add(this.label2);
            this.pnlTrainer.Controls.Add(this.txtTrainerName);
            this.pnlTrainer.Controls.Add(this.txtTrainerID);
            this.pnlTrainer.Controls.Add(this.label4);
            this.pnlTrainer.Controls.Add(this.label10);
            this.pnlTrainer.Location = new System.Drawing.Point(61, 329);
            this.pnlTrainer.Name = "pnlTrainer";
            this.pnlTrainer.Size = new System.Drawing.Size(624, 89);
            this.pnlTrainer.TabIndex = 6;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtSpecialty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialty.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialty.Location = new System.Drawing.Point(384, 23);
            this.txtSpecialty.Multiline = true;
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.ReadOnly = true;
            this.txtSpecialty.Size = new System.Drawing.Size(225, 56);
            this.txtSpecialty.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(381, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Specialty:";
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtTrainerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerName.Location = new System.Drawing.Point(164, 23);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.ReadOnly = true;
            this.txtTrainerName.Size = new System.Drawing.Size(208, 29);
            this.txtTrainerName.TabIndex = 3;
            // 
            // txtTrainerID
            // 
            this.txtTrainerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtTrainerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerID.Location = new System.Drawing.Point(29, 23);
            this.txtTrainerID.Name = "txtTrainerID";
            this.txtTrainerID.ReadOnly = true;
            this.txtTrainerID.Size = new System.Drawing.Size(114, 29);
            this.txtTrainerID.TabIndex = 2;
            this.txtTrainerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(164, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(26, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Gray;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrevious.Image = global::GymMS_Project1.Properties.Resources.previous;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(246, 458);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(85, 35);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "Prev";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPlanID);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.txtAdditionalNotes);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPlanDescription);
            this.panel2.Controls.Add(this.txtPlanDuration);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lalala);
            this.panel2.Location = new System.Drawing.Point(61, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 123);
            this.panel2.TabIndex = 8;
            // 
            // txtPlanID
            // 
            this.txtPlanID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtPlanID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanID.Location = new System.Drawing.Point(29, 27);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.ReadOnly = true;
            this.txtPlanID.Size = new System.Drawing.Size(114, 29);
            this.txtPlanID.TabIndex = 7;
            this.txtPlanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label.Location = new System.Drawing.Point(26, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(23, 15);
            this.label.TabIndex = 6;
            this.label.Text = "ID:";
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtAdditionalNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionalNotes.Location = new System.Drawing.Point(164, 23);
            this.txtAdditionalNotes.Multiline = true;
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.ReadOnly = true;
            this.txtAdditionalNotes.Size = new System.Drawing.Size(208, 91);
            this.txtAdditionalNotes.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(381, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Description:";
            // 
            // txtPlanDescription
            // 
            this.txtPlanDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtPlanDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPlanDescription.Location = new System.Drawing.Point(384, 23);
            this.txtPlanDescription.Multiline = true;
            this.txtPlanDescription.Name = "txtPlanDescription";
            this.txtPlanDescription.ReadOnly = true;
            this.txtPlanDescription.Size = new System.Drawing.Size(225, 91);
            this.txtPlanDescription.TabIndex = 3;
            // 
            // txtPlanDuration
            // 
            this.txtPlanDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtPlanDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanDuration.Location = new System.Drawing.Point(29, 85);
            this.txtPlanDuration.Name = "txtPlanDuration";
            this.txtPlanDuration.ReadOnly = true;
            this.txtPlanDuration.Size = new System.Drawing.Size(114, 29);
            this.txtPlanDuration.TabIndex = 2;
            this.txtPlanDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(161, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Additional Notes:";
            // 
            // lalala
            // 
            this.lalala.AutoSize = true;
            this.lalala.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lalala.Location = new System.Drawing.Point(26, 67);
            this.lalala.Name = "lalala";
            this.lalala.Size = new System.Drawing.Size(57, 15);
            this.lalala.TabIndex = 0;
            this.lalala.Text = "Duration:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Location = new System.Drawing.Point(0, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Plan: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPackageDescription);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPackageName);
            this.panel1.Controls.Add(this.txtPackageID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(61, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 125);
            this.panel1.TabIndex = 2;
            // 
            // txtPackageDescription
            // 
            this.txtPackageDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtPackageDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageDescription.Location = new System.Drawing.Point(384, 24);
            this.txtPackageDescription.Multiline = true;
            this.txtPackageDescription.Name = "txtPackageDescription";
            this.txtPackageDescription.ReadOnly = true;
            this.txtPackageDescription.Size = new System.Drawing.Size(225, 91);
            this.txtPackageDescription.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(381, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description:";
            // 
            // txtPackageName
            // 
            this.txtPackageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtPackageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(164, 23);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.ReadOnly = true;
            this.txtPackageName.Size = new System.Drawing.Size(208, 29);
            this.txtPackageName.TabIndex = 3;
            // 
            // txtPackageID
            // 
            this.txtPackageID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtPackageID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageID.Location = new System.Drawing.Point(29, 23);
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.ReadOnly = true;
            this.txtPackageID.Size = new System.Drawing.Size(114, 29);
            this.txtPackageID.TabIndex = 2;
            this.txtPackageID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(164, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Package Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(26, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(0, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Package: ";
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose2.Image = global::GymMS_Project1.Properties.Resources.btnClose;
            this.btnClose2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose2.Location = new System.Drawing.Point(337, 458);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(85, 35);
            this.btnClose2.TabIndex = 9;
            this.btnClose2.Text = "Close";
            this.btnClose2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(700, 624);
            this.ControlBox = false;
            this.Controls.Add(this.tcMemberInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmMemberDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Details";
            this.Load += new System.EventHandler(this.frmMemberDetails_Load);
            this.tpPersonInfo.ResumeLayout(false);
            this.tcMemberInfo.ResumeLayout(false);
            this.tpMembershipInfo.ResumeLayout(false);
            this.tpMembershipInfo.PerformLayout();
            this.pnlTrainer.ResumeLayout(false);
            this.pnlTrainer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabControl tcMemberInfo;
        private System.Windows.Forms.TabPage tpMembershipInfo;
        private System.Windows.Forms.Button btnCancel;
        private Global.ctrlPersonCard crtlPersonCard2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPackageDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.TextBox txtPackageID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAdditionalNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPlanDescription;
        private System.Windows.Forms.TextBox txtPlanDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lalala;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlTrainer;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.TextBox txtTrainerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNoTrainoerSelected;
    }
}