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
    public partial class frmWeeklyHolidaySetup : Form
    {
        public frmWeeklyHolidaySetup()
        {
            InitializeComponent();
        }

        private void radAllLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (radAllLocation.Checked == true)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }

            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;

            }
        }

        private void frmWeeklyHolidaySetup_Load(object sender, EventArgs e)
        {
            //groupBox1.Top = 35;
            //groupBox1.Left = 10;
            //groupBox2.Top = 35;
            //groupBox2.Left = 10;


            lstWeeklyHoliday.View = View.Details;
            lstWeeklyHoliday.GridLines = true;
            lstWeeklyHoliday.FullRowSelect = true;

            ColumnHeader whDesc, whDay;
            whDesc = new ColumnHeader();
            whDay = new ColumnHeader();


            whDesc.Text = "Location";
            whDesc.TextAlign = HorizontalAlignment.Left;
            whDesc.Width = 300;

            whDay.Text = "Day";
            whDay.TextAlign = HorizontalAlignment.Center;
            whDay.Width = 100;

            lstWeeklyHoliday.Columns.Add(whDesc);
            lstWeeklyHoliday.Columns.Add(whDay);

            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////

            cmbDayAll.Items.Add("Friday");
            cmbDayAll.Items.Add("Saturday");
            cmbDayAll.Items.Add("Sunday");
            cmbDayAll.Items.Add("Monday");
            cmbDayAll.Items.Add("Tuesday");
            cmbDayAll.Items.Add("Wednesday");
            cmbDayAll.Items.Add("Thursday");

            cmbDayLocation.Items.Add("Friday");
            cmbDayLocation.Items.Add("Saturday");
            cmbDayLocation.Items.Add("Sunday");
            cmbDayLocation.Items.Add("Monday");
            cmbDayLocation.Items.Add("Tuesday");
            cmbDayLocation.Items.Add("Wednesday");
            cmbDayLocation.Items.Add("Thursday");

            cmbLocationLocation.Items.Add("Gulshan Tower");
            cmbLocationLocation.Items.Add("Mohakhali");
            cmbLocationLocation.Items.Add("Motijheel");

        }
    }
}
