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
    public partial class frmDesignation : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmDesignationMaster master;
        string strSQL;
        int activeStatus;
        public frmDesignation(frmDesignationMaster frm)
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
            if (txtDesID.Text == "")
            {
                MessageBox.Show("Enter Designation ID");
                this.ActiveControl = txtDesID;
                return;
            }
            if (txtDesName.Text == "")
            {
                MessageBox.Show("Enter Designation Name");
                this.ActiveControl = txtDesName;
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

                strSQL = "INSERT INTO DESIGNATIONS (AUDTDATE,AUDTTIME,AUDTUSER,DESID,DESNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtDesID.Text.Trim() + "',"
                    + "'" + txtDesName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from DESIGNATIONS";

                master.dataLoadList(strSQL, "DESIGNATIONS");

                txtDesID.Text = "";
                txtDesName.Text = "";
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

                strSQL = "update DESIGNATIONS set DESID = '" + txtDesID.Text.Trim() + "', DESNAME = '"
                    + txtDesName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where DESID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from DESIGNATIONS";

                master.dataLoadList(strSQL, "DESIGNATIONS");

                txtDesID.Text = "";
                txtDesName.Text = "";
                chkStatus.Checked = true;
            }

        }
        private void frmDesignation_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from DESIGNATIONS WHERE DESID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "DESIGNATIONS");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtDesID.Text = drow["DESID"].ToString().Trim();
                        txtDesName.Text = drow["DESNAME"].ToString().Trim();

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
