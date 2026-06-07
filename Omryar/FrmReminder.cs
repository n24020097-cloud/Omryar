using Omryar.DAL;
using Omryar.Domain;
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
        public FrmHome frmHome;
        IDrugService _drugService = AppFactory.DrugService();

        Drug drug;
        bool isEdit = false;
        int idForEdit = 0;
        public FrmReminder()
        {
            InitializeComponent();

        }
        private async void FrmReminder_Load(object sender, EventArgs e)
        {
           await FillDgv();
            tmrReminder.Enabled = true;
        }

        private async void btnRecord_Click(object sender, EventArgs e)
        {
            await Save();
           await FillDgv();
        }

        private async Task Save()
        {
            if (!isEdit)
            {
                drug = new Drug();
                btnRecord.Text = "ثبت";
            }

            var tDrugName = mtxtDrugName.Text;
            var tRepeatValue = mtxtRepeatValue.Text;
            var tDosage = mtxtDosage.Text;

            drug.DrugName = tDrugName;
            drug.Dosage = int.Parse(tDosage);
            drug.ReminderRepeatValue = int.Parse(tRepeatValue);
            drug.PersonId = StaticData.CurrentUser.Id;
            drug.ReminderDosage = drug.Dosage;


            if (rdbtnDaily.Checked)
                drug.ReminderRepeatType = RepeatType.Daily;
            else if (rdbtnEvereXHours.Checked)
                drug.ReminderRepeatType = RepeatType.EvereXHouers;
            else
                MessageBox.Show(Messages.Drug.ReminderRepeatType);

           

            var result = await _drugService.AddDrug(drug, idForEdit, StaticData.CurrentUser.Id);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message);
                return;
            }
            ClearTextBox();

          await _drugService.UpdateAndSaveChanges();
        }

        private void ClearTextBox()
        {
            mtxtDrugName.Clear();
            mtxtDosage.Clear();
            mtxtRepeatValue.Clear();
            rdbtnDaily.Checked= false;
            rdbtnEvereXHours.Checked = false;
        }

        private async Task FillDgv()
        {
            dgvReminder.DataSource = await _drugService.SelectDrug(StaticData.CurrentUser.Id);
        }

        private async void dgvReminder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvReminder.Columns[ColDelete.Name].Index)
            {
                 idForEdit = (int)dgvReminder.Rows[e.RowIndex].Cells["DrugId"].Value;
                var result=MessageBox.Show(Messages.Drug.Qestion,null,MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
               await _drugService.DeleteDrug(idForEdit);
            }

           else if (e.ColumnIndex == dgvReminder.Columns[ColEdit.Name].Index)
            {
                isEdit = true;
                btnRecord.Text = "ویرایش";
                idForEdit = (int)dgvReminder.Rows[e.RowIndex].Cells["DrugId"].Value;
                drug =await _drugService.UpdateDrug(idForEdit);
                FillInfo(drug);
               
            }
           await FillDgv();
        }

        private void FillInfo(Drug d)
        {
            mtxtDrugName.Text =d.DrugName;
            mtxtDosage.Text = d.Dosage.ToString();
            mtxtRepeatValue.Text= d.ReminderRepeatValue.ToString();

            if(d.ReminderRepeatType == RepeatType.Daily)
                rdbtnDaily.Checked = true;
            else
                rdbtnEvereXHours.Checked = true;
        }

        private void dgvReminder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvReminder.Rows[e.RowIndex].Cells[ColRow.Name].Value = e.RowIndex + 1;
        }

        private void mtxtRepeatValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitPress(e);
        }

        private void mtxtDosage_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitPress(e);
        }

        public void DigitPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FrmReminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome.Show();
        }

        private async void tmrReminder_Tick(object sender, EventArgs e)
        {
           
           var res= await _drugService.SelectForReminder(StaticData.CurrentUser.Id);


            foreach (var dr in res)
            {
                if (dr.ReminderDosage <= 0)
                {
                    dr.IsDeleted = true;
                    MessageBox.Show("شما به پایان دارو رسیدید: " + dr.DrugName);
                    await _drugService.UpdateAndSaveChanges();
                    continue;
                }


                var nextTime = dr.ReminderStartTime.AddHours(dr.ReminderRepeatValue);

                if (DateTime.Now >= nextTime)
                {
                    MessageBox.Show("زمان مصرف دارو: " + dr.DrugName);

                    dr.ReminderDosage -= 1;
                    dr.ReminderStartTime = DateTime.Now;

                    await _drugService.UpdateAndSaveChanges();
                }
            }

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
