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
    public partial class frmNationalityMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmNationalityMaster()
        {
            InitializeComponent();
        }
        private void frmNationalityMaster_Load(object sender, EventArgs e)
        {
            lstNationality.View = View.Details;
            lstNationality.GridLines = true;
            lstNationality.FullRowSelect = true;

            ColumnHeader natID, natName, natStatus;
            natID = new ColumnHeader();
            natName = new ColumnHeader();
            natStatus = new ColumnHeader();

            natID.Text = "ID";
            natID.TextAlign = HorizontalAlignment.Center;
            natID.Width = 70;

            natName.Text = "Nationality";
            natName.TextAlign = HorizontalAlignment.Center;
            natName.Width = 545;

            natStatus.Text = "Status";
            natStatus.TextAlign = HorizontalAlignment.Center;
            natStatus.Width = 150;

            lstNationality.Columns.Add(natID);
            lstNationality.Columns.Add(natName);
            lstNationality.Columns.Add(natStatus);

            strSQL = "Select * from NATIONALITY";

            dataLoadList(strSQL, "NATIONALITY");            
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();           
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstNationality.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["NATID"].ToString().Trim());
                    lvi.SubItems.Add(drow["NATNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstNationality.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNationality nationality = new frmNationality(this);
            nationality.Owner = this;
            nationality.txtMainUserName = txtMainUserName;
            nationality.fromAdd = true;
            nationality.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstNationality.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmNationality nationality = new frmNationality(this);
                nationality.Owner = this;
                nationality.txtMainUserName = txtMainUserName;
                nationality.fromAdd = false;
                ListViewItem item = lstNationality.SelectedItems[0];
                nationality.primaryID = item.Text;
                nationality.ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNationality.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstNationality.SelectedItems[0];

                strSQL = "DELETE from NATIONALITY where NATID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from NATIONALITY";

                dataLoadList(strSQL, "NATIONALITY");
            }

        }
    }
}
