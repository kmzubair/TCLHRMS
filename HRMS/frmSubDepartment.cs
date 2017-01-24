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
    public partial class frmSubDepartment : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;
        private frmSubDepartmentMaster master;
        private string strSQL;
        private int activeStatus;

        public frmSubDepartment(frmSubDepartmentMaster frm)
        {
            InitializeComponent();
            master = frm;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSubDepID.Text == "")
            {
                MessageBox.Show("Enter SubDepartment ID");
                this.ActiveControl = txtSubDepID;
                return;
            }
            if (txtSubDepName.Text == "")
            {
                MessageBox.Show("Enter SubDepartment Name");
                this.ActiveControl = txtSubDepName;
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

                strSQL = "INSERT INTO SUBDEPARTMENT (AUDTDATE,AUDTTIME,AUDTUSER,SUBDEPID,SUBDEPNAME,SWACTV,DATELASTMN,LSTUSER)"
                         + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" +
                         txtSubDepID.Text.Trim() + "'," + "'" + txtSubDepName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from SUBDEPARTMENT";

                master.dataLoadList(strSQL, "SUBDEPARTMENT");

                txtSubDepID.Text = "";
                txtSubDepName.Text = "";
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

                strSQL = "update SUBDEPARTMENT set SUBDEPID = '" + txtSubDepID.Text.Trim() + "', SUBDEPNAME = '"
                         + txtSubDepName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                         + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where SUBDEPID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from SUBDEPARTMENT";

                master.dataLoadList(strSQL, "SUBDEPARTMENT");

                txtSubDepID.Text = "";
                txtSubDepName.Text = "";
                chkStatus.Checked = true;
            }

        }
        private void frmSubDepartment_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from SUBDEPARTMENT WHERE SUBDEPID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "SUBDEPARTMENT");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtSubDepID.Text = drow["SUBDEPID"].ToString().Trim();
                        txtSubDepName.Text = drow["SUBDEPNAME"].ToString().Trim();

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

            if (fromAdd == false)
            {

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

