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
using MetroFramework.Controls;
using Entity;
using Process;
using System.Reflection;

namespace ScrumBoard
{
    public partial class frmDataCRUD : MetroForm
    {
        public ICRUDuc uc { get; set; }

        public frmDataCRUD()
        {
            InitializeComponent();
            this.Load += frmDataCRUD_Load;
        }

        void frmDataCRUD_Load(object sender, EventArgs e)
        {
            UserControl DataUC = uc as UserControl;
            DataUC.Dock = DockStyle.Fill;
            pnlDetail.Controls.Add(DataUC);

            listData.DataSource = uc.SBCRUDGetAll();

            uc.SBCRUDClearComp();
        }

        private void listData_DoubleClick(object sender, EventArgs e)
        {
            uc.SBCRUDInput = (SBInput)listData.SelectedItem;
            uc.SBCRUDLoadDetail();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            uc.SBCRUDClearComp();
            MessageBox.Show("Detail panel is Cleared!!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (uc.SBCRUDInput != null)
            {
                uc.SBCRUDDelete();
                MessageBox.Show("Data is deleted!!!");

                listData.DataSource = uc.SBCRUDGetAll();
            }
            else
            {
                MessageBox.Show("Select any item!!!");
            }

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (uc.SBCRUDInput == null)
            {
                if (uc.SBCRUDCheck())
                {
                    uc.SBCRUDInsert();
                    MessageBox.Show("Data is added!!!");

                    listData.DataSource = uc.SBCRUDGetAll();
                }
                else
                {
                    MessageBox.Show("Required field must filled!!!");
                }
            }
            else
            {
                uc.SBCRUDUpdate();
                MessageBox.Show("Data is updated!!!");

                listData.DataSource = uc.SBCRUDGetAll();
                MessageBox.Show("Data are Listed!!!");
            }
        }

    }
}
