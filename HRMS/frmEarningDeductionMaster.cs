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
    public partial class frmEarningDeductionMaster : Form
    {
        public frmEarningDeductionMaster()
        {
            InitializeComponent();
        }

        private void frmEarningDeductionMaster_Load(object sender, EventArgs e)
        {
            lstEarningDeduction.View = View.Details;
            lstEarningDeduction.GridLines = true;
            lstEarningDeduction.FullRowSelect = true;

            ColumnHeader edID, edName, edType;
            edID = new ColumnHeader();
            edName = new ColumnHeader();
            edType = new ColumnHeader();


            edID.Text = "ID";
            edID.TextAlign = HorizontalAlignment.Center;
            edID.Width = 70;

            edName.Text = "Description";
            edName.TextAlign = HorizontalAlignment.Left;
            edName.Width = 550;

            edType.Text = "Type";
            edType.TextAlign = HorizontalAlignment.Center;
            edType.Width = 100;


            lstEarningDeduction.Columns.Add(edID);
            lstEarningDeduction.Columns.Add(edName);
            lstEarningDeduction.Columns.Add(edType);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEarningdeductionsSetup EarningDeductionsSetup = new frmEarningdeductionsSetup();
            EarningDeductionsSetup.Owner = this;
            EarningDeductionsSetup.ShowDialog();

        }
    }
}
