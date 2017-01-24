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
    public partial class frmOPIGradeMaster : Form
    {
        public frmOPIGradeMaster()
        {
            InitializeComponent();
        }

        private void frmOPIGradeMaster_Load(object sender, EventArgs e)
        {
            lstOPIGrade.View = View.Details;
            lstOPIGrade.GridLines = true;
            lstOPIGrade.FullRowSelect = true;

            ColumnHeader opiItem, opiType, opiGrades, opiStatus;
            opiItem = new ColumnHeader();
            opiType = new ColumnHeader();
            opiGrades = new ColumnHeader();
            opiStatus = new ColumnHeader();

            opiItem.Text = "OPI Item";
            opiItem.TextAlign = HorizontalAlignment.Left;
            opiItem.Width = 150;

            opiType.Text = "Type";
            opiType.TextAlign = HorizontalAlignment.Center;
            opiType.Width = 100;

            opiGrades.Text = "Grades";
            opiGrades.TextAlign = HorizontalAlignment.Left;
            opiGrades.Width = 400;

            opiStatus.Text = "Status";
            opiStatus.TextAlign = HorizontalAlignment.Left;
            opiStatus.Width = 100;


            lstOPIGrade.Columns.Add(opiItem);
            lstOPIGrade.Columns.Add(opiType);
            lstOPIGrade.Columns.Add(opiGrades);
            lstOPIGrade.Columns.Add(opiStatus);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOPIGradeSetup OPIGradeSetup = new frmOPIGradeSetup();
            OPIGradeSetup.Owner = this;
            OPIGradeSetup.ShowDialog();

        }
    }
}
