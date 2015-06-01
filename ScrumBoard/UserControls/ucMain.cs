using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace ScrumBoard.UserControls
{
    public partial class ucMain : UserControl
    {
        private SBTask _Task { get; set; }

        public ucMain(SBTask _task)
        {
            this._Task = _task;
            InitializeComponent();
            this.Load += ucMain_Load;
        }

        void ucMain_Load(object sender, EventArgs e)
        {
            if ((_Task.Sprint.Deadline- DateTime.Now).TotalDays < 3)
            {
                pnlPriority.BackColor = Color.OrangeRed;
            }
            else
            {
                pnlPriority.BackColor = Color.GreenYellow;
            }

            lblName.Text = _Task.Name;
            lblDescrp.Text = _Task.Descrp;
            lblUserName.Text = _Task.User.Name;
            lblTime.Text = _Task.CreateTime.ToString();
            toolTipUser.SetToolTip(pbUser, _Task.User.Name);
            toolTipUser.ToolTipTitle = _Task.User.Role.ToString();
        }
    }
}
