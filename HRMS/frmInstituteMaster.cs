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
    public partial class frmInstituteMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmInstituteMaster()
        {
            InitializeComponent();
        }

        private void frmInstituteMaster_Load(object sender, EventArgs e)
        {
            lstInstitute.View = View.Details;
            lstInstitute.GridLines = true;
            lstInstitute.FullRowSelect = true;

            ColumnHeader insID, insName, insStatus;
            insID = new ColumnHeader();
            insName = new ColumnHeader();
            insStatus = new ColumnHeader();

            insID.Text = "ID";
            insID.TextAlign = HorizontalAlignment.Center;
            insID.Width = 70;

            insName.Text = "Institute Name";
            insName.TextAlign = HorizontalAlignment.Center;
            insName.Width = 545;

            insStatus.Text = "Status";
            insStatus.TextAlign = HorizontalAlignment.Center;
            insStatus.Width = 150;


            lstInstitute.Columns.Add(insID);
            lstInstitute.Columns.Add(insName);
            lstInstitute.Columns.Add(insStatus);

            strSQL = "Select * from INSTITUTE";

            dataLoadList(strSQL, "INSTITUTE");

        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();           
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstInstitute.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["INSID"].ToString().Trim());
                    lvi.SubItems.Add(drow["INSNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstInstitute.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInstitute instituteSetup = new frmInstitute(this);
            instituteSetup.Owner = this;
            instituteSetup.txtMainUserName = txtMainUserName;
            instituteSetup.fromAdd = true;
            instituteSetup.ShowDialog();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstInstitute.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmInstitute institute = new frmInstitute(this);
                institute.Owner = this;
                institute.txtMainUserName = txtMainUserName;
                institute.fromAdd = false;
                ListViewItem item = lstInstitute.SelectedItems[0];
                institute.primaryID = item.Text;
                institute.ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstInstitute.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstInstitute.SelectedItems[0];

                strSQL = "DELETE from INSTITUTE where INSID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from INSTITUTE";

                dataLoadList(strSQL, "INSTITUTE");
            }
        }
    }
}
