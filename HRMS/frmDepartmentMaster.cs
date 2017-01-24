using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.Class;

namespace HRMS
{
    public partial class frmDepartmentMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;        
        public frmDepartmentMaster()
        {
            InitializeComponent();
        }
        private void frmDepartmentMaster_Load(object sender, EventArgs e)
        {
            lstDepartment.View = View.Details;
            lstDepartment.GridLines = true;
            lstDepartment.FullRowSelect = true;

            ColumnHeader depID, depName, depStatus;
            depID = new ColumnHeader();
            depName = new ColumnHeader();
            depStatus = new ColumnHeader();

            depID.Text = "ID";
            depID.TextAlign = HorizontalAlignment.Center;
            depID.Width = 110;

            depName.Text = "Department Name";
            depName.TextAlign = HorizontalAlignment.Center;
            depName.Width = 545;

            depStatus.Text = "Status";
            depStatus.TextAlign = HorizontalAlignment.Center;
            depStatus.Width = 110;

            lstDepartment.Columns.Add(depID);
            lstDepartment.Columns.Add(depName);
            lstDepartment.Columns.Add(depStatus);

            strSQL = "Select * from DEPARTMENT";

            dataLoadList(strSQL, "DEPARTMENT");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();
            
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstDepartment.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["DEPID"].ToString().Trim());
                    lvi.SubItems.Add(drow["DEPNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstDepartment.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDepartment Department = new frmDepartment(this);
            Department.Owner = this;
            Department.fromAdd = true;
            Department.ShowDialog();
            Department.txtMainUserName = txtMainUserName;
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstDepartment.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmDepartment Department = new frmDepartment(this);
                Department.Owner = this;
                Department.txtMainUserName = txtMainUserName;
                Department.fromAdd = false;
                ListViewItem item = lstDepartment.SelectedItems[0];
                Department.primaryID = item.Text;
                Department.ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDepartment.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstDepartment.SelectedItems[0];

                strSQL = "DELETE from DEPARTMENT where DEPID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from DEPARTMENT";

                dataLoadList(strSQL, "DEPARTMENT");
            }        
        }
    }
}
