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
    public partial class frmLocation : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmLocationMaster master;
        private string strSQL;
        private int activeStatus;

        public frmLocation(frmLocationMaster frm)
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
            if (txtLocID.Text == "")
            {
                MessageBox.Show("Enter Location ID");
                this.ActiveControl = txtLocID;
                return;
            }
            if (txtLocName.Text == "")
            {
                MessageBox.Show("Enter Location Name");
                this.ActiveControl = txtLocName;
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

                strSQL = "INSERT INTO LOCATION (AUDTDATE,AUDTTIME,AUDTUSER,LOCID,LOCNAME,SWACTV,DATELASTMN,LSTUSER)"
                         + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" +
                         txtLocID.Text.Trim() + "',"
                         + "'" + txtLocName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" +
                         txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from LOCATION";

                master.dataLoadList(strSQL, "LOCATION");

                txtLocID.Text = "";
                txtLocName.Text = "";
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

                strSQL = "update LOCATION set LOCID = '" + txtLocID.Text.Trim() + "', LOCNAME = '"
                         + txtLocName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                         + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where LOCID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from LOCATION";

                master.dataLoadList(strSQL, "LOCATION");

                txtLocID.Text = "";
                txtLocName.Text = "";
                chkStatus.Checked = true;
            }
        }
        private void frmLocation_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from LOCATION WHERE LOCID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "LOCATION");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtLocID.Text = drow["LOCID"].ToString().Trim();
                        txtLocName.Text = drow["LOCNAME"].ToString().Trim();

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
