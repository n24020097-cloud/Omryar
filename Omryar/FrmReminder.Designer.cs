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
            this.dgvReminder = new System.Windows.Forms.DataGridView();
            this.ColRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReminderDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnEvereXHours = new System.Windows.Forms.RadioButton();
            this.rdbtnDaily = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mtxtDosage = new Omryar.MyTextBox();
            this.mtxtRepeatValue = new Omryar.MyTextBox();
            this.mtxtDrugName = new Omryar.MyTextBox();
            this.tmrReminder = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReminder
            // 
            this.dgvReminder.AllowUserToAddRows = false;
            this.dgvReminder.AllowUserToDeleteRows = false;
            this.dgvReminder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRow,
            this.DrugId,
            this.DrugName,
            this.ReminderDosage,
            this.ColDelete,
            this.ColEdit});
            this.dgvReminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReminder.Location = new System.Drawing.Point(0, 0);
            this.dgvReminder.Name = "dgvReminder";
            this.dgvReminder.ReadOnly = true;
            this.dgvReminder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReminder.Size = new System.Drawing.Size(600, 548);
            this.dgvReminder.TabIndex = 0;
            this.dgvReminder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReminder_CellContentClick);
            this.dgvReminder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReminder_CellFormatting);
            // 
            // ColRow
            // 
            this.ColRow.DataPropertyName = "ColRow";
            this.ColRow.HeaderText = "ردیف";
            this.ColRow.Name = "ColRow";
            this.ColRow.ReadOnly = true;
            // 
            // DrugId
            // 
            this.DrugId.DataPropertyName = "DrugId";
            this.DrugId.HeaderText = "شناسه";
            this.DrugId.Name = "DrugId";
            this.DrugId.ReadOnly = true;
            // 
            // DrugName
            // 
            this.DrugName.DataPropertyName = "DrugName";
            this.DrugName.HeaderText = "نام دارو";
            this.DrugName.Name = "DrugName";
            this.DrugName.ReadOnly = true;
            // 
            // ReminderDosage
            // 
            this.ReminderDosage.DataPropertyName = "ReminderDosage";
            this.ReminderDosage.HeaderText = "تعداد دارو";
            this.ReminderDosage.Name = "ReminderDosage";
            this.ReminderDosage.ReadOnly = true;
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(213, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = ":مقدار تکرار";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(229, 181);
            this.label1.Name = "label1";
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
            this.btnRecord.Location = new System.Drawing.Point(65, 431);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(179, 42);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "ثبت";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnEvereXHours);
            this.groupBox1.Controls.Add(this.rdbtnDaily);
            this.groupBox1.Font = new System.Drawing.Font("2  Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(28, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(221, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع تکرار یادآوری";
            // 
            // rdbtnEvereXHours
            // 
            this.rdbtnEvereXHours.AutoSize = true;
            this.rdbtnEvereXHours.Font = new System.Drawing.Font("2  Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbtnEvereXHours.Location = new System.Drawing.Point(36, 30);
            this.rdbtnEvereXHours.Name = "rdbtnEvereXHours";
            this.rdbtnEvereXHours.Size = new System.Drawing.Size(56, 25);
            this.rdbtnEvereXHours.TabIndex = 0;
            this.rdbtnEvereXHours.TabStop = true;
            this.rdbtnEvereXHours.Text = "ساعتی";
            this.rdbtnEvereXHours.UseVisualStyleBackColor = true;
            // 
            // rdbtnDaily
            // 
            this.rdbtnDaily.AutoSize = true;
            this.rdbtnDaily.Font = new System.Drawing.Font("2  Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbtnDaily.Location = new System.Drawing.Point(126, 30);
            this.rdbtnDaily.Name = "rdbtnDaily";
            this.rdbtnDaily.Size = new System.Drawing.Size(51, 25);
            this.rdbtnDaily.TabIndex = 0;
            this.rdbtnDaily.TabStop = true;
            this.rdbtnDaily.Text = "روزانه";
            this.rdbtnDaily.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(213, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = ":تعداد داروی مصرفی";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(660, 82);
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvReminder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnBack);
            this.splitContainer1.Panel2.Controls.Add(this.btnSetting);
            this.splitContainer1.Panel2.Controls.Add(this.mtxtDosage);
            this.splitContainer1.Panel2.Controls.Add(this.mtxtRepeatValue);
            this.splitContainer1.Panel2.Controls.Add(this.btnRecord);
            this.splitContainer1.Panel2.Controls.Add(this.mtxtDrugName);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(944, 548);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 10;
            // 
            // mtxtDosage
            // 
            this.mtxtDosage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtDosage.Location = new System.Drawing.Point(28, 354);
            this.mtxtDosage.MaxLength = 3;
            this.mtxtDosage.Multiline = true;
            this.mtxtDosage.Name = "mtxtDosage";
            this.mtxtDosage.Size = new System.Drawing.Size(179, 32);
            this.mtxtDosage.TabIndex = 2;
            this.mtxtDosage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtDosage_KeyPress);
            // 
            // mtxtRepeatValue
            // 
            this.mtxtRepeatValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtRepeatValue.BackColor = System.Drawing.Color.White;
            this.mtxtRepeatValue.Location = new System.Drawing.Point(28, 318);
            this.mtxtRepeatValue.MaxLength = 3;
            this.mtxtRepeatValue.Multiline = true;
            this.mtxtRepeatValue.Name = "mtxtRepeatValue";
            this.mtxtRepeatValue.Size = new System.Drawing.Size(179, 32);
            this.mtxtRepeatValue.TabIndex = 1;
            this.mtxtRepeatValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtRepeatValue_KeyPress);
            // 
            // mtxtDrugName
            // 
            this.mtxtDrugName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtDrugName.BackColor = System.Drawing.Color.White;
            this.mtxtDrugName.Location = new System.Drawing.Point(28, 173);
            this.mtxtDrugName.Multiline = true;
            this.mtxtDrugName.Name = "mtxtDrugName";
            this.mtxtDrugName.Size = new System.Drawing.Size(195, 32);
            this.mtxtDrugName.TabIndex = 0;
            // 
            // tmrReminder
            // 
            this.tmrReminder.Interval = 60000;
            this.tmrReminder.Tick += new System.EventHandler(this.tmrReminder_Tick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(13, 27);
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
            // FrmReminder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 548);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("2  Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmReminder";
            this.Text = "FrmReminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReminder_FormClosing);
            this.Load += new System.EventHandler(this.FrmReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReminder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecord;
        private MyTextBox mtxtRepeatValue;
        private MyTextBox mtxtDrugName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnEvereXHours;
        private System.Windows.Forms.RadioButton rdbtnDaily;
        private MyTextBox mtxtDosage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer tmrReminder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReminderDosage;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
    }
}