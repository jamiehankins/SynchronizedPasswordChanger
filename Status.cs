using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynchronizedPasswordChanger
{
    public partial class Status : Form
    {
        public Status(
            string domain1,
            string username1,
            string oldPassword1,
            string newPassword,
            string domain2,
            string username2,
            string oldPassword2
            )
        {
            _domain1 = domain1;
            _domain2 = domain2;
            _username1 = username1;
            _username2 = username2;
            _oldPassword1 = oldPassword1;
            _oldPassword2 = oldPassword2;
            _newPassword = newPassword;

            InitializeComponent();
            _iconToolTip = new ToolTip();
            _iconToolTip.SetToolTip(_pbCheck1, "Succeeded");
            _iconToolTip.SetToolTip(_pbCheck2, "Succeeded");
            _iconToolTip.SetToolTip(_pbChange1, "Succeeded");
            _iconToolTip.SetToolTip(_pbChange2, "Succeeded");
            _iconToolTip.SetToolTip(_pbDone, "Succeeded");
        }

        public async void DoOperation()
        {
            var changer = new PasswordChanger();
            bool success;
            string status;
            (success, status) = await changer.CheckUserPassword(_domain1, _username1, _oldPassword1);
            _lblCheckAccount1.Visible = true;
            if(success)
            {
                _pbCheck1.Image = Properties.Resources.GreenCheck48;
            }
            else
            {
                _pbCheck1.Image = Properties.Resources.RedX48;
                //_pbCheck1.
            }
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private string _domain1, _domain2;
        private string _username1, _username2;
        private string _oldPassword1, _oldPassword2;
        private string _newPassword;
        private ToolTip _iconToolTip;
    }
}
