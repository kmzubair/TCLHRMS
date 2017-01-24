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
    public partial class frmBonusParameterMaster : Form
    {
        public frmBonusParameterMaster()
        {
            InitializeComponent();
        }

        private void frmBonusParameterMaster_Load(object sender, EventArgs e)
        {
            lstBonusParameter.View = View.Details;
            lstBonusParameter.GridLines = true;
            lstBonusParameter.FullRowSelect = true;

            ColumnHeader bonname, bonGrade;
            bonname = new ColumnHeader();
            bonGrade = new ColumnHeader();
            

            bonname.Text = "Bonus Name";
            bonname.TextAlign = HorizontalAlignment.Center;
            bonname.Width = 270;

            bonGrade.Text = "Applied Grade";
            bonGrade.TextAlign = HorizontalAlignment.Left;
            bonGrade.Width = 450;


            lstBonusParameter.Columns.Add(bonname);
            lstBonusParameter.Columns.Add(bonGrade);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBonusParameter BonusParameter = new frmBonusParameter();
            BonusParameter.Owner = this;
            BonusParameter.ShowDialog();

        }
    }
}
