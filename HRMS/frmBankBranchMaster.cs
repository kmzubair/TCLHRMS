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
    public partial class frmBankBranchMaster : Form
    {
        public frmBankBranchMaster()
        {
            InitializeComponent();
        }

        private void frmBankBranchMaster_Load(object sender, EventArgs e)
        {
            lstBankBranch.View = View.Details;
            lstBankBranch.GridLines = true;
            lstBankBranch.FullRowSelect = true;

            ColumnHeader brnID, brnName, brnStatus;
            brnID = new ColumnHeader();
            brnName = new ColumnHeader();
            brnStatus = new ColumnHeader();

            brnID.Text = "ID";
            brnID.TextAlign = HorizontalAlignment.Center;
            brnID.Width = 70;

            brnName.Text = "Branch Name";
            brnName.TextAlign = HorizontalAlignment.Left;
            brnName.Width = 550;

            brnStatus.Text = "Status";
            brnStatus.TextAlign = HorizontalAlignment.Center;
            brnStatus.Width = 100;


            lstBankBranch.Columns.Add(brnID);
            lstBankBranch.Columns.Add(brnName);
            lstBankBranch.Columns.Add(brnStatus);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBankBranchSetup BankBranchSetup = new frmBankBranchSetup();
            BankBranchSetup.Owner = this;
            BankBranchSetup.ShowDialog();

        }
    }
}
