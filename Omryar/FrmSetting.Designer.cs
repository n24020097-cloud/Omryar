namespace Omryar
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAboutMe = new System.Windows.Forms.TextBox();
            this.btnEditAboutMe = new System.Windows.Forms.Button();
            this.chkPublicProfile = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.btnEditPass = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtLastPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExitAccount = new System.Windows.Forms.Button();
            this.chkMedicineReminder = new System.Windows.Forms.CheckBox();
            this.chkVisitReminder = new System.Windows.Forms.CheckBox();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picProfile
            // 
            this.picProfile.Location = new System.Drawing.Point(236, 12);
            this.picProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(157, 161);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnAddPicture.ForeColor = System.Drawing.Color.White;
            this.btnAddPicture.Location = new System.Drawing.Point(129, 127);
            this.btnAddPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(101, 46);
            this.btnAddPicture.TabIndex = 1;
            this.btnAddPicture.Text = "افزودن پروفایل";
            this.btnAddPicture.UseVisualStyleBackColor = false;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(163, 63);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام کاربری:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.Location = new System.Drawing.Point(100, 63);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(64, 24);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "نام کاربری:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(337, 203);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "درباره من:";
            // 
            // txtAboutMe
            // 
            this.txtAboutMe.Location = new System.Drawing.Point(114, 186);
            this.txtAboutMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAboutMe.Multiline = true;
            this.txtAboutMe.Name = "txtAboutMe";
            this.txtAboutMe.ReadOnly = true;
            this.txtAboutMe.Size = new System.Drawing.Size(217, 60);
            this.txtAboutMe.TabIndex = 3;
            // 
            // btnEditAboutMe
            // 
            this.btnEditAboutMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnEditAboutMe.ForeColor = System.Drawing.Color.White;
            this.btnEditAboutMe.Location = new System.Drawing.Point(16, 193);
            this.btnEditAboutMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditAboutMe.Name = "btnEditAboutMe";
            this.btnEditAboutMe.Size = new System.Drawing.Size(92, 45);
            this.btnEditAboutMe.TabIndex = 1;
            this.btnEditAboutMe.Text = "ویرایش";
            this.btnEditAboutMe.UseVisualStyleBackColor = false;
            this.btnEditAboutMe.Click += new System.EventHandler(this.btnEditAboutMe_Click);
            // 
            // chkPublicProfile
            // 
            this.chkPublicProfile.AutoSize = true;
            this.chkPublicProfile.Location = new System.Drawing.Point(250, 273);
            this.chkPublicProfile.Name = "chkPublicProfile";
            this.chkPublicProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPublicProfile.Size = new System.Drawing.Size(141, 28);
            this.chkPublicProfile.TabIndex = 4;
            this.chkPublicProfile.Text = "نمایش پروفایل عمومی";
            this.chkPublicProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxShowPass);
            this.groupBox1.Controls.Add(this.btnEditPass);
            this.groupBox1.Controls.Add(this.txtNewPass);
            this.groupBox1.Controls.Add(this.txtLastPass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پسوورد";
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Enabled = false;
            this.checkBoxShowPass.Location = new System.Drawing.Point(194, 121);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(101, 28);
            this.checkBoxShowPass.TabIndex = 4;
            this.checkBoxShowPass.Text = "نمایش پسوورد";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // btnEditPass
            // 
            this.btnEditPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnEditPass.ForeColor = System.Drawing.Color.White;
            this.btnEditPass.Location = new System.Drawing.Point(28, 133);
            this.btnEditPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditPass.Name = "btnEditPass";
            this.btnEditPass.Size = new System.Drawing.Size(77, 43);
            this.btnEditPass.TabIndex = 1;
            this.btnEditPass.Text = "ویرایش";
            this.btnEditPass.UseVisualStyleBackColor = false;
            this.btnEditPass.Click += new System.EventHandler(this.btnEditPass_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Enabled = false;
            this.txtNewPass.Location = new System.Drawing.Point(90, 72);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPass.Multiline = true;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.ReadOnly = true;
            this.txtNewPass.Size = new System.Drawing.Size(118, 31);
            this.txtNewPass.TabIndex = 3;
            // 
            // txtLastPass
            // 
            this.txtLastPass.Enabled = false;
            this.txtLastPass.Location = new System.Drawing.Point(90, 33);
            this.txtLastPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastPass.Multiline = true;
            this.txtLastPass.Name = "txtLastPass";
            this.txtLastPass.PasswordChar = '*';
            this.txtLastPass.ReadOnly = true;
            this.txtLastPass.Size = new System.Drawing.Size(118, 31);
            this.txtLastPass.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(219, 75);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "پسوورد جدید:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(224, 33);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "پسوورد قبلی:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("2  Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(25, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "تمامی اطلاعات شخصی شما که موقع ثبت نام وارد کردید محفوظ است";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // btnExitAccount
            // 
            this.btnExitAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnExitAccount.ForeColor = System.Drawing.Color.White;
            this.btnExitAccount.Location = new System.Drawing.Point(18, 264);
            this.btnExitAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExitAccount.Name = "btnExitAccount";
            this.btnExitAccount.Size = new System.Drawing.Size(152, 45);
            this.btnExitAccount.TabIndex = 1;
            this.btnExitAccount.Text = "خروج از حساب کاربری";
            this.btnExitAccount.UseVisualStyleBackColor = false;
            this.btnExitAccount.Click += new System.EventHandler(this.btnExitAccount_Click);
            // 
            // chkMedicineReminder
            // 
            this.chkMedicineReminder.AutoSize = true;
            this.chkMedicineReminder.Location = new System.Drawing.Point(53, 265);
            this.chkMedicineReminder.Name = "chkMedicineReminder";
            this.chkMedicineReminder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMedicineReminder.Size = new System.Drawing.Size(79, 28);
            this.chkMedicineReminder.TabIndex = 0;
            this.chkMedicineReminder.Text = "یادآور دارو";
            this.chkMedicineReminder.UseVisualStyleBackColor = true;
            // 
            // chkVisitReminder
            // 
            this.chkVisitReminder.AutoSize = true;
            this.chkVisitReminder.Location = new System.Drawing.Point(40, 224);
            this.chkVisitReminder.Name = "chkVisitReminder";
            this.chkVisitReminder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkVisitReminder.Size = new System.Drawing.Size(92, 28);
            this.chkVisitReminder.TabIndex = 0;
            this.chkVisitReminder.Text = "یادآور ویزیت";
            this.chkVisitReminder.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Location = new System.Drawing.Point(40, 326);
            this.numericUpDownFontSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownFontSize.TabIndex = 3;
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTheme);
            this.groupBox2.Location = new System.Drawing.Point(158, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 115);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تم برنامه";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.comboBoxTheme.Location = new System.Drawing.Point(16, 47);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(131, 32);
            this.comboBoxTheme.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(268, 333);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "فونت سایز:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 76);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownFontSize);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.chkMedicineReminder);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.chkVisitReminder);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picProfile);
            this.splitContainer1.Panel2.Controls.Add(this.txtAboutMe);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveChanges);
            this.splitContainer1.Panel2.Controls.Add(this.btnEditAboutMe);
            this.splitContainer1.Panel2.Controls.Add(this.lblLastName);
            this.splitContainer1.Panel2.Controls.Add(this.chkPublicProfile);
            this.splitContainer1.Panel2.Controls.Add(this.lblFirstName);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnExitAccount);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lblUserName);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddPicture);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.splitContainer1.Size = new System.Drawing.Size(764, 402);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(18, 333);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(375, 47);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "ثبت تغییرات";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastName.Location = new System.Drawing.Point(100, 27);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLastName.Size = new System.Drawing.Size(64, 24);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام کاربری:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFirstName.Location = new System.Drawing.Point(163, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFirstName.Size = new System.Drawing.Size(64, 24);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "نام کاربری:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "حذف پروفایل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(343, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 35);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(764, 475);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSetting";
            this.Text = "FrmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAboutMe;
        private System.Windows.Forms.Button btnEditAboutMe;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtLastPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.CheckBox chkPublicProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExitAccount;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.CheckBox chkMedicineReminder;
        private System.Windows.Forms.CheckBox chkVisitReminder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBack;
    }
}