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
    public partial class frmOccupations : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmOccupationsMaster master;
        string strSQL;
        int activeStatus;
        public frmOccupations(frmOccupationsMaster frm)
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
            if (txtOccID.Text == "")
            {
                MessageBox.Show("Enter Occupation ID");
                this.ActiveControl = txtOccID;
                return;
            }
            if (txtOccName.Text == "")
            {
                MessageBox.Show("Enter Occupation Name");
                this.ActiveControl = txtOccName;
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

                strSQL = "INSERT INTO OCCUPATIONS (AUDTDATE,AUDTTIME,AUDTUSER,OCCID,OCCNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtOccID.Text.Trim() + "',"
                    + "'" + txtOccName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from OCCUPATIONS";

                master.dataLoadList(strSQL, "OCCUPATIONS");

                txtOccID.Text = "";
                txtOccName.Text = "";
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

                strSQL = "update OCCUPATIONS set OCCID = '" + txtOccID.Text.Trim() + "', OCCNAME = '"
                    + txtOccName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where OCCID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from OCCUPATIONS";

                master.dataLoadList(strSQL, "OCCUPATIONS");

                txtOccID.Text = "";
                txtOccName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmOccupations_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from OCCUPATIONS WHERE OCCID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "OCCUPATIONS");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtOccID.Text = drow["OCCID"].ToString().Trim();
                        txtOccName.Text = drow["OCCNAME"].ToString().Trim();

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
