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
    public partial class frmDisciplinaryPunishmentMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmDisciplinaryPunishmentMaster()
        {
            InitializeComponent();
        }

        private void frmDisciplinaryPunishmentMaster_Load(object sender, EventArgs e)
        {
            lstPunishment.View = View.Details;
            lstPunishment.GridLines = true;
            lstPunishment.FullRowSelect = true;

            ColumnHeader punID, punName, punStatus;
            punID = new ColumnHeader();
            punName = new ColumnHeader();
            punStatus = new ColumnHeader();

            punID.Text = "ID";
            punID.TextAlign = HorizontalAlignment.Center;
            punID.Width = 70;

            punName.Text = "Punishment Description";
            punName.TextAlign = HorizontalAlignment.Center;
            punName.Width = 545;

            punStatus.Text = "Status";
            punStatus.TextAlign = HorizontalAlignment.Center;
            punStatus.Width = 150;


            lstPunishment.Columns.Add(punID);
            lstPunishment.Columns.Add(punName);
            lstPunishment.Columns.Add(punStatus);

            strSQL = "Select * from PUNISHMENT";

            dataLoadList(strSQL, "PUNISHMENT");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();            
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstPunishment.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["PUNISHID"].ToString().Trim());
                    lvi.SubItems.Add(drow["PUNISHNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstPunishment.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDisciplinaryPunishment punishmentSetup = new frmDisciplinaryPunishment(this);
            punishmentSetup.Owner = this;
            punishmentSetup.txtMainUserName = txtMainUserName;
            punishmentSetup.fromAdd = true;
            punishmentSetup.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPunishment.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmDisciplinaryPunishment punishment = new frmDisciplinaryPunishment(this);
                punishment.Owner = this;
                punishment.txtMainUserName = txtMainUserName;
                punishment.fromAdd = false;
                ListViewItem item = lstPunishment.SelectedItems[0];
                punishment.primaryID = item.Text;
                punishment.ShowDialog();
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPunishment.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstPunishment.SelectedItems[0];

                strSQL = "DELETE from PUNISHMENT where PUNISHID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from PUNISHMENT";

                dataLoadList(strSQL, "PUNISHMENT");
            }
        }
    }
}
