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
    public partial class frmDesignationMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmDesignationMaster()
        {
            InitializeComponent();
        }
        private void frmDesignationMaster_Load(object sender, EventArgs e)
        {
            lstDesignation.View = View.Details;
            lstDesignation.GridLines = true;
            lstDesignation.FullRowSelect = true;

            ColumnHeader desID, desDesc, desStatus;

            desID = new ColumnHeader();
            desDesc = new ColumnHeader();
            desStatus = new ColumnHeader();

            desID.Text = "ID";
            desDesc.TextAlign = HorizontalAlignment.Center;
            desDesc.Width = 70;

            desDesc.Text = "Designation";
            desDesc.TextAlign = HorizontalAlignment.Center;
            desDesc.Width = 545;

            desStatus.Text = "Status";
            desStatus.TextAlign = HorizontalAlignment.Center;
            desStatus.Width = 150;

            lstDesignation.Columns.Add(desID);
            lstDesignation.Columns.Add(desDesc);
            lstDesignation.Columns.Add(desStatus);

            strSQL = "Select * from DESIGNATIONS";

            dataLoadList(strSQL, "DESIGNATIONS");

        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();            
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstDesignation.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["DESID"].ToString().Trim());
                    lvi.SubItems.Add(drow["DESNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstDesignation.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDesignation designation = new frmDesignation(this);
            designation.Owner = this;
            designation.txtMainUserName = txtMainUserName;
            designation.fromAdd = true;
            designation.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstDesignation.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmDesignation designation = new frmDesignation(this);
                designation.Owner = this;
                designation.txtMainUserName = txtMainUserName;
                designation.fromAdd = false;
                ListViewItem item = lstDesignation.SelectedItems[0];
                designation.primaryID = item.Text;
                designation.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDesignation.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstDesignation.SelectedItems[0];

                strSQL = "DELETE from DESIGNATIONS where DESID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from DESIGNATIONS";

                dataLoadList(strSQL, "DESIGNATIONS");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
