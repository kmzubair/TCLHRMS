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
    public partial class frmEarningDeductionGradeSetup : Form
    {
        public frmEarningDeductionGradeSetup()
        {
            InitializeComponent();
        }

        private void frmEarningDeductionGradeSetup_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            ColumnHeader code, description;
            code = new ColumnHeader();
            description = new ColumnHeader();
            

            code.Text = "Code";
            code.TextAlign = HorizontalAlignment.Center;
            code.Width = 70;

            description.Text = "Description";
            description.TextAlign = HorizontalAlignment.Left;
            description.Width = 250;


            listView1.Columns.Add(code);
            listView1.Columns.Add(description);
            

        }
    }
}
