using System;
using System.Windows.Forms;

namespace SynchronizedPasswordChanger
{
    /// <summary>
    /// I originally wrote this using SecureStrings for the credentials.
    /// However, it added complexity, and ultimately didn't seem worth
    /// it. If a bad actor has physical access enough to manipulate your
    /// process' internal memory, then you're already pwnd.
    /// </summary>
    public partial class PasswordBox : UserControl
    {
        public PasswordBox()
        {
            InitializeComponent();
        }

        public bool ShowPassword
        {
            get => !_tbPassword.UseSystemPasswordChar;
            set => SetShowPassword(value);
        }
        public override string Text { get => _tbPassword.Text; set => _tbPassword.Text = value; }

        public EventHandler ShowPasswordChanged;
        public EventHandler PasswordChanged;

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            PasswordChanged?.Invoke(this, EventArgs.Empty);
        }

        private void SetShowPassword(bool show)
        {
            _tbPassword.UseSystemPasswordChar = !show;
            _btnShow.Text = show ? "Hide" : "Show";
            ShowPasswordChanged?.Invoke(this, EventArgs.Empty);
        }

        private void OnShowClicked(object sender, EventArgs e)
        {
            SetShowPassword(_tbPassword.UseSystemPasswordChar);
        }
    }
}
