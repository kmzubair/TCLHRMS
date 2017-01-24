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
    public partial class frmDistrict : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmDistrictMaster master;
        private string strSQL;
        private int activeStatus;

        public frmDistrict(frmDistrictMaster frm)
        {
            InitializeComponent();
            master = frm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDisID.Text == "")
            {
                MessageBox.Show("Enter District ID");
                this.ActiveControl = txtDisID;
                return;
            }
            if (txtDisName.Text == "")
            {
                MessageBox.Show("Enter District Name");
                this.ActiveControl = txtDisName;
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

                strSQL = "INSERT INTO DISTRICT (AUDTDATE,AUDTTIME,AUDTUSER,DISID,DISNAME,DIVNAME,SWACTV,DATELASTMN,LSTUSER)"
                         + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtDisID.Text.Trim() + "',"
                         + "'" + txtDisName.Text.Trim() + "','"+cmbDivisionName.Text.Trim()+"','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";
                
                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from DISTRICT";

                master.dataLoadList(strSQL, "DISTRICT");

                txtDisID.Text = "";
                txtDisName.Text = "";
                cmbDivisionName.Text = "";
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

                strSQL = "update DISTRICT set DISID = '" + txtDisID.Text.Trim() + "', DISNAME = '" + txtDisName.Text.Trim() + "', DIVNAME='"+cmbDivisionName.Text.Trim()+"', SWACTV = '" + activeStatus + "', " +
                         "DATELASTMN = '" + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where DISID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from DISTRICT";

                master.dataLoadList(strSQL, "DISTRICT");

                txtDisID.Text = "";
                txtDisName.Text = "";
                chkStatus.Checked = true;
            }
        }
        private void frmDistrict_Load(object sender, EventArgs e)
        {
            cmbDivisionName.Items.Add("Select Division...");
            cmbDivisionName.Items.Add("Dhaka");
            cmbDivisionName.Items.Add("Chittagong");
            cmbDivisionName.Items.Add("Rajshahi");
            cmbDivisionName.Items.Add("Rangpur");
            cmbDivisionName.Items.Add("Khulna");
            cmbDivisionName.Items.Add("Sylhet");
            cmbDivisionName.Items.Add("Barisal");
            cmbDivisionName.Items.Add("Mymenshingh");
            cmbDivisionName.SelectedIndex = 0;

            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from DISTRICT WHERE DISID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "DISTRICT");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtDisID.Text = drow["DISID"].ToString().Trim();
                        txtDisName.Text = drow["DISNAME"].ToString().Trim();
                        cmbDivisionName.Text = drow["DIVNAME"].ToString().Trim();
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

