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
    public partial class frmReligionMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmReligionMaster()
        {
            InitializeComponent();
        }

        private void frmReligionMaster_Load(object sender, EventArgs e)
        {
            lstReligion.View = View.Details;
            lstReligion.GridLines = true;
            lstReligion.FullRowSelect = true;

            ColumnHeader relID, relName, relStatus;
            relID = new ColumnHeader();
            relName = new ColumnHeader();
            relStatus = new ColumnHeader();

            relID.Text = "ID";
            relID.TextAlign = HorizontalAlignment.Center;
            relID.Width = 70;

            relName.Text = "Religion";
            relName.TextAlign = HorizontalAlignment.Center;
            relName.Width = 545;

            relStatus.Text = "Status";
            relStatus.TextAlign = HorizontalAlignment.Center;
            relStatus.Width = 150;

            lstReligion.Columns.Add(relID);
            lstReligion.Columns.Add(relName);
            lstReligion.Columns.Add(relStatus);

            strSQL = "Select * from RELIGIONS";

            dataLoadList(strSQL, "RELIGIONS");

        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();         
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstReligion.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["RELIID"].ToString().Trim());
                    lvi.SubItems.Add(drow["RELINAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstReligion.Items.Add(lvi);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmReligion religion = new frmReligion(this);
            religion.Owner = this;
            religion.txtMainUserName = txtMainUserName;
            religion.fromAdd = true;
            religion.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstReligion.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmReligion religion = new frmReligion(this);
                religion.Owner = this;
                religion.txtMainUserName = txtMainUserName;
                religion.fromAdd = false;
                ListViewItem item = lstReligion.SelectedItems[0];
                religion.primaryID = item.Text;
                religion.ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstReligion.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstReligion.SelectedItems[0];

                strSQL = "DELETE from RELIGIONS where RELIID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from RELIGIONS";

                dataLoadList(strSQL, "RELIGIONS");
            }

        }
    }
}
