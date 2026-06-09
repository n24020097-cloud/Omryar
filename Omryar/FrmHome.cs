using Omryar.Domain.Interfaces;
using Omryar.Helpers;
using Omryar.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omryar
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        IVisitService _visitService;
        private void btnMedicationReminder_Click(object sender, EventArgs e)
        {
            new FrmReminder().Show();
            this.Hide();

        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            var frmdailyReport = new FrmDailyReport();
            this.Hide();
            frmdailyReport.Show();
        }

        private void btnVisitReminder_Click(object sender, EventArgs e)
        {
            var frmVisitReminder = new FrmVisitReminder();
            this.Hide();
            frmVisitReminder.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new FrmSetting().Show();
            this.Hide();
        }
        private void SetupDgvVisits()
        {
            dgvVisits.AutoGenerateColumns = false;
            dgvVisits.Columns.Clear();

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DoctorName",
                HeaderText = "پزشک"
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Specialty",
                HeaderText = "تخصص"
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VisitDateTime",
                HeaderText = "زمان ویزیت",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyyy/MM/dd HH:mm"
                }
            });

            dgvVisits.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Notes",
                HeaderText = "یادداشت"
            });
        }
        private async void FrmHome_Load(object sender, EventArgs e)
        {
            SetupDgvVisits();
            _visitService = AppFactory.VisitService();
            var visits = await _visitService.GetNext24HoursAsync(StaticData.CurrentUser.Id);

            dgvVisits.DataSource = visits;
        }
    }
}
