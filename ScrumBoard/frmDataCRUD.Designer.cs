namespace ScrumBoard
{
    partial class frmDataCRUD
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
            this.pnlDetail = new MetroFramework.Controls.MetroPanel();
            this.listData = new System.Windows.Forms.ListBox();
            this.pnlButtons = new MetroFramework.Controls.MetroPanel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnProcess = new MetroFramework.Controls.MetroButton();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.HorizontalScrollbarBarColor = true;
            this.pnlDetail.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDetail.HorizontalScrollbarSize = 10;
            this.pnlDetail.Location = new System.Drawing.Point(220, 60);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(360, 233);
            this.pnlDetail.TabIndex = 0;
            this.pnlDetail.VerticalScrollbarBarColor = true;
            this.pnlDetail.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDetail.VerticalScrollbarSize = 10;
            // 
            // listData
            // 
            this.listData.Dock = System.Windows.Forms.DockStyle.Left;
            this.listData.FormattingEnabled = true;
            this.listData.Location = new System.Drawing.Point(20, 60);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(200, 295);
            this.listData.TabIndex = 8;
            this.listData.DoubleClick += new System.EventHandler(this.listData_DoubleClick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnNew);
            this.pnlButtons.Controls.Add(this.btnProcess);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.HorizontalScrollbarBarColor = true;
            this.pnlButtons.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlButtons.HorizontalScrollbarSize = 10;
            this.pnlButtons.Location = new System.Drawing.Point(220, 293);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(360, 62);
            this.pnlButtons.TabIndex = 2;
            this.pnlButtons.VerticalScrollbarBarColor = true;
            this.pnlButtons.VerticalScrollbarHighlightOnWheel = false;
            this.pnlButtons.VerticalScrollbarSize = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(185, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(104, 21);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Location = new System.Drawing.Point(266, 21);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseSelectable = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // frmDataCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.listData);
            this.Name = "frmDataCRUD";
            this.Resizable = false;
            this.Text = "Data CRUD";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlDetail;
        private System.Windows.Forms.ListBox listData;
        private MetroFramework.Controls.MetroPanel pnlButtons;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnProcess;

    }
}