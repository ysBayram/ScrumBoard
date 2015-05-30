using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Process;
using Entity;

namespace ScrumBoard.UserControls
{
    public partial class ucSprint : UserControl, ICRUDuc
    {
        public ucSprint()
        {
            InitializeComponent();
        }

        public SBInput SBCRUDInput { get; set; }

        Repository<SBSprint> rps = new Repository<SBSprint>();

        public void SBCRUDInsert()
        {
            rps.Add(new SBSprint()
            {
                Name = txtSprintName.Text,
                Deadline = dtSprintDeadLine.Value,
                Category = (SBCategory)cmbSprintCategory.SelectedItem
            });
        }

        public void SBCRUDDelete()
        {
            rps.Delete((SBSprint)SBCRUDInput);
        }

        public void SBCRUDUpdate()
        {
            SBSprint sbs = (SBSprint)SBCRUDInput;
            sbs.Name = txtSprintName.Text;
            sbs.Deadline = dtSprintDeadLine.Value;
            sbs.Category = (SBCategory)cmbSprintCategory.SelectedItem;

            rps.UpdateSaveChanges();
        }

        public List<SBInput> SBCRUDGetAll()
        {
            return rps.GetAll().ToList<SBInput>();
        }


        public void SBCRUDLoadDetail()
        {
            SBSprint sbs = (SBSprint)SBCRUDInput;
            txtSprintName.Text = sbs.Name;
            dtSprintDeadLine.Value = sbs.Deadline;
            cmbSprintCategory.SelectedItem = sbs.Category;
        }

        public void SBCRUDClearComp()
        {
            SBCRUDInput = null;
            txtSprintName.Text = string.Empty;
            dtSprintDeadLine.Value = DateTime.Now;
            Repository<SBCategory> rpc = new Repository<SBCategory>();
            cmbSprintCategory.DataSource = rpc.GetAll();
            cmbSprintCategory.SelectedIndex = -1;
        }

        public bool SBCRUDCheck()
        {
            return (!string.IsNullOrEmpty(txtSprintName.Text) && (cmbSprintCategory.SelectedIndex != -1));
        }
    }
}
