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
    public partial class frmLoanSchedule : Form
    {
        public frmLoanSchedule()
        {
            InitializeComponent();
        }

        private void frmLoanSchedule_Load(object sender, EventArgs e)
        {
            lstLoanSchedule.View = View.Details;
            lstLoanSchedule.GridLines = true;
            lstLoanSchedule.FullRowSelect = true;

            ColumnHeader loanmonth, loanopening, loanprincipal, loaninterest,loaninstallment,loanclosing;
            loanmonth = new ColumnHeader();
            loanopening = new ColumnHeader();
            loanprincipal = new ColumnHeader();
            loaninterest = new ColumnHeader();
            loaninstallment = new ColumnHeader();
            loanclosing = new ColumnHeader();

            loanmonth.Text = "Month";
            loanmonth.TextAlign = HorizontalAlignment.Center;
            loanmonth.Width = 100;

            loanopening.Text = "Opening";
            loanopening.TextAlign = HorizontalAlignment.Left;
            loanopening.Width = 100;

            loanprincipal.Text = "Principal";
            loanprincipal.TextAlign = HorizontalAlignment.Left;
            loanprincipal.Width = 100;

            loaninterest.Text = "Interest";
            loaninterest.TextAlign = HorizontalAlignment.Center;
            loaninterest.Width = 100;

            loaninstallment.Text = "Installment";
            loaninstallment.TextAlign = HorizontalAlignment.Center;
            loaninstallment.Width = 100;

            loanclosing.Text = "Closing";
            loanclosing.TextAlign = HorizontalAlignment.Center;
            loanclosing.Width = 100;


            lstLoanSchedule.Columns.Add(loanmonth);
            lstLoanSchedule.Columns.Add(loanopening);
            lstLoanSchedule.Columns.Add(loanprincipal);
            lstLoanSchedule.Columns.Add(loaninterest);
            lstLoanSchedule.Columns.Add(loaninstallment);
            lstLoanSchedule.Columns.Add(loanclosing);

        }
    }
}
