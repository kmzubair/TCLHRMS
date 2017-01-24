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
    public partial class frmEmployeeGradesMaster : Form
    {
        public string txtMainUserName { get; set; }
        private string strSQL;    
        public frmEmployeeGradesMaster()
        {
            InitializeComponent();            
        }
        private void frmEmployeeGradesMaster_Load(object sender, EventArgs e)
        {
            lstEmpGrade.View = View.Details;
            lstEmpGrade.GridLines = true;
            lstEmpGrade.FullRowSelect = true;

            ColumnHeader grdID, grdName, grdGroup;

            grdID = new ColumnHeader();
            grdName = new ColumnHeader();
            grdGroup = new ColumnHeader();

            grdID.Text = "ID";
            grdName.TextAlign = HorizontalAlignment.Center;
            grdName.Width = 70;


            grdName.Text = "Grade Name";
            grdName.TextAlign = HorizontalAlignment.Center;
            grdName.Width = 545;

            grdGroup.Text = "Grade Group";
            grdGroup.TextAlign = HorizontalAlignment.Left;
            grdGroup.Width = 150;

            lstEmpGrade.Columns.Add(grdID);
            lstEmpGrade.Columns.Add(grdName);
            lstEmpGrade.Columns.Add(grdGroup);

            strSQL = "Select * from EMPLOYEEGRADE";

            dataLoadList(strSQL, "EMPLOYEEGRADE");
        }
        public void dataLoadList(string strSQL, string myString)
        {
            DataTable dtable = new DataTable();         
            dataProvider lstData = new dataProvider();

            dtable = lstData.getDataTable(strSQL, myString);

            lstEmpGrade.Items.Clear();          

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["EMPGRADEID"].ToString().Trim());
                    lvi.SubItems.Add(drow["EMPGRADENAME"].ToString().Trim());
                    lvi.SubItems.Add(drow["GRDGROUP"].ToString().Trim());             
                    lstEmpGrade.Items.Add(lvi);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeGrades employeeGrade = new frmEmployeeGrades(this);
            employeeGrade.Owner = this;
            employeeGrade.txtMainUserName = txtMainUserName;       
            employeeGrade.fromAdd = true;            
            employeeGrade.ShowDialog();
        }       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstEmpGrade.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
            }
            else
            {
                frmEmployeeGrades employeeGrades = new frmEmployeeGrades(this);
                employeeGrades.Owner = this;
                employeeGrades.txtMainUserName = txtMainUserName;
                employeeGrades.fromAdd = false;
                ListViewItem item = lstEmpGrade.SelectedItems[0];
                employeeGrades.primaryID = item.Text;
                employeeGrades.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEmpGrade.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Item Selected");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ListViewItem item = lstEmpGrade.SelectedItems[0];

                strSQL = "DELETE from EMPLOYEEGRADE where EMPGRADEID = '" + item.Text + "'";

                dataProvider DBexe = new dataProvider();

                DBexe.ExecuteCommand(strSQL);

                MessageBox.Show("Delete Successful....");

                strSQL = "Select * from EMPLOYEEGRADE";

                dataLoadList(strSQL, "EMPLOYEEGRADE");
            }

        }
    }
}
