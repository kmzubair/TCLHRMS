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
    public partial class frmOccupationsMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmOccupationsMaster()
        {
            InitializeComponent();
        }
        private void frmOccupationsMaster_Load(object sender, EventArgs e)
        {
            lstOccupations.View = View.Details;
            lstOccupations.GridLines = true;
            lstOccupations.FullRowSelect = true;

            ColumnHeader occID, occDesc, occStatus;

            occID = new ColumnHeader();
            occDesc = new ColumnHeader();
            occStatus = new ColumnHeader();

            occID.Text = "ID";
            occDesc.TextAlign = HorizontalAlignment.Center;
            occDesc.Width = 70;


            occDesc.Text = "Occupations";
            occDesc.TextAlign = HorizontalAlignment.Center;
            occDesc.Width = 545;

            occStatus.Text = "Status";
            occStatus.TextAlign = HorizontalAlignment.Center;
            occStatus.Width = 150;

            lstOccupations.Columns.Add(occID);
            lstOccupations.Columns.Add(occDesc);
            lstOccupations.Columns.Add(occStatus);

            strSQL = "Select * from OCCUPATIONS";

            dataLoadList(strSQL, "OCCUPATIONS");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();           
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstOccupations.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["OCCID"].ToString().Trim());
                    lvi.SubItems.Add(drow["OCCNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstOccupations.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOccupations Occupations = new frmOccupations(this);
            Occupations.Owner = this;
            Occupations.txtMainUserName = txtMainUserName;
            Occupations.fromAdd = true;
            Occupations.ShowDialog();   
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstOccupations.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmOccupations occupations = new frmOccupations(this);
                occupations.Owner = this;
                occupations.txtMainUserName = txtMainUserName;
                occupations.fromAdd = false;
                ListViewItem item = lstOccupations.SelectedItems[0];
                occupations.primaryID = item.Text;
                occupations.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstOccupations.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstOccupations.SelectedItems[0];

                strSQL = "DELETE from OCCUPATIONS where OCCID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from OCCUPATIONS";

                dataLoadList(strSQL, "OCCUPATIONS");
            }

        }
    }
}
