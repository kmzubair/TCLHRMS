namespace HRMS
{
    partial class frmBonusParameter
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstGrade = new System.Windows.Forms.ListView();
            this.noofdisbursement = new System.Windows.Forms.NumericUpDown();
            this.noofbasic = new System.Windows.Forms.NumericUpDown();
            this.bonusfixedamount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbbonusname = new System.Windows.Forms.ComboBox();
            this.chbtaxprojection = new System.Windows.Forms.CheckBox();
            this.chbonlyforconfirmemployee = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noofdisbursement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noofbasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusfixedamount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstGrade);
            this.groupBox3.Location = new System.Drawing.Point(358, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 233);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Applicable Grade";
            // 
            // lstGrade
            // 
            this.lstGrade.Location = new System.Drawing.Point(7, 18);
            this.lstGrade.Name = "lstGrade";
            this.lstGrade.Size = new System.Drawing.Size(250, 204);
            this.lstGrade.TabIndex = 1;
            this.lstGrade.UseCompatibleStateImageBehavior = false;
            // 
            // noofdisbursement
            // 
            this.noofdisbursement.Location = new System.Drawing.Point(213, 74);
            this.noofdisbursement.Name = "noofdisbursement";
            this.noofdisbursement.Size = new System.Drawing.Size(120, 23);
            this.noofdisbursement.TabIndex = 12;
            this.noofdisbursement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // noofbasic
            // 
            this.noofbasic.Location = new System.Drawing.Point(213, 46);
            this.noofbasic.Name = "noofbasic";
            this.noofbasic.Size = new System.Drawing.Size(120, 23);
            this.noofbasic.TabIndex = 11;
            this.noofbasic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bonusfixedamount
            // 
            this.bonusfixedamount.Location = new System.Drawing.Point(213, 19);
            this.bonusfixedamount.Name = "bonusfixedamount";
            this.bonusfixedamount.Size = new System.Drawing.Size(120, 23);
            this.bonusfixedamount.TabIndex = 10;
            this.bonusfixedamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "No. of Disbursement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "No. of Basic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fixed Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noofdisbursement);
            this.groupBox2.Controls.Add(this.noofbasic);
            this.groupBox2.Controls.Add(this.bonusfixedamount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 108);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Applied As";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cmbbonusname);
            this.groupBox1.Controls.Add(this.chbtaxprojection);
            this.groupBox1.Controls.Add(this.chbonlyforconfirmemployee);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bonus Name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(324, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Cutoff Date is needed for Service Length Calculation";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbbonusname
            // 
            this.cmbbonusname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbonusname.FormattingEnabled = true;
            this.cmbbonusname.Location = new System.Drawing.Point(91, 16);
            this.cmbbonusname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbbonusname.Name = "cmbbonusname";
            this.cmbbonusname.Size = new System.Drawing.Size(154, 24);
            this.cmbbonusname.TabIndex = 3;
            // 
            // chbtaxprojection
            // 
            this.chbtaxprojection.AutoSize = true;
            this.chbtaxprojection.Location = new System.Drawing.Point(9, 70);
            this.chbtaxprojection.Name = "chbtaxprojection";
            this.chbtaxprojection.Size = new System.Drawing.Size(218, 20);
            this.chbtaxprojection.TabIndex = 5;
            this.chbtaxprojection.Text = "Project in Income Tax Calculation";
            this.chbtaxprojection.UseVisualStyleBackColor = true;
            // 
            // chbonlyforconfirmemployee
            // 
            this.chbonlyforconfirmemployee.AutoSize = true;
            this.chbonlyforconfirmemployee.Location = new System.Drawing.Point(9, 48);
            this.chbonlyforconfirmemployee.Name = "chbonlyforconfirmemployee";
            this.chbonlyforconfirmemployee.Size = new System.Drawing.Size(180, 20);
            this.chbonlyforconfirmemployee.TabIndex = 4;
            this.chbonlyforconfirmemployee.Text = "Only for Confirm Employee";
            this.chbonlyforconfirmemployee.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupBox4.Location = new System.Drawing.Point(12, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(609, 59);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnClose.Location = new System.Drawing.Point(523, 19);
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
            // frmBonusParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 337);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBonusParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus Parameter Setup";
            this.Load += new System.EventHandler(this.frmBonusParameter_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noofdisbursement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noofbasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusfixedamount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstGrade;
        private System.Windows.Forms.NumericUpDown noofdisbursement;
        private System.Windows.Forms.NumericUpDown noofbasic;
        private System.Windows.Forms.NumericUpDown bonusfixedamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbbonusname;
        private System.Windows.Forms.CheckBox chbtaxprojection;
        private System.Windows.Forms.CheckBox chbonlyforconfirmemployee;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}