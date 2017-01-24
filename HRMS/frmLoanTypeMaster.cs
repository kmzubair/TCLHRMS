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
    public partial class frmLoanTypeMaster : Form
    {
        public frmLoanTypeMaster()
        {
            InitializeComponent();
        }

        private void frmLoanTypeMaster_Load(object sender, EventArgs e)
        {
            lstLoanType.View = View.Details;
            lstLoanType.GridLines = true;
            lstLoanType.FullRowSelect = true;

            ColumnHeader loanID, loanName, loanRate, loanStatus;
            loanID = new ColumnHeader();
            loanName = new ColumnHeader();
            loanRate = new ColumnHeader();
            loanStatus = new ColumnHeader();

            loanID.Text = "ID";
            loanID.TextAlign = HorizontalAlignment.Center;
            loanID.Width = 70;

            loanName.Text = "Loan Description";
            loanName.TextAlign = HorizontalAlignment.Left;
            loanName.Width = 500;

            loanRate.Text = "Rate %";
            loanRate.TextAlign = HorizontalAlignment.Left;
            loanRate.Width = 70;

            loanStatus.Text = "Status";
            loanStatus.TextAlign = HorizontalAlignment.Center;
            loanStatus.Width = 100;


            lstLoanType.Columns.Add(loanID);
            lstLoanType.Columns.Add(loanName);
            lstLoanType.Columns.Add(loanRate);
            lstLoanType.Columns.Add(loanStatus);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLoanTypeSetup LoanSetup = new frmLoanTypeSetup();
            LoanSetup.Owner = this;
            LoanSetup.ShowDialog();

        }
    }
}
