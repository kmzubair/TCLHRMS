namespace HRMS
{
    partial class frmBonusPaymentWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnuploaddata = new System.Windows.Forms.Button();
            this.btncleartax = new System.Windows.Forms.Button();
            this.btnbonusundo = new System.Windows.Forms.Button();
            this.btnbonusedit = new System.Windows.Forms.Button();
            this.btnbonusrefresh = new System.Windows.Forms.Button();
            this.btnbonusprocess = new System.Windows.Forms.Button();
            this.btnemployeesearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbcalculatetax = new System.Windows.Forms.CheckBox();
            this.chbdisbursewithsalary = new System.Windows.Forms.CheckBox();
            this.remainingbonusprocess = new System.Windows.Forms.NumericUpDown();
            this.currentbonusprocess = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bonuspaymentdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Bonuscutoffdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.basicconsidermonth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbonusname = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstEmpBonus = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remainingbonusprocess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentbonusprocess)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnuploaddata
            // 
            this.btnuploaddata.Location = new System.Drawing.Point(14, 394);
            this.btnuploaddata.Name = "btnuploaddata";
            this.btnuploaddata.Size = new System.Drawing.Size(80, 30);
            this.btnuploaddata.TabIndex = 6;
            this.btnuploaddata.Text = "Upload";
            this.btnuploaddata.UseVisualStyleBackColor = true;
            // 
            // btncleartax
            // 
            this.btncleartax.Location = new System.Drawing.Point(14, 358);
            this.btncleartax.Name = "btncleartax";
            this.btncleartax.Size = new System.Drawing.Size(80, 30);
            this.btncleartax.TabIndex = 5;
            this.btncleartax.Text = "Clear Tax";
            this.btncleartax.UseVisualStyleBackColor = true;
            // 
            // btnbonusundo
            // 
            this.btnbonusundo.Location = new System.Drawing.Point(14, 322);
            this.btnbonusundo.Name = "btnbonusundo";
            this.btnbonusundo.Size = new System.Drawing.Size(80, 30);
            this.btnbonusundo.TabIndex = 4;
            this.btnbonusundo.Text = "Undo";
            this.btnbonusundo.UseVisualStyleBackColor = true;
            // 
            // btnbonusedit
            // 
            this.btnbonusedit.Location = new System.Drawing.Point(14, 286);
            this.btnbonusedit.Name = "btnbonusedit";
            this.btnbonusedit.Size = new System.Drawing.Size(80, 30);
            this.btnbonusedit.TabIndex = 3;
            this.btnbonusedit.Text = "Edit";
            this.btnbonusedit.UseVisualStyleBackColor = true;
            // 
            // btnbonusrefresh
            // 
            this.btnbonusrefresh.Location = new System.Drawing.Point(14, 86);
            this.btnbonusrefresh.Name = "btnbonusrefresh";
            this.btnbonusrefresh.Size = new System.Drawing.Size(80, 30);
            this.btnbonusrefresh.TabIndex = 2;
            this.btnbonusrefresh.Text = "Refresh";
            this.btnbonusrefresh.UseVisualStyleBackColor = true;
            // 
            // btnbonusprocess
            // 
            this.btnbonusprocess.Location = new System.Drawing.Point(14, 50);
            this.btnbonusprocess.Name = "btnbonusprocess";
            this.btnbonusprocess.Size = new System.Drawing.Size(80, 30);
            this.btnbonusprocess.TabIndex = 1;
            this.btnbonusprocess.Text = "Process";
            this.btnbonusprocess.UseVisualStyleBackColor = true;
            // 
            // btnemployeesearch
            // 
            this.btnemployeesearch.Location = new System.Drawing.Point(14, 14);
            this.btnemployeesearch.Name = "btnemployeesearch";
            this.btnemployeesearch.Size = new System.Drawing.Size(80, 30);
            this.btnemployeesearch.TabIndex = 0;
            this.btnemployeesearch.Text = "Employee";
            this.btnemployeesearch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnuploaddata);
            this.groupBox2.Controls.Add(this.btncleartax);
            this.groupBox2.Controls.Add(this.btnbonusundo);
            this.groupBox2.Controls.Add(this.btnbonusedit);
            this.groupBox2.Controls.Add(this.btnbonusrefresh);
            this.groupBox2.Controls.Add(this.btnbonusprocess);
            this.groupBox2.Controls.Add(this.btnemployeesearch);
            this.groupBox2.Location = new System.Drawing.Point(620, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 434);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // chbcalculatetax
            // 
            this.chbcalculatetax.AutoSize = true;
            this.chbcalculatetax.Location = new System.Drawing.Point(355, 103);
            this.chbcalculatetax.Name = "chbcalculatetax";
            this.chbcalculatetax.Size = new System.Drawing.Size(104, 20);
            this.chbcalculatetax.TabIndex = 15;
            this.chbcalculatetax.Text = "Calculate Tax";
            this.chbcalculatetax.UseVisualStyleBackColor = true;
            // 
            // chbdisbursewithsalary
            // 
            this.chbdisbursewithsalary.AutoSize = true;
            this.chbdisbursewithsalary.Location = new System.Drawing.Point(355, 74);
            this.chbdisbursewithsalary.Name = "chbdisbursewithsalary";
            this.chbdisbursewithsalary.Size = new System.Drawing.Size(144, 20);
            this.chbdisbursewithsalary.TabIndex = 14;
            this.chbdisbursewithsalary.Text = "Disburse with Salary";
            this.chbdisbursewithsalary.UseVisualStyleBackColor = true;
            // 
            // remainingbonusprocess
            // 
            this.remainingbonusprocess.Location = new System.Drawing.Point(163, 103);
            this.remainingbonusprocess.Name = "remainingbonusprocess";
            this.remainingbonusprocess.Size = new System.Drawing.Size(50, 23);
            this.remainingbonusprocess.TabIndex = 13;
            // 
            // currentbonusprocess
            // 
            this.currentbonusprocess.Location = new System.Drawing.Point(163, 74);
            this.currentbonusprocess.Name = "currentbonusprocess";
            this.currentbonusprocess.Size = new System.Drawing.Size(50, 23);
            this.currentbonusprocess.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Remaining";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Currently Process for";
            // 
            // bonuspaymentdate
            // 
            this.bonuspaymentdate.CustomFormat = "dd-MMM-yyyy";
            this.bonuspaymentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bonuspaymentdate.Location = new System.Drawing.Point(163, 44);
            this.bonuspaymentdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bonuspaymentdate.Name = "bonuspaymentdate";
            this.bonuspaymentdate.Size = new System.Drawing.Size(169, 23);
            this.bonuspaymentdate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bonus Payment Date";
            // 
            // Bonuscutoffdate
            // 
            this.Bonuscutoffdate.CustomFormat = "dd-MMM-yyyy";
            this.Bonuscutoffdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Bonuscutoffdate.Location = new System.Drawing.Point(480, 44);
            this.Bonuscutoffdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bonuscutoffdate.Name = "Bonuscutoffdate";
            this.Bonuscutoffdate.Size = new System.Drawing.Size(99, 23);
            this.Bonuscutoffdate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bonus Cutoff Date";
            // 
            // basicconsidermonth
            // 
            this.basicconsidermonth.CustomFormat = "dd-MMM-yyyy";
            this.basicconsidermonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.basicconsidermonth.Location = new System.Drawing.Point(480, 16);
            this.basicconsidermonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.basicconsidermonth.Name = "basicconsidermonth";
            this.basicconsidermonth.Size = new System.Drawing.Size(99, 23);
            this.basicconsidermonth.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consider Basic of";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbcalculatetax);
            this.groupBox1.Controls.Add(this.chbdisbursewithsalary);
            this.groupBox1.Controls.Add(this.remainingbonusprocess);
            this.groupBox1.Controls.Add(this.currentbonusprocess);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bonuspaymentdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Bonuscutoffdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.basicconsidermonth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbbonusname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bonus Name";
            // 
            // cmbbonusname
            // 
            this.cmbbonusname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbonusname.FormattingEnabled = true;
            this.cmbbonusname.Location = new System.Drawing.Point(163, 16);
            this.cmbbonusname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbbonusname.Name = "cmbbonusname";
            this.cmbbonusname.Size = new System.Drawing.Size(169, 24);
            this.cmbbonusname.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstEmpBonus);
            this.groupBox4.Location = new System.Drawing.Point(12, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(587, 303);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // lstEmpBonus
            // 
            this.lstEmpBonus.Location = new System.Drawing.Point(9, 23);
            this.lstEmpBonus.Name = "lstEmpBonus";
            this.lstEmpBonus.Size = new System.Drawing.Size(572, 274);
            this.lstEmpBonus.TabIndex = 0;
            this.lstEmpBonus.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(12, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 59);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnClose.Location = new System.Drawing.Point(622, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(6, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmBonusPaymentWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBonusPaymentWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus Payment Wizard";
            this.Load += new System.EventHandler(this.frmBonusPaymentWizard_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remainingbonusprocess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentbonusprocess)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnuploaddata;
        private System.Windows.Forms.Button btncleartax;
        private System.Windows.Forms.Button btnbonusundo;
        private System.Windows.Forms.Button btnbonusedit;
        private System.Windows.Forms.Button btnbonusrefresh;
        private System.Windows.Forms.Button btnbonusprocess;
        private System.Windows.Forms.Button btnemployeesearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbcalculatetax;
        private System.Windows.Forms.CheckBox chbdisbursewithsalary;
        private System.Windows.Forms.NumericUpDown remainingbonusprocess;
        private System.Windows.Forms.NumericUpDown currentbonusprocess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker bonuspaymentdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Bonuscutoffdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker basicconsidermonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbonusname;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lstEmpBonus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}