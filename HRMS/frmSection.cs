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
    public partial class frmSection : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmSectionMaster master;
        private string strSQL;
        private int activeStatus;

        public frmSection(frmSectionMaster frm)
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
            if (txtSecID.Text == "")
            {
                MessageBox.Show("Enter Section ID");
                this.ActiveControl = txtSecID;
                return;
            }
            if (txtSecName.Text == "")
            {
                MessageBox.Show("Enter Section Name");
                this.ActiveControl = txtSecName;
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

                strSQL = "INSERT INTO SECTION (AUDTDATE,AUDTTIME,AUDTUSER,SECID,SECNAME,SWACTV,DATELASTMN,LSTUSER)"
                         + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" +
                         txtSecID.Text.Trim() + "',"
                         + "'" + txtSecName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" +
                         txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from SECTION";

                master.dataLoadList(strSQL, "SECTION");

                txtSecID.Text = "";
                txtSecName.Text = "";
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

                strSQL = "update SECTION set SECID = '" + txtSecID.Text.Trim() + "', SECNAME = '"
                         + txtSecName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                         + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where SECID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from SECTION";

                master.dataLoadList(strSQL, "SECTION");

                txtSecID.Text = "";
                txtSecName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmSection_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from SECTION WHERE SECID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "SECTION");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtSecID.Text = drow["SECID"].ToString().Trim();
                        txtSecName.Text = drow["SECNAME"].ToString().Trim();

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
    }
}

