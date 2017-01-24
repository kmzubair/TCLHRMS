using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.Class;

namespace HRMS
{
    public partial class frmEmployeeGrades : Form
    {
        
        public string txtMainUserName { get; set; }

        public bool fromAdd;
        public string primaryID;

        private frmEmployeeGradesMaster master;
        string strSQL;
        int activeStatus;
        public frmEmployeeGrades(frmEmployeeGradesMaster frm)
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
            if (txtEmpGrdID.Text == "")
            {
                MessageBox.Show("Enter Grade ID");
                this.ActiveControl = txtEmpGrdID;
                return;
            }
            if (txtEmpGrdName.Text == "")
            {
                MessageBox.Show("Enter Grade Name");
                this.ActiveControl = txtEmpGrdName;
                return;
            }
            string AUDTDATE = DateTime.Now.ToString("yyyyMMdd");
            string AUDTTIME = DateTime.Now.ToString("HHmm");

            if (fromAdd == true)
            {      
                dataProvider DBexe = new dataProvider();

                strSQL = "INSERT INTO EMPLOYEEGRADE (AUDTDATE,AUDTTIME,AUDTUSER,EMPGRADEID,EMPGRADENAME,GRDGROUP,DATELASTMN,LSTUSER)"
                    + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" + txtEmpGrdID.Text.Trim() + "',"
                    + "'" + txtEmpGrdName.Text.Trim() + "','" + cmbGradeGroup.Text.Trim() + "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from EMPLOYEEGRADE";

                master.dataLoadList(strSQL, "EMPLOYEEGRADE");

                txtEmpGrdID.Text = "";
                txtEmpGrdName.Text = "";                
            }

            if (fromAdd == false)
            {                
                dataProvider DBexe = new dataProvider();

                strSQL = "update EMPLOYEEGRADE set EMPGRADEID = '" + txtEmpGrdID.Text.Trim() + "', EMPGRADENAME = '"
                    + txtEmpGrdName.Text.Trim() + "', GRDGROUP = '" + cmbGradeGroup.Text.Trim() + "', DATELASTMN = '"
                    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where EMPGRADEID = '" + primaryID + "'";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Updated Successful....");

                strSQL = "Select * from EMPLOYEEGRADE";

                master.dataLoadList(strSQL, "EMPLOYEEGRADE");

                txtEmpGrdID.Text = "";
                txtEmpGrdName.Text = "";
                //cmbGradeGroup.Text = "";
            }
        }

        private void frmEmployeeGrades_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();
            if (fromAdd == false)
            {
                DataTable dtable = new DataTable();
                dataProvider lstData = new dataProvider();                

                strSQL = "Select * from EMPLOYEEGRADE WHERE EMPGRADEID = '" + primaryID + "'";
                dtable = lstData.getDataTable(strSQL, "EMPLOYEEGRADE");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        txtEmpGrdID.Text = drow["EMPGRADEID"].ToString().Trim();
                        txtEmpGrdName.Text = drow["EMPGRADENAME"].ToString().Trim();
                    }
                }
            }
        }
        public void ComboBoxLoad()
        {
            SQL sq = new SQL();
            DataTable dt = new DataTable();
            dt = sq.get_rs("Select GRDGROUP FROM GRADE");
            foreach (DataRow r in dt.Rows)
            {
                cmbGradeGroup.Items.Add(r["GRDGROUP"].ToString());
            }
        }
    }
}
