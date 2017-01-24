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
    public partial class frmTrainingType : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmTrainingTypeMaster master;
        string strSQL;
        int activeStatus;
        public frmTrainingType(frmTrainingTypeMaster frm)
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
            if (txtTrnID.Text == "")
            {
                MessageBox.Show("Enter Traning ID");
                this.ActiveControl = txtTrnID;
                return;
            }
            if (txtTrnName.Text == "")
            {
                MessageBox.Show("Enter Traning Name");
                this.ActiveControl = txtTrnName;
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

                strSQL = "INSERT INTO TRANINGTYPE (AUDTDATE,AUDTTIME,AUDTUSER,TRNTYPEID,TRNTYPENAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtTrnID.Text.Trim() + "',"
                    + "'" + txtTrnName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from TRANINGTYPE";

                master.dataLoadList(strSQL, "TRANINGTYPE");

                txtTrnID.Text = "";
                txtTrnName.Text = "";
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

                strSQL = "update TRANINGTYPE set TRNTYPEID = '" + txtTrnID.Text.Trim() + "', TRNTYPENAME = '"
                    + txtTrnName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where TRNTYPEID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from TRANINGTYPE";

                master.dataLoadList(strSQL, "TRANINGTYPE");

                txtTrnID.Text = "";
                txtTrnName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmTrainingType_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from TRANINGTYPE WHERE TRNTYPEID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "TRANINGTYPE");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtTrnID.Text = drow["TRNTYPEID"].ToString().Trim();
                        txtTrnName.Text = drow["TRNTYPENAME"].ToString().Trim();

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
