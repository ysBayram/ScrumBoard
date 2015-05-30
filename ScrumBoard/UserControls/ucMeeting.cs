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
using Process;

namespace ScrumBoard.UserControls
{
    public partial class ucMeeting : UserControl, ICRUDuc
    {
        public ucMeeting()
        {
            InitializeComponent();
        }

        public SBInput SBCRUDInput { get; set; }

        Repository<SBMeeting> rps = new Repository<SBMeeting>();

        public void SBCRUDInsert()
        {
            rps.Add(new SBMeeting()
            {
                Name = txtMeetName.Text,
                Descrp = txtMeetDescrp.Text,
                Time = dtMeetTime.Value,
                Sprint = (SBSprint)cmbMeetSprint.SelectedItem
            });
        }

        public void SBCRUDDelete()
        {
            rps.Delete((SBMeeting)SBCRUDInput);
        }

        public void SBCRUDUpdate()
        {
            SBMeeting sbm = (SBMeeting)SBCRUDInput;
            sbm.Name = txtMeetName.Text;
            sbm.Descrp = txtMeetDescrp.Text;
            sbm.Time = dtMeetTime.Value;
            sbm.Sprint = (SBSprint)cmbMeetSprint.SelectedItem;

            rps.UpdateSaveChanges();
        }

        public List<Entity.SBInput> SBCRUDGetAll()
        {
            return rps.GetAll().ToList<SBInput>();
        }

        public void SBCRUDLoadDetail()
        {
            SBMeeting sbm = (SBMeeting)SBCRUDInput;
            txtMeetName.Text = sbm.Name;
            txtMeetDescrp.Text = sbm.Descrp;
            dtMeetTime.Value = sbm.Time;
            cmbMeetSprint.SelectedItem = sbm.Sprint;
        }

        public void SBCRUDClearComp()
        {
            SBCRUDInput = null;
            txtMeetName.Text = string.Empty;
            txtMeetDescrp.Text = string.Empty;
            dtMeetTime.Value = DateTime.Now;
            Repository<SBSprint> rps = new Repository<SBSprint>();
            cmbMeetSprint.DataSource = rps.GetAll();
            cmbMeetSprint.SelectedItem = -1;
        }

        public bool SBCRUDCheck()
        {
            return (!string.IsNullOrEmpty(txtMeetName.Text) && (dtMeetTime.Value != null) && (cmbMeetSprint.SelectedIndex != -1));
        }
    }
}
