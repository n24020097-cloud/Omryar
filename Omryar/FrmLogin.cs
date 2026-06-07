using Omryar.Domain;
using Omryar.Domain.Interfaces;
using Omryar.Helpers;
using Omryar.Service;
using Omryar.Service.DTOs;
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

namespace Omryar
{
    public partial class FrmLogin : Form
    {
        IPersonService _personService;
        IUserSettingService _userSettingService;
        public FrmLogin()
        {
            InitializeComponent();
            _personService = AppFactory.PersonService();
            _userSettingService = AppFactory.UserSettingService();
        }
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            AddPersonDto p = new AddPersonDto
            {
                FirstName= txtFirstName.Text,
                LastName= txtLastName.Text,
                NationalCode= txtNationalCode.Text,
                Mobile= txtMobile.Text,
                UserName=txtUserNameRe.Text,
                Password=txtPasswordRe.Text
            };
            var result =await _personService.AddPersonAsync(p);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message);
                return;
            }
            StaticData.CurrentUser = p.ToPersnInfoDto();
            var resultSetting = await _userSettingService.GetAsync(StaticData.CurrentUser.Id);
            StaticData.CurrentSetting =resultSetting.Data;
            FoundControls<TextBox>.Found(tableLayoutPanel1).ForEach(t => t.Text = "");
            this.Hide();
            FrmHome frmhome= new FrmHome();
            frmhome.Show();
            FrmReminder frmReminder= new FrmReminder();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var result=await _personService.LoginAsync(txtUserNameLI.Text,txtPasswordLI.Text);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message);
                return;
            }
            StaticData.CurrentUser =result.Data;
            var resultSetting = await _userSettingService.GetAsync(StaticData.CurrentUser.Id);
            StaticData.CurrentSetting = resultSetting.Data;
            this.Hide();
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
        }

    }
}
