namespace GymMS_Project1.Users
{
    partial class frmAddEditUser
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcAddEditUser = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.llRemovePic = new System.Windows.Forms.LinkLabel();
            this.llAddPic = new System.Windows.Forms.LinkLabel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.llRemovePicture = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdCardNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tpUserLogin = new System.Windows.Forms.TabPage();
            this.lblNote = new System.Windows.Forms.Label();
            this.pnlPermissions = new System.Windows.Forms.Panel();
            this.cbManageUsers = new System.Windows.Forms.CheckBox();
            this.cbManageTrainers = new System.Windows.Forms.CheckBox();
            this.cbManagePlans = new System.Windows.Forms.CheckBox();
            this.cbManagePackages = new System.Windows.Forms.CheckBox();
            this.cbManageMemberships = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbDashboard = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdChooseImage = new System.Windows.Forms.OpenFileDialog();
            this.tcAddEditUser.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.tpUserLogin.SuspendLayout();
            this.pnlPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTitle.Location = new System.Drawing.Point(233, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 50);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Add New Users ";
            // 
            // tcAddEditUser
            // 
            this.tcAddEditUser.Controls.Add(this.tpPersonInfo);
            this.tcAddEditUser.Controls.Add(this.tpUserLogin);
            this.tcAddEditUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAddEditUser.Location = new System.Drawing.Point(12, 89);
            this.tcAddEditUser.Name = "tcAddEditUser";
            this.tcAddEditUser.SelectedIndex = 0;
            this.tcAddEditUser.Size = new System.Drawing.Size(686, 469);
            this.tcAddEditUser.TabIndex = 5;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.llRemovePic);
            this.tpPersonInfo.Controls.Add(this.llAddPic);
            this.tpPersonInfo.Controls.Add(this.cbGender);
            this.tpPersonInfo.Controls.Add(this.llRemovePicture);
            this.tpPersonInfo.Controls.Add(this.label16);
            this.tpPersonInfo.Controls.Add(this.label15);
            this.tpPersonInfo.Controls.Add(this.label14);
            this.tpPersonInfo.Controls.Add(this.label2);
            this.tpPersonInfo.Controls.Add(this.label4);
            this.tpPersonInfo.Controls.Add(this.label10);
            this.tpPersonInfo.Controls.Add(this.pbPersonImage);
            this.tpPersonInfo.Controls.Add(this.label7);
            this.tpPersonInfo.Controls.Add(this.txtAddress);
            this.tpPersonInfo.Controls.Add(this.label9);
            this.tpPersonInfo.Controls.Add(this.txtIdCardNumber);
            this.tpPersonInfo.Controls.Add(this.label8);
            this.tpPersonInfo.Controls.Add(this.dtpDateOfBirth);
            this.tpPersonInfo.Controls.Add(this.label6);
            this.tpPersonInfo.Controls.Add(this.txtPhone);
            this.tpPersonInfo.Controls.Add(this.label5);
            this.tpPersonInfo.Controls.Add(this.txtEmail);
            this.tpPersonInfo.Controls.Add(this.label);
            this.tpPersonInfo.Controls.Add(this.txtLastName);
            this.tpPersonInfo.Controls.Add(this.txtMiddleName);
            this.tpPersonInfo.Controls.Add(this.txtFirstName);
            this.tpPersonInfo.Controls.Add(this.label17);
            this.tpPersonInfo.Controls.Add(this.label18);
            this.tpPersonInfo.Controls.Add(this.label19);
            this.tpPersonInfo.Controls.Add(this.label13);
            this.tpPersonInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 24);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(678, 441);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Image = global::GymMS_Project1.Properties.Resources.next_Black;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(576, 388);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 35);
            this.btnNext.TabIndex = 87;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // llRemovePic
            // 
            this.llRemovePic.AutoSize = true;
            this.llRemovePic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemovePic.Location = new System.Drawing.Point(545, 321);
            this.llRemovePic.Name = "llRemovePic";
            this.llRemovePic.Size = new System.Drawing.Size(69, 15);
            this.llRemovePic.TabIndex = 116;
            this.llRemovePic.TabStop = true;
            this.llRemovePic.Text = "Remove pic";
            this.llRemovePic.Visible = false;
            this.llRemovePic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemovePic_LinkClicked);
            // 
            // llAddPic
            // 
            this.llAddPic.AutoSize = true;
            this.llAddPic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddPic.Location = new System.Drawing.Point(614, 321);
            this.llAddPic.Name = "llAddPic";
            this.llAddPic.Size = new System.Drawing.Size(48, 15);
            this.llAddPic.TabIndex = 115;
            this.llAddPic.TabStop = true;
            this.llAddPic.Text = "Add pic";
            this.llAddPic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddPic_LinkClicked);
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(262, 236);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(154, 29);
            this.cbGender.TabIndex = 114;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // llRemovePicture
            // 
            this.llRemovePicture.AutoSize = true;
            this.llRemovePicture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemovePicture.Location = new System.Drawing.Point(606, 3);
            this.llRemovePicture.Name = "llRemovePicture";
            this.llRemovePicture.Size = new System.Drawing.Size(51, 15);
            this.llRemovePicture.TabIndex = 113;
            this.llRemovePicture.TabStop = true;
            this.llRemovePicture.Text = "Edit Info";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(544, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 15);
            this.label16.TabIndex = 112;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(582, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 15);
            this.label15.TabIndex = 111;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(112, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 15);
            this.label14.TabIndex = 110;
            this.label14.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(135, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 108;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(309, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 107;
            this.label4.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(97, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 106;
            this.label10.Text = "*";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonImage.Image = global::GymMS_Project1.Properties.Resources.person_man;
            this.pbPersonImage.Location = new System.Drawing.Point(538, 185);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(121, 133);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonImage.TabIndex = 105;
            this.pbPersonImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(258, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 104;
            this.label7.Text = "Gender:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(20, 339);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(641, 37);
            this.txtAddress.TabIndex = 103;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(16, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 102;
            this.label9.Text = "Address:";
            // 
            // txtIdCardNumber
            // 
            this.txtIdCardNumber.BackColor = System.Drawing.Color.White;
            this.txtIdCardNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCardNumber.Location = new System.Drawing.Point(20, 147);
            this.txtIdCardNumber.Multiline = true;
            this.txtIdCardNumber.Name = "txtIdCardNumber";
            this.txtIdCardNumber.Size = new System.Drawing.Size(154, 32);
            this.txtIdCardNumber.TabIndex = 101;
            this.txtIdCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdCardNumber.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(16, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 100;
            this.label8.Text = "ID Card Number:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(20, 236);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dtpDateOfBirth.TabIndex = 99;
            this.dtpDateOfBirth.Value = new System.DateTime(2025, 5, 28, 14, 0, 11, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(16, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Date Of Birth:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(263, 147);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 32);
            this.txtPhone.TabIndex = 97;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(258, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(505, 147);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 32);
            this.txtEmail.TabIndex = 95;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBox_Validating);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(500, 116);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 20);
            this.label.TabIndex = 94;
            this.label.Text = "Email:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(507, 68);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 32);
            this.txtLastName.TabIndex = 93;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBox_Validating);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(264, 68);
            this.txtMiddleName.Multiline = true;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(154, 32);
            this.txtMiddleName.TabIndex = 92;
            this.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(21, 68);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(154, 32);
            this.txtFirstName.TabIndex = 91;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBox_Validating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(504, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 20);
            this.label17.TabIndex = 90;
            this.label17.Text = "Last Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(260, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 20);
            this.label18.TabIndex = 89;
            this.label18.Text = "Middle Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(16, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 20);
            this.label19.TabIndex = 88;
            this.label19.Text = "First Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(319, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 15);
            this.label13.TabIndex = 109;
            this.label13.Text = "*";
            // 
            // tpUserLogin
            // 
            this.tpUserLogin.Controls.Add(this.lblNote);
            this.tpUserLogin.Controls.Add(this.pnlPermissions);
            this.tpUserLogin.Controls.Add(this.label12);
            this.tpUserLogin.Controls.Add(this.txtConfirmPassword);
            this.tpUserLogin.Controls.Add(this.label11);
            this.tpUserLogin.Controls.Add(this.txtPassword);
            this.tpUserLogin.Controls.Add(this.label1);
            this.tpUserLogin.Controls.Add(this.txtUsername);
            this.tpUserLogin.Controls.Add(this.label3);
            this.tpUserLogin.Controls.Add(this.btnPrev);
            this.tpUserLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpUserLogin.Location = new System.Drawing.Point(4, 24);
            this.tpUserLogin.Name = "tpUserLogin";
            this.tpUserLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserLogin.Size = new System.Drawing.Size(678, 441);
            this.tpUserLogin.TabIndex = 1;
            this.tpUserLogin.Text = "User Login";
            this.tpUserLogin.UseVisualStyleBackColor = true;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(261, 322);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(349, 17);
            this.lblNote.TabIndex = 115;
            this.lblNote.Text = "Updating Permissions is not Accessible from this menu";
            // 
            // pnlPermissions
            // 
            this.pnlPermissions.Controls.Add(this.cbManageUsers);
            this.pnlPermissions.Controls.Add(this.cbManageTrainers);
            this.pnlPermissions.Controls.Add(this.cbManagePlans);
            this.pnlPermissions.Controls.Add(this.cbManagePackages);
            this.pnlPermissions.Controls.Add(this.cbManageMemberships);
            this.pnlPermissions.Controls.Add(this.label20);
            this.pnlPermissions.Controls.Add(this.cbDashboard);
            this.pnlPermissions.Location = new System.Drawing.Point(380, 77);
            this.pnlPermissions.Name = "pnlPermissions";
            this.pnlPermissions.Size = new System.Drawing.Size(230, 193);
            this.pnlPermissions.TabIndex = 114;
            // 
            // cbManageUsers
            // 
            this.cbManageUsers.AutoSize = true;
            this.cbManageUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManageUsers.Location = new System.Drawing.Point(13, 169);
            this.cbManageUsers.Name = "cbManageUsers";
            this.cbManageUsers.Size = new System.Drawing.Size(98, 17);
            this.cbManageUsers.TabIndex = 10;
            this.cbManageUsers.Tag = "32";
            this.cbManageUsers.Text = "Manage Users";
            this.cbManageUsers.UseVisualStyleBackColor = true;
            // 
            // cbManageTrainers
            // 
            this.cbManageTrainers.AutoSize = true;
            this.cbManageTrainers.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManageTrainers.Location = new System.Drawing.Point(13, 146);
            this.cbManageTrainers.Name = "cbManageTrainers";
            this.cbManageTrainers.Size = new System.Drawing.Size(109, 17);
            this.cbManageTrainers.TabIndex = 9;
            this.cbManageTrainers.Tag = "16";
            this.cbManageTrainers.Text = "Manage Trainers";
            this.cbManageTrainers.UseVisualStyleBackColor = true;
            // 
            // cbManagePlans
            // 
            this.cbManagePlans.AutoSize = true;
            this.cbManagePlans.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManagePlans.Location = new System.Drawing.Point(13, 123);
            this.cbManagePlans.Name = "cbManagePlans";
            this.cbManagePlans.Size = new System.Drawing.Size(96, 17);
            this.cbManagePlans.TabIndex = 8;
            this.cbManagePlans.Tag = "8";
            this.cbManagePlans.Text = "Manage Plans";
            this.cbManagePlans.UseVisualStyleBackColor = true;
            // 
            // cbManagePackages
            // 
            this.cbManagePackages.AutoSize = true;
            this.cbManagePackages.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManagePackages.Location = new System.Drawing.Point(13, 100);
            this.cbManagePackages.Name = "cbManagePackages";
            this.cbManagePackages.Size = new System.Drawing.Size(117, 17);
            this.cbManagePackages.TabIndex = 3;
            this.cbManagePackages.Tag = "4";
            this.cbManagePackages.Text = "Manage Packages";
            this.cbManagePackages.UseVisualStyleBackColor = true;
            // 
            // cbManageMemberships
            // 
            this.cbManageMemberships.AutoSize = true;
            this.cbManageMemberships.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManageMemberships.Location = new System.Drawing.Point(13, 77);
            this.cbManageMemberships.Name = "cbManageMemberships";
            this.cbManageMemberships.Size = new System.Drawing.Size(139, 17);
            this.cbManageMemberships.TabIndex = 2;
            this.cbManageMemberships.Tag = "2";
            this.cbManageMemberships.Text = "Manage Memberships";
            this.cbManageMemberships.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "Grant Access to:";
            // 
            // cbDashboard
            // 
            this.cbDashboard.AutoSize = true;
            this.cbDashboard.Checked = true;
            this.cbDashboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDashboard.Enabled = false;
            this.cbDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDashboard.Location = new System.Drawing.Point(13, 54);
            this.cbDashboard.Name = "cbDashboard";
            this.cbDashboard.Size = new System.Drawing.Size(82, 17);
            this.cbDashboard.TabIndex = 0;
            this.cbDashboard.Tag = "1";
            this.cbDashboard.Text = "Dashboard";
            this.cbDashboard.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(376, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 113;
            this.label12.Text = "Select Permissions:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(74, 238);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(143, 32);
            this.txtConfirmPassword.TabIndex = 112;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBox_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(70, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 111;
            this.label11.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(74, 154);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 32);
            this.txtPassword.TabIndex = 110;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(70, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(74, 77);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(143, 32);
            this.txtUsername.TabIndex = 108;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(70, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "Username:";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrev.Image = global::GymMS_Project1.Properties.Resources.previousBlack;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(15, 392);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(85, 35);
            this.btnPrev.TabIndex = 23;
            this.btnPrev.Text = "Prev";
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Image = global::GymMS_Project1.Properties.Resources.btnSave;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(609, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 35);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(518, 564);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 35);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ofdChooseImage
            // 
            this.ofdChooseImage.FileName = "openFileDialog1";
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 610);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcAddEditUser);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.tcAddEditUser.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.tpUserLogin.ResumeLayout(false);
            this.tpUserLogin.PerformLayout();
            this.pnlPermissions.ResumeLayout(false);
            this.pnlPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcAddEditUser;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpUserLogin;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.LinkLabel llRemovePic;
        private System.Windows.Forms.LinkLabel llAddPic;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.LinkLabel llRemovePicture;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdCardNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlPermissions;
        private System.Windows.Forms.CheckBox cbDashboard;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cbManageMemberships;
        private System.Windows.Forms.CheckBox cbManagePackages;
        private System.Windows.Forms.CheckBox cbManagePlans;
        private System.Windows.Forms.CheckBox cbManageTrainers;
        private System.Windows.Forms.CheckBox cbManageUsers;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog ofdChooseImage;
        private System.Windows.Forms.Label lblNote;
    }
}