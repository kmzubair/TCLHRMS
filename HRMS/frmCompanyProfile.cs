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
    public partial class frmCompanyProfile : Form
    {
        public string txtMainUserName;      
        private string primaryID;
        private string strSQL;
        private int rowIndex = 0;
        SQL sq = new SQL();
        DataTable dt = new DataTable();
        private frmCompanyProfile companyProfile;
        dataProvider DBexe = new dataProvider();
        string AUDTDATE = DateTime.Now.ToString("yyyyMMdd");
        string AUDTTIME = DateTime.Now.ToString("HHmm");
        public Boolean oldRecord;
        public Boolean enableEdit;
        public frmCompanyProfile()
        {
            InitializeComponent();
        }
        private void frmCompanyProfile_Load(object sender, EventArgs e)
        {           
            //ButtonStatus();
            btnSave.Enabled = true;
            btnEdit.Enabled = true;
            dt = sq.get_rs("Select COMNAME,COMADDRESS,COMEMAIL,COMWEB FROM companyProfile");

            if (dt.Rows.Count<1)
            {
                goto exit;
            }
            CompanyInfoHeld();
            btnSave.Enabled = false;
            exit:
            ;
        }
        public void CompanyInfoHeld()
        {
            txtComName.Text = dt.Rows[rowIndex]["COMNAME"].ToString();
            txtComAddress.Text = dt.Rows[rowIndex]["COMADDRESS"].ToString();
            txtEmail.Text = dt.Rows[rowIndex]["COMEMAIL"].ToString();
            txtWeb.Text = dt.Rows[rowIndex]["COMWEB"].ToString();  
        }        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //ButtonStatus();

            //if (oldRecord==true)
            //{
                if (txtComName.Text == "")
                {
                    MessageBox.Show("Please Provide Company Name");
                    this.ActiveControl = txtComName;
                    return;
                }
                if (txtComAddress.Text == "")
                {
                    MessageBox.Show("Plese Provide Company Address");
                    this.ActiveControl = txtComAddress;
                    return;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Plese Provide Email Address");
                    this.ActiveControl = txtEmail;
                    return;
                }
                if (txtWeb.Text == "")
                {
                    MessageBox.Show("Plese Provide Web Address");
                    this.ActiveControl = txtWeb;
                    return;
                }

                strSQL = "INSERT INTO companyProfile (AUDTDATE,AUDTTIME,AUDTUSER,COMNAME,COMADDRESS,COMEMAIL,COMWEB,DATELASTMN,LSTUSER)"
                         + " VALUES ('" + AUDTDATE + "','" + AUDTTIME + "', '" + txtMainUserName + "', '" +
                         txtComName.Text.Trim() + "',"
                         + "'" + txtComAddress.Text.Trim() + "','" + txtEmail.Text.Trim() + "','" + txtWeb.Text.Trim() +
                         "','" + AUDTDATE + "', '" + txtMainUserName + "')";

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Saved Successful....");

                strSQL = "Select * from companyProfile";
            //}
            //if (oldRecord==false)
            //{                
                //dataProvider DBexe = new dataProvider();

                //strSQL = "update companyProfile set COMNAME = '" + txtComName.Text.Trim() + "', COMADDRESS = '"
                //    + txtComAddress.Text.Trim() + "', COMEMAIL = '" + txtEmail.Text.Trim() + "',COMWEB='" + txtWeb.Text.Trim() + "', DATELASTMN = '"
                //    + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where COMEMAIL = '"+txtEmail.Text.Trim()+"'";

                //DBexe.ExecuteCommand(strSQL);

                //MessageBox.Show("Updated Successful....");

                //strSQL = "Select * from companyProfile";
            //}     
           
        }        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnSave.Enabled = false;

            dataProvider DBexe = new dataProvider();

            strSQL = "update companyProfile set COMNAME = '" + txtComName.Text.Trim() + "', COMADDRESS = '"
                + txtComAddress.Text.Trim() + "', COMEMAIL = '" + txtEmail.Text.Trim() + "',COMWEB='" + txtWeb.Text.Trim() + "', DATELASTMN = '"
                + AUDTDATE + "', LSTUSER = '" + txtMainUserName + "' where COMEMAIL = '" + txtEmail.Text.Trim() + "'";

            DBexe.ExecuteCommand(strSQL);

            MessageBox.Show("Updated Successful....");

            strSQL = "Select * from companyProfile";
            //ButtonStatus();
           
        }
        public void ButtonStatus()
        {
            if (oldRecord==true)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;           
            }
            if (oldRecord==false)
            {
                btnEdit.Enabled = false;
                btnSave.Enabled = true;
           
            }
        }
    }
}
