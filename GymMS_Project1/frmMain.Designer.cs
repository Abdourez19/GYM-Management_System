namespace GymMS_Project1
{
    partial class frmMain
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
            this.tmExtandSideBar = new System.Windows.Forms.Timer(this.components);
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMenuIcon = new System.Windows.Forms.PictureBox();
            this.flpSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.btnPlans = new System.Windows.Forms.Button();
            this.btnTrainers = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTopBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuIcon)).BeginInit();
            this.flpSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmExtandSideBar
            // 
            this.tmExtandSideBar.Interval = 13;
            this.tmExtandSideBar.Tick += new System.EventHandler(this.tmExtendSideBar_Tick);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.pnlTopBar.Controls.Add(this.panel2);
            this.pnlTopBar.Controls.Add(this.label1);
            this.pnlTopBar.Controls.Add(this.pbMenuIcon);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(967, 64);
            this.pnlTopBar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(745, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 64);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(123, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(99, 64);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "msAdmin";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logoutToolStripMenuItem});
            this.administratorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.administratorToolStripMenuItem.Image = global::GymMS_Project1.Properties.Resources.admin00;
            this.administratorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administratorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.administratorToolStripMenuItem.Text = "Admin";
            // 
            // manageAccountToolStripMenuItem
            // 
            this.manageAccountToolStripMenuItem.Image = global::GymMS_Project1.Properties.Resources.account_settings__1_;
            this.manageAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            this.manageAccountToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.manageAccountToolStripMenuItem.Text = "Manage Account";
            this.manageAccountToolStripMenuItem.Click += new System.EventHandler(this.manageAccountToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::GymMS_Project1.Properties.Resources._sign_out__1_;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "GYM MS PROJECT1";
            // 
            // pbMenuIcon
            // 
            this.pbMenuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMenuIcon.Image = global::GymMS_Project1.Properties.Resources.menuIcon;
            this.pbMenuIcon.Location = new System.Drawing.Point(0, 2);
            this.pbMenuIcon.Name = "pbMenuIcon";
            this.pbMenuIcon.Size = new System.Drawing.Size(73, 70);
            this.pbMenuIcon.TabIndex = 0;
            this.pbMenuIcon.TabStop = false;
            this.pbMenuIcon.Click += new System.EventHandler(this.pbMenuIcon_Click);
            // 
            // flpSideBar
            // 
            this.flpSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.flpSideBar.Controls.Add(this.btnDashboard);
            this.flpSideBar.Controls.Add(this.btnMembers);
            this.flpSideBar.Controls.Add(this.btnPackages);
            this.flpSideBar.Controls.Add(this.btnPlans);
            this.flpSideBar.Controls.Add(this.btnTrainers);
            this.flpSideBar.Controls.Add(this.btnUsers);
            this.flpSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSideBar.Location = new System.Drawing.Point(0, 64);
            this.flpSideBar.MaximumSize = new System.Drawing.Size(270, 1000);
            this.flpSideBar.MinimumSize = new System.Drawing.Size(73, 1000);
            this.flpSideBar.Name = "flpSideBar";
            this.flpSideBar.Size = new System.Drawing.Size(270, 1000);
            this.flpSideBar.TabIndex = 2;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDashboard.Image = global::GymMS_Project1.Properties.Resources.home;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(263, 66);
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Tag = "1";
            this.btnDashboard.Text = "                  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.MenuButtons_OnMouseLeave);
            this.btnDashboard.MouseHover += new System.EventHandler(this.MenuButtons_MouseHover);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMembers.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMembers.Image = global::GymMS_Project1.Properties.Resources.member;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(3, 75);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(263, 66);
            this.btnMembers.TabIndex = 9;
            this.btnMembers.Tag = "2";
            this.btnMembers.Text = "                  Memberships";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            this.btnMembers.MouseLeave += new System.EventHandler(this.MenuButtons_OnMouseLeave);
            this.btnMembers.MouseHover += new System.EventHandler(this.MenuButtons_MouseHover);
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnPackages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPackages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPackages.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPackages.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPackages.Image = global::GymMS_Project1.Properties.Resources.Plans1;
            this.btnPackages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPackages.Location = new System.Drawing.Point(3, 147);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(263, 66);
            this.btnPackages.TabIndex = 11;
            this.btnPackages.Tag = "4";
            this.btnPackages.Text = "                  Packages";
            this.btnPackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            this.btnPackages.MouseLeave += new System.EventHandler(this.MenuButtons_OnMouseLeave);
            this.btnPackages.MouseHover += new System.EventHandler(this.MenuButtons_MouseHover);
            // 
            // btnPlans
            // 
            this.btnPlans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnPlans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlans.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlans.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlans.Image = global::GymMS_Project1.Properties.Resources.packages1;
            this.btnPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlans.Location = new System.Drawing.Point(3, 219);
            this.btnPlans.Name = "btnPlans";
            this.btnPlans.Size = new System.Drawing.Size(267, 66);
            this.btnPlans.TabIndex = 12;
            this.btnPlans.Tag = "8";
            this.btnPlans.Text = "                  Plans";
            this.btnPlans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlans.UseVisualStyleBackColor = false;
            this.btnPlans.Click += new System.EventHandler(this.btnPlans_Click);
            this.btnPlans.MouseLeave += new System.EventHandler(this.MenuButtons_OnMouseLeave);
            this.btnPlans.MouseHover += new System.EventHandler(this.MenuButtons_MouseHover);
            // 
            // btnTrainers
            // 
            this.btnTrainers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnTrainers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTrainers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrainers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnTrainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTrainers.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTrainers.Image = global::GymMS_Project1.Properties.Resources.entraineu00r;
            this.btnTrainers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainers.Location = new System.Drawing.Point(3, 291);
            this.btnTrainers.Name = "btnTrainers";
            this.btnTrainers.Size = new System.Drawing.Size(267, 66);
            this.btnTrainers.TabIndex = 12;
            this.btnTrainers.Tag = "16";
            this.btnTrainers.Text = "                  Trainers";
            this.btnTrainers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainers.UseVisualStyleBackColor = false;
            this.btnTrainers.Click += new System.EventHandler(this.btnTrainers_Click);
            this.btnTrainers.MouseLeave += new System.EventHandler(this.MenuButtons_OnMouseLeave);
            this.btnTrainers.MouseHover += new System.EventHandler(this.MenuButtons_MouseHover);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(12)))), ((int)(((byte)(44)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUsers.Image = global::GymMS_Project1.Properties.Resources.u64;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(3, 363);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(267, 66);
            this.btnUsers.TabIndex = 13;
            this.btnUsers.Tag = "32";
            this.btnUsers.Text = "                  Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.MouseLeave += new System.EventHandler(this.MenuButtons_OnMouseLeave);
            this.btnUsers.MouseHover += new System.EventHandler(this.MenuButtons_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(270, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 441);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GymMS_Project1.Properties.Resources.HomePicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(180)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(967, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpSideBar);
            this.Controls.Add(this.pnlTopBar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuIcon)).EndInit();
            this.flpSideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmExtandSideBar;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMenuIcon;
        private System.Windows.Forms.FlowLayoutPanel flpSideBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Button btnTrainers;
        private System.Windows.Forms.Button btnPlans;
        private System.Windows.Forms.Button btnUsers;
    }
}