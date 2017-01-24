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
    public partial class frmOPIGradeSetup : Form
    {
        public frmOPIGradeSetup()
        {
            InitializeComponent();
        }

        private void frmOPIGradeSetup_Load(object sender, EventArgs e)
        {
            lstGrade.View = View.Details;
            lstGrade.GridLines = true;
            lstGrade.FullRowSelect = true;

            ColumnHeader grdCode, grdDesc;
            grdCode = new ColumnHeader();
            grdDesc = new ColumnHeader();

            grdCode.Text = "Code";
            grdCode.TextAlign = HorizontalAlignment.Left;
            grdCode.Width = 70;

            grdDesc.Text = "Description";
            grdDesc.TextAlign = HorizontalAlignment.Center;
            grdDesc.Width = 200;


            lstGrade.Columns.Add(grdCode);
            lstGrade.Columns.Add(grdDesc);

        }
    }
}
