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
    public partial class frmInstitute : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmInstituteMaster master;
        string strSQL;
        int activeStatus;
        public frmInstitute(frmInstituteMaster frm)
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
            if (txtInstituteID.Text == "")
            {
                MessageBox.Show("Enter Institute ID");
                this.ActiveControl = txtInstituteID;
                return;
            }
            if (txtInstituteName.Text == "")
            {
                MessageBox.Show("Enter Institute Name");
                this.ActiveControl = txtInstituteName;
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

                strSQL = "INSERT INTO INSTITUTE (AUDTDATE,AUDTTIME,AUDTUSER,INSID,INSNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtInstituteID.Text.Trim() + "',"
                    + "'" + txtInstituteName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from INSTITUTE";

                master.dataLoadList(strSQL, "INSTITUTE");

                txtInstituteID.Text = "";
                txtInstituteName.Text = "";
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

                strSQL = "update INSTITUTE set INSID = '" + txtInstituteID.Text.Trim() + "', INSNAME = '"
                    + txtInstituteName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where INSID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from INSTITUTE";

                master.dataLoadList(strSQL, "INSTITUTE");

                txtInstituteID.Text = "";
                txtInstituteName.Text = "";
                chkStatus.Checked = true;
            }
        }
        private void frmInstitute_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from INSTITUTE WHERE INSID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "INSTITUTE");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtInstituteID.Text = drow["INSID"].ToString().Trim();
                        txtInstituteName.Text = drow["INSNAME"].ToString().Trim();

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
