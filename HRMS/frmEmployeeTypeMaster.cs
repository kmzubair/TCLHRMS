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
    public partial class frmEmployeeTypeMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmEmployeeTypeMaster()
        {
            InitializeComponent();
        }

        private void frmEmployeeTypeMaster_Load(object sender, EventArgs e)
        {
            lstEmployeeType.View = View.Details;
            lstEmployeeType.GridLines = true;
            lstEmployeeType.FullRowSelect = true;

            ColumnHeader typID, typName, typStatus;
            typID = new ColumnHeader();
            typName = new ColumnHeader();
            typStatus = new ColumnHeader();

            typID.Text = "ID";
            typID.TextAlign = HorizontalAlignment.Center;
            typID.Width = 70;

            typName.Text = "Employee Type";
            typName.TextAlign = HorizontalAlignment.Center;
            typName.Width = 545;

            typStatus.Text = "Status";
            typStatus.TextAlign = HorizontalAlignment.Center;
            typStatus.Width = 150;


            lstEmployeeType.Columns.Add(typID);
            lstEmployeeType.Columns.Add(typName);
            lstEmployeeType.Columns.Add(typStatus);

            strSQL = "Select * from EMPLOYEETYPE";

            dataLoadList(strSQL, "EMPLOYEETYPE");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();            
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstEmployeeType.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["EMPID"].ToString().Trim());
                    lvi.SubItems.Add(drow["EMPNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstEmployeeType.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeType employee = new frmEmployeeType(this);
            employee.Owner = this;
            employee.txtMainUserName = txtMainUserName;
            employee.fromAdd = true;
            employee.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstEmployeeType.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmEmployeeType employeeType = new frmEmployeeType(this);
                employeeType.Owner = this;
                employeeType.txtMainUserName = txtMainUserName;
                employeeType.fromAdd = false;
                ListViewItem item = lstEmployeeType.SelectedItems[0];
                employeeType.primaryID = item.Text;
                employeeType.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEmployeeType.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstEmployeeType.SelectedItems[0];

                strSQL = "DELETE from EMPLOYEETYPE where EMPID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from EMPLOYEETYPE";

                dataLoadList(strSQL, "EMPLOYEETYPE");
            }
        }
    }
}
