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
    public partial class frmDivisionMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmDivisionMaster()
        {
            InitializeComponent();
        }
        private void frmDivisionMaster_Load(object sender, EventArgs e)
        {            
            lstDivision.View = View.Details;
            lstDivision.GridLines = true;
            lstDivision.FullRowSelect = true;

            ColumnHeader divID, divName, divStatus;
	        divID = new ColumnHeader();
	        divName = new ColumnHeader();
            divStatus = new ColumnHeader();

            divID.Text = "ID";
	        divID.TextAlign = HorizontalAlignment.Center;
	        divID.Width = 70;

            divName.Text = "Division Name";
	        divName.TextAlign = HorizontalAlignment.Center;
	        divName.Width = 545;

            divStatus.Text = "Status";
	        divStatus.TextAlign = HorizontalAlignment.Center;
	        divStatus.Width = 150;

            lstDivision.Columns.Add(divID);
            lstDivision.Columns.Add(divName);
            lstDivision.Columns.Add(divStatus);

            strSQL = "Select * from DIVISION";

            dataLoadList(strSQL, "DIVISION");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();

            //dbConnection ReportDB = new dbConnection();
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstDivision.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState!= DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["DIVID"].ToString().Trim());
                    lvi.SubItems.Add(drow["DIVNAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString()=="1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }
                    
                    lvi.SubItems.Add(activeStatus);
                    lstDivision.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDivision Division = new frmDivision(this);
            Division.Owner = this;
            Division.txtMainUserName = txtMainUserName;
            Division.fromAdd = true;
            Division.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lstDivision.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmDivision Division = new frmDivision(this);
                Division.Owner = this;
                Division.txtMainUserName = txtMainUserName;
                Division.fromAdd = false;
                ListViewItem item = lstDivision.SelectedItems[0];
                Division.primaryID = item.Text;
                Division.ShowDialog();                
                
                //ListViewItem item = lstDivision.SelectedItems[0];
                //MessageBox.Show(item.Text);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDivision.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstDivision.SelectedItems[0];

                strSQL = "DELETE from DIVISION where DIVID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from DIVISION";

                dataLoadList(strSQL, "DIVISION");
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
