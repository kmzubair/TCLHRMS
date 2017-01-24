using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.Class;

namespace HRMS
{
    public partial class frmRelationMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmRelationMaster()
        {
            InitializeComponent();
        }
        private void frmRelationMaster_Load(object sender, EventArgs e)
        {
            lstRelation.View = View.Details;
            lstRelation.GridLines = true;
            lstRelation.FullRowSelect = true;

            ColumnHeader relID, relDesc, relStatus;

            relID = new ColumnHeader();
            relDesc = new ColumnHeader();
            relStatus = new ColumnHeader();

            relID.Text = "ID";
            relDesc.TextAlign = HorizontalAlignment.Center;
            relDesc.Width = 70;

            relDesc.Text = "Relation";
            relDesc.TextAlign = HorizontalAlignment.Center;
            relDesc.Width = 545;

            relStatus.Text = "Status";
            relStatus.TextAlign = HorizontalAlignment.Center;
            relStatus.Width = 150;

            lstRelation.Columns.Add(relID);
            lstRelation.Columns.Add(relDesc);
            lstRelation.Columns.Add(relStatus);

            strSQL = "Select * from RELATION";
            dataLoadList(strSQL, "RELATION");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();           
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstRelation.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["RELID"].ToString().Trim());
                    lvi.SubItems.Add(drow["RELNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstRelation.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRelation relation = new frmRelation(this);
            relation.Owner = this;
            relation.txtMainUserName = txtMainUserName;
            relation.fromAdd = true;
            relation.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstRelation.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmRelation relation = new frmRelation(this);
                relation.Owner = this;
                relation.txtMainUserName = txtMainUserName;
                relation.fromAdd = false;
                ListViewItem item = lstRelation.SelectedItems[0];
                relation.primaryID = item.Text;
                relation.ShowDialog();               
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRelation.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstRelation.SelectedItems[0];

                strSQL = "DELETE from RELATION where RELID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from RELATION";

                dataLoadList(strSQL, "RELATION");
            }
        }
    }
}
