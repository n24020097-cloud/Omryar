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
            var drug=new DrugDto()
            {
                Id=_currentDrugId,
                DrugName = mtxtDrugName.Text,
                DrugQty = int.Parse(numericUpDownQty.Value.ToString()),
                IsActive = checkBoxActive.Checked,
                LastTakenTime = dateTimePicker1.Value,
                Note = rtxtNote.Text,
                RepeatType = (RepeatType)comboBoxtype.SelectedIndex,
                RepeatValue = int.Parse(numericUpDownRepeatValue.Value.ToString()),
                PersonId=StaticData.CurrentUser.Id
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
            fillDgv();
            clearFrm();
        }

        private void FrmReminder_Load(object sender, EventArgs e)
        {
            fillDgv();
            comboBoxtype.Items.Add("ساعتی");
            comboBoxtype.Items.Add("روزانه");
            comboBoxtype.Items.Add("هفتگی");

            comboBoxtype.DisplayMember = "Text";
            comboBoxtype.ValueMember = "Value";
        }

        private async void dgvReminder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex<=0) return;
            var drug = dgvReminder.Rows[e.RowIndex].DataBoundItem as DrugDto;
            if (drug == null) return;
            if (dgvReminder.Columns[e.ColumnIndex].HeaderText == "ویرایش")
            {
                var fullDrug = await _drugService.GetDrugByIdAsync(drug.Id);
                _currentDrugId = fullDrug.Data.Id;
                mtxtDrugName.Text = fullDrug.Data.DrugName;
                rtxtNote.Text = fullDrug.Data.Note;
                numericUpDownQty.Value = fullDrug.Data.DrugQty;
                numericUpDownRepeatValue.Value=fullDrug.Data.RepeatValue;
                comboBoxtype.SelectedIndex = (int)fullDrug.Data.RepeatType;
                checkBoxActive.Checked = fullDrug.Data.IsActive;
                dateTimePicker1.Value = (DateTime)fullDrug.Data.LastTakenTime;
            }

            if (dgvReminder.Columns[e.ColumnIndex].HeaderText == "حذف")
            {
                await _drugService.DeleteDrugAsync(drug.Id);
                clearFrm();
                fillDgv();
            }
        }

        private async void fillDgv()
        {
            dgvReminder.DataSource = await _drugService.GetDrugsByPersonIdAsync(StaticData.CurrentUser.Id);
        }

        private void clearFrm()
        {
            mtxtDrugName.Text = "";
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
    }
}
