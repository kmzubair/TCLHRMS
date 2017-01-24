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
    public partial class frmRelation : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmRelationMaster master;
        string strSQL;
        int activeStatus;
        public frmRelation(frmRelationMaster frm)
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
            if (txtRelationID.Text == "")
            {
                MessageBox.Show("Enter Relation ID");
                this.ActiveControl = txtRelationID;
                return;
            }
            if (txtRelationName.Text == "")
            {
                MessageBox.Show("Enter Relation Name");
                this.ActiveControl = txtRelationName;
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

                strSQL = "INSERT INTO RELATION (AUDTDATE,AUDTTIME,AUDTUSER,RELID,RELNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtRelationID.Text.Trim() + "',"
                    + "'" + txtRelationName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from RELATION";

                master.dataLoadList(strSQL, "RELATION");

                txtRelationID.Text = "";
                txtRelationName.Text = "";
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

                strSQL = "update RELATION set RELID = '" + txtRelationID.Text.Trim() + "', RELNAME = '"
                    + txtRelationName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where RELID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from RELATION";

                master.dataLoadList(strSQL, "RELATION");

                txtRelationID.Text = "";
                txtRelationName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmRelation_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from RELATION WHERE RELID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "RELATION");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtRelationID.Text = drow["RELID"].ToString().Trim();
                        txtRelationName.Text = drow["RELNAME"].ToString().Trim();

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