using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Windows.Forms;

namespace SynchronizedPasswordChanger
{
    public partial class PasswordChangerForm : Form
    {
        public PasswordChangerForm()
        {
            InitializeComponent();
            string[] domains = GetDomains();
            _cbDomain1.Items.AddRange(domains);
            _cbDomain2.Items.AddRange(domains);
            _cbDomain1.SelectedItem = Properties.Settings.Default.Domain1;
            _cbDomain2.SelectedItem = Properties.Settings.Default.Domain2;
            _tbUsername1.Text = Properties.Settings.Default.Username1;
            _tbUsername2.Text = Properties.Settings.Default.Username2;

            _pbNewPassword.ShowPasswordChanged += OnShowNewPasswordChanged;
            _pbNewPassword.PasswordChanged += OnTextChanged;
            _pbOldPassword1.PasswordChanged += OnTextChanged;
            _pbOldPassword2.PasswordChanged += OnTextChanged;
        }

        private string[] GetDomains()
        {
            var domains = new HashSet<string>();
            try
            {
                var forest = Forest.GetCurrentForest();
                domains.Add(forest.Name);

                var trusts = forest.GetAllTrustRelationships();
                foreach (TrustRelationshipInformation trust in trusts)
                {
                    domains.Add(trust.SourceName);
                    domains.Add(trust.TargetName);
                }
            }
            catch (ActiveDirectoryOperationException)
            {
                domains.Add(Environment.MachineName);
            }

            return domains.ToArray();
        }

        private void OnClose(object sender, EventArgs e)
        {
            Close();
        }

        private void OnShowNewPasswordChanged(object source, EventArgs e)
        {
            _tbVerifyPassword.Enabled = !_pbNewPassword.ShowPassword;
            ValidateConditions();
        }

        private void OnSameAsAboveChanged(object sender, EventArgs e)
        {
            if (_cbSameAsAbove.Checked)
            {
                _pbOldPassword2.Text = string.Empty;
            }
            _pbOldPassword2.Enabled = !_cbSameAsAbove.Checked;
            ValidateConditions();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            ValidateConditions();
        }

        private void ValidateConditions()
        {
            // Handle account 1.
            // Do we have a first domain?
            bool validated = !string.IsNullOrWhiteSpace(_cbDomain1.Text);
            // Do we have a first username?
            validated = validated && !string.IsNullOrWhiteSpace(_tbUsername1.Text);
            // Do we have an old first password?
            validated = validated && !string.IsNullOrWhiteSpace(_pbOldPassword1.Text);

            // Handle account 2.
            // Do we have a second domain?
            validated = validated && !string.IsNullOrWhiteSpace(_cbDomain2.Text);
            // Do we have a second username?
            validated = validated && !string.IsNullOrWhiteSpace(_tbUsername2.Text);
            // If using a separate old password for domain 2, do we have it?
            if (validated && _pbOldPassword2.Enabled)
            {
                validated = !string.IsNullOrWhiteSpace(_pbOldPassword2.Text);
            }

            // Handle the new info.
            // Do we have a new password?
            validated = validated && !string.IsNullOrWhiteSpace(_pbNewPassword.Text);
            // If we're hiding it, is it validated?
            if (validated && _tbVerifyPassword.Enabled)
            {
                validated = validated && _pbNewPassword.Text.Equals(_tbVerifyPassword.Text);
            }

            _btnExecute.Enabled = validated;
        }

        private void OnExecute(object sender, EventArgs e)
        {
            var changer = new Status(
                _cbDomain1.Text,
                _tbUsername1.Text,
                _pbOldPassword1.Text,
                _pbNewPassword.Text,
                _cbDomain2.Text,
                _tbUsername2.Text,
                _pbOldPassword2.Text);
            changer.ShowDialog(this);
        }
    }
}
