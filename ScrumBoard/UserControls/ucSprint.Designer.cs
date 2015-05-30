namespace ScrumBoard.UserControls
{
    partial class ucSprint
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
            this.pnlSprint = new MetroFramework.Controls.MetroPanel();
            this.cmbSprintCategory = new MetroFramework.Controls.MetroComboBox();
            this.lblSprintCategory = new MetroFramework.Controls.MetroLabel();
            this.dtSprintDeadLine = new MetroFramework.Controls.MetroDateTime();
            this.txtSprintName = new MetroFramework.Controls.MetroTextBox();
            this.lblSprintDeadLine = new MetroFramework.Controls.MetroLabel();
            this.lblSprintName = new MetroFramework.Controls.MetroLabel();
            this.pnlSprint.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSprint
            // 
            this.pnlSprint.Controls.Add(this.cmbSprintCategory);
            this.pnlSprint.Controls.Add(this.lblSprintCategory);
            this.pnlSprint.Controls.Add(this.dtSprintDeadLine);
            this.pnlSprint.Controls.Add(this.txtSprintName);
            this.pnlSprint.Controls.Add(this.lblSprintDeadLine);
            this.pnlSprint.Controls.Add(this.lblSprintName);
            this.pnlSprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSprint.HorizontalScrollbarBarColor = true;
            this.pnlSprint.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSprint.HorizontalScrollbarSize = 10;
            this.pnlSprint.Location = new System.Drawing.Point(0, 0);
            this.pnlSprint.Name = "pnlSprint";
            this.pnlSprint.Size = new System.Drawing.Size(369, 123);
            this.pnlSprint.TabIndex = 7;
            this.pnlSprint.VerticalScrollbarBarColor = true;
            this.pnlSprint.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSprint.VerticalScrollbarSize = 10;
            // 
            // cmbSprintCategory
            // 
            this.cmbSprintCategory.FormattingEnabled = true;
            this.cmbSprintCategory.ItemHeight = 23;
            this.cmbSprintCategory.Location = new System.Drawing.Point(118, 75);
            this.cmbSprintCategory.Name = "cmbSprintCategory";
            this.cmbSprintCategory.Size = new System.Drawing.Size(200, 29);
            this.cmbSprintCategory.TabIndex = 2;
            this.cmbSprintCategory.UseSelectable = true;
            // 
            // lblSprintCategory
            // 
            this.lblSprintCategory.AutoSize = true;
            this.lblSprintCategory.Location = new System.Drawing.Point(9, 80);
            this.lblSprintCategory.Name = "lblSprintCategory";
            this.lblSprintCategory.Size = new System.Drawing.Size(64, 19);
            this.lblSprintCategory.TabIndex = 6;
            this.lblSprintCategory.Text = "Category";
            // 
            // dtSprintDeadLine
            // 
            this.dtSprintDeadLine.Location = new System.Drawing.Point(118, 40);
            this.dtSprintDeadLine.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtSprintDeadLine.Name = "dtSprintDeadLine";
            this.dtSprintDeadLine.Size = new System.Drawing.Size(200, 29);
            this.dtSprintDeadLine.TabIndex = 1;
            // 
            // txtSprintName
            // 
            this.txtSprintName.Lines = new string[0];
            this.txtSprintName.Location = new System.Drawing.Point(118, 11);
            this.txtSprintName.MaxLength = 32767;
            this.txtSprintName.Name = "txtSprintName";
            this.txtSprintName.PasswordChar = '\0';
            this.txtSprintName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSprintName.SelectedText = "";
            this.txtSprintName.Size = new System.Drawing.Size(239, 23);
            this.txtSprintName.TabIndex = 0;
            this.txtSprintName.UseSelectable = true;
            // 
            // lblSprintDeadLine
            // 
            this.lblSprintDeadLine.AutoSize = true;
            this.lblSprintDeadLine.Location = new System.Drawing.Point(9, 45);
            this.lblSprintDeadLine.Name = "lblSprintDeadLine";
            this.lblSprintDeadLine.Size = new System.Drawing.Size(63, 19);
            this.lblSprintDeadLine.TabIndex = 3;
            this.lblSprintDeadLine.Text = "DeadLine";
            // 
            // lblSprintName
            // 
            this.lblSprintName.AutoSize = true;
            this.lblSprintName.Location = new System.Drawing.Point(9, 13);
            this.lblSprintName.Name = "lblSprintName";
            this.lblSprintName.Size = new System.Drawing.Size(45, 19);
            this.lblSprintName.TabIndex = 3;
            this.lblSprintName.Text = "Name";
            // 
            // ucSprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSprint);
            this.Name = "ucSprint";
            this.Size = new System.Drawing.Size(369, 123);
            this.pnlSprint.ResumeLayout(false);
            this.pnlSprint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlSprint;
        private MetroFramework.Controls.MetroComboBox cmbSprintCategory;
        private MetroFramework.Controls.MetroLabel lblSprintCategory;
        private MetroFramework.Controls.MetroDateTime dtSprintDeadLine;
        private MetroFramework.Controls.MetroTextBox txtSprintName;
        private MetroFramework.Controls.MetroLabel lblSprintDeadLine;
        private MetroFramework.Controls.MetroLabel lblSprintName;
    }
}
