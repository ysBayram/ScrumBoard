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
    public partial class ucUser : UserControl, ICRUDuc
    {
        public ucUser()
        {
            InitializeComponent();
        }

        public SBInput SBCRUDInput { get; set; }

        Repository<SBUser> rps = new Repository<SBUser>();

        public void SBCRUDInsert()
        {
            rps.Add(new SBUser()
            {
                Name = txtUserName.Text,
                Role = (Role)(Enum.Parse(typeof(Role), cmbUserRole.SelectedValue.ToString()))
            });
        }

        public void SBCRUDDelete()
        {
            rps.Delete((SBUser)SBCRUDInput);
        }

        public void SBCRUDUpdate()
        {
            SBUser sbu = (SBUser)SBCRUDInput;
            sbu.Name = txtUserName.Text;
            sbu.Role = (Role)cmbUserRole.SelectedItem;

            rps.UpdateSaveChanges();
        }

        public List<SBInput> SBCRUDGetAll()
        {
            return rps.GetAll().ToList<SBInput>();
        }

        public void SBCRUDLoadDetail()
        {
            SBUser sbu = (SBUser)SBCRUDInput;
            txtUserName.Text = sbu.Name;
            cmbUserRole.SelectedItem = sbu.Role;
        }

        public void SBCRUDClearComp()
        {
            SBCRUDInput = null;
            txtUserName.Text = string.Empty;
            cmbUserRole.DataSource = Enum.GetNames(typeof(Role));
            cmbUserRole.SelectedItem = -1;
        }

        public bool SBCRUDCheck()
        {
            return ((!string.IsNullOrEmpty(txtUserName.Text)) && (cmbUserRole.SelectedIndex != -1));
        }
    }
}
