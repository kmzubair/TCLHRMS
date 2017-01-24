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
    public partial class frmDegreeTitle : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmDegreeTitleMaster master;
        string strSQL;
        int activeStatus;
        public frmDegreeTitle(frmDegreeTitleMaster frm)
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
            if (txtDegID.Text == "")
            {
                MessageBox.Show("Enter Degree ID");
                this.ActiveControl = txtDegID;
                return;
            }
            if (txtDegName.Text == "")
            {
                MessageBox.Show("Enter Degree Name");
                this.ActiveControl = txtDegName;
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

                strSQL = "INSERT INTO DEGREE (AUDTDATE,AUDTTIME,AUDTUSER,DEGID,DEGNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtDegID.Text.Trim() + "',"
                    + "'" + txtDegName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from DEGREE";

                master.dataLoadList(strSQL, "DEGREE");

                txtDegID.Text = "";
                txtDegName.Text = "";
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

                strSQL = "update DEGREE set DEGID = '" + txtDegID.Text.Trim() + "', DEGNAME = '"
                    + txtDegName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where DEGID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from DEGREE";

                master.dataLoadList(strSQL, "DEGREE");

                txtDegID.Text = "";
                txtDegName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmDegreeTitle_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from DEGREE WHERE DEGID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "DEGREE");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtDegID.Text = drow["DEGID"].ToString().Trim();
                        txtDegName.Text = drow["DEGNAME"].ToString().Trim();

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
