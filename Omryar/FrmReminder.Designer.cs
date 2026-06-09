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
            this.LastTakenTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepeatValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepeatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRepeatValue = new System.Windows.Forms.NumericUpDown();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.mtxtDrugName = new Omryar.MyTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmrReminder = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatValue)).BeginInit();
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
            this.LastTakenTime,
            this.Note,
            this.DrugQty,
            this.IsActive,
            this.Id,
            this.RepeatValue,
            this.RepeatType,
            this.DrugName,
            this.ColDelete,
            this.ColEdit});
            this.dgvReminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReminder.Location = new System.Drawing.Point(0, 0);
            this.dgvReminder.Name = "dgvReminder";
            this.dgvReminder.ReadOnly = true;
            this.dgvReminder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReminder.Size = new System.Drawing.Size(600, 619);
            this.dgvReminder.TabIndex = 0;
            this.dgvReminder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReminder_CellContentClick);
            // 
            // ColRow
            // 
            this.ColRow.DataPropertyName = "ColRow";
            this.ColRow.HeaderText = "ردیف";
            this.ColRow.Name = "ColRow";
            this.ColRow.ReadOnly = true;
            // 
            // LastTakenTime
            // 
            this.LastTakenTime.DataPropertyName = "LastTakenTime";
            this.LastTakenTime.HeaderText = "آخرین زمان مصرف";
            this.LastTakenTime.Name = "LastTakenTime";
            this.LastTakenTime.ReadOnly = true;
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(246, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = ":فاصله تکرار";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(266, 133);
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
            this.btnRecord.Location = new System.Drawing.Point(84, 565);
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
            this.label3.Location = new System.Drawing.Point(256, 308);
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvReminder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxtype);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox6);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxActive);
            this.splitContainer1.Panel2.Controls.Add(this.rtxtNote);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownQty);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownRepeatValue);
            this.splitContainer1.Panel2.Controls.Add(this.btnBack);
            this.splitContainer1.Panel2.Controls.Add(this.btnSetting);
            this.splitContainer1.Panel2.Controls.Add(this.btnRecord);
            this.splitContainer1.Panel2.Controls.Add(this.mtxtDrugName);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(944, 619);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 10;
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Location = new System.Drawing.Point(23, 201);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(128, 25);
            this.comboBoxtype.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 468);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 24);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBoxActive.Location = new System.Drawing.Point(198, 520);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxActive.Size = new System.Drawing.Size(112, 28);
            this.checkBoxActive.TabIndex = 17;
            this.checkBoxActive.Text = "فعال بودن یادآور";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.Location = new System.Drawing.Point(23, 348);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(146, 96);
            this.rtxtNote.TabIndex = 16;
            this.rtxtNote.Text = "";
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Location = new System.Drawing.Point(23, 308);
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownQty.Size = new System.Drawing.Size(146, 24);
            this.numericUpDownQty.TabIndex = 15;
            // 
            // numericUpDownRepeatValue
            // 
            this.numericUpDownRepeatValue.Location = new System.Drawing.Point(23, 265);
            this.numericUpDownRepeatValue.Name = "numericUpDownRepeatValue";
            this.numericUpDownRepeatValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownRepeatValue.Size = new System.Drawing.Size(146, 24);
            this.numericUpDownRepeatValue.TabIndex = 15;
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
            // mtxtDrugName
            // 
            this.mtxtDrugName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtDrugName.BackColor = System.Drawing.Color.White;
            this.mtxtDrugName.Location = new System.Drawing.Point(23, 133);
            this.mtxtDrugName.Multiline = true;
            this.mtxtDrugName.Name = "mtxtDrugName";
            this.mtxtDrugName.Size = new System.Drawing.Size(195, 32);
            this.mtxtDrugName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(184, 468);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "آخرین زمان مصرف دارو:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(226, 348);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "هشدار/یادداشت:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(258, 202);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "نوع تکرار:";
            // 
            // tmrReminder
            // 
            this.tmrReminder.Interval = 60000;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReminder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecord;
        private MyTextBox mtxtDrugName;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastTakenTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugQty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepeatValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepeatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
    }
}