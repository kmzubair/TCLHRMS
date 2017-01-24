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
    public partial class frmEmployeeType : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmEmployeeTypeMaster master;
        string strSQL;
        int activeStatus;
        public frmEmployeeType(frmEmployeeTypeMaster frm)
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
            if (txtEmpID.Text == "")
            {
                MessageBox.Show("Enter Employee ID");
                this.ActiveControl = txtEmpID;
                return;
            }
            if (txtEmpName.Text == "")
            {
                MessageBox.Show("Enter Employee Name");
                this.ActiveControl = txtEmpName;
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

                strSQL = "INSERT INTO EMPLOYEETYPE (AUDTDATE,AUDTTIME,AUDTUSER,EMPID,EMPNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtEmpID.Text.Trim() + "',"
                    + "'" + txtEmpName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from EMPLOYEETYPE";

                master.dataLoadList(strSQL, "EMPLOYEETYPE");

                txtEmpID.Text = "";
                txtEmpName.Text = "";
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

                strSQL = "update EMPLOYEETYPE set EMPID = '" + txtEmpID.Text.Trim() + "', EMPNAME = '"
                    + txtEmpName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where EMPID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from EMPLOYEETYPE";

                master.dataLoadList(strSQL, "EMPLOYEETYPE");

                txtEmpID.Text = "";
                txtEmpName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmEmployeeType_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from EMPLOYEETYPE WHERE EMPID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "EMPLOYEETYPE");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtEmpID.Text = drow["EMPID"].ToString().Trim();
                        txtEmpName.Text = drow["EMPNAME"].ToString().Trim();

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
