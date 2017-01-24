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
    public partial class frmDisciplinaryComplainMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmDisciplinaryComplainMaster()
        {
            InitializeComponent();
        }

        private void frmDisciplinaryComplain_Load(object sender, EventArgs e)
        {
            lstComplain.View = View.Details;
            lstComplain.GridLines = true;
            lstComplain.FullRowSelect = true;

            ColumnHeader comID, comName, comStatus;
            comID = new ColumnHeader();
            comName = new ColumnHeader();
            comStatus = new ColumnHeader();

            comID.Text = "ID";
            comID.TextAlign = HorizontalAlignment.Center;
            comID.Width = 70;

            comName.Text = "Complain Description";
            comName.TextAlign = HorizontalAlignment.Center;
            comName.Width = 545;

            comStatus.Text = "Status";
            comStatus.TextAlign = HorizontalAlignment.Center;
            comStatus.Width = 150;


            lstComplain.Columns.Add(comID);
            lstComplain.Columns.Add(comName);
            lstComplain.Columns.Add(comStatus);

            strSQL = "Select * from COMPLAIN";

            dataLoadList(strSQL, "COMPLAIN");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();           
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstComplain.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["COMID"].ToString().Trim());
                    lvi.SubItems.Add(drow["COMNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstComplain.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDisciplinaryComplain complainSetup = new frmDisciplinaryComplain(this);
            complainSetup.Owner = this;
            complainSetup.txtMainUserName = txtMainUserName;
            complainSetup.fromAdd = true;
            complainSetup.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstComplain.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmDisciplinaryComplain complain = new frmDisciplinaryComplain(this);
                complain.Owner = this;
                complain.txtMainUserName = txtMainUserName;
                complain.fromAdd = false;
                ListViewItem item = lstComplain.SelectedItems[0];
                complain.primaryID = item.Text;
                complain.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstComplain.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstComplain.SelectedItems[0];

                strSQL = "DELETE from COMPLAIN where COMID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from COMPLAIN";

                dataLoadList(strSQL, "COMPLAIN");
            }
        }
    }
}
