using Omryar.Domain.DTOs;
using Omryar.Domain.DTOs.ReportDtos;
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
    public partial class FrmVisitReminder : Form
    {
        public FrmVisitReminder()
        {
            InitializeComponent();
        }
        IVisitService _visitService;
        int _currentVisitId=0;
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void FrmVisitReminder_Load(object sender, EventArgs e)
        {
            _visitService = AppFactory.VisitService();
            dgvVisit.AutoGenerateColumns = false;
            dgvVisit.DataSource=await _visitService.GetByPersonIdAsync(StaticData.CurrentUser.Id);
            dgvVisit.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DoctorName",
                HeaderText = "پزشک",
                Name = "DoctorName"
            });

            dgvVisit.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Specialty",
                HeaderText = "تخصص",
                Name = "Specialty"
            });

            dgvVisit.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "VisitDateTime",
                HeaderText = "تاریخ و ساعت",
                Name = "VisitDateTime"
            });

            dgvVisit.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "IsDone",
                HeaderText = "انجام شده",
                Name = "IsDone"
            });

            dgvVisit.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "ویرایش",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Name = "Edit"
            });

            dgvVisit.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "حذف",
                Text = "X",
                UseColumnTextForButtonValue = true,
                Name = "Delete"
            });

        }
        public void clearFrm()
        {
            txtDoctorName.Text = "";
            txtSpecialty.Text = "";
            richTextBoxNote.Text = "";
        }
        private async void dgvVisit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var visit = dgvVisit.Rows[e.RowIndex].DataBoundItem as VisitReminderDto;
            if (visit == null) return;
            if (dgvVisit.Columns[e.ColumnIndex].HeaderText == "ویرایش")
            {
                var fullVisit = await _visitService.GetByIdAsync(visit.Id);
                _currentVisitId = fullVisit.Data.Id;
                richTextBoxNote.Text = fullVisit.Data.Notes;
                txtDoctorName.Text = fullVisit.Data.DoctorName;
                txtSpecialty.Text= fullVisit.Data.Specialty;
                dateTimePicker1.Value = fullVisit.Data.VisitDateTime;
            }

            if (dgvVisit.Columns[e.ColumnIndex].HeaderText == "حذف")
            {
                await _visitService.DeleteAsync(visit.Id);
                clearFrm();
                fillDgv();
            }
        }

        private async void btnSaveVisit_Click(object sender, EventArgs e)
        {
            var visit = new VisitReminderDto()
            {
                DoctorName = txtDoctorName.Text,
                Notes = richTextBoxNote.Text,
                Specialty = txtSpecialty.Text,
                VisitDateTime = dateTimePicker1.Value,
                PersonId=StaticData.CurrentUser.Id
            };
            if (_currentVisitId == 0)
            {
                var result = await _visitService.AddAsync(visit);
                MessageBox.Show(result.Message);
            }
            else
            {
                var result=await _visitService.UpdateAsync(visit);
                MessageBox.Show(result.Message);
            }
            clearFrm();
            fillDgv();
        }

        private async void fillDgv()
        {
            dgvVisit.DataSource=await _visitService.GetByPersonIdAsync(StaticData.CurrentUser.Id);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new FrmSetting().Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmHome().Show();
            this.Close();
        }
    }
}
