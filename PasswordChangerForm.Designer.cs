namespace SynchronizedPasswordChanger
{
    partial class PasswordChangerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox gbAccount1;
            System.Windows.Forms.TableLayoutPanel _account1LayoutPanel2;
            System.Windows.Forms.Label lblDomain1;
            System.Windows.Forms.Label lblOldPassword1;
            System.Windows.Forms.Label lblNewPassword;
            System.Windows.Forms.Label lblUsername1;
            System.Windows.Forms.Label lblVerifyPass;
            System.Windows.Forms.GroupBox gbAccount2;
            System.Windows.Forms.TableLayoutPanel _account2LayoutPanel3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.GroupBox gbCombined;
            this._cbDomain1 = new System.Windows.Forms.ComboBox();
            this._tbUsername1 = new System.Windows.Forms.TextBox();
            this._tbVerifyPassword = new System.Windows.Forms.TextBox();
            this._cbDomain2 = new System.Windows.Forms.ComboBox();
            this._tbUsername2 = new System.Windows.Forms.TextBox();
            this._cbSameAsAbove = new System.Windows.Forms.CheckBox();
            this._topLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._btnClose = new System.Windows.Forms.Button();
            this._btnExecute = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._pbOldPassword2 = new SynchronizedPasswordChanger.PasswordBox();
            this._pbOldPassword1 = new SynchronizedPasswordChanger.PasswordBox();
            this._pbNewPassword = new SynchronizedPasswordChanger.PasswordBox();
            gbAccount1 = new System.Windows.Forms.GroupBox();
            _account1LayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblDomain1 = new System.Windows.Forms.Label();
            lblOldPassword1 = new System.Windows.Forms.Label();
            lblNewPassword = new System.Windows.Forms.Label();
            lblUsername1 = new System.Windows.Forms.Label();
            lblVerifyPass = new System.Windows.Forms.Label();
            gbAccount2 = new System.Windows.Forms.GroupBox();
            _account2LayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            gbCombined = new System.Windows.Forms.GroupBox();
            gbAccount1.SuspendLayout();
            _account1LayoutPanel2.SuspendLayout();
            gbAccount2.SuspendLayout();
            _account2LayoutPanel3.SuspendLayout();
            this._topLayoutPanel.SuspendLayout();
            this._tableLayoutPanel1.SuspendLayout();
            gbCombined.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAccount1
            // 
            gbAccount1.AutoSize = true;
            gbAccount1.Controls.Add(_account1LayoutPanel2);
            gbAccount1.Dock = System.Windows.Forms.DockStyle.Fill;
            gbAccount1.Location = new System.Drawing.Point(3, 3);
            gbAccount1.Name = "gbAccount1";
            gbAccount1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbAccount1.Size = new System.Drawing.Size(493, 126);
            gbAccount1.TabIndex = 0;
            gbAccount1.TabStop = false;
            gbAccount1.Text = "Account &1";
            // 
            // _account1LayoutPanel2
            // 
            _account1LayoutPanel2.AutoSize = true;
            _account1LayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            _account1LayoutPanel2.ColumnCount = 2;
            _account1LayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            _account1LayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            _account1LayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            _account1LayoutPanel2.Controls.Add(lblDomain1, 0, 0);
            _account1LayoutPanel2.Controls.Add(lblOldPassword1, 0, 2);
            _account1LayoutPanel2.Controls.Add(lblUsername1, 1, 0);
            _account1LayoutPanel2.Controls.Add(this._cbDomain1, 0, 1);
            _account1LayoutPanel2.Controls.Add(this._tbUsername1, 1, 1);
            _account1LayoutPanel2.Controls.Add(this._pbOldPassword1, 0, 3);
            _account1LayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            _account1LayoutPanel2.Location = new System.Drawing.Point(4, 19);
            _account1LayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            _account1LayoutPanel2.Name = "_account1LayoutPanel2";
            _account1LayoutPanel2.RowCount = 6;
            _account1LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _account1LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _account1LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _account1LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _account1LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _account1LayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _account1LayoutPanel2.Size = new System.Drawing.Size(485, 103);
            _account1LayoutPanel2.TabIndex = 0;
            // 
            // lblDomain1
            // 
            lblDomain1.AutoSize = true;
            lblDomain1.Location = new System.Drawing.Point(4, 0);
            lblDomain1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDomain1.Name = "lblDomain1";
            lblDomain1.Size = new System.Drawing.Size(56, 17);
            lblDomain1.TabIndex = 0;
            lblDomain1.Text = "&Domain";
            // 
            // lblOldPassword1
            // 
            lblOldPassword1.AutoSize = true;
            lblOldPassword1.Location = new System.Drawing.Point(4, 49);
            lblOldPassword1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOldPassword1.Name = "lblOldPassword1";
            lblOldPassword1.Size = new System.Drawing.Size(128, 17);
            lblOldPassword1.TabIndex = 4;
            lblOldPassword1.Text = "&Previous Password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new System.Drawing.Point(4, 0);
            lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new System.Drawing.Size(100, 17);
            lblNewPassword.TabIndex = 0;
            lblNewPassword.Text = "&New Password";
            // 
            // lblUsername1
            // 
            lblUsername1.AutoSize = true;
            lblUsername1.Location = new System.Drawing.Point(246, 0);
            lblUsername1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsername1.Name = "lblUsername1";
            lblUsername1.Size = new System.Drawing.Size(73, 17);
            lblUsername1.TabIndex = 2;
            lblUsername1.Text = "&Username";
            // 
            // lblVerifyPass
            // 
            lblVerifyPass.AutoSize = true;
            lblVerifyPass.Location = new System.Drawing.Point(247, 0);
            lblVerifyPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVerifyPass.Name = "lblVerifyPass";
            lblVerifyPass.Size = new System.Drawing.Size(140, 17);
            lblVerifyPass.TabIndex = 2;
            lblVerifyPass.Text = "&Verify New Password";
            // 
            // _cbDomain1
            // 
            this._cbDomain1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cbDomain1.FormattingEnabled = true;
            this._cbDomain1.Location = new System.Drawing.Point(4, 21);
            this._cbDomain1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._cbDomain1.Name = "_cbDomain1";
            this._cbDomain1.Size = new System.Drawing.Size(234, 24);
            this._cbDomain1.TabIndex = 1;
            this._cbDomain1.SelectedValueChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // _tbUsername1
            // 
            this._tbUsername1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._tbUsername1.Location = new System.Drawing.Point(246, 22);
            this._tbUsername1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tbUsername1.Name = "_tbUsername1";
            this._tbUsername1.Size = new System.Drawing.Size(235, 22);
            this._tbUsername1.TabIndex = 3;
            this._tbUsername1.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // _tbVerifyPassword
            // 
            this._tbVerifyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._tbVerifyPassword.Location = new System.Drawing.Point(247, 24);
            this._tbVerifyPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tbVerifyPassword.Name = "_tbVerifyPassword";
            this._tbVerifyPassword.Size = new System.Drawing.Size(236, 22);
            this._tbVerifyPassword.TabIndex = 3;
            this._tbVerifyPassword.UseSystemPasswordChar = true;
            this._tbVerifyPassword.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // gbAccount2
            // 
            gbAccount2.AutoSize = true;
            gbAccount2.Controls.Add(_account2LayoutPanel3);
            gbAccount2.Dock = System.Windows.Forms.DockStyle.Fill;
            gbAccount2.Location = new System.Drawing.Point(3, 135);
            gbAccount2.Name = "gbAccount2";
            gbAccount2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbAccount2.Size = new System.Drawing.Size(493, 126);
            gbAccount2.TabIndex = 1;
            gbAccount2.TabStop = false;
            gbAccount2.Text = "Account &2";
            // 
            // _account2LayoutPanel3
            // 
            _account2LayoutPanel3.AutoSize = true;
            _account2LayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            _account2LayoutPanel3.ColumnCount = 2;
            _account2LayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            _account2LayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            _account2LayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            _account2LayoutPanel3.Controls.Add(label1, 0, 0);
            _account2LayoutPanel3.Controls.Add(label2, 0, 2);
            _account2LayoutPanel3.Controls.Add(label4, 1, 0);
            _account2LayoutPanel3.Controls.Add(this._cbDomain2, 0, 1);
            _account2LayoutPanel3.Controls.Add(this._tbUsername2, 1, 1);
            _account2LayoutPanel3.Controls.Add(this._pbOldPassword2, 0, 3);
            _account2LayoutPanel3.Controls.Add(this._cbSameAsAbove, 1, 3);
            _account2LayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            _account2LayoutPanel3.Location = new System.Drawing.Point(4, 19);
            _account2LayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            _account2LayoutPanel3.Name = "_account2LayoutPanel3";
            _account2LayoutPanel3.RowCount = 4;
            _account2LayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _account2LayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _account2LayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _account2LayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            _account2LayoutPanel3.Size = new System.Drawing.Size(485, 103);
            _account2LayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 0);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "D&omain";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 49);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(128, 17);
            label2.TabIndex = 4;
            label2.Text = "P&revious Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(246, 0);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 17);
            label4.TabIndex = 2;
            label4.Text = "U&sername";
            // 
            // _cbDomain2
            // 
            this._cbDomain2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cbDomain2.FormattingEnabled = true;
            this._cbDomain2.Location = new System.Drawing.Point(4, 21);
            this._cbDomain2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._cbDomain2.Name = "_cbDomain2";
            this._cbDomain2.Size = new System.Drawing.Size(234, 24);
            this._cbDomain2.TabIndex = 1;
            this._cbDomain2.SelectedValueChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // _tbUsername2
            // 
            this._tbUsername2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._tbUsername2.Location = new System.Drawing.Point(246, 22);
            this._tbUsername2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tbUsername2.Name = "_tbUsername2";
            this._tbUsername2.Size = new System.Drawing.Size(235, 22);
            this._tbUsername2.TabIndex = 3;
            this._tbUsername2.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // _cbSameAsAbove
            // 
            this._cbSameAsAbove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._cbSameAsAbove.AutoSize = true;
            this._cbSameAsAbove.Location = new System.Drawing.Point(246, 70);
            this._cbSameAsAbove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._cbSameAsAbove.Name = "_cbSameAsAbove";
            this._cbSameAsAbove.Size = new System.Drawing.Size(130, 29);
            this._cbSameAsAbove.TabIndex = 6;
            this._cbSameAsAbove.Text = "Same As &Above";
            this._cbSameAsAbove.UseVisualStyleBackColor = true;
            this._cbSameAsAbove.CheckedChanged += new System.EventHandler(this.OnSameAsAboveChanged);
            // 
            // _topLayoutPanel
            // 
            this._topLayoutPanel.AutoSize = true;
            this._topLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._topLayoutPanel.ColumnCount = 1;
            this._topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._topLayoutPanel.Controls.Add(gbAccount2, 0, 1);
            this._topLayoutPanel.Controls.Add(gbAccount1, 0, 0);
            this._topLayoutPanel.Controls.Add(this._tableLayoutPanel1, 0, 3);
            this._topLayoutPanel.Controls.Add(gbCombined, 0, 2);
            this._topLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._topLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._topLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._topLayoutPanel.Name = "_topLayoutPanel";
            this._topLayoutPanel.RowCount = 4;
            this._topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this._topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._topLayoutPanel.Size = new System.Drawing.Size(499, 387);
            this._topLayoutPanel.TabIndex = 0;
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.AutoSize = true;
            this._tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanel1.ColumnCount = 3;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanel1.Controls.Add(this._btnClose, 2, 0);
            this._tableLayoutPanel1.Controls.Add(this._btnExecute, 1, 0);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(4, 348);
            this._tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 1;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel1.Size = new System.Drawing.Size(491, 35);
            this._tableLayoutPanel1.TabIndex = 3;
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(387, 4);
            this._btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(100, 28);
            this._btnClose.TabIndex = 1;
            this._btnClose.Text = "&Close";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this.OnClose);
            // 
            // _btnExecute
            // 
            this._btnExecute.Enabled = false;
            this._btnExecute.Location = new System.Drawing.Point(279, 4);
            this._btnExecute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnExecute.Name = "_btnExecute";
            this._btnExecute.Size = new System.Drawing.Size(100, 28);
            this._btnExecute.TabIndex = 0;
            this._btnExecute.Text = "&Execute";
            this._btnExecute.UseVisualStyleBackColor = true;
            this._btnExecute.Click += new System.EventHandler(this.OnExecute);
            // 
            // gbCombined
            // 
            gbCombined.Controls.Add(this.tableLayoutPanel1);
            gbCombined.Dock = System.Windows.Forms.DockStyle.Fill;
            gbCombined.Location = new System.Drawing.Point(3, 267);
            gbCombined.Name = "gbCombined";
            gbCombined.Size = new System.Drawing.Size(493, 74);
            gbCombined.TabIndex = 2;
            gbCombined.TabStop = false;
            gbCombined.Text = "Combined";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(lblNewPassword, 0, 0);
            this.tableLayoutPanel1.Controls.Add(lblVerifyPass, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._pbNewPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._tbVerifyPassword, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 53);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _pbOldPassword2
            // 
            this._pbOldPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._pbOldPassword2.AutoSize = true;
            this._pbOldPassword2.Location = new System.Drawing.Point(5, 71);
            this._pbOldPassword2.Margin = new System.Windows.Forms.Padding(5);
            this._pbOldPassword2.MaximumSize = new System.Drawing.Size(800, 49);
            this._pbOldPassword2.MinimumSize = new System.Drawing.Size(187, 25);
            this._pbOldPassword2.Name = "_pbOldPassword2";
            this._pbOldPassword2.ShowPassword = false;
            this._pbOldPassword2.Size = new System.Drawing.Size(232, 27);
            this._pbOldPassword2.TabIndex = 5;
            this._pbOldPassword2.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // _pbOldPassword1
            // 
            this._pbOldPassword1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._pbOldPassword1.AutoSize = true;
            this._pbOldPassword1.Location = new System.Drawing.Point(5, 71);
            this._pbOldPassword1.Margin = new System.Windows.Forms.Padding(5);
            this._pbOldPassword1.MaximumSize = new System.Drawing.Size(800, 49);
            this._pbOldPassword1.MinimumSize = new System.Drawing.Size(187, 25);
            this._pbOldPassword1.Name = "_pbOldPassword1";
            this._pbOldPassword1.ShowPassword = false;
            this._pbOldPassword1.Size = new System.Drawing.Size(232, 27);
            this._pbOldPassword1.TabIndex = 5;
            this._pbOldPassword1.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // _pbNewPassword
            // 
            this._pbNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._pbNewPassword.AutoSize = true;
            this._pbNewPassword.Location = new System.Drawing.Point(5, 22);
            this._pbNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this._pbNewPassword.MaximumSize = new System.Drawing.Size(800, 49);
            this._pbNewPassword.MinimumSize = new System.Drawing.Size(187, 25);
            this._pbNewPassword.Name = "_pbNewPassword";
            this._pbNewPassword.ShowPassword = false;
            this._pbNewPassword.Size = new System.Drawing.Size(233, 27);
            this._pbNewPassword.TabIndex = 1;
            this._pbNewPassword.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // PasswordChangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 387);
            this.Controls.Add(this._topLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1058, 434);
            this.MinimumSize = new System.Drawing.Size(511, 434);
            this.Name = "PasswordChangerForm";
            this.Text = "Synchronized Password Changer";
            gbAccount1.ResumeLayout(false);
            gbAccount1.PerformLayout();
            _account1LayoutPanel2.ResumeLayout(false);
            _account1LayoutPanel2.PerformLayout();
            gbAccount2.ResumeLayout(false);
            gbAccount2.PerformLayout();
            _account2LayoutPanel3.ResumeLayout(false);
            _account2LayoutPanel3.PerformLayout();
            this._topLayoutPanel.ResumeLayout(false);
            this._topLayoutPanel.PerformLayout();
            this._tableLayoutPanel1.ResumeLayout(false);
            gbCombined.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _topLayoutPanel;
        private System.Windows.Forms.ComboBox _cbDomain1;
        private System.Windows.Forms.TextBox _tbUsername1;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnExecute;
        private PasswordBox _pbOldPassword1;
        private System.Windows.Forms.TextBox _tbVerifyPassword;
        private PasswordBox _pbNewPassword;
        private System.Windows.Forms.ComboBox _cbDomain2;
        private System.Windows.Forms.TextBox _tbUsername2;
        private PasswordBox _pbOldPassword2;
        private System.Windows.Forms.CheckBox _cbSameAsAbove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

