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
    public partial class frmNomination : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmNominationMaster master;
        string strSQL;
        int activeStatus;
        public frmNomination(frmNominationMaster frm)
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
            if (txtNomID.Text == "")
            {
                MessageBox.Show("Enter Nomination ID");
                this.ActiveControl = txtNomID;
                return;
            }
            if (txtNomName.Text == "")
            {
                MessageBox.Show("Enter Nomination Name");
                this.ActiveControl = txtNomName;
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

                strSQL = "INSERT INTO NOMINATIONS (AUDTDATE,AUDTTIME,AUDTUSER,NOMID,NOMNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtNomID.Text.Trim() + "',"
                    + "'" + txtNomName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from NOMINATIONS";

                master.dataLoadList(strSQL, "NOMINATIONS");

                txtNomID.Text = "";
                txtNomName.Text = "";
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

                strSQL = "update NOMINATIONS set NOMID = '" + txtNomID.Text.Trim() + "', NOMNAME = '"
                    + txtNomName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where NOMID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from NOMINATIONS";

                master.dataLoadList(strSQL, "NOMINATIONS");

                txtNomID.Text = "";
                txtNomName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmNomination_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from NOMINATIONS WHERE NOMID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "NOMINATIONS");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtNomID.Text = drow["NOMID"].ToString().Trim();
                        txtNomName.Text = drow["NOMNAME"].ToString().Trim();

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
