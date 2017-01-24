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
    public partial class frmBankSetup : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmBankMaster master;
        string strSQL;
        int activeStatus;
        public frmBankSetup(frmBankMaster frm)
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
            if (txtBnkID.Text == "")
            {
                MessageBox.Show("Enter Bank ID");
                this.ActiveControl = txtBnkID;
                return;
            }
            if (txtBnkName.Text == "")
            {
                MessageBox.Show("Enter Bank Name");
                this.ActiveControl = txtBnkName;
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

                strSQL = "INSERT INTO BANK (AUDTDATE,AUDTTIME,AUDTUSER,BNKID,BNKNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtBnkID.Text.Trim() + "',"
                    + "'" + txtBnkName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from BANK";

                master.dataLoadList(strSQL, "BANK");
                txtBnkID.Text = "";
                txtBnkName.Text = "";
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

                strSQL = "update BANK set BNKID = '" + txtBnkID.Text.Trim() + "', BNKNAME = '"
                    + txtBnkName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where BNKID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from BANK";

                master.dataLoadList(strSQL, "BANK");

                txtBnkID.Text = "";
                txtBnkName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmBankSetup_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from BANK WHERE BNKID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "BANK");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtBnkID.Text = drow["BNKID"].ToString().Trim();
                        txtBnkName.Text = drow["BNKNAME"].ToString().Trim();

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
