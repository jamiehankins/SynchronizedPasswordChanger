namespace SynchronizedPasswordChanger
{
    partial class PasswordBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            this._btnShow = new System.Windows.Forms.Button();
            this._tbPassword = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(this._btnShow, 1, 0);
            tableLayoutPanel1.Controls.Add(this._tbPassword, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(191, 28);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _btnShow
            // 
            this._btnShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._btnShow.Location = new System.Drawing.Point(135, 0);
            this._btnShow.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._btnShow.Name = "_btnShow";
            this._btnShow.Size = new System.Drawing.Size(56, 27);
            this._btnShow.TabIndex = 1;
            this._btnShow.Text = "Show";
            this._btnShow.UseVisualStyleBackColor = true;
            this._btnShow.Click += new System.EventHandler(this.OnShowClicked);
            // 
            // _tbPassword
            // 
            this._tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbPassword.Location = new System.Drawing.Point(0, 1);
            this._tbPassword.Margin = new System.Windows.Forms.Padding(0, 1, 4, 0);
            this._tbPassword.Name = "_tbPassword";
            this._tbPassword.Size = new System.Drawing.Size(127, 22);
            this._tbPassword.TabIndex = 0;
            this._tbPassword.UseSystemPasswordChar = true;
            this._tbPassword.TextChanged += new System.EventHandler(this.OnPasswordChanged);
            // 
            // PasswordBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(800, 49);
            this.MinimumSize = new System.Drawing.Size(187, 25);
            this.Name = "PasswordBox";
            this.Size = new System.Drawing.Size(191, 28);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnShow;
        private System.Windows.Forms.TextBox _tbPassword;
    }
}
