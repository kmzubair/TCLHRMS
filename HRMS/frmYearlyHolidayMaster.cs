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
    public partial class frmYearlyHolidayMaster : Form
    {
        public frmYearlyHolidayMaster()
        {
            InitializeComponent();
        }

        private void frmYearlyHolidayMaster_Load(object sender, EventArgs e)
        {
            lstYearlyHoliday.View = View.Details;
            lstYearlyHoliday.GridLines = true;
            lstYearlyHoliday.FullRowSelect = true;

            ColumnHeader yhDesc, yhFromDate, yhToDate, yhStatus;
            yhDesc = new ColumnHeader();
            yhFromDate = new ColumnHeader();
            yhToDate = new ColumnHeader();
            yhStatus = new ColumnHeader();


            yhDesc.Text = "Description";
            yhDesc.TextAlign = HorizontalAlignment.Left;
            yhDesc.Width = 300;

            yhFromDate.Text = "From Date";
            yhFromDate.TextAlign = HorizontalAlignment.Center;
            yhFromDate.Width = 100;

            yhToDate.Text = "To Date";
            yhToDate.TextAlign = HorizontalAlignment.Center;
            yhToDate.Width = 100;

            yhStatus.Text = "Status";
            yhStatus.TextAlign = HorizontalAlignment.Center;
            yhStatus.Width = 100;


            lstYearlyHoliday.Columns.Add(yhDesc);
            lstYearlyHoliday.Columns.Add(yhFromDate);
            lstYearlyHoliday.Columns.Add(yhToDate);
            lstYearlyHoliday.Columns.Add(yhStatus);

            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////

            string[] arr = new string[4];
            ListViewItem itm;

            //Add first item
            arr[0] = "Independence Day";
            arr[1] = "26-March-2017";
            arr[2] = "26-March-2017";
            arr[3] = "Active";
            itm = new ListViewItem(arr);
            lstYearlyHoliday.Items.Add(itm);


            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmYearlyHolidaySetup YearlyHolidaySetup = new frmYearlyHolidaySetup();
            YearlyHolidaySetup.Owner = this;
            YearlyHolidaySetup.ShowDialog();
        }
    }
}
