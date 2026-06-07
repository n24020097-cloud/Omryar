using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omryar
{
    internal class MyTextBox:TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {
            //base.OnGotFocus(e);
            BackColor = System.Drawing.Color.LightGray;
        }
        protected override void OnLostFocus(EventArgs e)
        {
            //base.OnLostFocus(e);
            BackColor = System.Drawing.Color.White;
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter)
            {
                this.Parent.SelectNextControl(this, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }
    }
}
