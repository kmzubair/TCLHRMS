namespace HRMS
{
    partial class frmLoanSchedule
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loanissuedate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnloancalculate = new System.Windows.Forms.Button();
            this.installmentstartdate = new System.Windows.Forms.DateTimePicker();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.interestrate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncreateadvance = new System.Windows.Forms.Button();
            this.btnloanscheduleprint = new System.Windows.Forms.Button();
            this.btnloanscheduleclose = new System.Windows.Forms.Button();
            this.btnloanscheduleedit = new System.Windows.Forms.Button();
            this.btnloanscheduleadd = new System.Windows.Forms.Button();
            this.noofinstallment = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loanamount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbloanschedulestatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnloanfinder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtloanno = new System.Windows.Forms.TextBox();
            this.btnloancategoryfinder = new System.Windows.Forms.Button();
            this.btnloannew = new System.Windows.Forms.Button();
            this.txtloancategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtloantypedescription = new System.Windows.Forms.TextBox();
            this.btnloantype = new System.Windows.Forms.Button();
            this.txtloantype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemployeename = new System.Windows.Forms.TextBox();
            this.btnemployeefinder = new System.Windows.Forms.Button();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLoanSchedule = new System.Windows.Forms.ListView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestrate)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noofinstallment)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanamount)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLoanSchedule);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(261, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 213);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Schedule";
            // 
            // loanissuedate
            // 
            this.loanissuedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.loanissuedate.Location = new System.Drawing.Point(130, 124);
            this.loanissuedate.Name = "loanissuedate";
            this.loanissuedate.Size = new System.Drawing.Size(109, 23);
            this.loanissuedate.TabIndex = 21;
            this.loanissuedate.Value = new System.DateTime(2017, 1, 9, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Loan Issue Date";
            // 
            // btnloancalculate
            // 
            this.btnloancalculate.Location = new System.Drawing.Point(157, 166);
            this.btnloancalculate.Name = "btnloancalculate";
            this.btnloancalculate.Size = new System.Drawing.Size(80, 30);
            this.btnloancalculate.TabIndex = 16;
            this.btnloancalculate.Text = "&Calculate";
            this.btnloancalculate.UseVisualStyleBackColor = true;
            // 
            // installmentstartdate
            // 
            this.installmentstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.installmentstartdate.Location = new System.Drawing.Point(130, 98);
            this.installmentstartdate.Name = "installmentstartdate";
            this.installmentstartdate.Size = new System.Drawing.Size(109, 23);
            this.installmentstartdate.TabIndex = 19;
            this.installmentstartdate.Value = new System.DateTime(2017, 1, 9, 0, 0, 0, 0);
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthdate.Location = new System.Drawing.Point(6, 103);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(103, 16);
            this.lblbirthdate.TabIndex = 20;
            this.lblbirthdate.Text = "Installment Start";
            // 
            // interestrate
            // 
            this.interestrate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestrate.Location = new System.Drawing.Point(130, 72);
            this.interestrate.Name = "interestrate";
            this.interestrate.Size = new System.Drawing.Size(107, 23);
            this.interestrate.TabIndex = 16;
            this.interestrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Interest Rate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncreateadvance);
            this.groupBox3.Controls.Add(this.btnloanscheduleprint);
            this.groupBox3.Controls.Add(this.btnloanscheduleclose);
            this.groupBox3.Controls.Add(this.btnloanscheduleedit);
            this.groupBox3.Controls.Add(this.btnloanscheduleadd);
            this.groupBox3.Location = new System.Drawing.Point(12, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 67);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // btncreateadvance
            // 
            this.btncreateadvance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateadvance.Location = new System.Drawing.Point(177, 22);
            this.btncreateadvance.Name = "btncreateadvance";
            this.btncreateadvance.Size = new System.Drawing.Size(80, 30);
            this.btncreateadvance.TabIndex = 4;
            this.btncreateadvance.Text = "Advance";
            this.btncreateadvance.UseVisualStyleBackColor = true;
            // 
            // btnloanscheduleprint
            // 
            this.btnloanscheduleprint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloanscheduleprint.Location = new System.Drawing.Point(323, 22);
            this.btnloanscheduleprint.Name = "btnloanscheduleprint";
            this.btnloanscheduleprint.Size = new System.Drawing.Size(80, 30);
            this.btnloanscheduleprint.TabIndex = 3;
            this.btnloanscheduleprint.Text = "Print";
            this.btnloanscheduleprint.UseVisualStyleBackColor = true;
            // 
            // btnloanscheduleclose
            // 
            this.btnloanscheduleclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnloanscheduleclose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloanscheduleclose.Location = new System.Drawing.Point(743, 22);
            this.btnloanscheduleclose.Name = "btnloanscheduleclose";
            this.btnloanscheduleclose.Size = new System.Drawing.Size(80, 30);
            this.btnloanscheduleclose.TabIndex = 2;
            this.btnloanscheduleclose.Text = "Close";
            this.btnloanscheduleclose.UseVisualStyleBackColor = true;
            // 
            // btnloanscheduleedit
            // 
            this.btnloanscheduleedit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloanscheduleedit.Location = new System.Drawing.Point(91, 22);
            this.btnloanscheduleedit.Name = "btnloanscheduleedit";
            this.btnloanscheduleedit.Size = new System.Drawing.Size(80, 30);
            this.btnloanscheduleedit.TabIndex = 1;
            this.btnloanscheduleedit.Text = "Edit";
            this.btnloanscheduleedit.UseVisualStyleBackColor = true;
            // 
            // btnloanscheduleadd
            // 
            this.btnloanscheduleadd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloanscheduleadd.Location = new System.Drawing.Point(9, 22);
            this.btnloanscheduleadd.Name = "btnloanscheduleadd";
            this.btnloanscheduleadd.Size = new System.Drawing.Size(80, 30);
            this.btnloanscheduleadd.TabIndex = 0;
            this.btnloanscheduleadd.Text = "Add";
            this.btnloanscheduleadd.UseVisualStyleBackColor = true;
            // 
            // noofinstallment
            // 
            this.noofinstallment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofinstallment.Location = new System.Drawing.Point(130, 47);
            this.noofinstallment.Name = "noofinstallment";
            this.noofinstallment.Size = new System.Drawing.Size(107, 23);
            this.noofinstallment.TabIndex = 14;
            this.noofinstallment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loanissuedate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnloancalculate);
            this.groupBox1.Controls.Add(this.installmentstartdate);
            this.groupBox1.Controls.Add(this.lblbirthdate);
            this.groupBox1.Controls.Add(this.interestrate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.noofinstallment);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.loanamount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 213);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Detail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "No. of Installment";
            // 
            // loanamount
            // 
            this.loanamount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanamount.Location = new System.Drawing.Point(130, 22);
            this.loanamount.Name = "loanamount";
            this.loanamount.Size = new System.Drawing.Size(107, 23);
            this.loanamount.TabIndex = 12;
            this.loanamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loan Amount";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbloanschedulestatus);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnloanfinder);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtloanno);
            this.groupBox4.Controls.Add(this.btnloancategoryfinder);
            this.groupBox4.Controls.Add(this.btnloannew);
            this.groupBox4.Controls.Add(this.txtloancategory);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtloantypedescription);
            this.groupBox4.Controls.Add(this.btnloantype);
            this.groupBox4.Controls.Add(this.txtloantype);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtemployeename);
            this.groupBox4.Controls.Add(this.btnemployeefinder);
            this.groupBox4.Controls.Add(this.txtemployeeid);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(13, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(829, 113);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            // 
            // cmbloanschedulestatus
            // 
            this.cmbloanschedulestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloanschedulestatus.FormattingEnabled = true;
            this.cmbloanschedulestatus.Items.AddRange(new object[] {
            "Open",
            "Started",
            "Early Settled"});
            this.cmbloanschedulestatus.Location = new System.Drawing.Point(512, 72);
            this.cmbloanschedulestatus.Name = "cmbloanschedulestatus";
            this.cmbloanschedulestatus.Size = new System.Drawing.Size(110, 24);
            this.cmbloanschedulestatus.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Status";
            // 
            // btnloanfinder
            // 
            this.btnloanfinder.Image = global::HRMS.Properties.Resources.finder;
            this.btnloanfinder.Location = new System.Drawing.Point(414, 70);
            this.btnloanfinder.Name = "btnloanfinder";
            this.btnloanfinder.Size = new System.Drawing.Size(30, 23);
            this.btnloanfinder.TabIndex = 50;
            this.btnloanfinder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Loan No.";
            // 
            // txtloanno
            // 
            this.txtloanno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloanno.Location = new System.Drawing.Point(291, 70);
            this.txtloanno.Name = "txtloanno";
            this.txtloanno.Size = new System.Drawing.Size(89, 23);
            this.txtloanno.TabIndex = 48;
            // 
            // btnloancategoryfinder
            // 
            this.btnloancategoryfinder.Image = global::HRMS.Properties.Resources.finder;
            this.btnloancategoryfinder.Location = new System.Drawing.Point(191, 68);
            this.btnloancategoryfinder.Name = "btnloancategoryfinder";
            this.btnloancategoryfinder.Size = new System.Drawing.Size(30, 23);
            this.btnloancategoryfinder.TabIndex = 57;
            this.btnloancategoryfinder.UseVisualStyleBackColor = true;
            // 
            // btnloannew
            // 
            this.btnloannew.Image = global::HRMS.Properties.Resources.New;
            this.btnloannew.Location = new System.Drawing.Point(382, 70);
            this.btnloannew.Name = "btnloannew";
            this.btnloannew.Size = new System.Drawing.Size(30, 23);
            this.btnloannew.TabIndex = 49;
            this.btnloannew.UseVisualStyleBackColor = true;
            // 
            // txtloancategory
            // 
            this.txtloancategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloancategory.Location = new System.Drawing.Point(96, 68);
            this.txtloancategory.Name = "txtloancategory";
            this.txtloancategory.Size = new System.Drawing.Size(89, 23);
            this.txtloancategory.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Category";
            // 
            // txtloantypedescription
            // 
            this.txtloantypedescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloantypedescription.Location = new System.Drawing.Point(227, 43);
            this.txtloantypedescription.Name = "txtloantypedescription";
            this.txtloantypedescription.Size = new System.Drawing.Size(395, 23);
            this.txtloantypedescription.TabIndex = 54;
            // 
            // btnloantype
            // 
            this.btnloantype.Image = global::HRMS.Properties.Resources.finder;
            this.btnloantype.Location = new System.Drawing.Point(191, 41);
            this.btnloantype.Name = "btnloantype";
            this.btnloantype.Size = new System.Drawing.Size(30, 23);
            this.btnloantype.TabIndex = 53;
            this.btnloantype.UseVisualStyleBackColor = true;
            // 
            // txtloantype
            // 
            this.txtloantype.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloantype.Location = new System.Drawing.Point(96, 43);
            this.txtloantype.Name = "txtloantype";
            this.txtloantype.Size = new System.Drawing.Size(89, 23);
            this.txtloantype.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Loan Type";
            // 
            // txtemployeename
            // 
            this.txtemployeename.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeename.Location = new System.Drawing.Point(227, 18);
            this.txtemployeename.Name = "txtemployeename";
            this.txtemployeename.Size = new System.Drawing.Size(395, 23);
            this.txtemployeename.TabIndex = 46;
            // 
            // btnemployeefinder
            // 
            this.btnemployeefinder.Image = global::HRMS.Properties.Resources.finder;
            this.btnemployeefinder.Location = new System.Drawing.Point(191, 16);
            this.btnemployeefinder.Name = "btnemployeefinder";
            this.btnemployeefinder.Size = new System.Drawing.Size(30, 23);
            this.btnemployeefinder.TabIndex = 45;
            this.btnemployeefinder.UseVisualStyleBackColor = true;
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeid.Location = new System.Drawing.Point(96, 18);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.Size = new System.Drawing.Size(89, 23);
            this.txtemployeeid.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Employee ID";
            // 
            // lstLoanSchedule
            // 
            this.lstLoanSchedule.Location = new System.Drawing.Point(6, 22);
            this.lstLoanSchedule.Name = "lstLoanSchedule";
            this.lstLoanSchedule.Size = new System.Drawing.Size(568, 174);
            this.lstLoanSchedule.TabIndex = 1;
            this.lstLoanSchedule.UseCompatibleStateImageBehavior = false;
            // 
            // frmLoanSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 418);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLoanSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Schedule";
            this.Load += new System.EventHandler(this.frmLoanSchedule_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.interestrate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noofinstallment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanamount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker loanissuedate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnloancalculate;
        private System.Windows.Forms.DateTimePicker installmentstartdate;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.NumericUpDown interestrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncreateadvance;
        private System.Windows.Forms.Button btnloanscheduleprint;
        private System.Windows.Forms.Button btnloanscheduleclose;
        private System.Windows.Forms.Button btnloanscheduleedit;
        private System.Windows.Forms.Button btnloanscheduleadd;
        private System.Windows.Forms.NumericUpDown noofinstallment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown loanamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstLoanSchedule;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbloanschedulestatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnloanfinder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtloanno;
        private System.Windows.Forms.Button btnloancategoryfinder;
        private System.Windows.Forms.Button btnloannew;
        private System.Windows.Forms.TextBox txtloancategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtloantypedescription;
        private System.Windows.Forms.Button btnloantype;
        private System.Windows.Forms.TextBox txtloantype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemployeename;
        private System.Windows.Forms.Button btnemployeefinder;
        private System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.Label label1;
    }
}