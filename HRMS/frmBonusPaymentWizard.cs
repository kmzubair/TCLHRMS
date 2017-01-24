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
    public partial class frmBonusPaymentWizard : Form
    {
        public frmBonusPaymentWizard()
        {
            InitializeComponent();
        }

        private void frmBonusPaymentWizard_Load(object sender, EventArgs e)
        {
            lstEmpBonus.View = View.Details;
            lstEmpBonus.GridLines = true;
            lstEmpBonus.FullRowSelect = true;

            ColumnHeader empID, empName, empBasic, empBonus, empBonusTax, empBonusTotal;
            empID = new ColumnHeader();
            empName = new ColumnHeader();
            empBasic = new ColumnHeader();
            empBonus = new ColumnHeader();
            empBonusTax = new ColumnHeader();
            empBonusTotal = new ColumnHeader();

            empID.Text = "Emp. ID";
            empID.TextAlign = HorizontalAlignment.Center;
            empID.Width = 70;

            empName.Text = "Name";
            empName.TextAlign = HorizontalAlignment.Left;
            empName.Width = 200;

            empBasic.Text = "Basic";
            empBasic.TextAlign = HorizontalAlignment.Left;
            empBasic.Width = 70;

            empBonus.Text = "Bonus";
            empBonus.TextAlign = HorizontalAlignment.Left;
            empBonus.Width = 70;

            empBonusTax.Text = "Tax";
            empBonusTax.TextAlign = HorizontalAlignment.Left;
            empBonusTax.Width = 70;

            empBonusTotal.Text = "Total";
            empBonusTotal.TextAlign = HorizontalAlignment.Left;
            empBonusTotal.Width = 70;

            lstEmpBonus.Columns.Add(empID);
            lstEmpBonus.Columns.Add(empName);
            lstEmpBonus.Columns.Add(empBasic);
            lstEmpBonus.Columns.Add(empBonus);
            lstEmpBonus.Columns.Add(empBonusTax);
            lstEmpBonus.Columns.Add(empBonusTotal);

        }
    }
}
