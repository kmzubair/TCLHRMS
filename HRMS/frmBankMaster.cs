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
    public partial class frmBankMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmBankMaster()
        {
            InitializeComponent();
        }

        private void frmBankMaster_Load(object sender, EventArgs e)
        {
            lstBank.View = View.Details;
            lstBank.GridLines = true;
            lstBank.FullRowSelect = true;

            ColumnHeader bnkID, bnkName, bonStatus;
            bnkID = new ColumnHeader();
            bnkName = new ColumnHeader();
            bonStatus = new ColumnHeader();

            bnkID.Text = "ID";
            bnkID.TextAlign = HorizontalAlignment.Center;
            bnkID.Width = 120;

            bnkName.Text = "Bank Name";
            bnkName.TextAlign = HorizontalAlignment.Left;
            bnkName.Width = 500;

            bonStatus.Text = "Status";
            bonStatus.TextAlign = HorizontalAlignment.Center;
            bonStatus.Width = 145;

            lstBank.Columns.Add(bnkID);
            lstBank.Columns.Add(bnkName);
            lstBank.Columns.Add(bonStatus);

            strSQL = "Select * from BANK";

            dataLoadList(strSQL, "BANK");
       }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstBank.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["BNKID"].ToString().Trim());
                    lvi.SubItems.Add(drow["BNKNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstBank.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBankSetup bankSetup = new frmBankSetup(this);
            bankSetup.Owner = this;
            bankSetup.txtMainUserName = txtMainUserName;
            bankSetup.fromAdd = true;
            bankSetup.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstBank.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmBankSetup bankSetup = new frmBankSetup(this);
                bankSetup.Owner = this;
                bankSetup.txtMainUserName = txtMainUserName;
                bankSetup.fromAdd = false;
                ListViewItem item = lstBank.SelectedItems[0];
                bankSetup.primaryID = item.Text;
                bankSetup.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBank.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstBank.SelectedItems[0];

                strSQL = "DELETE from BANK where BNKID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from BANK";

                dataLoadList(strSQL, "BANK");
            }
        }
    }
}
