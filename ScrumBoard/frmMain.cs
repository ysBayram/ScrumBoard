using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScrumBoard.UserControls;
using Process;
using Entity;

namespace ScrumBoard
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += frmMain_Load;
        }

        Repository<SBTask> rpt = new Repository<SBTask>();

        void frmMain_Load(object sender, EventArgs e)
        {
            fpnlMain.Controls.Clear();
            List<SBTask> lstTask = rpt.GetAll();
            for (int i = 0; i < lstTask.Count; i++)
            {
                ucMain ucm = new ucMain(lstTask[i]);
                ucm.Name = "Task_" + lstTask[i].Id.ToString();
                fpnlMain.Controls.Add(ucm);
            }
        }

        #region Menu Click Event

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataCRUD frmDataCRUD = new frmDataCRUD();
            frmDataCRUD.uc = new ucCategory();
            frmDataCRUD.ShowDialog();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataCRUD frmDataCRUD = new frmDataCRUD();
            frmDataCRUD.uc = new ucCategory();
            frmDataCRUD.ShowDialog();
        }

        private void sprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataCRUD frmDataCRUD = new frmDataCRUD();
            frmDataCRUD.uc = new ucSprint();
            frmDataCRUD.ShowDialog();
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataCRUD frmDataCRUD = new frmDataCRUD();
            frmDataCRUD.uc = new ucTask();
            frmDataCRUD.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataCRUD frmDataCRUD = new frmDataCRUD();
            frmDataCRUD.uc = new ucUser();
            frmDataCRUD.ShowDialog();
        }

        private void meetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataCRUD frmDataCRUD = new frmDataCRUD();
            frmDataCRUD.uc = new ucMeeting();
            frmDataCRUD.ShowDialog();
        }

        #endregion

    }
}
