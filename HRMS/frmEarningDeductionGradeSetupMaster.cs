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
    public partial class frmEarningDeductionGradeSetupMaster : Form
    {
        public frmEarningDeductionGradeSetupMaster()
        {
            InitializeComponent();
        }

        private void frmEarningDeductionGradeSetupMaster_Load(object sender, EventArgs e)
        {
            lstGradeSetup.View = View.Details;
            lstGradeSetup.GridLines = true;
            lstGradeSetup.FullRowSelect = true;

            ColumnHeader grdDesc, grdType, grdGrades, grdPer;
            grdDesc = new ColumnHeader();
            grdType = new ColumnHeader();
            grdGrades = new ColumnHeader();
            grdPer = new ColumnHeader();

            grdDesc.Text = "Description";
            grdDesc.TextAlign = HorizontalAlignment.Center;
            grdDesc.Width = 200;

            grdType.Text = "Type";
            grdType.TextAlign = HorizontalAlignment.Left;
            grdType.Width = 100;

            grdGrades.Text = "Grades";
            grdGrades.TextAlign = HorizontalAlignment.Center;
            grdGrades.Width = 300;

            grdPer.Text = "Periodicity";
            grdPer.TextAlign = HorizontalAlignment.Center;
            grdPer.Width = 100;


            lstGradeSetup.Columns.Add(grdDesc);
            lstGradeSetup.Columns.Add(grdType);
            lstGradeSetup.Columns.Add(grdGrades);
            lstGradeSetup.Columns.Add(grdPer);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEarningDeductionGradeSetup GradeSetup = new frmEarningDeductionGradeSetup();
            GradeSetup.Owner = this;
            GradeSetup.ShowDialog();

        }
    }
}
