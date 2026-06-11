namespace Omryar
{
    partial class FrmReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReminder));
            this.dgvAllDrugs = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTodayDrugs = new System.Windows.Forms.DataGridView();
            this.DrugName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextTokenTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepeatType1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepeatValue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastTakenTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugQty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.txtDrugName = new Omryar.MyTextBox();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRepeatValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.tmrReminder = new System.Windows.Forms.Timer(this.components);
            this.LastTakenTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextTokenTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepeatValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepeatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDrugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayDrugs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatValue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllDrugs
            // 
            this.dgvAllDrugs.AllowUserToAddRows = false;
            this.dgvAllDrugs.AllowUserToDeleteRows = false;
            this.dgvAllDrugs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastTakenTime,
            this.NextTokenTime1,
            this.Note,
            this.DrugQty,
            this.IsActive,
            this.Id,
            this.PersonId,
            this.RepeatValue,
            this.RepeatType,
            this.DrugName,
            this.ColDelete,
            this.ColEdit});
            this.dgvAllDrugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllDrugs.Location = new System.Drawing.Point(3, 23);
            this.dgvAllDrugs.Name = "dgvAllDrugs";
            this.dgvAllDrugs.ReadOnly = true;
            this.dgvAllDrugs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllDrugs.Size = new System.Drawing.Size(594, 292);
            this.dgvAllDrugs.TabIndex = 0;
            this.dgvAllDrugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllDrugs_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(214, 133);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = ":فاصله تکرار";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(238, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = ":نام دارو";
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnRecord.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRecord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecord.Location = new System.Drawing.Point(64, 416);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(179, 42);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "ثبت";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(224, 173);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "تعداد کل:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(47, 82);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(254, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(742, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox6);
            this.splitContainer1.Panel2.Controls.Add(this.btnBack);
            this.splitContainer1.Panel2.Controls.Add(this.btnSetting);
            this.splitContainer1.Size = new System.Drawing.Size(944, 619);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAllDrugs);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("2  Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(0, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(600, 318);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "کل دارو ها";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTodayDrugs);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("2  Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(600, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "داروهای امروز";
            // 
            // dgvTodayDrugs
            // 
            this.dgvTodayDrugs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTodayDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrugName1,
            this.NextTokenTime,
            this.drugid,
            this.RepeatType1,
            this.RepeatValue1,
            this.LastTakenTime1,
            this.Notes1,
            this.DrugQty1,
            this.columnStatus});
            this.dgvTodayDrugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayDrugs.Location = new System.Drawing.Point(3, 25);
            this.dgvTodayDrugs.Name = "dgvTodayDrugs";
            this.dgvTodayDrugs.Size = new System.Drawing.Size(594, 262);
            this.dgvTodayDrugs.TabIndex = 0;
            this.dgvTodayDrugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodayDrugs_CellContentClick);
            // 
            // DrugName1
            // 
            this.DrugName1.DataPropertyName = "DrugName";
            this.DrugName1.HeaderText = "نام دارو";
            this.DrugName1.Name = "DrugName1";
            // 
            // NextTokenTime
            // 
            this.NextTokenTime.DataPropertyName = "NextTokenTime";
            this.NextTokenTime.HeaderText = "زمان مصرف";
            this.NextTokenTime.Name = "NextTokenTime";
            // 
            // drugid
            // 
            this.drugid.DataPropertyName = "Id";
            this.drugid.HeaderText = "Column1";
            this.drugid.Name = "drugid";
            this.drugid.Visible = false;
            // 
            // RepeatType1
            // 
            this.RepeatType1.DataPropertyName = "RepeatType";
            this.RepeatType1.HeaderText = "نوع مصرف";
            this.RepeatType1.Name = "RepeatType1";
            this.RepeatType1.Visible = false;
            // 
            // RepeatValue1
            // 
            this.RepeatValue1.DataPropertyName = "RepeatValue";
            this.RepeatValue1.HeaderText = "فاصله مصرف";
            this.RepeatValue1.Name = "RepeatValue1";
            this.RepeatValue1.Visible = false;
            // 
            // LastTakenTime1
            // 
            this.LastTakenTime1.DataPropertyName = "LastTakenTime";
            this.LastTakenTime1.HeaderText = "آخرین زمان مصرف";
            this.LastTakenTime1.Name = "LastTakenTime1";
            this.LastTakenTime1.Visible = false;
            // 
            // Notes1
            // 
            this.Notes1.DataPropertyName = "Note";
            this.Notes1.HeaderText = "یادداشت/هشدار";
            this.Notes1.Name = "Notes1";
            // 
            // DrugQty1
            // 
            this.DrugQty1.DataPropertyName = "DrugQty";
            this.DrugQty1.HeaderText = "تعداد باقی مانده";
            this.DrugQty1.Name = "DrugQty1";
            // 
            // columnStatus
            // 
            this.columnStatus.HeaderText = "وضعیت مصرف";
            this.columnStatus.Name = "columnStatus";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxtype);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkBoxActive);
            this.groupBox1.Controls.Add(this.txtDrugName);
            this.groupBox1.Controls.Add(this.btnRecord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtxtNote);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownQty);
            this.groupBox1.Controls.Add(this.numericUpDownRepeatValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("2  Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(23, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(302, 479);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت داروی جدید";
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Location = new System.Drawing.Point(12, 84);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(128, 31);
            this.comboBoxtype.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 328);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 29);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBoxActive.Location = new System.Drawing.Point(170, 382);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxActive.Size = new System.Drawing.Size(112, 28);
            this.checkBoxActive.TabIndex = 17;
            this.checkBoxActive.Text = "فعال بودن یادآور";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // txtDrugName
            // 
            this.txtDrugName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDrugName.BackColor = System.Drawing.Color.White;
            this.txtDrugName.Location = new System.Drawing.Point(12, 27);
            this.txtDrugName.Multiline = true;
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(195, 32);
            this.txtDrugName.TabIndex = 0;
            // 
            // rtxtNote
            // 
            this.rtxtNote.Location = new System.Drawing.Point(12, 214);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(146, 96);
            this.rtxtNote.TabIndex = 16;
            this.rtxtNote.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("2  Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(173, 328);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "آخرین زمان مصرف دارو:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(228, 82);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "نوع تکرار:";
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Location = new System.Drawing.Point(12, 173);
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownQty.Size = new System.Drawing.Size(146, 29);
            this.numericUpDownQty.TabIndex = 15;
            // 
            // numericUpDownRepeatValue
            // 
            this.numericUpDownRepeatValue.Location = new System.Drawing.Point(12, 133);
            this.numericUpDownRepeatValue.Name = "numericUpDownRepeatValue";
            this.numericUpDownRepeatValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownRepeatValue.Size = new System.Drawing.Size(146, 29);
            this.numericUpDownRepeatValue.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(196, 212);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "هشدار/یادداشت:";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(23, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 35);
            this.btnBack.TabIndex = 13;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(290, 24);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(38, 40);
            this.btnSetting.TabIndex = 14;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // tmrReminder
            // 
            this.tmrReminder.Interval = 60000;
            // 
            // LastTakenTime
            // 
            this.LastTakenTime.DataPropertyName = "LastTakenTime";
            this.LastTakenTime.HeaderText = "آخرین زمان مصرف";
            this.LastTakenTime.Name = "LastTakenTime";
            this.LastTakenTime.ReadOnly = true;
            // 
            // NextTokenTime1
            // 
            this.NextTokenTime1.DataPropertyName = "NextTokenTime";
            this.NextTokenTime1.HeaderText = "Column1";
            this.NextTokenTime1.Name = "NextTokenTime1";
            this.NextTokenTime1.ReadOnly = true;
            this.NextTokenTime1.Visible = false;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "هشدار/یادداشت";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // DrugQty
            // 
            this.DrugQty.DataPropertyName = "DrugQty";
            this.DrugQty.HeaderText = "تعداد باقی مانده";
            this.DrugQty.Name = "DrugQty";
            this.DrugQty.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "فعال بودن یادآور";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Column1";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // PersonId
            // 
            this.PersonId.DataPropertyName = "PersonId";
            this.PersonId.HeaderText = "Column1";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            this.PersonId.Visible = false;
            // 
            // RepeatValue
            // 
            this.RepeatValue.DataPropertyName = "RepeatValue";
            this.RepeatValue.HeaderText = "فاصله بین مصرف";
            this.RepeatValue.Name = "RepeatValue";
            this.RepeatValue.ReadOnly = true;
            // 
            // RepeatType
            // 
            this.RepeatType.DataPropertyName = "RepeatType";
            this.RepeatType.HeaderText = "نوع تکرار";
            this.RepeatType.Name = "RepeatType";
            this.RepeatType.ReadOnly = true;
            // 
            // DrugName
            // 
            this.DrugName.DataPropertyName = "DrugName";
            this.DrugName.HeaderText = "نام دارو";
            this.DrugName.Name = "DrugName";
            this.DrugName.ReadOnly = true;
            // 
            // ColDelete
            // 
            this.ColDelete.DataPropertyName = "ColDelete";
            this.ColDelete.HeaderText = "حذف";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            // 
            // ColEdit
            // 
            this.ColEdit.DataPropertyName = "ColEdit";
            this.ColEdit.HeaderText = "ویرایش";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            // 
            // FrmReminder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 619);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("2  Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmReminder";
            this.Text = "FrmReminder";
            this.Load += new System.EventHandler(this.FrmReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDrugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayDrugs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllDrugs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecord;
        private MyTextBox txtDrugName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer tmrReminder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.NumericUpDown numericUpDownRepeatValue;
        private System.Windows.Forms.RichTextBox rtxtNote;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTodayDrugs;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextTokenTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepeatType1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepeatValue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastTakenTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugQty1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastTakenTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextTokenTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugQty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepeatValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepeatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
    }
}