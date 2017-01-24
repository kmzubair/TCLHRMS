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
    public partial class frmThana : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmThanaMaster master;
        string strSQL;
        int activeStatus;
        public frmThana(frmThanaMaster frm)
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
            if (txtThnID.Text == "")
            {
                MessageBox.Show("Enter Thana ID");
                this.ActiveControl = txtThnID;
                return;
            }
            if (txtThnName.Text == "")
            {
                MessageBox.Show("Enter Thana Name");
                this.ActiveControl = txtThnName;
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

                strSQL = "INSERT INTO THANA (AUDTDATE,AUDTTIME,AUDTUSER,THNID,THNNAME,DISNAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtThnID.Text.Trim() + "',"
                    + "'" + txtThnName.Text.Trim() + "','"+ cmbDistrictName.Text.Trim() +"','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from THANA";

                master.dataLoadList(strSQL, "THANA");

                txtThnID.Text = "";
                txtThnName.Text = "";
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

                strSQL = "update THANA set THNID = '" + txtThnID.Text.Trim() + "', THNNAME = '"
                    + txtThnName.Text.Trim() + "',DISNAME='"+ cmbDistrictName.Text.Trim() +"', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where THNID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from THANA";

                master.dataLoadList(strSQL, "THANA");

                txtThnID.Text = "";
                txtThnName.Text = "";
                chkStatus.Checked = true;
            }
        }

        private void frmThana_Load(object sender, EventArgs e)
        {
            //string[] district = new string[] { "Select District Name....", "Tangail", "Dhaka", "Dhamrai", "Manikganj", "Sirajganj" };
            //int items = 6;
            //for (int i = 0; i <items; i++)
            //{
            //    cmbDistrictName.Items.Add(i) =district(i);
            //}

            cmbDistrictName.Items.Add("Select District Name....");
            cmbDistrictName.Items.Add("Tangail");
            cmbDistrictName.Items.Add("Sirajganj");
            cmbDistrictName.Items.Add("Dhamrai");
            cmbDistrictName.Items.Add("Dhaka");
            cmbDistrictName.Items.Add("Jatrabari");
            cmbDistrictName.SelectedIndex = 0;
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from THANA WHERE THNID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "THANA");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtThnID.Text = drow["THNID"].ToString().Trim();
                        txtThnName.Text = drow["THNNAME"].ToString().Trim();
                        cmbDistrictName.Text = drow["DISNAME"].ToString().Trim();

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
