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
            if (_Task.Sprint.Deadline < DateTime.Now)
            {
                pnlPriority.ForeColor = Color.OrangeRed;
            }
            else
            {
                pnlPriority.ForeColor = Color.DarkGreen;
            }

            int maxLengthName = int.Parse(lblName.AccessibleName);
            int maxLengthDesc = int.Parse(lblDescrp.AccessibleName);

            if (_Task.Name.Length > maxLengthName)
            {
                lblName.Text = _Task.Name.Substring(0, maxLengthName - 3) + "...";
            }
            else
            {
                lblName.Text = _Task.Name;
            }

            if (_Task.Descrp.Length > maxLengthDesc)
            {
                lblDescrp.Text = _Task.Descrp.Substring(0, maxLengthDesc - 3) + "...";
            }
            else
            {
                lblDescrp.Text = _Task.Descrp;
            }

            lblUserName.Text = _Task.User.Name;
            lblTime.Text = _Task.CreateTime.ToString();
            toolTipUser.SetToolTip(pbUser, _Task.User.Name);
            toolTipUser.ToolTipTitle = _Task.User.Role.ToString();
        }
    }
}
