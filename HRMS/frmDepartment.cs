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
    public partial class frmDepartment : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmDepartmentMaster master;
        string strSQL;
        int activeStatus;
        public frmDepartment(frmDepartmentMaster frm)
        {
            InitializeComponent();
            master = frm;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepId.Text == "")
            {
                MessageBox.Show("Enter Department ID");
                this.ActiveControl = txtDepId;
                return;
            }
            if (txtDepName.Text == "")
            {
                MessageBox.Show("Enter Department Name");
                this.ActiveControl = txtDepName;
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

                strSQL = "INSERT INTO DEPARTMENT (AUDTDATE,AUDTTIME,AUDTUSER,DEPID,DEPNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtDepId.Text.Trim() + "',"
                    + "'" + txtDepName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from DEPARTMENT";

                master.dataLoadList(strSQL, "DEPARTMENT");

                txtDepId.Text = "";
                txtDepName.Text = "";
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

                strSQL = "update DEPARTMENT set DEPID = '" + txtDepId.Text.Trim() + "', DEPNAME = '"
                    + txtDepName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where DEPID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from DEPARTMENT";

                master.dataLoadList(strSQL, "DEPARTMENT");

                txtDepId.Text = "";
                txtDepName.Text = "";
                chkStatus.Checked = true;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from DEPARTMENT WHERE DEPID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "DEPARTMENT");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtDepId.Text = drow["DEPID"].ToString().Trim();
                        txtDepName.Text = drow["DEPNAME"].ToString().Trim();

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
