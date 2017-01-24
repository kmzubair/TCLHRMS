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
    public partial class frmMain : Form
    {
        public string txtMainUserName{get; set;}
        public frmMain()
        {           
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            treeView1.Top = 0;
            treeView1.Left = 0;
            treeView1.Height = this.Height - 50;

            //ExpandToLevel(treeView1.Nodes, 2);
            
            treeView1.Nodes[0].Expand();
            treeView1.Nodes[0].Nodes[0].Expand();
            //treeView1.Nodes[0].Nodes[0].Nodes[1].Expand();           
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Company Profile")
            {
                frmCompanyProfile CompanyProfile = new frmCompanyProfile();
                CompanyProfile.Owner = this;
                CompanyProfile.txtMainUserName = txtMainUserName;
                CompanyProfile.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Division")
            {
                frmDivisionMaster DivisionMaster = new frmDivisionMaster();
                DivisionMaster.Owner = this;
                DivisionMaster.txtMainUserName = txtMainUserName;
                DivisionMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Department")
            {
                frmDepartmentMaster DepartmentMaster = new frmDepartmentMaster();
                DepartmentMaster.Owner = this;
                DepartmentMaster.txtMainUserName = txtMainUserName;
                DepartmentMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Subdepartment")
            {
                frmSubDepartmentMaster SubDepartmentMaster = new frmSubDepartmentMaster();
                SubDepartmentMaster.Owner = this;
                SubDepartmentMaster.txtMainUserName = txtMainUserName;
                SubDepartmentMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Section")
            {
                frmSectionMaster SectionMaster = new frmSectionMaster();
                SectionMaster.Owner = this;
                SectionMaster.txtMainUserName = txtMainUserName;
                SectionMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Locations")
            {
                frmLocationMaster locationMaster = new frmLocationMaster();
                locationMaster.Owner = this;
                locationMaster.txtMainUserName = txtMainUserName;
                locationMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Weekend Setup")
            {
                frmWeeklyHolidayMaster WeeklyHolidayMaster = new frmWeeklyHolidayMaster();
                WeeklyHolidayMaster.Owner = this;
                WeeklyHolidayMaster.ShowDialog();
                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Yearly Holiday Setup")
            {
                frmYearlyHolidayMaster YearlyHolidayMaster = new frmYearlyHolidayMaster();
                YearlyHolidayMaster.Owner = this;
                YearlyHolidayMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Nationality")
            {
                frmNationalityMaster NationalityMaster = new frmNationalityMaster();
                NationalityMaster.Owner = this;
                NationalityMaster.txtMainUserName = txtMainUserName;
                NationalityMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Religions")
            {
                frmReligionMaster ReligionMaster = new frmReligionMaster();
                ReligionMaster.Owner = this;
                ReligionMaster.txtMainUserName = txtMainUserName;
                ReligionMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Relation")
            {
                frmRelationMaster RelationMaster = new frmRelationMaster();
                RelationMaster.Owner = this;
                RelationMaster.txtMainUserName = txtMainUserName;
                RelationMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Occupations")
            {
                frmOccupationsMaster OccupationMaster = new frmOccupationsMaster();
                OccupationMaster.Owner = this;
                OccupationMaster.txtMainUserName = txtMainUserName;
                OccupationMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Nomination Purpose")
            {
                frmNominationMaster NominationMaster = new frmNominationMaster();
                NominationMaster.Owner = this;
                NominationMaster.txtMainUserName = txtMainUserName;
                NominationMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Designation")
            {
                frmDesignationMaster designationMaster = new frmDesignationMaster();
                designationMaster.Owner = this;
                designationMaster.txtMainUserName = txtMainUserName;
                designationMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Employee Grades")
            {
                frmEmployeeGradesMaster employeeGrades = new frmEmployeeGradesMaster();
                employeeGrades.Owner = this;
                employeeGrades.txtMainUserName = txtMainUserName;
                employeeGrades.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Employee Type")
            {
                frmEmployeeTypeMaster employeeType = new frmEmployeeTypeMaster();
                employeeType.Owner = this;
                employeeType.txtMainUserName = txtMainUserName;
                employeeType.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Grade Group")
            {
                frmGradeGroupMaster gradeGroup = new frmGradeGroupMaster();
                gradeGroup.Owner = this;
                gradeGroup.txtMainUserName = txtMainUserName;
                gradeGroup.ShowDialog();
                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Employee Information")
            {
                frmEmployeeInformation EmployeeInformation = new frmEmployeeInformation();
                EmployeeInformation.Owner = this;
                EmployeeInformation.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Earning Deduction Setup")
            {
                frmEarningDeductionMaster EarningDiductionMaster = new frmEarningDeductionMaster();
                EarningDiductionMaster.Owner = this;
                EarningDiductionMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Applied to Individual")
            {
                frmEarningDeductionApplied EarningDiductionApplied = new frmEarningDeductionApplied();
                EarningDiductionApplied.Owner = this;
                EarningDiductionApplied.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Grade Setup")
            {
                frmEarningDeductionGradeSetupMaster GradeSetupMaster = new frmEarningDeductionGradeSetupMaster();
                GradeSetupMaster.Owner = this;
                GradeSetupMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "District")
            {
                frmDistrictMaster DistrictMaster = new frmDistrictMaster();
                DistrictMaster.Owner = this;
                DistrictMaster.txtMainUserName = txtMainUserName;
                DistrictMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Thana")
            {
                frmThanaMaster ThanaMaster = new frmThanaMaster();
                ThanaMaster.Owner = this;
                ThanaMaster.txtMainUserName = txtMainUserName;
                ThanaMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "OPI Item")
            {
                frmOPIItemMaster OPIItemMaster = new frmOPIItemMaster();
                OPIItemMaster.Owner = this;
                OPIItemMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            if (e.Node.Text == "Provision setup as per grade")
            {
                frmOPIGradeMaster OPIGradeMaster = new frmOPIGradeMaster();
                OPIGradeMaster.Owner = this;
                OPIGradeMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Individual OPI Setup")
            {
                frmOPIIndividual OPIIndividual = new frmOPIIndividual();
                OPIIndividual.Owner = this;
                OPIIndividual.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Loan Type")
            {
                frmLoanTypeMaster LoanTypeMaster = new frmLoanTypeMaster();
                LoanTypeMaster.Owner = this;
                LoanTypeMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Loan Schedule")
            {
                frmLoanSchedule LoanSchedule = new frmLoanSchedule();
                LoanSchedule.Owner = this;
                LoanSchedule.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Bonus Defination")
            {
                frmBonusDefinationMaster BonusDefination = new frmBonusDefinationMaster();
                BonusDefination.Owner = this;
                BonusDefination.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Bonus Parameter")
            {
                frmBonusParameterMaster BonusParameterMaster = new frmBonusParameterMaster();
                BonusParameterMaster.Owner = this;
                BonusParameterMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }
            
            if (e.Node.Text == "Bonus Payment Wizard")
            {
                frmBonusPaymentWizard BonusPaymentWizard = new frmBonusPaymentWizard();
                BonusPaymentWizard.Owner = this;
                BonusPaymentWizard.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Bank Setup")
            {
                frmBankMaster bankMaster = new frmBankMaster();
                bankMaster.Owner = this;
                bankMaster.txtMainUserName = txtMainUserName;
                bankMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Bank Branches")
            {
                frmBankBranchMaster BankBranch = new frmBankBranchMaster();
                BankBranch.Owner = this;
                BankBranch.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Assign Bank Account - Salary")
            {
                frmBankAccountAssignSalary BankAssignSalary = new frmBankAccountAssignSalary();
                BankAssignSalary.Owner = this;
                BankAssignSalary.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Assign Bank Account - OPI")
            {
                frmBankAccountAssignOPI BankAssignOPI = new frmBankAccountAssignOPI();
                BankAssignOPI.Owner = this;
                BankAssignOPI.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Education Type")
            {
                frmEducationTypeMaster educationType = new frmEducationTypeMaster();
                educationType.Owner = this;
                educationType.txtMainUserName = txtMainUserName;
                educationType.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Training Type")
            {
                frmTrainingTypeMaster trainingType = new frmTrainingTypeMaster();
                trainingType.Owner = this;
                trainingType.txtMainUserName = txtMainUserName;
                trainingType.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Degree Title")
            {
                frmDegreeTitleMaster degreeTitle = new frmDegreeTitleMaster();
                degreeTitle.Owner = this;
                degreeTitle.txtMainUserName=txtMainUserName;
                degreeTitle.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Institute")
            {
                frmInstituteMaster instituteMaster = new frmInstituteMaster();
                instituteMaster.Owner = this;
                instituteMaster.txtMainUserName = txtMainUserName;
                instituteMaster.ShowDialog();
                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Complain")
            {
                frmDisciplinaryComplainMaster complainMaster = new frmDisciplinaryComplainMaster();
                complainMaster.Owner = this;
                complainMaster.txtMainUserName = txtMainUserName;
                complainMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Punishment")
            {
                frmDisciplinaryPunishmentMaster punishmentMaster = new frmDisciplinaryPunishmentMaster();
                punishmentMaster.Owner = this;
                punishmentMaster.txtMainUserName = txtMainUserName;
                punishmentMaster.ShowDialog();

                // MessageBox.Show("Special Rate");
            }

            if (e.Node.Text == "Disciplinary Action Management")
            {
                frmDisciplinaryActionTaken ActionTaken = new frmDisciplinaryActionTaken();
                ActionTaken.Owner = this;
                ActionTaken.ShowDialog();

                // MessageBox.Show("Special Rate");
            }           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmBonusPaymentWizard BonusPaymentWizard = new frmBonusPaymentWizard();
            BonusPaymentWizard.Owner = this;
            BonusPaymentWizard.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();           
        }
    }
}
