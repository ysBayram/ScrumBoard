namespace ScrumBoard.UserControls
{
    partial class ucTask
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
            this.pnlTask = new MetroFramework.Controls.MetroPanel();
            this.cmbTaskUser = new MetroFramework.Controls.MetroComboBox();
            this.lblTaskUser = new MetroFramework.Controls.MetroLabel();
            this.cmbTaskSprint = new MetroFramework.Controls.MetroComboBox();
            this.lblTaskSprint = new MetroFramework.Controls.MetroLabel();
            this.dtTaskCreateTime = new MetroFramework.Controls.MetroDateTime();
            this.txtTaskDescrp = new MetroFramework.Controls.MetroTextBox();
            this.txtTaskName = new MetroFramework.Controls.MetroTextBox();
            this.lblTaskDescrp = new MetroFramework.Controls.MetroLabel();
            this.lblTaskCreateTime = new MetroFramework.Controls.MetroLabel();
            this.lblTaskName = new MetroFramework.Controls.MetroLabel();
            this.pnlTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTask
            // 
            this.pnlTask.Controls.Add(this.cmbTaskUser);
            this.pnlTask.Controls.Add(this.lblTaskUser);
            this.pnlTask.Controls.Add(this.cmbTaskSprint);
            this.pnlTask.Controls.Add(this.lblTaskSprint);
            this.pnlTask.Controls.Add(this.dtTaskCreateTime);
            this.pnlTask.Controls.Add(this.txtTaskDescrp);
            this.pnlTask.Controls.Add(this.txtTaskName);
            this.pnlTask.Controls.Add(this.lblTaskDescrp);
            this.pnlTask.Controls.Add(this.lblTaskCreateTime);
            this.pnlTask.Controls.Add(this.lblTaskName);
            this.pnlTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTask.HorizontalScrollbarBarColor = true;
            this.pnlTask.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTask.HorizontalScrollbarSize = 10;
            this.pnlTask.Location = new System.Drawing.Point(0, 0);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(368, 188);
            this.pnlTask.TabIndex = 9;
            this.pnlTask.VerticalScrollbarBarColor = true;
            this.pnlTask.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTask.VerticalScrollbarSize = 10;
            // 
            // cmbTaskUser
            // 
            this.cmbTaskUser.FormattingEnabled = true;
            this.cmbTaskUser.ItemHeight = 23;
            this.cmbTaskUser.Location = new System.Drawing.Point(118, 140);
            this.cmbTaskUser.Name = "cmbTaskUser";
            this.cmbTaskUser.Size = new System.Drawing.Size(200, 29);
            this.cmbTaskUser.TabIndex = 4;
            this.cmbTaskUser.UseSelectable = true;
            // 
            // lblTaskUser
            // 
            this.lblTaskUser.AutoSize = true;
            this.lblTaskUser.Location = new System.Drawing.Point(9, 145);
            this.lblTaskUser.Name = "lblTaskUser";
            this.lblTaskUser.Size = new System.Drawing.Size(35, 19);
            this.lblTaskUser.TabIndex = 6;
            this.lblTaskUser.Text = "User";
            // 
            // cmbTaskSprint
            // 
            this.cmbTaskSprint.FormattingEnabled = true;
            this.cmbTaskSprint.ItemHeight = 23;
            this.cmbTaskSprint.Location = new System.Drawing.Point(118, 105);
            this.cmbTaskSprint.Name = "cmbTaskSprint";
            this.cmbTaskSprint.Size = new System.Drawing.Size(200, 29);
            this.cmbTaskSprint.TabIndex = 3;
            this.cmbTaskSprint.UseSelectable = true;
            // 
            // lblTaskSprint
            // 
            this.lblTaskSprint.AutoSize = true;
            this.lblTaskSprint.Location = new System.Drawing.Point(9, 110);
            this.lblTaskSprint.Name = "lblTaskSprint";
            this.lblTaskSprint.Size = new System.Drawing.Size(43, 19);
            this.lblTaskSprint.TabIndex = 6;
            this.lblTaskSprint.Text = "Sprint";
            // 
            // dtTaskCreateTime
            // 
            this.dtTaskCreateTime.Location = new System.Drawing.Point(118, 70);
            this.dtTaskCreateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTaskCreateTime.Name = "dtTaskCreateTime";
            this.dtTaskCreateTime.Size = new System.Drawing.Size(200, 29);
            this.dtTaskCreateTime.TabIndex = 2;
            // 
            // txtTaskDescrp
            // 
            this.txtTaskDescrp.Lines = new string[0];
            this.txtTaskDescrp.Location = new System.Drawing.Point(118, 40);
            this.txtTaskDescrp.MaxLength = 32767;
            this.txtTaskDescrp.Name = "txtTaskDescrp";
            this.txtTaskDescrp.PasswordChar = '\0';
            this.txtTaskDescrp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaskDescrp.SelectedText = "";
            this.txtTaskDescrp.Size = new System.Drawing.Size(239, 23);
            this.txtTaskDescrp.TabIndex = 1;
            this.txtTaskDescrp.UseSelectable = true;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Lines = new string[0];
            this.txtTaskName.Location = new System.Drawing.Point(118, 11);
            this.txtTaskName.MaxLength = 32767;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PasswordChar = '\0';
            this.txtTaskName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaskName.SelectedText = "";
            this.txtTaskName.Size = new System.Drawing.Size(239, 23);
            this.txtTaskName.TabIndex = 0;
            this.txtTaskName.UseSelectable = true;
            // 
            // lblTaskDescrp
            // 
            this.lblTaskDescrp.AutoSize = true;
            this.lblTaskDescrp.Location = new System.Drawing.Point(9, 42);
            this.lblTaskDescrp.Name = "lblTaskDescrp";
            this.lblTaskDescrp.Size = new System.Drawing.Size(74, 19);
            this.lblTaskDescrp.TabIndex = 3;
            this.lblTaskDescrp.Text = "Description";
            // 
            // lblTaskCreateTime
            // 
            this.lblTaskCreateTime.AutoSize = true;
            this.lblTaskCreateTime.Location = new System.Drawing.Point(9, 75);
            this.lblTaskCreateTime.Name = "lblTaskCreateTime";
            this.lblTaskCreateTime.Size = new System.Drawing.Size(81, 19);
            this.lblTaskCreateTime.TabIndex = 3;
            this.lblTaskCreateTime.Text = "Create Time";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(9, 13);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(45, 19);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "Name";
            // 
            // ucTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTask);
            this.Name = "ucTask";
            this.Size = new System.Drawing.Size(368, 188);
            this.pnlTask.ResumeLayout(false);
            this.pnlTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlTask;
        private MetroFramework.Controls.MetroComboBox cmbTaskUser;
        private MetroFramework.Controls.MetroLabel lblTaskUser;
        private MetroFramework.Controls.MetroComboBox cmbTaskSprint;
        private MetroFramework.Controls.MetroLabel lblTaskSprint;
        private MetroFramework.Controls.MetroDateTime dtTaskCreateTime;
        private MetroFramework.Controls.MetroTextBox txtTaskDescrp;
        private MetroFramework.Controls.MetroTextBox txtTaskName;
        private MetroFramework.Controls.MetroLabel lblTaskDescrp;
        private MetroFramework.Controls.MetroLabel lblTaskCreateTime;
        private MetroFramework.Controls.MetroLabel lblTaskName;
    }
}
