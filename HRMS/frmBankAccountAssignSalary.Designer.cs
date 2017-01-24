namespace HRMS
{
    partial class frmBankAccountAssignSalary
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
            this.bankeffectivedate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsalarybankaccountno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbranchfinder = new System.Windows.Forms.Button();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbank = new System.Windows.Forms.ComboBox();
            this.btnsalarybankedit = new System.Windows.Forms.Button();
            this.btnsalarybankadd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBankAccount = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemployeename = new System.Windows.Forms.TextBox();
            this.txtemployeeno = new System.Windows.Forms.TextBox();
            this.btnemployeefinder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bankeffectivedate
            // 
            this.bankeffectivedate.CustomFormat = "dd-MMM-yyyy";
            this.bankeffectivedate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankeffectivedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bankeffectivedate.Location = new System.Drawing.Point(110, 150);
            this.bankeffectivedate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bankeffectivedate.Name = "bankeffectivedate";
            this.bankeffectivedate.Size = new System.Drawing.Size(154, 23);
            this.bankeffectivedate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Effective Date";
            // 
            // txtsalarybankaccountno
            // 
            this.txtsalarybankaccountno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalarybankaccountno.Location = new System.Drawing.Point(110, 118);
            this.txtsalarybankaccountno.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtsalarybankaccountno.Name = "txtsalarybankaccountno";
            this.txtsalarybankaccountno.Size = new System.Drawing.Size(154, 23);
            this.txtsalarybankaccountno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Account No";
            // 
            // btnbranchfinder
            // 
            this.btnbranchfinder.Image = global::HRMS.Properties.Resources.finder;
            this.btnbranchfinder.Location = new System.Drawing.Point(235, 87);
            this.btnbranchfinder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnbranchfinder.Name = "btnbranchfinder";
            this.btnbranchfinder.Size = new System.Drawing.Size(29, 23);
            this.btnbranchfinder.TabIndex = 2;
            this.btnbranchfinder.UseVisualStyleBackColor = true;
            // 
            // txtbranch
            // 
            this.txtbranch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbranch.Location = new System.Drawing.Point(110, 86);
            this.txtbranch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(119, 23);
            this.txtbranch.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Branch";
            // 
            // cmbbank
            // 
            this.cmbbank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbank.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbank.FormattingEnabled = true;
            this.cmbbank.Items.AddRange(new object[] {
            "Monthly",
            "Once Off"});
            this.cmbbank.Location = new System.Drawing.Point(110, 53);
            this.cmbbank.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbbank.Name = "cmbbank";
            this.cmbbank.Size = new System.Drawing.Size(154, 24);
            this.cmbbank.TabIndex = 1;
            // 
            // btnsalarybankedit
            // 
            this.btnsalarybankedit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalarybankedit.Location = new System.Drawing.Point(187, 192);
            this.btnsalarybankedit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnsalarybankedit.Name = "btnsalarybankedit";
            this.btnsalarybankedit.Size = new System.Drawing.Size(80, 30);
            this.btnsalarybankedit.TabIndex = 6;
            this.btnsalarybankedit.Text = "Delete";
            this.btnsalarybankedit.UseVisualStyleBackColor = true;
            // 
            // btnsalarybankadd
            // 
            this.btnsalarybankadd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalarybankadd.Location = new System.Drawing.Point(101, 192);
            this.btnsalarybankadd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnsalarybankadd.Name = "btnsalarybankadd";
            this.btnsalarybankadd.Size = new System.Drawing.Size(80, 30);
            this.btnsalarybankadd.TabIndex = 5;
            this.btnsalarybankadd.Text = "Save";
            this.btnsalarybankadd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBankAccount);
            this.groupBox1.Controls.Add(this.cmbbank);
            this.groupBox1.Controls.Add(this.btnsalarybankedit);
            this.groupBox1.Controls.Add(this.btnsalarybankadd);
            this.groupBox1.Controls.Add(this.bankeffectivedate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsalarybankaccountno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnbranchfinder);
            this.groupBox1.Controls.Add(this.txtbranch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtemployeename);
            this.groupBox1.Controls.Add(this.txtemployeeno);
            this.groupBox1.Controls.Add(this.btnemployeefinder);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(805, 231);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Bank Account";
            // 
            // lstBankAccount
            // 
            this.lstBankAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBankAccount.Location = new System.Drawing.Point(273, 53);
            this.lstBankAccount.Name = "lstBankAccount";
            this.lstBankAccount.Size = new System.Drawing.Size(514, 169);
            this.lstBankAccount.TabIndex = 32;
            this.lstBankAccount.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee";
            // 
            // txtemployeename
            // 
            this.txtemployeename.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeename.Location = new System.Drawing.Point(272, 20);
            this.txtemployeename.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtemployeename.Name = "txtemployeename";
            this.txtemployeename.Size = new System.Drawing.Size(515, 23);
            this.txtemployeename.TabIndex = 19;
            // 
            // txtemployeeno
            // 
            this.txtemployeeno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeno.Location = new System.Drawing.Point(110, 20);
            this.txtemployeeno.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtemployeeno.Name = "txtemployeeno";
            this.txtemployeeno.Size = new System.Drawing.Size(119, 23);
            this.txtemployeeno.TabIndex = 17;
            // 
            // btnemployeefinder
            // 
            this.btnemployeefinder.Image = global::HRMS.Properties.Resources.finder;
            this.btnemployeefinder.Location = new System.Drawing.Point(235, 20);
            this.btnemployeefinder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnemployeefinder.Name = "btnemployeefinder";
            this.btnemployeefinder.Size = new System.Drawing.Size(29, 23);
            this.btnemployeefinder.TabIndex = 0;
            this.btnemployeefinder.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(14, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 59);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnClose.Location = new System.Drawing.Point(708, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmBankAccountAssignSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBankAccountAssignSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Bank Account - Salary";
            this.Load += new System.EventHandler(this.frmBankAccountAssignSalary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker bankeffectivedate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsalarybankaccountno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnbranchfinder;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbank;
        private System.Windows.Forms.Button btnsalarybankedit;
        private System.Windows.Forms.Button btnsalarybankadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstBankAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemployeename;
        private System.Windows.Forms.TextBox txtemployeeno;
        private System.Windows.Forms.Button btnemployeefinder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
    }
}