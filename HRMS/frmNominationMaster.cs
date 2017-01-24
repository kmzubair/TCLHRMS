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
    public partial class frmNominationMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmNominationMaster()
        {
            InitializeComponent();
        }

        private void frmNominationMaster_Load(object sender, EventArgs e)
        {
            lstNomination.View = View.Details;
            lstNomination.GridLines = true;
            lstNomination.FullRowSelect = true;

            ColumnHeader nomID, nomDesc, nomStatus;

            nomID = new ColumnHeader();
            nomDesc = new ColumnHeader();
            nomStatus = new ColumnHeader();

            nomID.Text = "ID";
            nomDesc.TextAlign = HorizontalAlignment.Center;
            nomDesc.Width = 70;


            nomDesc.Text = "Nomination Purposes";
            nomDesc.TextAlign = HorizontalAlignment.Center;
            nomDesc.Width = 545;

            nomStatus.Text = "Status";
            nomStatus.TextAlign = HorizontalAlignment.Center;
            nomStatus.Width = 150;

            lstNomination.Columns.Add(nomID);
            lstNomination.Columns.Add(nomDesc);
            lstNomination.Columns.Add(nomStatus);

            strSQL = "Select * from NOMINATIONS";

            dataLoadList(strSQL, "NOMINATIONS");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();        
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstNomination.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["NOMID"].ToString().Trim());
                    lvi.SubItems.Add(drow["NOMNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstNomination.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNomination nomination = new frmNomination(this);
            nomination.Owner = this;
            nomination.txtMainUserName = txtMainUserName;
            nomination.fromAdd = true;
            nomination.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstNomination.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmNomination nomination = new frmNomination(this);
                nomination.Owner = this;
                nomination.txtMainUserName = txtMainUserName;
                nomination.fromAdd = false;
                ListViewItem item = lstNomination.SelectedItems[0];
                nomination.primaryID = item.Text;
                nomination.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNomination.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstNomination.SelectedItems[0];

                strSQL = "DELETE from NOMINATIONS where NOMID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from NOMINATIONS";

                dataLoadList(strSQL, "NOMINATIONS");
            }

        }
    }
}
