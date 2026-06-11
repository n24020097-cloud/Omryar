namespace Omryar
{
    partial class FrmDailyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDailyReport));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.coledit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageTrash = new System.Windows.Forms.TabPage();
            this.dgvTrash = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DisplayTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.taskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldelete1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IsCompleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.brnSetting = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDownWater = new System.Windows.Forms.NumericUpDown();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtPokerEmoji = new System.Windows.Forms.RadioButton();
            this.rbtnAngryEmoji = new System.Windows.Forms.RadioButton();
            this.rbtnSadEmoji = new System.Windows.Forms.RadioButton();
            this.rbtnHappyEmoji = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.tabPageTrash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWater)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnGoBack);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTasks);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox6);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.brnSetting);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox5);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownWater);
            this.splitContainer1.Panel2.Controls.Add(this.rtxtNote);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddItem);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(951, 580);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 317);
            this.panel1.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReport);
            this.tabControl1.Controls.Add(this.tabPageTrash);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(271, 317);
            this.tabControl1.TabIndex = 11;
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.dgvReport);
            this.tabReport.Location = new System.Drawing.Point(4, 38);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(263, 275);
            this.tabReport.TabIndex = 0;
            this.tabReport.Text = "گزارش ها";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.date2,
            this.date,
            this.coldelete,
            this.coledit});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(3, 3);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(257, 269);
            this.dgvReport.TabIndex = 9;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colid
            // 
            this.colid.DataPropertyName = "Id";
            this.colid.HeaderText = "Column1";
            this.colid.Name = "colid";
            this.colid.Visible = false;
            // 
            // date2
            // 
            this.date2.DataPropertyName = "ReportDate";
            this.date2.HeaderText = "Column1";
            this.date2.Name = "date2";
            this.date2.Visible = false;
            // 
            // date
            // 
            this.date.DataPropertyName = "DisplayTitle";
            this.date.HeaderText = "تاریخ";
            this.date.Name = "date";
            // 
            // coldelete
            // 
            this.coldelete.HeaderText = "حذف";
            this.coldelete.Name = "coldelete";
            // 
            // coledit
            // 
            this.coledit.HeaderText = "ویرایش";
            this.coledit.Name = "coledit";
            // 
            // tabPageTrash
            // 
            this.tabPageTrash.Controls.Add(this.dgvTrash);
            this.tabPageTrash.Location = new System.Drawing.Point(4, 38);
            this.tabPageTrash.Name = "tabPageTrash";
            this.tabPageTrash.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrash.Size = new System.Drawing.Size(263, 275);
            this.tabPageTrash.TabIndex = 1;
            this.tabPageTrash.Text = "سطل زباله";
            this.tabPageTrash.UseVisualStyleBackColor = true;
            // 
            // dgvTrash
            // 
            this.dgvTrash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ReportDate,
            this.edit,
            this.delete,
            this.DisplayTitle});
            this.dgvTrash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrash.Location = new System.Drawing.Point(3, 3);
            this.dgvTrash.Name = "dgvTrash";
            this.dgvTrash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTrash.Size = new System.Drawing.Size(257, 269);
            this.dgvTrash.TabIndex = 0;
            this.dgvTrash.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrash_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ReportDate
            // 
            this.ReportDate.DataPropertyName = "ReportDate";
            this.ReportDate.HeaderText = "Column1";
            this.ReportDate.Name = "ReportDate";
            this.ReportDate.Visible = false;
            // 
            // edit
            // 
            this.edit.HeaderText = "ویرایش";
            this.edit.Name = "edit";
            // 
            // delete
            // 
            this.delete.HeaderText = "حذف";
            this.delete.Name = "delete";
            this.delete.Text = "X";
            // 
            // DisplayTitle
            // 
            this.DisplayTitle.DataPropertyName = "DisplayTitle";
            this.DisplayTitle.HeaderText = "تاریخ";
            this.DisplayTitle.Name = "DisplayTitle";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.button1.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "پاک کردن";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 495);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(271, 61);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "ثبت گزارش";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_ClickAsync);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(12, 16);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(51, 33);
            this.btnGoBack.TabIndex = 7;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(213, 138);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "گزارش ها:";
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskId,
            this.coldelete1,
            this.IsCompleted,
            this.TaskTitle});
            this.dgvTasks.Location = new System.Drawing.Point(410, 171);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(215, 385);
            this.dgvTasks.TabIndex = 0;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // taskId
            // 
            this.taskId.DataPropertyName = "Id";
            this.taskId.HeaderText = "Column1";
            this.taskId.Name = "taskId";
            this.taskId.Visible = false;
            // 
            // coldelete1
            // 
            this.coldelete1.HeaderText = "حذف";
            this.coldelete1.Name = "coldelete1";
            // 
            // IsCompleted
            // 
            this.IsCompleted.DataPropertyName = "IsCompleted";
            this.IsCompleted.HeaderText = "وضعیت";
            this.IsCompleted.Name = "IsCompleted";
            // 
            // TaskTitle
            // 
            this.TaskTitle.DataPropertyName = "TaskTitle";
            this.TaskTitle.HeaderText = "کار";
            this.TaskTitle.Name = "TaskTitle";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-8, 86);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(456, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(178, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // brnSetting
            // 
            this.brnSetting.BackColor = System.Drawing.Color.Transparent;
            this.brnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brnSetting.BackgroundImage")));
            this.brnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brnSetting.FlatAppearance.BorderSize = 0;
            this.brnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnSetting.Location = new System.Drawing.Point(599, 16);
            this.brnSetting.Name = "brnSetting";
            this.brnSetting.Size = new System.Drawing.Size(34, 33);
            this.brnSetting.TabIndex = 7;
            this.brnSetting.UseVisualStyleBackColor = false;
            this.brnSetting.Click += new System.EventHandler(this.brnSetting_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(347, 515);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(250, 515);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(147, 515);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 515);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDownWater
            // 
            this.numericUpDownWater.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownWater.Location = new System.Drawing.Point(56, 419);
            this.numericUpDownWater.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownWater.Name = "numericUpDownWater";
            this.numericUpDownWater.Size = new System.Drawing.Size(147, 37);
            this.numericUpDownWater.TabIndex = 4;
            // 
            // rtxtNote
            // 
            this.rtxtNote.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtxtNote.Location = new System.Drawing.Point(15, 172);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtxtNote.Size = new System.Drawing.Size(383, 207);
            this.rtxtNote.TabIndex = 3;
            this.rtxtNote.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(243, 395);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "امروز چقدر آب خوردی؟";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(270, 474);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "امروز حالت چطوره؟";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(254, 140);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "یادداشت و شکرگزاری:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("_MRT_Win2Farsi_2", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(410, 130);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(38, 35);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(550, 138);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "لیست کارها:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtPokerEmoji);
            this.panel2.Controls.Add(this.rbtnAngryEmoji);
            this.panel2.Controls.Add(this.rbtnSadEmoji);
            this.panel2.Controls.Add(this.rbtnHappyEmoji);
            this.panel2.Location = new System.Drawing.Point(10, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 46);
            this.panel2.TabIndex = 8;
            // 
            // rbtPokerEmoji
            // 
            this.rbtPokerEmoji.AutoSize = true;
            this.rbtPokerEmoji.Location = new System.Drawing.Point(314, 23);
            this.rbtPokerEmoji.Name = "rbtPokerEmoji";
            this.rbtPokerEmoji.Size = new System.Drawing.Size(14, 13);
            this.rbtPokerEmoji.TabIndex = 6;
            this.rbtPokerEmoji.TabStop = true;
            this.rbtPokerEmoji.Tag = "3";
            this.rbtPokerEmoji.UseVisualStyleBackColor = true;
            // 
            // rbtnAngryEmoji
            // 
            this.rbtnAngryEmoji.AutoSize = true;
            this.rbtnAngryEmoji.Location = new System.Drawing.Point(217, 23);
            this.rbtnAngryEmoji.Name = "rbtnAngryEmoji";
            this.rbtnAngryEmoji.Size = new System.Drawing.Size(14, 13);
            this.rbtnAngryEmoji.TabIndex = 6;
            this.rbtnAngryEmoji.TabStop = true;
            this.rbtnAngryEmoji.Tag = "2";
            this.rbtnAngryEmoji.UseVisualStyleBackColor = true;
            // 
            // rbtnSadEmoji
            // 
            this.rbtnSadEmoji.AutoSize = true;
            this.rbtnSadEmoji.Location = new System.Drawing.Point(114, 23);
            this.rbtnSadEmoji.Name = "rbtnSadEmoji";
            this.rbtnSadEmoji.Size = new System.Drawing.Size(14, 13);
            this.rbtnSadEmoji.TabIndex = 6;
            this.rbtnSadEmoji.TabStop = true;
            this.rbtnSadEmoji.Tag = "1";
            this.rbtnSadEmoji.UseVisualStyleBackColor = true;
            // 
            // rbtnHappyEmoji
            // 
            this.rbtnHappyEmoji.AutoSize = true;
            this.rbtnHappyEmoji.Location = new System.Drawing.Point(10, 21);
            this.rbtnHappyEmoji.Name = "rbtnHappyEmoji";
            this.rbtnHappyEmoji.Size = new System.Drawing.Size(14, 13);
            this.rbtnHappyEmoji.TabIndex = 6;
            this.rbtnHappyEmoji.TabStop = true;
            this.rbtnHappyEmoji.Tag = "0";
            this.rbtnHappyEmoji.UseVisualStyleBackColor = true;
            // 
            // FrmDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 580);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDailyReport";
            this.Text = "گزارش روزانه";
            this.Load += new System.EventHandler(this.FrmDailyReport_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.tabPageTrash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWater)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.RichTextBox rtxtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownWater;
        private System.Windows.Forms.RadioButton rbtPokerEmoji;
        private System.Windows.Forms.RadioButton rbtnAngryEmoji;
        private System.Windows.Forms.RadioButton rbtnSadEmoji;
        private System.Windows.Forms.RadioButton rbtnHappyEmoji;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button brnSetting;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TabPage tabPageTrash;
        private System.Windows.Forms.DataGridView dgvTrash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportDate;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewButtonColumn coldelete;
        private System.Windows.Forms.DataGridViewButtonColumn coledit;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskId;
        private System.Windows.Forms.DataGridViewButtonColumn coldelete1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTitle;
    }
}