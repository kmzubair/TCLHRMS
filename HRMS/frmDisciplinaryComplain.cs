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
    public partial class frmDisciplinaryComplain : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmDisciplinaryComplainMaster master;
        string strSQL;
        int activeStatus;
        public frmDisciplinaryComplain(frmDisciplinaryComplainMaster frm)
        {
            InitializeComponent();
            master = frm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtComID.Text == "")
            {
                MessageBox.Show("Enter Complain ID");
                this.ActiveControl = txtComID;
                return;
            }
            if (txtComDesName.Text == "")
            {
                MessageBox.Show("Enter Complain Name");
                this.ActiveControl = txtComDesName;
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

                strSQL = "INSERT INTO COMPLAIN (AUDTDATE,AUDTTIME,AUDTUSER,COMID,COMNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtComID.Text.Trim() + "',"
                    + "'" + txtComDesName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from COMPLAIN";

                master.dataLoadList(strSQL, "COMPLAIN");

                txtComID.Text = "";
                txtComDesName.Text = "";
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

                strSQL = "update COMPLAIN set COMID = '" + txtComID.Text.Trim() + "', COMNAME = '"
                    + txtComDesName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where COMID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from COMPLAIN";

                master.dataLoadList(strSQL, "COMPLAIN");

                txtComID.Text = "";
                txtComDesName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDisciplinaryComplain_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from COMPLAIN WHERE COMID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "COMPLAIN");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtComID.Text = drow["COMID"].ToString().Trim();
                        txtComDesName.Text = drow["COMNAME"].ToString().Trim();

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
