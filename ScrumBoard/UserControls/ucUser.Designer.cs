namespace ScrumBoard.UserControls
{
    partial class ucUser
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
            this.pnlUser = new MetroFramework.Controls.MetroPanel();
            this.cmbUserRole = new MetroFramework.Controls.MetroComboBox();
            this.lblUserRole = new MetroFramework.Controls.MetroLabel();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.cmbUserRole);
            this.pnlUser.Controls.Add(this.lblUserRole);
            this.pnlUser.Controls.Add(this.txtUserName);
            this.pnlUser.Controls.Add(this.lblUserName);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.HorizontalScrollbarBarColor = true;
            this.pnlUser.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlUser.HorizontalScrollbarSize = 10;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(365, 84);
            this.pnlUser.TabIndex = 9;
            this.pnlUser.VerticalScrollbarBarColor = true;
            this.pnlUser.VerticalScrollbarHighlightOnWheel = false;
            this.pnlUser.VerticalScrollbarSize = 10;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.ItemHeight = 23;
            this.cmbUserRole.Location = new System.Drawing.Point(118, 40);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(200, 29);
            this.cmbUserRole.TabIndex = 1;
            this.cmbUserRole.UseSelectable = true;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(9, 45);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(35, 19);
            this.lblUserRole.TabIndex = 6;
            this.lblUserRole.Text = "Role";
            // 
            // txtUserName
            // 
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(118, 11);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(239, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.UseSelectable = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(9, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(45, 19);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Name";
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUser);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(365, 84);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlUser;
        private MetroFramework.Controls.MetroComboBox cmbUserRole;
        private MetroFramework.Controls.MetroLabel lblUserRole;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroLabel lblUserName;
    }
}
