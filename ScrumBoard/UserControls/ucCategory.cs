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
    public partial class ucCategory : UserControl, ICRUDuc
    {
        public ucCategory()
        {
            InitializeComponent();
        }

        public SBInput SBCRUDInput { get; set; }

        Repository<SBCategory> rps = new Repository<SBCategory>();

        public void SBCRUDInsert()
        {
            rps.Add(new SBCategory()
            {
                Name = txtCategoryName.Text
            });
        }

        public void SBCRUDDelete()
        {
            rps.Delete((SBCategory)SBCRUDInput);
        }

        public void SBCRUDUpdate()
        {
            SBCategory sbc = (SBCategory)SBCRUDInput;
            sbc.Name = txtCategoryName.Text;
            rps.UpdateSaveChanges();
        }

        public List<SBInput> SBCRUDGetAll()
        {
            return rps.GetAll().ToList<SBInput>();
        }

        public void SBCRUDLoadDetail()
        {
            SBCategory sbc = (SBCategory)SBCRUDInput;
            txtCategoryName.Text = sbc.Name;
        }

        public void SBCRUDClearComp()
        {
            SBCRUDInput = null;
            txtCategoryName.Text = string.Empty;
        }

        public bool SBCRUDCheck()
        {
            return (!string.IsNullOrEmpty(txtCategoryName.Text));
        }
    }
}
