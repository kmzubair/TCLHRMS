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
    public partial class frmBonusParameter : Form
    {
        public frmBonusParameter()
        {
            InitializeComponent();
        }

        private void frmBonusParameter_Load(object sender, EventArgs e)
        {
            lstGrade.View = View.Details;
            lstGrade.GridLines = true;
            lstGrade.FullRowSelect = true;

            ColumnHeader grdID, grdName, depStatus;
            grdID = new ColumnHeader();
            grdName = new ColumnHeader();


            grdID.Text = "ID";
            grdID.TextAlign = HorizontalAlignment.Center;
            grdID.Width = 70;

            grdName.Text = "Grade";
            grdName.TextAlign = HorizontalAlignment.Left;
            grdName.Width = 250;


            lstGrade.Columns.Add(grdID);
            lstGrade.Columns.Add(grdName);
            

        }
    }
}
