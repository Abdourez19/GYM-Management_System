namespace GymMS_Project1.Members
{
    partial class frmAddEditMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.tpMembershipInfo = new System.Windows.Forms.TabPage();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpSubscriptionDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.cbTrainer = new System.Windows.Forms.ComboBox();
            this.cbPackage = new System.Windows.Forms.ComboBox();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.llRemovePic = new System.Windows.Forms.LinkLabel();
            this.llAddPic = new System.Windows.Forms.LinkLabel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.llRemovePicture = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.tcMemberInfo = new System.Windows.Forms.TabControl();
            this.ofdAddPic = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpMembershipInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.tcMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTitle.Location = new System.Drawing.Point(239, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 47);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(280, -57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Member Details";
            // 
            // tpMembershipInfo
            // 
            this.tpMembershipInfo.BackColor = System.Drawing.Color.LightGray;
            this.tpMembershipInfo.Controls.Add(this.btnPrev);
            this.tpMembershipInfo.Controls.Add(this.txtAmount);
            this.tpMembershipInfo.Controls.Add(this.label22);
            this.tpMembershipInfo.Controls.Add(this.txtNotes);
            this.tpMembershipInfo.Controls.Add(this.label21);
            this.tpMembershipInfo.Controls.Add(this.dtpSubscriptionDate);
            this.tpMembershipInfo.Controls.Add(this.label20);
            this.tpMembershipInfo.Controls.Add(this.cbTrainer);
            this.tpMembershipInfo.Controls.Add(this.cbPackage);
            this.tpMembershipInfo.Controls.Add(this.cbPlan);
            this.tpMembershipInfo.Controls.Add(this.btnPrevious);
            this.tpMembershipInfo.Controls.Add(this.label12);
            this.tpMembershipInfo.Controls.Add(this.label3);
            this.tpMembershipInfo.Controls.Add(this.btnClose2);
            this.tpMembershipInfo.Controls.Add(this.label11);
            this.tpMembershipInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpMembershipInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tpMembershipInfo.Location = new System.Drawing.Point(4, 29);
            this.tpMembershipInfo.Name = "tpMembershipInfo";
            this.tpMembershipInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMembershipInfo.Size = new System.Drawing.Size(690, 447);
            this.tpMembershipInfo.TabIndex = 2;
            this.tpMembershipInfo.Text = "Membership Info";
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
            this.btnPrev.Location = new System.Drawing.Point(25, 396);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(85, 35);
            this.btnPrev.TabIndex = 21;
            this.btnPrev.Text = "Prev";
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtAmount.Location = new System.Drawing.Point(246, 291);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(154, 43);
            this.txtAmount.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label22.Location = new System.Drawing.Point(7, 309);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 25);
            this.label22.TabIndex = 19;
            this.label22.Text = "Amount:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(246, 165);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(441, 103);
            this.txtNotes.TabIndex = 18;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label21.Location = new System.Drawing.Point(246, 145);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 21);
            this.label21.TabIndex = 17;
            this.label21.Text = "Note:";
            // 
            // dtpSubscriptionDate
            // 
            this.dtpSubscriptionDate.Location = new System.Drawing.Point(12, 165);
            this.dtpSubscriptionDate.Name = "dtpSubscriptionDate";
            this.dtpSubscriptionDate.Size = new System.Drawing.Size(200, 23);
            this.dtpSubscriptionDate.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label20.Location = new System.Drawing.Point(9, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 21);
            this.label20.TabIndex = 15;
            this.label20.Text = "Subscription Date:";
            // 
            // cbTrainer
            // 
            this.cbTrainer.AllowDrop = true;
            this.cbTrainer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTrainer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTrainer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrainer.FormattingEnabled = true;
            this.cbTrainer.ItemHeight = 17;
            this.cbTrainer.Location = new System.Drawing.Point(480, 80);
            this.cbTrainer.MaxDropDownItems = 10;
            this.cbTrainer.Name = "cbTrainer";
            this.cbTrainer.Size = new System.Drawing.Size(207, 25);
            this.cbTrainer.TabIndex = 14;
            // 
            // cbPackage
            // 
            this.cbPackage.AllowDrop = true;
            this.cbPackage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPackage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPackage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPackage.FormattingEnabled = true;
            this.cbPackage.ItemHeight = 17;
            this.cbPackage.Location = new System.Drawing.Point(246, 80);
            this.cbPackage.MaxDropDownItems = 10;
            this.cbPackage.Name = "cbPackage";
            this.cbPackage.Size = new System.Drawing.Size(207, 25);
            this.cbPackage.TabIndex = 13;
            this.cbPackage.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCb_Validating);
            // 
            // cbPlan
            // 
            this.cbPlan.AllowDrop = true;
            this.cbPlan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.ItemHeight = 17;
            this.cbPlan.Location = new System.Drawing.Point(12, 80);
            this.cbPlan.MaxDropDownItems = 10;
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(207, 25);
            this.cbPlan.TabIndex = 12;
            this.cbPlan.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyCb_Validating);
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
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Location = new System.Drawing.Point(9, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Plan Duration (mon): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(246, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Package Name: ";
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
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(477, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Trainer Specialty: ";
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.Transparent;
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
            this.tpPersonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpPersonInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(690, 447);
            this.tpPersonInfo.TabIndex = 1;
            this.tpPersonInfo.Text = "Person Info";
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
            this.btnNext.Location = new System.Drawing.Point(577, 397);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 35);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // llRemovePic
            // 
            this.llRemovePic.AutoSize = true;
            this.llRemovePic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemovePic.Location = new System.Drawing.Point(546, 336);
            this.llRemovePic.Name = "llRemovePic";
            this.llRemovePic.Size = new System.Drawing.Size(69, 15);
            this.llRemovePic.TabIndex = 86;
            this.llRemovePic.TabStop = true;
            this.llRemovePic.Text = "Remove pic";
            this.llRemovePic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemovePic_LinkClicked);
            // 
            // llAddPic
            // 
            this.llAddPic.AutoSize = true;
            this.llAddPic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddPic.Location = new System.Drawing.Point(615, 336);
            this.llAddPic.Name = "llAddPic";
            this.llAddPic.Size = new System.Drawing.Size(48, 15);
            this.llAddPic.TabIndex = 85;
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
            this.cbGender.Location = new System.Drawing.Point(263, 251);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(154, 29);
            this.cbGender.TabIndex = 84;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // llRemovePicture
            // 
            this.llRemovePicture.AutoSize = true;
            this.llRemovePicture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemovePicture.Location = new System.Drawing.Point(607, 18);
            this.llRemovePicture.Name = "llRemovePicture";
            this.llRemovePicture.Size = new System.Drawing.Size(51, 15);
            this.llRemovePicture.TabIndex = 83;
            this.llRemovePicture.TabStop = true;
            this.llRemovePicture.Text = "Edit Info";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(545, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 15);
            this.label16.TabIndex = 82;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(583, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 15);
            this.label15.TabIndex = 81;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(113, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 15);
            this.label14.TabIndex = 80;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(320, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 15);
            this.label13.TabIndex = 79;
            this.label13.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(136, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(310, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 77;
            this.label4.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(98, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 76;
            this.label10.Text = "*";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonImage.Image = global::GymMS_Project1.Properties.Resources.person_man;
            this.pbPersonImage.Location = new System.Drawing.Point(548, 200);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(112, 133);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonImage.TabIndex = 75;
            this.pbPersonImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(259, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Gender:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(21, 354);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(641, 37);
            this.txtAddress.TabIndex = 73;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(17, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "Address:";
            // 
            // txtIdCardNumber
            // 
            this.txtIdCardNumber.BackColor = System.Drawing.Color.White;
            this.txtIdCardNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCardNumber.Location = new System.Drawing.Point(21, 162);
            this.txtIdCardNumber.Multiline = true;
            this.txtIdCardNumber.Name = "txtIdCardNumber";
            this.txtIdCardNumber.Size = new System.Drawing.Size(154, 32);
            this.txtIdCardNumber.TabIndex = 71;
            this.txtIdCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdCardNumber.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBoxValidating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(17, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "ID Card Number:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(21, 251);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dtpDateOfBirth.TabIndex = 69;
            this.dtpDateOfBirth.Value = new System.DateTime(2025, 5, 28, 14, 0, 11, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(17, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Date Of Birth:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(264, 162);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 32);
            this.txtPhone.TabIndex = 67;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBoxValidating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(259, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(506, 162);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 32);
            this.txtEmail.TabIndex = 65;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBoxValidating);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(501, 131);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 20);
            this.label.TabIndex = 64;
            this.label.Text = "Email:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(508, 83);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 32);
            this.txtLastName.TabIndex = 63;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBoxValidating);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(265, 83);
            this.txtMiddleName.Multiline = true;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(154, 32);
            this.txtMiddleName.TabIndex = 62;
            this.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(22, 83);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(154, 32);
            this.txtFirstName.TabIndex = 61;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyTxtBoxValidating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(505, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 20);
            this.label17.TabIndex = 60;
            this.label17.Text = "Last Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(261, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 20);
            this.label18.TabIndex = 59;
            this.label18.Text = "Middle Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(17, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 20);
            this.label19.TabIndex = 58;
            this.label19.Text = "First Name:";
            // 
            // tcMemberInfo
            // 
            this.tcMemberInfo.Controls.Add(this.tpPersonInfo);
            this.tcMemberInfo.Controls.Add(this.tpMembershipInfo);
            this.tcMemberInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMemberInfo.ItemSize = new System.Drawing.Size(70, 25);
            this.tcMemberInfo.Location = new System.Drawing.Point(12, 93);
            this.tcMemberInfo.Name = "tcMemberInfo";
            this.tcMemberInfo.SelectedIndex = 0;
            this.tcMemberInfo.Size = new System.Drawing.Size(698, 480);
            this.tcMemberInfo.TabIndex = 8;
            // 
            // ofdAddPic
            // 
            this.ofdAddPic.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Image = global::GymMS_Project1.Properties.Resources.btnSave;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(593, 575);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 35);
            this.btnSave.TabIndex = 10;
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
            this.btnClose.Location = new System.Drawing.Point(502, 575);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 618);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcMemberInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmAddEditMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Member";
            this.Load += new System.EventHandler(this.frmAddEditMember_Load);
            this.tpMembershipInfo.ResumeLayout(false);
            this.tpMembershipInfo.PerformLayout();
            this.tpPersonInfo.ResumeLayout(false);
            this.tpPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.tcMemberInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpMembershipInfo;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabControl tcMemberInfo;
        private System.Windows.Forms.LinkLabel llRemovePic;
        private System.Windows.Forms.LinkLabel llAddPic;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.LinkLabel llRemovePicture;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpSubscriptionDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbTrainer;
        private System.Windows.Forms.ComboBox cbPackage;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.OpenFileDialog ofdAddPic;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}