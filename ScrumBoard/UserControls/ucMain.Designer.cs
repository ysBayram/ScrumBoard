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
            this.pnlTask = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lblDescrp = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlPriority = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.toolTipUser = new MetroFramework.Components.MetroToolTip();
            this.pnlTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.pnlPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTask
            // 
            this.pnlTask.BackColor = System.Drawing.Color.Transparent;
            this.pnlTask.Controls.Add(this.lblUserName);
            this.pnlTask.Controls.Add(this.pbUser);
            this.pnlTask.Controls.Add(this.lblDescrp);
            this.pnlTask.Controls.Add(this.lblTime);
            this.pnlTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTask.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTask.Location = new System.Drawing.Point(0, 50);
            this.pnlTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(175, 105);
            this.pnlTask.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(12, 64);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(126, 14);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "[UserName]";
            // 
            // pbUser
            // 
            this.pbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUser.BackColor = System.Drawing.Color.Transparent;
            this.pbUser.Image = global::ScrumBoard.Properties.Resources.user_suit;
            this.pbUser.Location = new System.Drawing.Point(147, 66);
            this.pbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(25, 22);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 4;
            this.pbUser.TabStop = false;
            // 
            // lblDescrp
            // 
            this.lblDescrp.AccessibleName = "75";
            this.lblDescrp.BackColor = System.Drawing.Color.Transparent;
            this.lblDescrp.ForeColor = System.Drawing.Color.White;
            this.lblDescrp.Location = new System.Drawing.Point(4, 3);
            this.lblDescrp.Name = "lblDescrp";
            this.lblDescrp.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.lblDescrp.Size = new System.Drawing.Size(167, 59);
            this.lblDescrp.TabIndex = 2;
            this.lblDescrp.Text = "Description Description Description Description Description Description Descripti" +
    "on Descrip....";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(13, 78);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(126, 12);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "01.01.2001 01:01";
            // 
            // pnlPriority
            // 
            this.pnlPriority.BackColor = System.Drawing.Color.Transparent;
            this.pnlPriority.Controls.Add(this.lblName);
            this.pnlPriority.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlPriority.Location = new System.Drawing.Point(0, 0);
            this.pnlPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPriority.Name = "pnlPriority";
            this.pnlPriority.Size = new System.Drawing.Size(175, 50);
            this.pnlPriority.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AccessibleName = "35";
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(3);
            this.lblName.Size = new System.Drawing.Size(175, 50);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Lorem ipsum dolor sit a met. Lorem ipsum dolor sit a met.";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // toolTipUser
            // 
            this.toolTipUser.Style = MetroFramework.MetroColorStyle.White;
            this.toolTipUser.StyleManager = null;
            this.toolTipUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::ScrumBoard.Properties.Resources.postit_175;
            this.Controls.Add(this.pnlTask);
            this.Controls.Add(this.pnlPriority);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(175, 155);
            this.pnlTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.pnlPriority.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTask;
        private System.Windows.Forms.Panel pnlPriority;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblDescrp;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private MetroFramework.Components.MetroToolTip toolTipUser;
        private System.Windows.Forms.Label lblUserName;
    }
}
