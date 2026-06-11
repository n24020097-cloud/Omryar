using Omryar.Domain.DTOs;
using Omryar.Domain.DTOs.PersonDtos;
using Omryar.Domain.DTOs.Requests;
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
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
        }
        IUserSettingService _userSettingServic;
        IPersonService _personService;
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "انتخاب عکس";
            openFileDialog1.Filter = "aks jpg|*.jpg;*.jpeg;*.gif|aks bmp|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                picProfile.ImageLocation = openFileDialog1.FileName;
        }

        private async void FrmSetting_Load(object sender, EventArgs e)
        {
            _personService = AppFactory.PersonService();
            _userSettingServic=AppFactory.UserSettingService();
            var setting = await _userSettingServic.GetAsync(StaticData.CurrentUser.Id);
            if (setting == null) return;
            txtAboutMe.Text = setting.Data.Bio;
            lblFirstName.Text = StaticData.CurrentUser.FirstName;
            lblLastName.Text = StaticData.CurrentUser.LastName;
            lblUserName.Text = StaticData.CurrentUser.UserName;
            chkMedicineReminder.Checked = setting.Data.EnableMedicineReminder;
            chkPublicProfile.Checked = setting.Data.IsProfilePublic;
            chkVisitReminder.Checked = setting.Data.EnableVisitReminder;
            comboBoxTheme.Text = setting.Data.Theme;
            picProfile.ImageLocation = setting.Data.ProfileImagePath;

        }

        private void btnEditAboutMe_Click(object sender, EventArgs e)
        {
            if (txtAboutMe.ReadOnly)
            {
                txtAboutMe.ReadOnly = false;
                btnEditAboutMe.Text = "ذخیره";
            }
            else
            {
                txtAboutMe.ReadOnly = true;
                btnEditAboutMe.Text = "ویرایش";
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPass.Checked)
            {
                txtLastPass.PasswordChar = '\0';
                txtLastPass.PasswordChar = '\0';
            }
            else
            {
                txtLastPass.PasswordChar = '*';
                txtLastPass.PasswordChar = '*';
            }
        }

        private async void btnEditPass_Click(object sender, EventArgs e)
        {
            if (btnEditPass.Text == "ویرایش")
            {
                txtLastPass.Enabled = true;
                txtNewPass.Enabled = true;
                txtLastPass.ReadOnly = false;
                txtNewPass.ReadOnly = false;
                checkBoxShowPass.Enabled = true;
                btnEditPass.Text = "ذخیره";
            }
            else
            {
                var change=await _personService.ChangePasswordAsync(new ChangePasswordDto()
                {
                    CurrentPassword = txtLastPass.Text,
                    NewPassword = txtNewPass.Text,
                    PersonId=StaticData.CurrentUser.Id
                });
                MessageBox.Show(change.Message);
                
                txtLastPass.Enabled = false;
                txtNewPass.Enabled = false;
                checkBoxShowPass.Enabled = false;
                btnEditPass.Text = "ویرایش";
            }
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var dto = new UserSettingDto()
            {
                Theme = comboBoxTheme.Text,
                Bio=txtAboutMe.Text,
                EnableMedicineReminder=chkMedicineReminder.Checked,
                EnableVisitReminder=chkVisitReminder.Checked,
                FontSize=int.Parse(numericUpDownFontSize.Value.ToString()),
                IsProfilePublic=chkPublicProfile.Checked,
                PersonId=StaticData.CurrentUser.Id,
                ProfileImagePath=picProfile.ImageLocation
            };
            var update=await _userSettingServic.UpdateAsync(dto);
            MessageBox.Show(update.Message);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmHome().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picProfile.ImageLocation = "";
        }

        private void btnExitAccount_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Close();
        }

    }
}
