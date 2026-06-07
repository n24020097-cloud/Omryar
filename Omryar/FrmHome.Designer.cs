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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
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
            this.btnMedcationReminder.Location = new System.Drawing.Point(79, 303);
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
            this.btnDailyReport.Location = new System.Drawing.Point(79, 210);
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
            this.btnVisitReminder.Location = new System.Drawing.Point(79, 114);
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
            this.dgvVisits.Location = new System.Drawing.Point(378, 142);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.Size = new System.Drawing.Size(376, 136);
            this.dgvVisits.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = ":نزدیک ترین ویزیت ها";
            // 
            // FrmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVisits);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnMedcationReminder;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnVisitReminder;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.Label label1;
    }
}