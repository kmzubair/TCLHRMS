using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRMS.Class;

namespace HRMS
{
    public partial class frmDivision : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmDivisionMaster master;
        string strSQL;
        int activeStatus;
        public frmDivision(frmDivisionMaster frm)
        {
            InitializeComponent();
            master = frm;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDivID.Text == "")
            {
                MessageBox.Show("Enter Division ID");
                this.ActiveControl = txtDivID;
                return;
            }
            if (txtDivName.Text == "")
            {
                MessageBox.Show("Enter Division Name");
                this.ActiveControl = txtDivName;
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

                strSQL = "INSERT INTO DIVISION (AUDTDATE,AUDTTIME,AUDTUSER,DIVID,DIVNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtDivID.Text.Trim() + "',"
                    + "'" + txtDivName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from DIVISION";

                master.dataLoadList(strSQL, "DIVISION");

                txtDivID.Text = "";
                txtDivName.Text = "";
                chkStatus.Checked = true;
            }

            if (fromAdd ==false)
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

                strSQL = "update division set DIVID = '" + txtDivID.Text.Trim() + "', DIVNAME = '"
                    + txtDivName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where DIVID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from DIVISION";

                master.dataLoadList(strSQL, "DIVISION");

                txtDivID.Text = "";
                txtDivName.Text = "";
                chkStatus.Checked = true;
            }
        }
        private void frmDivision_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from DIVISION WHERE DIVID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "DIVISION");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtDivID.Text = drow["DIVID"].ToString().Trim();
                        txtDivName.Text = drow["DIVNAME"].ToString().Trim();

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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
