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
    public partial class frmLocationMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;  
        public frmLocationMaster()
        {
            InitializeComponent();
        }

        private void frmLocationMaster_Load(object sender, EventArgs e)
        {
            lstLocation.View = View.Details;
            lstLocation.GridLines = true;
            lstLocation.FullRowSelect = true;

            ColumnHeader locationID, locationName, locationStatus;
            locationID = new ColumnHeader();
            locationName = new ColumnHeader();
            locationStatus = new ColumnHeader();

            locationID.Text = "ID";
            locationID.TextAlign = HorizontalAlignment.Center;
            locationID.Width = 110;

            locationName.Text = "Location Name";
            locationName.TextAlign = HorizontalAlignment.Center;
            locationName.Width = 545;

            locationStatus.Text = "Status";
            locationStatus.TextAlign = HorizontalAlignment.Center;
            locationStatus.Width = 110;


            lstLocation.Columns.Add(locationID);
            lstLocation.Columns.Add(locationName);
            lstLocation.Columns.Add(locationStatus);

            strSQL = "Select * from LOCATION";

            dataLoadList(strSQL, "LOCATION");

        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();

            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstLocation.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["LOCID"].ToString().Trim());
                    lvi.SubItems.Add(drow["LOCNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstLocation.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLocation location = new frmLocation(this);
            location.Owner = this;
            location.txtMainUserName = txtMainUserName;
            location.fromAdd = true;
            location.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstLocation.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmLocation location = new frmLocation(this);
                location.Owner = this;
                location.txtMainUserName = txtMainUserName;
                location.fromAdd = false;
                ListViewItem item = lstLocation.SelectedItems[0];
                location.primaryID = item.Text;
                location.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstLocation.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstLocation.SelectedItems[0];

                strSQL = "DELETE from LOCATION where LOCID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from LOCATION";

                dataLoadList(strSQL, "LOCATION");
            }               
        }
    }
}
