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
    public partial class frmGradeGroup : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmGradeGroupMaster master;
        string strSQL;
        int activeStatus;
        public frmGradeGroup(frmGradeGroupMaster frm)
        {
            InitializeComponent();
            master = frm;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtGrdID.Text == "")
            {
                MessageBox.Show("Enter Grade ID");
                this.ActiveControl = txtGrdID;
                return;
            }
            if (txtGrdGroup.Text == "")
            {
                MessageBox.Show("Enter Grade Group");
                this.ActiveControl = txtGrdGroup;
                return;
            }
            string AUDTDATE = DateTime.Now.ToString("yyyyMMdd");
            string AUDTTIME = DateTime.Now.ToString("HHmm");

            if (fromAdd == true)
            {
                if (chkStatus.Checked == true)
                {
                    activeStatus = 1;
                }
                else
                {
                    activeStatus = 0;
                }
                dataProvider DBexe = new dataProvider();

                strSQL = "INSERT INTO GRADE (AUDTDATE,AUDTTIME,AUDTUSER,GRDID,GRDGROUP,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtGrdID.Text.Trim() + "',"
                    + "'" + txtGrdGroup.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from GRADE";

                master.dataLoadList(strSQL, "GRADE");

                txtGrdID.Text = "";
                txtGrdGroup.Text = "";
                chkStatus.Checked = true;
            }

            if (fromAdd == false)
            {
                if (chkStatus.Checked == true)
                {
                    activeStatus = 1;
                }
                else
                {
                    activeStatus = 0;
                }
                dataProvider DBexe = new dataProvider();

                strSQL = "update GRADE set GRDID = '" + txtGrdID.Text.Trim() + "', GRDGROUP = '"
                    + txtGrdGroup.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where GRDID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from GRADE";

                master.dataLoadList(strSQL, "GRADE");

                txtGrdID.Text = "";
                txtGrdGroup.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmGradeGroup_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from GRADE WHERE GRDID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "GRADE");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtGrdID.Text = drow["GRDID"].ToString().Trim();
                        txtGrdGroup.Text = drow["GRDGROUP"].ToString().Trim();

                        if (drow["SWACTV"].ToString() == "1")
                        {
                            chkStatus.Checked = true;
                        }
                        else
                        {
                            chkStatus.Checked = false;
                        }

                    }
                }
            }
        }
    }
}
