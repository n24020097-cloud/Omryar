using Omryar.DAL;
using Omryar.Domain;
using Omryar.Domain.DTOs;
using Omryar.Domain.DTOs.DrugDtos;
using Omryar.Domain.Enums;
using Omryar.Domain.Interfaces;
using Omryar.Helpers;
using Omryar.Service;
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
using Drug = Omryar.Domain.Drug;

namespace Omryar
{
    public partial class FrmReminder : Form
    {
        IDrugService _drugService = AppFactory.DrugService();
        int _currentDrugId;
        public FrmReminder()
        {
            InitializeComponent();
        }

        private async void btnRecord_Click(object sender, EventArgs e)
        {
            var drug = new DrugDto()
            {
                Id = _currentDrugId,
                DrugName = txtDrugName.Text,
                DrugQty = int.Parse(numericUpDownQty.Value.ToString()),
                IsActive = checkBoxActive.Checked,
                LastTakenTime = dateTimePicker1.Value,
                Note = rtxtNote.Text,
                RepeatType = (RepeatType)comboBoxtype.SelectedIndex,
                RepeatValue = int.Parse(numericUpDownRepeatValue.Value.ToString()),
                PersonId = StaticData.CurrentUser.Id,
                NextTokenTime = DrugScheduleCalculator.Calculate
                (dateTimePicker1.Value,
                (RepeatType)comboBoxtype.SelectedIndex,
                int.Parse(numericUpDownRepeatValue.Value.ToString()))
            };
            if (_currentDrugId == 0)
            {
                var result = await _drugService.AddDrugAsync(drug);
                MessageBox.Show(result.Message);
            }
            else
            {
                var result = await _drugService.UpdateDrugAsync(drug);
                MessageBox.Show(result.Message);
            }
            await fillDgvAllDrugs();
            await FillTodayDrugsGridAsync();
            clearFrm();
        }

        private async void FrmReminder_Load(object sender, EventArgs e)
        {
            await fillDgvAllDrugs();
            await FillTodayDrugsGridAsync();
            LoadComboBox();
            await CheckOverdueDrugsAsync();

        }

        private async Task CheckOverdueDrugsAsync()
        {
            var todayDrugs = dgvTodayDrugs.DataSource as List<TodayDrugDto>;
            if (todayDrugs == null) return;

            var overdueDrugs = todayDrugs
                .Where(d => d.NextTokenTime <= DateTime.Now)
                .ToList();

            foreach (var drug in overdueDrugs)
            {
                var answer = MessageBox.Show(
                    $"آیا داروی «{drug.DrugName}» را مصرف کردید؟",
                    "یادآوری دارو",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                    await MarkAsTakenAndRefreshAsync(drug.Id);
            }
        }
       
        private void LoadComboBox()
        {
            comboBoxtype.Items.Add("ساعتی");
            comboBoxtype.Items.Add("روزانه");
            comboBoxtype.Items.Add("هفتگی");
            comboBoxtype.DisplayMember = "Text";
            comboBoxtype.ValueMember = "Value";
        }

        private async void dgvAllDrugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex<=0) return;
            var drug = dgvAllDrugs.Rows[e.RowIndex].DataBoundItem as DrugDto;
            if (drug == null) return;
            if (dgvAllDrugs.Columns[e.ColumnIndex].HeaderText == "ویرایش")
            {
                var fullDrug = await _drugService.GetDrugByIdAsync(drug.Id);
                _currentDrugId = fullDrug.Data.Id;
                txtDrugName.Text = fullDrug.Data.DrugName;
                rtxtNote.Text = fullDrug.Data.Note;
                numericUpDownQty.Value = fullDrug.Data.DrugQty;
                numericUpDownRepeatValue.Value=fullDrug.Data.RepeatValue;
                comboBoxtype.SelectedIndex = (int)fullDrug.Data.RepeatType;
                checkBoxActive.Checked = fullDrug.Data.IsActive;
                dateTimePicker1.Value = (DateTime)fullDrug.Data.LastTakenTime;
            }

            if (dgvAllDrugs.Columns[e.ColumnIndex].HeaderText == "حذف")
            {
                await _drugService.DeleteDrugAsync(drug.Id);
                clearFrm();
                await fillDgvAllDrugs();
            }
        }

        private async Task fillDgvAllDrugs()
        {
            dgvAllDrugs.DataSource = await _drugService
                .GetDrugsByPersonIdAsync(StaticData.CurrentUser.Id);
        }

        private async Task FillTodayDrugsGridAsync()
        {
            dgvTodayDrugs.DataSource = await _drugService
                .GetTodayDrugsAsync(StaticData.CurrentUser.Id);
        }

        private void clearFrm()
        {
            txtDrugName.Text = "";
            rtxtNote.Text = "";
            numericUpDownQty.Value = 0;
            numericUpDownRepeatValue.Value = 0;
            checkBoxActive.Checked=false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmHome().Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new FrmSetting().Show();
            this.Close();
        }

        private async void dgvTodayDrugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvTodayDrugs.Columns[e.ColumnIndex].Name != "columnStatus") return;

            var drug = dgvTodayDrugs.Rows[e.RowIndex].DataBoundItem as TodayDrugDto;
            if (drug == null) return;

            if (drug.NextTokenTime > DateTime.Now)
            {
                MessageBox.Show(
                    $"هنوز زمان مصرف «{drug.DrugName}» نرسیده است.",
                    "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var answer = MessageBox.Show(
                $"آیا داروی «{drug.DrugName}» را مصرف کردید؟",
                "تأیید مصرف دارو",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
                await MarkAsTakenAndRefreshAsync(drug.Id);
        }

        private async Task MarkAsTakenAndRefreshAsync(int drugId)
        {
            var result = await _drugService.MarkDrugAsTakenAsync(drugId);
            if (!string.IsNullOrEmpty(result.Message))
            {
                MessageBox.Show(result.Message, "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            await FillTodayDrugsGridAsync();
            await fillDgvAllDrugs();
        }
    }
}
