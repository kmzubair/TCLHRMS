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
    public partial class frmWeeklyHolidayMaster : Form
    {
        public frmWeeklyHolidayMaster()
        {
            InitializeComponent();
        }

        private void frmWeeklyHolidayMaster_Load(object sender, EventArgs e)
        {
            lstWeeklyHoliday.View = View.Details;
            lstWeeklyHoliday.GridLines = true;
            lstWeeklyHoliday.FullRowSelect = true;

            ColumnHeader whDesc, whDay;
            whDesc = new ColumnHeader();
            whDay = new ColumnHeader();


            whDesc.Text = "Location";
            whDesc.TextAlign = HorizontalAlignment.Left;
            whDesc.Width = 550;

            whDay.Text = "Day";
            whDay.TextAlign = HorizontalAlignment.Center;
            whDay.Width = 100;

            lstWeeklyHoliday.Columns.Add(whDesc);
            lstWeeklyHoliday.Columns.Add(whDay);

            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////

            string[] arr = new string[2];
            ListViewItem itm;

            //Add first item
            arr[0] = "All Location";
            arr[1] = "Friday";
            itm = new ListViewItem(arr);
            lstWeeklyHoliday.Items.Add(itm);


            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmWeeklyHolidaySetup WeeklyHolidaySetup = new frmWeeklyHolidaySetup();
            WeeklyHolidaySetup.Owner = this;
            WeeklyHolidaySetup.ShowDialog();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmWeeklyHolidayCalenderView ViewHolidayCalender = new frmWeeklyHolidayCalenderView();
            ViewHolidayCalender.Owner = this;
            ViewHolidayCalender.ShowDialog();

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            frmWeeklyHolidayProcess HolidayProcess = new frmWeeklyHolidayProcess();
            HolidayProcess.Owner = this;
            HolidayProcess.ShowDialog();
        }
    }
}
