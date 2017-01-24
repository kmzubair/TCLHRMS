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
    public partial class frmDegreeTitleMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmDegreeTitleMaster()
        {
            InitializeComponent();
        }

        private void frmDegreeTitleMaster_Load(object sender, EventArgs e)
        {
            lstDegreeTitle.View = View.Details;
            lstDegreeTitle.GridLines = true;
            lstDegreeTitle.FullRowSelect = true;

            ColumnHeader degID, degName, degStatus;
            degID = new ColumnHeader();
            degName = new ColumnHeader();
            degStatus = new ColumnHeader();

            degID.Text = "ID";
            degID.TextAlign = HorizontalAlignment.Center;
            degID.Width = 70;

            degName.Text = "Degree Title";
            degName.TextAlign = HorizontalAlignment.Center;
            degName.Width = 545;

            degStatus.Text = "Status";
            degStatus.TextAlign = HorizontalAlignment.Center;
            degStatus.Width = 150;


            lstDegreeTitle.Columns.Add(degID);
            lstDegreeTitle.Columns.Add(degName);
            lstDegreeTitle.Columns.Add(degStatus);

            strSQL = "Select * from DEGREE";

            dataLoadList(strSQL, "DEGREE");

        }

        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();          
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstDegreeTitle.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["DEGID"].ToString().Trim());
                    lvi.SubItems.Add(drow["DEGNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstDegreeTitle.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDegreeTitle degreeTitle = new frmDegreeTitle(this);
            degreeTitle.Owner = this;
            degreeTitle.txtMainUserName = txtMainUserName;
            degreeTitle.fromAdd = true;
            degreeTitle.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstDegreeTitle.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmDegreeTitle degree = new frmDegreeTitle(this);
                degree.Owner = this;
                degree.txtMainUserName = txtMainUserName;
                degree.fromAdd = false;
                ListViewItem item = lstDegreeTitle.SelectedItems[0];
                degree.primaryID = item.Text;
                degree.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDegreeTitle.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstDegreeTitle.SelectedItems[0];

                strSQL = "DELETE from DEGREE where DEGID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from DEGREE";

                dataLoadList(strSQL, "DEGREE");
            }
        }
    }
}
