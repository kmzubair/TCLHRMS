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
    public partial class frmDisciplinaryPunishment : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmDisciplinaryPunishmentMaster master;
        string strSQL;
        int activeStatus;
        public frmDisciplinaryPunishment(frmDisciplinaryPunishmentMaster frm)
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
            if (txtPunishID.Text == "")
            {
                MessageBox.Show("Enter Punishment ID");
                this.ActiveControl = txtPunishID;
                return;
            }
            if (txtPunishName.Text == "")
            {
                MessageBox.Show("Enter Punishment Name");
                this.ActiveControl = txtPunishName;
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

                strSQL = "INSERT INTO PUNISHMENT (AUDTDATE,AUDTTIME,AUDTUSER,PUNISHID,PUNISHNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtPunishID.Text.Trim() + "',"
                    + "'" + txtPunishName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from PUNISHMENT";

                master.dataLoadList(strSQL, "PUNISHMENT");

                txtPunishID.Text = "";
                txtPunishName.Text = "";
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

                strSQL = "update PUNISHMENT set PUNISHID = '" + txtPunishID.Text.Trim() + "', PUNISHNAME = '"
                    + txtPunishName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where PUNISHID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from PUNISHMENT";

                master.dataLoadList(strSQL, "PUNISHMENT");

                txtPunishID.Text = "";
                txtPunishName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmDisciplinaryPunishment_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from PUNISHMENT WHERE PUNISHID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "PUNISHMENT");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtPunishID.Text = drow["PUNISHID"].ToString().Trim();
                        txtPunishName.Text = drow["PUNISHNAME"].ToString().Trim();

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
