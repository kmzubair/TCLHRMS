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
    public partial class frmTrainingTypeMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;
        public frmTrainingTypeMaster()
        {
            InitializeComponent();
        }

        private void frmTrainingTypeMaster_Load(object sender, EventArgs e)
        {
            lstTrainingType.View = View.Details;
            lstTrainingType.GridLines = true;
            lstTrainingType.FullRowSelect = true;

            ColumnHeader trnID, trnName, trnStatus;
            trnID = new ColumnHeader();
            trnName = new ColumnHeader();
            trnStatus = new ColumnHeader();

            trnID.Text = "ID";
            trnID.TextAlign = HorizontalAlignment.Center;
            trnID.Width = 70;

            trnName.Text = "Training Type";
            trnName.TextAlign = HorizontalAlignment.Center;
            trnName.Width = 545;

            trnStatus.Text = "Status";
            trnStatus.TextAlign = HorizontalAlignment.Center;
            trnStatus.Width = 150;


            lstTrainingType.Columns.Add(trnID);
            lstTrainingType.Columns.Add(trnName);
            lstTrainingType.Columns.Add(trnStatus);


            strSQL = "Select * from TRANINGTYPE";

            dataLoadList(strSQL, "TRANINGTYPE");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();         
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstTrainingType.Items.Clear();

            string activeStatus;

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["TRNTYPEID"].ToString().Trim());
                    lvi.SubItems.Add(drow["TRNTYPENAME"].ToString().Trim());

                    if (drow["SWACTV"].ToString() == "1")
                    {
                        activeStatus = "Active";
                    }
                    else
                    {
                        activeStatus = "Inactive";
                    }

                    lvi.SubItems.Add(activeStatus);
                    lstTrainingType.Items.Add(lvi);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTrainingType trainingType = new frmTrainingType(this);
            trainingType.Owner = this;
            trainingType.txtMainUserName = txtMainUserName;
            trainingType.fromAdd = true;
            trainingType.ShowDialog();

        }       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTrainingType.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmTrainingType trainingType = new frmTrainingType(this);
                trainingType.Owner = this;
                trainingType.txtMainUserName = txtMainUserName;
                trainingType.fromAdd = false;
                ListViewItem item = lstTrainingType.SelectedItems[0];
                trainingType.primaryID = item.Text;
                trainingType.ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTrainingType.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstTrainingType.SelectedItems[0];

                strSQL = "DELETE from TRANINGTYPE where TRNTYPEID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from TRANINGTYPE";

                dataLoadList(strSQL, "TRANINGTYPE");
            }
        }
    }
}
