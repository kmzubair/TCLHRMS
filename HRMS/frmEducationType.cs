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
    public partial class frmEducationType : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmEducationTypeMaster master;
        string strSQL;
        int activeStatus;
        public frmEducationType(frmEducationTypeMaster frm)
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
            if (txtEduID.Text == "")
            {
                MessageBox.Show("Enter Education Type ID");
                this.ActiveControl = txtEduID;
                return;
            }
            if (txtEduName.Text == "")
            {
                MessageBox.Show("Enter Education Type Name");
                this.ActiveControl = txtEduName;
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

                strSQL = "INSERT INTO EDUCATIONTYPE (AUDTDATE,AUDTTIME,AUDTUSER,EDUID,EDUNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtEduID.Text.Trim() + "',"
                    + "'" + txtEduName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from EDUCATIONTYPE";

                master.dataLoadList(strSQL, "EDUCATIONTYPE");

                txtEduID.Text = "";
                txtEduName.Text = "";
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

                strSQL = "update EDUCATIONTYPE set EDUID = '" + txtEduID.Text.Trim() + "', EDUNAME = '"
                    + txtEduName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where EDUID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from EDUCATIONTYPE";

                master.dataLoadList(strSQL, "EDUCATIONTYPE");

                txtEduID.Text = "";
                txtEduName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmEducationType_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from EDUCATIONTYPE WHERE EDUID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "EDUCATIONTYPE");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtEduID.Text = drow["EDUID"].ToString().Trim();
                        txtEduName.Text = drow["EDUNAME"].ToString().Trim();

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
