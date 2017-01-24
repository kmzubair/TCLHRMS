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
    public partial class frmThanaMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmThanaMaster()
        {
            InitializeComponent();
        }

        private void frmThanaMaster_Load(object sender, EventArgs e)
        {
            lstThana.View = View.Details;
            lstThana.GridLines = true;
            lstThana.FullRowSelect = true;

            ColumnHeader thnID, thnName,disName,thnStatus;
            thnID = new ColumnHeader();
            thnName = new ColumnHeader();
            disName= new ColumnHeader();
            thnStatus=new ColumnHeader();

            thnID.Text = "ID";
            thnID.TextAlign = HorizontalAlignment.Center;
            thnID.Width = 100;

            thnName.Text = "Thana Name";
            thnName.TextAlign = HorizontalAlignment.Center;
            thnName.Width = 250;

            disName.Text = "District Name";
            disName.TextAlign = HorizontalAlignment.Center;
            disName.Width = 250;

            thnStatus.Text = "Status";
            thnStatus.TextAlign = HorizontalAlignment.Center;
            thnStatus.Width = 160;

            lstThana.Columns.Add(thnID);
            lstThana.Columns.Add(thnName);
            lstThana.Columns.Add(disName);
            lstThana.Columns.Add(thnStatus);

            strSQL = "Select * from THANA";

            dataLoadList(strSQL, "THANA");
    
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();
            
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstThana.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["THNID"].ToString().Trim());
                    lvi.SubItems.Add(drow["THNNAME"].ToString().Trim());
                    lvi.SubItems.Add(drow["DISNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }
                    lvi.SubItems.Add(activeStatus);
                    lstThana.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThana ThanaSetup = new frmThana(this);
            ThanaSetup.Owner = this;
            ThanaSetup.txtMainUserName = txtMainUserName;
            ThanaSetup.fromAdd = true;
            ThanaSetup.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstThana.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmThana thana = new frmThana(this);
                thana.Owner = this;
                thana.txtMainUserName = txtMainUserName;
                thana.fromAdd = false;
                ListViewItem item = lstThana.SelectedItems[0];
                thana.primaryID = item.Text;
                thana.ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstThana.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstThana.SelectedItems[0];

                strSQL = "DELETE from THANA where THNID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from THANA";

                dataLoadList(strSQL, "THANA");
            }

        }
    }
}
