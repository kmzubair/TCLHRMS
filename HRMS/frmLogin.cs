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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbCompany.Items.Add("Transcom Limited");
            cmbCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCompany.SelectedIndex = 0;
            dtpSessionDate.Value = DateTime.Now;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {            
            if(txtUserID.Text == "")
            {
                MessageBox.Show("Enter User ID");
                return;
            }

            if (txtPassword.Text =="")
            {
                MessageBox.Show("Enter Password");
                return;
            }
            string strSQL;
            string UserID = "";
            string UserPass = "";
            strSQL = "Select * from USERTBL";

            DataTable dtable = new DataTable();           
            dataProvider dtprovider = new dataProvider();

            dtable = dtprovider.getDataTable(strSQL, "USERTBL");

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    UserID = drow["USERID"].ToString().Trim();
                    UserPass = drow["USERPASS"].ToString().Trim();
                }
            }
            if (txtUserID.Text != UserID)
            {
                MessageBox.Show("Invalid User");
                return;
            }            
            if (txtPassword.Text != UserPass)
            {
                MessageBox.Show("Invalid Password");
                return;
            }
            frmMain MasterForm = new frmMain();
            this.Hide();
            MasterForm.txtMainUserName = txtUserID.Text;
            MasterForm.Show();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
