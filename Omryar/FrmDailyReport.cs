using Omryar.Domain;
using Omryar.Domain.DTOs.ReportDtos;
using Omryar.Domain.Interfaces;
using Omryar.Helpers;
using Omryar.Service;
using Omryar.Service.Mappings;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Omryar.Shared.Messages;

namespace Omryar
{
    public partial class FrmDailyReport : Form
    {
        public FrmDailyReport()
        {
            InitializeComponent();
        }

        private IReportService _reportService;
        private int _currentReportId = 0;
        private BindingList<ReportTaskDto> _tasks = new BindingList<ReportTaskDto>();
        private async void FrmDailyReport_Load(object sender, EventArgs e)
        {
            _reportService = AppFactory.ReportService();

            dgvTrash.AutoGenerateColumns = false;
            dgvTrash.DataSource = await _reportService.GetDeletedReportAsync(StaticData.CurrentUser.Id);
            dgvTrash.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ReportDate",
                HeaderText = "تاریخ گزارش",
                Name = "ReportDate"
            });

            dgvTrash.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DisplayTitle",
                HeaderText = "عنوان",
                Name = "DisplayTitle"
            });

            dgvTrash.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "بازگردانی",
                Text = "Restore",
                UseColumnTextForButtonValue = true,
                Name = "Restore"
            });

            dgvTrash.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "حذف کامل",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "HardDelete"
            });



            dgvTasks.AutoGenerateColumns = false;
            dgvTasks.DataSource = _tasks;
            dgvTasks.ReadOnly = false;
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TaskTitle",
                HeaderText = "عنوان کار",
                Name = "TaskTitle"
            });

            dgvTasks.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "IsCompleted",
                HeaderText = "انجام شده",
                Name = "IsCompleted"
            });

            dgvTasks.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "حذف",
                Text = "X",
                UseColumnTextForButtonValue = true,
                Name = "Delete"
            });


            dgvReport.AutoGenerateColumns = false;
            await FillDgvReport();
            dgvReport.Columns.Clear();
            dgvReport.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ReportDate",
                HeaderText = "گزارش"
            });
            dgvReport.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ReportId",
                Visible = false
            });
            dgvReport.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "ویرایش",
                Text = "ویرایش",
                UseColumnTextForButtonValue = true
            });
            dgvReport.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "حذف",
                Text = "X",
                UseColumnTextForButtonValue = true
            });
        }
        public void FillDgvTasks(List<ReportTaskDto> tasks)
        {
            _tasks.Clear();

            if (tasks == null)
                return;

            foreach (var task in tasks)
            {
                _tasks.Add(task);
            }
        }
        public int GetSelectedMode()
        {
            foreach (RadioButton rbtn in panel2.Controls.OfType<RadioButton>())
            {
                if (rbtn.Checked)
                    return Convert.ToInt32(rbtn.Tag);
            }
            return 0;
        }

        public void SetSelectedMode(int modeValue)
        {
            foreach (RadioButton rbtn in panel2.Controls.OfType<RadioButton>())
            {
                if (Convert.ToInt32(rbtn.Tag) == modeValue)
                {
                    rbtn.Checked = true;
                    break;
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            _tasks.Add(new ReportTaskDto()
            {
                TaskTitle = "",
                IsCompleted = false
            });

            dgvTasks.CurrentCell = dgvTasks.Rows[dgvTasks.Rows.Count - 1].Cells[0];
            dgvTasks.BeginEdit(true);
        }
        public List<ReportTaskDto> GetTasks()
        {
            return _tasks.ToList();
        }
        private async void btnSave_ClickAsync(object sender, EventArgs e)
        {
            var report = new ReportDto()
            {
                DateReport= DateTime.Now.Date,
                Id = _currentReportId,
                WaterCups = (int)numericUpDownWater.Value,
                Notes = rtxtNote.Text,
                Mood = GetSelectedMode(),
                Tasks = GetTasks(),
                PersonId = StaticData.CurrentUser.Id,
            };

            if (_currentReportId == 0)
            {
                var result=await _reportService.AddReportAsync(report);
                if(!result.IsSuccess)
                    MessageBox.Show(result.Message);
            }
            else
            {
                var result = await _reportService.UpdateReportAsync(report);
                MessageBox.Show(result.Message);
            }
            await FillDgvReport();
            ClearForm();
        }
        private void ClearForm()
        {
            _currentReportId = 0;
            rtxtNote.Clear();
            numericUpDownWater.Value = 0;
            _tasks.Clear();
            FillDgvTasks(null);
            SetSelectedMode(0);
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            new FrmHome().Show();
            this.Close();
        }
        public async Task FillDgvTrash()
        {
            dgvTrash.DataSource = await _reportService.GetDeletedReportAsync(StaticData.CurrentUser.Id);
        }
        public async Task FillDgvReport()
        {
            var list = await _reportService.SelectReports(StaticData.CurrentUser.Id);
            dgvReport.DataSource = list.ToList();
        }
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var report = dgvReport.Rows[e.RowIndex].DataBoundItem as ReportListDto;
            if (report == null) return;
            if (dgvReport.Columns[e.ColumnIndex].HeaderText == "ویرایش")
            {
                var fullReport = await _reportService.GetReportByIdAsync(report.Id);
                _currentReportId = fullReport.Data.Id;
                rtxtNote.Text = fullReport.Data.Notes;
                numericUpDownWater.Value = fullReport.Data.WaterCups;
                FillDgvTasks(fullReport.Data.Tasks);
                SetSelectedMode(fullReport.Data.Mood);
            }

            if (dgvReport.Columns[e.ColumnIndex].HeaderText == "حذف")
            {
                await _reportService.DeleteReportLogicAsync(report.Id);
                await FillDgvReport();
                await FillDgvTrash();
            }
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvTasks.Columns[e.ColumnIndex].HeaderText == "حذف")
            {
                _tasks.RemoveAt(e.RowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void dgvTrash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var report = dgvTrash.Rows[e.RowIndex].DataBoundItem as ReportListDto;
            if (report == null) return;

            var column = dgvTrash.Columns[e.ColumnIndex].HeaderText;

            if (column == "بازگردانی")
            {
                await _reportService.RestoreReportAsync(report.Id);
                await FillDgvTrash();
                await FillDgvReport();
            }

            if (column == "حذف کامل")
            {
                var result=MessageBox.Show(Messages.ReportMessages.DeleteQuestion,"حذف کامل",MessageBoxButtons.OKCancel);
                if(result == DialogResult.Cancel) return;
                await _reportService.HardDeleteAsync(report.Id);
                await FillDgvTrash();
            }
        }

        private void brnSetting_Click(object sender, EventArgs e)
        {
            new FrmSetting().Show();
            this.Close();
        }
    }
}
