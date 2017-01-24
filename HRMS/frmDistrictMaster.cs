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
    public partial class frmDistrictMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmDistrictMaster()
        {
            InitializeComponent();
        }

        private void frmDistrictMaster_Load(object sender, EventArgs e)
        {
            lstDistrict.View = View.Details;
            lstDistrict.GridLines = true;
            lstDistrict.FullRowSelect = true;

            ColumnHeader disID, disName,disStatus,divName;
            disID = new ColumnHeader();
            disName = new ColumnHeader();
            disStatus = new ColumnHeader();
            divName=new ColumnHeader();

            disID.Text = "ID";
            disID.TextAlign = HorizontalAlignment.Center;
            disID.Width = 100;
            
            disName.Text = "District Name";
            disName.TextAlign = HorizontalAlignment.Center;
            disName.Width = 250;

            divName.Text = "Division Name";
            divName.TextAlign = HorizontalAlignment.Center;
            divName.Width = 250;

            disStatus.Text = "Status";
            disStatus.TextAlign = HorizontalAlignment.Center;
            disStatus.Width = 160;


            lstDistrict.Columns.Add(disID);
            lstDistrict.Columns.Add(disName);
            lstDistrict.Columns.Add(divName);
            lstDistrict.Columns.Add(disStatus);
      

            strSQL = "Select * from DISTRICT";

            dataLoadList(strSQL, "DISTRICT");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();

            //dbConnection ReportDB = new dbConnection();
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstDistrict.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["DISID"].ToString().Trim());
                    lvi.SubItems.Add(drow["DISNAME"].ToString().Trim());
                    lvi.SubItems.Add(drow["DIVNAME"].ToString().Trim());


                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstDistrict.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDistrict District = new frmDistrict(this);
            District.Owner = this;
            District.txtMainUserName = txtMainUserName;
            District.fromAdd = true;
            District.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstDistrict.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmDistrict district = new frmDistrict(this);
                district.Owner = this;
                district.txtMainUserName = txtMainUserName;
                district.fromAdd = false;
                ListViewItem item = lstDistrict.SelectedItems[0];
                district.primaryID = item.Text;
                district.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDistrict.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstDistrict.SelectedItems[0];

                strSQL = "DELETE from DISTRICT where DISID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from DISTRICT";

                dataLoadList(strSQL, "DISTRICT");
            }
        }
    }
}
