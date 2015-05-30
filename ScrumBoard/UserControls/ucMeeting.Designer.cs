namespace ScrumBoard.UserControls
{
    partial class ucMeeting
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
            this.pnlMeeting = new MetroFramework.Controls.MetroPanel();
            this.cmbMeetSprint = new MetroFramework.Controls.MetroComboBox();
            this.lblMeetSprint = new MetroFramework.Controls.MetroLabel();
            this.dtMeetTime = new MetroFramework.Controls.MetroDateTime();
            this.txtMeetDescrp = new MetroFramework.Controls.MetroTextBox();
            this.txtMeetName = new MetroFramework.Controls.MetroTextBox();
            this.lblMeetDescrp = new MetroFramework.Controls.MetroLabel();
            this.lblMeetTime = new MetroFramework.Controls.MetroLabel();
            this.lblMeetName = new MetroFramework.Controls.MetroLabel();
            this.pnlMeeting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMeeting
            // 
            this.pnlMeeting.Controls.Add(this.cmbMeetSprint);
            this.pnlMeeting.Controls.Add(this.lblMeetSprint);
            this.pnlMeeting.Controls.Add(this.dtMeetTime);
            this.pnlMeeting.Controls.Add(this.txtMeetDescrp);
            this.pnlMeeting.Controls.Add(this.txtMeetName);
            this.pnlMeeting.Controls.Add(this.lblMeetDescrp);
            this.pnlMeeting.Controls.Add(this.lblMeetTime);
            this.pnlMeeting.Controls.Add(this.lblMeetName);
            this.pnlMeeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMeeting.HorizontalScrollbarBarColor = true;
            this.pnlMeeting.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMeeting.HorizontalScrollbarSize = 10;
            this.pnlMeeting.Location = new System.Drawing.Point(0, 0);
            this.pnlMeeting.Name = "pnlMeeting";
            this.pnlMeeting.Size = new System.Drawing.Size(376, 154);
            this.pnlMeeting.TabIndex = 10;
            this.pnlMeeting.VerticalScrollbarBarColor = true;
            this.pnlMeeting.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMeeting.VerticalScrollbarSize = 10;
            // 
            // cmbMeetSprint
            // 
            this.cmbMeetSprint.FormattingEnabled = true;
            this.cmbMeetSprint.ItemHeight = 23;
            this.cmbMeetSprint.Location = new System.Drawing.Point(118, 105);
            this.cmbMeetSprint.Name = "cmbMeetSprint";
            this.cmbMeetSprint.Size = new System.Drawing.Size(200, 29);
            this.cmbMeetSprint.TabIndex = 3;
            this.cmbMeetSprint.UseSelectable = true;
            // 
            // lblMeetSprint
            // 
            this.lblMeetSprint.AutoSize = true;
            this.lblMeetSprint.Location = new System.Drawing.Point(9, 110);
            this.lblMeetSprint.Name = "lblMeetSprint";
            this.lblMeetSprint.Size = new System.Drawing.Size(43, 19);
            this.lblMeetSprint.TabIndex = 6;
            this.lblMeetSprint.Text = "Sprint";
            // 
            // dtMeetTime
            // 
            this.dtMeetTime.Location = new System.Drawing.Point(118, 70);
            this.dtMeetTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtMeetTime.Name = "dtMeetTime";
            this.dtMeetTime.Size = new System.Drawing.Size(200, 29);
            this.dtMeetTime.TabIndex = 2;
            // 
            // txtMeetDescrp
            // 
            this.txtMeetDescrp.Lines = new string[0];
            this.txtMeetDescrp.Location = new System.Drawing.Point(118, 40);
            this.txtMeetDescrp.MaxLength = 32767;
            this.txtMeetDescrp.Name = "txtMeetDescrp";
            this.txtMeetDescrp.PasswordChar = '\0';
            this.txtMeetDescrp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMeetDescrp.SelectedText = "";
            this.txtMeetDescrp.Size = new System.Drawing.Size(239, 23);
            this.txtMeetDescrp.TabIndex = 1;
            this.txtMeetDescrp.UseSelectable = true;
            // 
            // txtMeetName
            // 
            this.txtMeetName.Lines = new string[0];
            this.txtMeetName.Location = new System.Drawing.Point(118, 11);
            this.txtMeetName.MaxLength = 32767;
            this.txtMeetName.Name = "txtMeetName";
            this.txtMeetName.PasswordChar = '\0';
            this.txtMeetName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMeetName.SelectedText = "";
            this.txtMeetName.Size = new System.Drawing.Size(239, 23);
            this.txtMeetName.TabIndex = 0;
            this.txtMeetName.UseSelectable = true;
            // 
            // lblMeetDescrp
            // 
            this.lblMeetDescrp.AutoSize = true;
            this.lblMeetDescrp.Location = new System.Drawing.Point(9, 42);
            this.lblMeetDescrp.Name = "lblMeetDescrp";
            this.lblMeetDescrp.Size = new System.Drawing.Size(74, 19);
            this.lblMeetDescrp.TabIndex = 3;
            this.lblMeetDescrp.Text = "Description";
            // 
            // lblMeetTime
            // 
            this.lblMeetTime.AutoSize = true;
            this.lblMeetTime.Location = new System.Drawing.Point(9, 75);
            this.lblMeetTime.Name = "lblMeetTime";
            this.lblMeetTime.Size = new System.Drawing.Size(38, 19);
            this.lblMeetTime.TabIndex = 3;
            this.lblMeetTime.Text = "Time";
            // 
            // lblMeetName
            // 
            this.lblMeetName.AutoSize = true;
            this.lblMeetName.Location = new System.Drawing.Point(9, 13);
            this.lblMeetName.Name = "lblMeetName";
            this.lblMeetName.Size = new System.Drawing.Size(45, 19);
            this.lblMeetName.TabIndex = 3;
            this.lblMeetName.Text = "Name";
            // 
            // ucMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMeeting);
            this.Name = "ucMeeting";
            this.Size = new System.Drawing.Size(376, 154);
            this.pnlMeeting.ResumeLayout(false);
            this.pnlMeeting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMeeting;
        private MetroFramework.Controls.MetroComboBox cmbMeetSprint;
        private MetroFramework.Controls.MetroLabel lblMeetSprint;
        private MetroFramework.Controls.MetroDateTime dtMeetTime;
        private MetroFramework.Controls.MetroTextBox txtMeetDescrp;
        private MetroFramework.Controls.MetroTextBox txtMeetName;
        private MetroFramework.Controls.MetroLabel lblMeetDescrp;
        private MetroFramework.Controls.MetroLabel lblMeetTime;
        private MetroFramework.Controls.MetroLabel lblMeetName;
    }
}
