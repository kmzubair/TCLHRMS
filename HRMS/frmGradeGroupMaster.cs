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
    public partial class frmGradeGroupMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmGradeGroupMaster()
        {
            InitializeComponent();
        }

        private void frmGradeGroupMaster_Load(object sender, EventArgs e)
        {
            lstGradeGroup.View = View.Details;
            lstGradeGroup.GridLines = true;
            lstGradeGroup.FullRowSelect = true;

            ColumnHeader grdID, grdgroup, grdStatus;
            grdID = new ColumnHeader();
            grdgroup = new ColumnHeader();
            grdStatus = new ColumnHeader();

            grdID.Text = "ID";
            grdID.TextAlign = HorizontalAlignment.Center;
            grdID.Width = 70;

            grdgroup.Text = "Grade group";
            grdgroup.TextAlign = HorizontalAlignment.Center;
            grdgroup.Width = 545;

            grdStatus.Text = "Status";
            grdStatus.TextAlign = HorizontalAlignment.Center;
            grdStatus.Width = 150;

            lstGradeGroup.Columns.Add(grdID);
            lstGradeGroup.Columns.Add(grdgroup);
            lstGradeGroup.Columns.Add(grdStatus);

            strSQL = "Select * from GRADE";

            dataLoadList(strSQL, "GRADE");

        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();           
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);
            lstGradeGroup.Items.Clear();
            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["GRDID"].ToString().Trim());
                    lvi.SubItems.Add(drow["GRDGROUP"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstGradeGroup.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmGradeGroup gradeGroup = new frmGradeGroup(this);
            gradeGroup.Owner = this;
            gradeGroup.txtMainUserName = txtMainUserName;
            gradeGroup.fromAdd = true;
            gradeGroup.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstGradeGroup.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmGradeGroup gradeGroup = new frmGradeGroup(this);
                gradeGroup.Owner = this;
                gradeGroup.txtMainUserName = txtMainUserName;
                gradeGroup.fromAdd = false;
                ListViewItem item = lstGradeGroup.SelectedItems[0];
                gradeGroup.primaryID = item.Text;
                gradeGroup.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstGradeGroup.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstGradeGroup.SelectedItems[0];

                strSQL = "DELETE from GRADE where GRDID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from GRADE";

                dataLoadList(strSQL, "GRADE");
            }

        }
    }
}
