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
    public partial class frmSubDepartmentMaster : Form
    {
        public string txtMainUserName { get; set; }

        public string dsnName;
        private string strSQL;
        public string cnt;
        public frmSubDepartmentMaster()
        {
            InitializeComponent();
        }
        private void frmSubDepartmentMaster_Load(object sender, EventArgs e)
        {
            lstSubDepartment.View = View.Details;
            lstSubDepartment.GridLines = true;
            lstSubDepartment.FullRowSelect = true;

            ColumnHeader sdepID, sdepName, sdepStatus;
            sdepID = new ColumnHeader();
            sdepName = new ColumnHeader();
            sdepStatus = new ColumnHeader();

            sdepID.Text = "ID";
            sdepID.TextAlign = HorizontalAlignment.Center;
            sdepID.Width = 70;

            sdepName.Text = "Sub Department Name";
            sdepName.TextAlign = HorizontalAlignment.Center;
            sdepName.Width = 545;

            sdepStatus.Text = "Status";
            sdepStatus.TextAlign = HorizontalAlignment.Center;
            sdepStatus.Width = 150;

            lstSubDepartment.Columns.Add(sdepID);
            lstSubDepartment.Columns.Add(sdepName);
            lstSubDepartment.Columns.Add(sdepStatus);

            strSQL = "Select * from SUBDEPARTMENT";

            dataLoadList(strSQL, "SUBDEPARTMENT");

        }

        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();
            
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstSubDepartment.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["SUBDEPID"].ToString().Trim());
                    lvi.SubItems.Add(drow["SUBDEPNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstSubDepartment.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSubDepartment SubDepartment = new frmSubDepartment(this);
            SubDepartment.Owner = this;         
            SubDepartment.txtMainUserName = txtMainUserName;
            SubDepartment.fromAdd = true;
            SubDepartment.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstSubDepartment.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmSubDepartment subDepartment = new frmSubDepartment(this);
                subDepartment.Owner = this;
                subDepartment.txtMainUserName = txtMainUserName;
                subDepartment.fromAdd = false;
                ListViewItem item = lstSubDepartment.SelectedItems[0];
                subDepartment.primaryID = item.Text;
                subDepartment.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstSubDepartment.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstSubDepartment.SelectedItems[0];

                strSQL = "DELETE from SUBDEPARTMENT where SUBDEPID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from SUBDEPARTMENT";

                dataLoadList(strSQL, "SUBDEPARTMENT");
            }
        }
    }
}
