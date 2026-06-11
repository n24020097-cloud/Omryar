namespace Omryar
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnMedcationReminder = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnVisitReminder = new System.Windows.Forms.Button();
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(378, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(69, 67);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnMedcationReminder
            // 
            this.btnMedcationReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMedcationReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnMedcationReminder.FlatAppearance.BorderSize = 0;
            this.btnMedcationReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedcationReminder.ForeColor = System.Drawing.Color.White;
            this.btnMedcationReminder.Location = new System.Drawing.Point(325, 368);
            this.btnMedcationReminder.Name = "btnMedcationReminder";
            this.btnMedcationReminder.Size = new System.Drawing.Size(122, 47);
            this.btnMedcationReminder.TabIndex = 4;
            this.btnMedcationReminder.Text = "یادآوری دارو";
            this.btnMedcationReminder.UseVisualStyleBackColor = false;
            this.btnMedcationReminder.Click += new System.EventHandler(this.btnMedicationReminder_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDailyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnDailyReport.FlatAppearance.BorderSize = 0;
            this.btnDailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyReport.ForeColor = System.Drawing.Color.White;
            this.btnDailyReport.Location = new System.Drawing.Point(632, 368);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(122, 47);
            this.btnDailyReport.TabIndex = 6;
            this.btnDailyReport.Text = "گزارش روزانه";
            this.btnDailyReport.UseVisualStyleBackColor = false;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(735, 24);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(38, 40);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnCall
            // 
            this.btnCall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCall.BackColor = System.Drawing.Color.Transparent;
            this.btnCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCall.BackgroundImage")));
            this.btnCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCall.FlatAppearance.BorderSize = 0;
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall.Location = new System.Drawing.Point(12, 12);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(41, 40);
            this.btnCall.TabIndex = 1;
            this.btnCall.UseVisualStyleBackColor = false;
            // 
            // btnVisitReminder
            // 
            this.btnVisitReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVisitReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btnVisitReminder.FlatAppearance.BorderSize = 0;
            this.btnVisitReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitReminder.ForeColor = System.Drawing.Color.White;
            this.btnVisitReminder.Location = new System.Drawing.Point(480, 368);
            this.btnVisitReminder.Name = "btnVisitReminder";
            this.btnVisitReminder.Size = new System.Drawing.Size(122, 47);
            this.btnVisitReminder.TabIndex = 7;
            this.btnVisitReminder.Text = "یادآور ویزیت";
            this.btnVisitReminder.UseVisualStyleBackColor = false;
            this.btnVisitReminder.Click += new System.EventHandler(this.btnVisitReminder_Click);
            // 
            // dgvVisits
            // 
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IsDone,
            this.Notes,
            this.DisplayDateTime,
            this.VisitDateTime,
            this.Specialty,
            this.DoctorName,
            this.PersonId});
            this.dgvVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisits.Location = new System.Drawing.Point(3, 27);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.Size = new System.Drawing.Size(460, 210);
            this.dgvVisits.TabIndex = 8;
            this.dgvVisits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisits_CellContentClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(170, 85);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(72, 24);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "زمان مصرف:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(150, 141);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(92, 24);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "تعداد باقی مانده:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(154, 183);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(88, 24);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "یادداشت/هشدار:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "نام دارو:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Location = new System.Drawing.Point(23, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(263, 310);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "داروی بعدی";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(19, 192);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(123, 94);
            this.txtNote.TabIndex = 12;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(19, 138);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(123, 31);
            this.txtQty.TabIndex = 12;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(19, 82);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(123, 31);
            this.txtTime.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(19, 32);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(123, 31);
            this.txtName.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvVisits);
            this.groupBox2.Location = new System.Drawing.Point(307, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(466, 240);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نزدیک ترین ویزیت ها";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Column1";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // IsDone
            // 
            this.IsDone.DataPropertyName = "IsDone";
            this.IsDone.HeaderText = "Column1";
            this.IsDone.Name = "IsDone";
            this.IsDone.Visible = false;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "یادداشت";
            this.Notes.Name = "Notes";
            // 
            // DisplayDateTime
            // 
            this.DisplayDateTime.DataPropertyName = "DisplayDateTime";
            this.DisplayDateTime.HeaderText = "زمان ویزیت";
            this.DisplayDateTime.Name = "DisplayDateTime";
            // 
            // VisitDateTime
            // 
            this.VisitDateTime.DataPropertyName = "VisitDateTime";
            this.VisitDateTime.HeaderText = "Column1";
            this.VisitDateTime.Name = "VisitDateTime";
            this.VisitDateTime.Visible = false;
            // 
            // Specialty
            // 
            this.Specialty.DataPropertyName = "Specialty";
            this.Specialty.HeaderText = "تخصص";
            this.Specialty.Name = "Specialty";
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "DoctorName";
            this.DoctorName.HeaderText = "نام دکتر";
            this.DoctorName.Name = "DoctorName";
            // 
            // PersonId
            // 
            this.PersonId.DataPropertyName = "PersonId";
            this.PersonId.HeaderText = "Column1";
            this.PersonId.Name = "PersonId";
            this.PersonId.Visible = false;
            // 
            // FrmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVisitReminder);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnMedcationReminder);
            this.Controls.Add(this.btnDailyReport);
            this.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmHome";
            this.Text = "خانه";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnMedcationReminder;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnVisitReminder;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
    }
}