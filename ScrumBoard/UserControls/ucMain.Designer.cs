namespace ScrumBoard.UserControls
{
    partial class ucMain
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
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lblDescrp = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.pnlPriority = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.toolTipUser = new MetroFramework.Components.MetroToolTip();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.pnlTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.pnlPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTask
            // 
            this.pnlTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTask.Controls.Add(this.lblUserName);
            this.pnlTask.Controls.Add(this.pbUser);
            this.pnlTask.Controls.Add(this.lblDescrp);
            this.pnlTask.Controls.Add(this.lblTime);
            this.pnlTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTask.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTask.HorizontalScrollbarBarColor = true;
            this.pnlTask.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTask.HorizontalScrollbarSize = 9;
            this.pnlTask.Location = new System.Drawing.Point(0, 22);
            this.pnlTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(175, 133);
            this.pnlTask.TabIndex = 3;
            this.pnlTask.VerticalScrollbarBarColor = true;
            this.pnlTask.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTask.VerticalScrollbarSize = 10;
            // 
            // pbUser
            // 
            this.pbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUser.Image = global::ScrumBoard.Properties.Resources.user_suit;
            this.pbUser.Location = new System.Drawing.Point(139, 97);
            this.pbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(32, 32);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 4;
            this.pbUser.TabStop = false;
            // 
            // lblDescrp
            // 
            this.lblDescrp.Location = new System.Drawing.Point(3, 2);
            this.lblDescrp.Name = "lblDescrp";
            this.lblDescrp.Size = new System.Drawing.Size(167, 91);
            this.lblDescrp.TabIndex = 2;
            this.lblDescrp.Text = "Description";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTime.Location = new System.Drawing.Point(7, 114);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(126, 14);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "01.01.2001 01:01";
            // 
            // pnlPriority
            // 
            this.pnlPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlPriority.Controls.Add(this.lblName);
            this.pnlPriority.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlPriority.Location = new System.Drawing.Point(0, 0);
            this.pnlPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPriority.Name = "pnlPriority";
            this.pnlPriority.Size = new System.Drawing.Size(175, 22);
            this.pnlPriority.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // toolTipUser
            // 
            this.toolTipUser.Style = MetroFramework.MetroColorStyle.White;
            this.toolTipUser.StyleManager = null;
            this.toolTipUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUserName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUserName.Location = new System.Drawing.Point(7, 97);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(126, 15);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "[UserName]";
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTask);
            this.Controls.Add(this.pnlPriority);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(175, 155);
            this.pnlTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.pnlPriority.ResumeLayout(false);
            this.pnlPriority.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlTask;
        private System.Windows.Forms.Panel pnlPriority;
        private System.Windows.Forms.PictureBox pbUser;
        private MetroFramework.Controls.MetroLabel lblDescrp;
        private MetroFramework.Controls.MetroLabel lblTime;
        private System.Windows.Forms.Label lblName;
        private MetroFramework.Components.MetroToolTip toolTipUser;
        private MetroFramework.Controls.MetroLabel lblUserName;
    }
}
