using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class frmBonusDefinationMaster : Form
    {
        public frmBonusDefinationMaster()
        {
            InitializeComponent();
        }

        private void frmBonusDefinationMaster_Load(object sender, EventArgs e)
        {
            lstBonusDefination.View = View.Details;
            lstBonusDefination.GridLines = true;
            lstBonusDefination.FullRowSelect = true;

            ColumnHeader bonID, bonName, bonStatus;
            bonID = new ColumnHeader();
            bonName = new ColumnHeader();
            bonStatus = new ColumnHeader();

            bonID.Text = "ID";
            bonID.TextAlign = HorizontalAlignment.Center;
            bonID.Width = 70;

            bonName.Text = "Bonus Name";
            bonName.TextAlign = HorizontalAlignment.Left;
            bonName.Width = 550;

            bonStatus.Text = "Status";
            bonStatus.TextAlign = HorizontalAlignment.Center;
            bonStatus.Width = 100;


            lstBonusDefination.Columns.Add(bonID);
            lstBonusDefination.Columns.Add(bonName);
            lstBonusDefination.Columns.Add(bonStatus);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBonusDefinationSetup BonusDefinationSetup = new frmBonusDefinationSetup();
            BonusDefinationSetup.Owner = this;
            BonusDefinationSetup.ShowDialog();

        }
    }
}
