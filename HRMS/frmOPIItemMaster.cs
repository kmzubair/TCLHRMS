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
    public partial class frmOPIItemMaster : Form
    {
        public frmOPIItemMaster()
        {
            InitializeComponent();
        }

        private void frmOPIItemMaster_Load(object sender, EventArgs e)
        {
            lstOPIItem.View = View.Details;
            lstOPIItem.GridLines = true;
            lstOPIItem.FullRowSelect = true;

            ColumnHeader opiID, opiName, opiStatus;
            opiID = new ColumnHeader();
            opiName = new ColumnHeader();
            opiStatus = new ColumnHeader();

            opiID.Text = "ID";
            opiID.TextAlign = HorizontalAlignment.Center;
            opiID.Width = 70;

            opiName.Text = "OPI Item Name";
            opiName.TextAlign = HorizontalAlignment.Left;
            opiName.Width = 550;

            opiStatus.Text = "Status";
            opiStatus.TextAlign = HorizontalAlignment.Center;
            opiStatus.Width = 100;


            lstOPIItem.Columns.Add(opiID);
            lstOPIItem.Columns.Add(opiName);
            lstOPIItem.Columns.Add(opiStatus);

            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////

            //string[] arr = new string[3];
            //ListViewItem itm;

            ////Add first item
            //arr[0] = "001";
            //arr[1] = "Accounts";
            //arr[2] = "Active";
            //itm = new ListViewItem(arr);
            //lstOPIItem.Items.Add(itm);

            ////Add second item
            //arr[0] = "002";
            //arr[1] = "Production";
            //arr[2] = "Active";
            //itm = new ListViewItem(arr);
            //lstOPIItem.Items.Add(itm);

            ////Add third item
            //arr[0] = "003";
            //arr[1] = "QC";
            //arr[2] = "Active";
            //itm = new ListViewItem(arr);
            //lstOPIItem.Items.Add(itm);


            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOPIItemSetup OPIItemSetup = new frmOPIItemSetup();
            OPIItemSetup.Owner = this;
            OPIItemSetup.ShowDialog();

        }
    }
}
