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
    public partial class ucTask : UserControl, ICRUDuc
    {
        public ucTask()
        {
            InitializeComponent();
        }

        public SBInput SBCRUDInput { get; set; }

        Repository<SBTask> rps = new Repository<SBTask>();

        public void SBCRUDInsert()
        {
            rps.Add(new SBTask()
            {
                Name = txtTaskName.Text,
                Descrp = txtTaskDescrp.Text,
                CreateTime = dtTaskCreateTime.Value,
                User = (SBUser)cmbTaskUser.SelectedItem,
                Sprint = (SBSprint)cmbTaskSprint.SelectedItem
            });
        }

        public void SBCRUDDelete()
        {
            rps.Delete((SBTask)SBCRUDInput);
        }

        public void SBCRUDUpdate()
        {
            SBTask sbt = (SBTask)SBCRUDInput;
            sbt.Name = txtTaskName.Text;
            sbt.Descrp = txtTaskDescrp.Text;
            sbt.CreateTime = dtTaskCreateTime.Value;
            sbt.User = (SBUser)cmbTaskUser.SelectedItem;
            sbt.Sprint = (SBSprint)cmbTaskSprint.SelectedItem;

            rps.UpdateSaveChanges();
        }

        public List<SBInput> SBCRUDGetAll()
        {
            return rps.GetAll().ToList<SBInput>();
        }


        public void SBCRUDLoadDetail()
        {
            SBTask sbt = (SBTask)SBCRUDInput;
            txtTaskName.Text = sbt.Name;
            txtTaskDescrp.Text = sbt.Descrp;
            dtTaskCreateTime.Value = sbt.CreateTime;
            cmbTaskUser.SelectedItem = sbt.User;
            cmbTaskSprint.SelectedItem = sbt.Sprint;
        }

        public void SBCRUDClearComp()
        {
            SBCRUDInput = null;
            txtTaskName.Text = string.Empty;
            txtTaskDescrp.Text = string.Empty;
            dtTaskCreateTime.Value = DateTime.Now;
            Repository<SBUser> rpu = new Repository<SBUser>();
            cmbTaskUser.DataSource = rpu.GetAll();
            cmbTaskUser.SelectedIndex = -1;
            Repository<SBSprint> rps = new Repository<SBSprint>();
            cmbTaskSprint.DataSource = rps.GetAll();
            cmbTaskSprint.SelectedIndex = -1;
        }

        public bool SBCRUDCheck()
        {
            return ((!string.IsNullOrEmpty(txtTaskName.Text) && (cmbTaskUser.SelectedIndex != -1) && (cmbTaskSprint.SelectedIndex != -1)));
        }
    }
}
