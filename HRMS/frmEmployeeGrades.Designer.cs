﻿namespace HRMS
{
    partial class frmEmployeeGrades
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGradeGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpGrdName = new System.Windows.Forms.TextBox();
            this.txtEmpGrdID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(16, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 59);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnClose.Location = new System.Drawing.Point(356, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(6, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGradeGroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmpGrdName);
            this.groupBox1.Controls.Add(this.txtEmpGrdID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cmbGradeGroup
            // 
            this.cmbGradeGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeGroup.FormattingEnabled = true;
            this.cmbGradeGroup.Location = new System.Drawing.Point(131, 81);
            this.cmbGradeGroup.Name = "cmbGradeGroup";
            this.cmbGradeGroup.Size = new System.Drawing.Size(297, 24);
            this.cmbGradeGroup.TabIndex = 3;          
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grade Group";
            // 
            // txtEmpGrdName
            // 
            this.txtEmpGrdName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtEmpGrdName.Location = new System.Drawing.Point(131, 51);
            this.txtEmpGrdName.MaxLength = 50;
            this.txtEmpGrdName.Name = "txtEmpGrdName";
            this.txtEmpGrdName.Size = new System.Drawing.Size(297, 23);
            this.txtEmpGrdName.TabIndex = 2;
            // 
            // txtEmpGrdID
            // 
            this.txtEmpGrdID.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtEmpGrdID.Location = new System.Drawing.Point(131, 22);
            this.txtEmpGrdID.MaxLength = 4;
            this.txtEmpGrdID.Name = "txtEmpGrdID";
            this.txtEmpGrdID.Size = new System.Drawing.Size(100, 23);
            this.txtEmpGrdID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grade Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grade ID";
            // 
            // frmEmployeeGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 217);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Grade Setup";
            this.Load += new System.EventHandler(this.frmEmployeeGrades_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpGrdName;
        private System.Windows.Forms.TextBox txtEmpGrdID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbGradeGroup;
    }
}