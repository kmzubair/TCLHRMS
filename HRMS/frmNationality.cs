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
    public partial class frmNationality : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmNationalityMaster master;
        string strSQL;
        int activeStatus;
        public frmNationality(frmNationalityMaster frm)
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
            if (txtNationalityID.Text == "")
            {
                MessageBox.Show("Enter Nationality ID");
                this.ActiveControl = txtNationalityID;
                return;
            }
            if (txtNationalityName.Text == "")
            {
                MessageBox.Show("Enter Nationality Name");
                this.ActiveControl = txtNationalityName;
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

                strSQL = "INSERT INTO NATIONALITY (AUDTDATE,AUDTTIME,AUDTUSER,NATID,NATNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtNationalityID.Text.Trim() + "',"
                    + "'" + txtNationalityName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from NATIONALITY";

                master.dataLoadList(strSQL, "NATIONALITY");

                txtNationalityID.Text = "";
                txtNationalityName.Text = "";
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

                strSQL = "update NATIONALITY set NATID = '" + txtNationalityID.Text.Trim() + "', NATNAME = '"
                    + txtNationalityName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where NATID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from NATIONALITY";

                master.dataLoadList(strSQL, "NATIONALITY");

                txtNationalityID.Text = "";
                txtNationalityName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmNationality_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from NATIONALITY WHERE NATID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "NATIONALITY");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtNationalityID.Text = drow["NATID"].ToString().Trim();
                        txtNationalityName.Text = drow["NATNAME"].ToString().Trim();

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
