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
    public partial class frmBankAccountAssignOPI : Form
    {
        public frmBankAccountAssignOPI()
        {
            InitializeComponent();
        }

        private void frmBankAccountAssignOPI_Load(object sender, EventArgs e)
        {
            lstBankAccount.View = View.Details;
            lstBankAccount.GridLines = true;
            lstBankAccount.FullRowSelect = true;

            ColumnHeader bnkAccount, bnkName, bnkBranch, bnkEffDate;
            bnkAccount = new ColumnHeader();
            bnkName = new ColumnHeader();
            bnkBranch = new ColumnHeader();
            bnkEffDate = new ColumnHeader();

            bnkAccount.Text = "Account Number";
            bnkAccount.TextAlign = HorizontalAlignment.Left;
            bnkAccount.Width = 130;

            bnkName.Text = "Bank";
            bnkName.TextAlign = HorizontalAlignment.Center;
            bnkName.Width = 130;

            bnkBranch.Text = "Branch";
            bnkBranch.TextAlign = HorizontalAlignment.Center;
            bnkBranch.Width = 130;

            bnkEffDate.Text = "Eff. Date";
            bnkEffDate.TextAlign = HorizontalAlignment.Center;
            bnkEffDate.Width = 130;

            lstBankAccount.Columns.Add(bnkAccount);
            lstBankAccount.Columns.Add(bnkName);
            lstBankAccount.Columns.Add(bnkBranch);
            lstBankAccount.Columns.Add(bnkEffDate);

        }
    }
}
