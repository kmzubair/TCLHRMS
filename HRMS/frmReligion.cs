﻿using System;
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
    public partial class frmReligion : Form
    {
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmReligionMaster master;
        string strSQL;
        int activeStatus;
        public frmReligion(frmReligionMaster frm)
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
            if (txtReligionID.Text == "")
            {
                MessageBox.Show("Enter Religion ID");
                this.ActiveControl = txtReligionID;
                return;
            }
            if (txtRelisionName.Text == "")
            {
                MessageBox.Show("Enter Religion Name");
                this.ActiveControl = txtRelisionName;
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

                strSQL = "INSERT INTO RELIGIONS (AUDTDATE,AUDTTIME,AUDTUSER,RELIID,RELINAME,SWACTV,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtReligionID.Text.Trim() + "',"
                    + "'" + txtRelisionName.Text.Trim() + "','" + activeStatus + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from RELIGIONS";

                master.dataLoadList(strSQL, "RELIGIONS");

                txtReligionID.Text = "";
                txtRelisionName.Text = "";
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

                strSQL = "update RELIGIONS set RELIID = '" + txtReligionID.Text.Trim() + "', RELINAME = '"
                    + txtRelisionName.Text.Trim() + "', SWACTV = '" + activeStatus + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where RELIID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from RELIGIONS";

                master.dataLoadList(strSQL, "RELIGIONS");

                txtReligionID.Text = "";
                txtRelisionName.Text = "";
                chkStatus.Checked = true;
            }
        }
        private void frmReligion_Load(object sender, EventArgs e)
        {
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();

                strSQL = "Select * from RELIGIONS WHERE RELIID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "RELIGIONS");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtReligionID.Text = drow["RELIID"].ToString().Trim();
                        txtRelisionName.Text = drow["RELINAME"].ToString().Trim();

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
