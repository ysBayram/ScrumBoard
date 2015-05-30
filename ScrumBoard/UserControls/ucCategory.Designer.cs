namespace ScrumBoard.UserControls
{
    partial class ucCategory
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
            this.pnlCategory = new MetroFramework.Controls.MetroPanel();
            this.txtCategoryName = new MetroFramework.Controls.MetroTextBox();
            this.lblCategoryName = new MetroFramework.Controls.MetroLabel();
            this.pnlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.txtCategoryName);
            this.pnlCategory.Controls.Add(this.lblCategoryName);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategory.HorizontalScrollbarBarColor = true;
            this.pnlCategory.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCategory.HorizontalScrollbarSize = 10;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(372, 70);
            this.pnlCategory.TabIndex = 6;
            this.pnlCategory.VerticalScrollbarBarColor = true;
            this.pnlCategory.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCategory.VerticalScrollbarSize = 10;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Lines = new string[0];
            this.txtCategoryName.Location = new System.Drawing.Point(66, 11);
            this.txtCategoryName.MaxLength = 32767;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.Size = new System.Drawing.Size(291, 23);
            this.txtCategoryName.TabIndex = 0;
            this.txtCategoryName.UseSelectable = true;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(9, 13);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(45, 19);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "Name";
            // 
            // ucCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCategory);
            this.Name = "ucCategory";
            this.Size = new System.Drawing.Size(372, 70);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlCategory;
        private MetroFramework.Controls.MetroTextBox txtCategoryName;
        private MetroFramework.Controls.MetroLabel lblCategoryName;
    }
}
