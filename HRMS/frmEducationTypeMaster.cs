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
    public partial class frmEducationTypeMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmEducationTypeMaster()
        {
            InitializeComponent();
        }

        private void frmEducationTypeMaster_Load(object sender, EventArgs e)
        {
            lstEducationType.View = View.Details;
            lstEducationType.GridLines = true;
            lstEducationType.FullRowSelect = true;

            ColumnHeader eudID, eudName, eudStatus;
            eudID = new ColumnHeader();
            eudName = new ColumnHeader();
            eudStatus = new ColumnHeader();

            eudID.Text = "ID";
            eudID.TextAlign = HorizontalAlignment.Center;
            eudID.Width = 70;

            eudName.Text = "Education Type";
            eudName.TextAlign = HorizontalAlignment.Center;
            eudName.Width = 545;

            eudStatus.Text = "Status";
            eudStatus.TextAlign = HorizontalAlignment.Center;
            eudStatus.Width = 150;

            lstEducationType.Columns.Add(eudID);
            lstEducationType.Columns.Add(eudName);
            lstEducationType.Columns.Add(eudStatus);

            strSQL = "Select * from EDUCATIONTYPE";

            dataLoadList(strSQL, "EDUCATIONTYPE");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();            
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstEducationType.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["EDUID"].ToString().Trim());
                    lvi.SubItems.Add(drow["EDUNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstEducationType.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEducationType educationType = new frmEducationType(this);
            educationType.Owner = this;
            educationType.txtMainUserName = txtMainUserName;
            educationType.fromAdd = true;
            educationType.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstEducationType.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmEducationType educationType = new frmEducationType(this);
                educationType.Owner = this;
                educationType.txtMainUserName = txtMainUserName;
                educationType.fromAdd = false;
                ListViewItem item = lstEducationType.SelectedItems[0];
                educationType.primaryID = item.Text;
                educationType.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEducationType.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstEducationType.SelectedItems[0];

                strSQL = "DELETE from EDUCATIONTYPE where EDUID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from EDUCATIONTYPE";

                dataLoadList(strSQL, "EDUCATIONTYPE");
            }
        }
    }
}
