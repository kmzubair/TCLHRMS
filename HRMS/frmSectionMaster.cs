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
    public partial class frmSectionMaster : Form
    {
        public string txtMainUserName { get; set; }

        public string dsnName;
        private string strSQL;
        public string cnt;
        public frmSectionMaster()
        {
            InitializeComponent();
        }
        private void frmSectionMaster_Load(object sender, EventArgs e)
        {
            lstSection.View = View.Details;
            lstSection.GridLines = true;
            lstSection.FullRowSelect = true;

            ColumnHeader sectionID, sectionName, sectionStatus;
            sectionID = new ColumnHeader();
            sectionName = new ColumnHeader();
            sectionStatus = new ColumnHeader();

            sectionID.Text = "ID";
            sectionID.TextAlign = HorizontalAlignment.Center;
            sectionID.Width = 70;

            sectionName.Text = "Sub Department Name";
            sectionName.TextAlign = HorizontalAlignment.Center;
            sectionName.Width = 545;

            sectionStatus.Text = "Status";
            sectionStatus.TextAlign = HorizontalAlignment.Center;
            sectionStatus.Width = 150;

            lstSection.Columns.Add(sectionID);
            lstSection.Columns.Add(sectionName);
            lstSection.Columns.Add(sectionStatus);

            strSQL = "Select * from SECTION";

            dataLoadList(strSQL, "SECTION");

        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstSection.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["SECID"].ToString().Trim());
                    lvi.SubItems.Add(drow["SECNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstSection.Items.Add(lvi);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSection Section = new frmSection(this);
            Section.Owner = this;
            Section.txtMainUserName = txtMainUserName;
            Section.fromAdd = true;
            Section.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstSection.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmSection section = new frmSection(this);
                section.Owner = this;
                section.txtMainUserName = txtMainUserName;
                section.fromAdd = false;
                ListViewItem item = lstSection.SelectedItems[0];
                section.primaryID = item.Text;
                section.ShowDialog(); 

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstSection.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstSection.SelectedItems[0];

                strSQL = "DELETE from SECTION where SECID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from SECTION";

                dataLoadList(strSQL, "SECTION");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
