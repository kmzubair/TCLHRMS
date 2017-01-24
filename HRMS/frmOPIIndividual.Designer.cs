namespace HRMS
{
    partial class frmOPIIndividual
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
            this.btnopiclose = new System.Windows.Forms.Button();
            this.opimonthlyamount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.opieffectivedateto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.opieffectivedatefrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbvaluetype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtopidescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnopiremove = new System.Windows.Forms.Button();
            this.btnopedit = new System.Windows.Forms.Button();
            this.btnopiadd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstOPIAmount = new System.Windows.Forms.ListView();
            this.btnopifinder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtemployeename = new System.Windows.Forms.TextBox();
            this.btnemployeefinder = new System.Windows.Forms.Button();
            this.txtemployeeserial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opimonthlyamount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnopiclose
            // 
            this.btnopiclose.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnopiclose.Location = new System.Drawing.Point(544, 22);
            this.btnopiclose.Name = "btnopiclose";
            this.btnopiclose.Size = new System.Drawing.Size(80, 30);
            this.btnopiclose.TabIndex = 0;
            this.btnopiclose.Text = "Close";
            this.btnopiclose.UseVisualStyleBackColor = true;
            // 
            // opimonthlyamount
            // 
            this.opimonthlyamount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opimonthlyamount.Location = new System.Drawing.Point(544, 42);
            this.opimonthlyamount.Name = "opimonthlyamount";
            this.opimonthlyamount.Size = new System.Drawing.Size(84, 23);
            this.opimonthlyamount.TabIndex = 4;
            this.opimonthlyamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Monthly Amount";
            // 
            // opieffectivedateto
            // 
            this.opieffectivedateto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opieffectivedateto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.opieffectivedateto.Location = new System.Drawing.Point(325, 43);
            this.opieffectivedateto.Name = "opieffectivedateto";
            this.opieffectivedateto.Size = new System.Drawing.Size(88, 23);
            this.opieffectivedateto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "To";
            // 
            // opieffectivedatefrom
            // 
            this.opieffectivedatefrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opieffectivedatefrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.opieffectivedatefrom.Location = new System.Drawing.Point(128, 44);
            this.opieffectivedatefrom.Name = "opieffectivedatefrom";
            this.opieffectivedatefrom.Size = new System.Drawing.Size(92, 23);
            this.opieffectivedatefrom.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Effective From";
            // 
            // cmbvaluetype
            // 
            this.cmbvaluetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvaluetype.FormattingEnabled = true;
            this.cmbvaluetype.Items.AddRange(new object[] {
            "Flat Amount",
            "Percentage"});
            this.cmbvaluetype.Location = new System.Drawing.Point(544, 15);
            this.cmbvaluetype.Name = "cmbvaluetype";
            this.cmbvaluetype.Size = new System.Drawing.Size(84, 24);
            this.cmbvaluetype.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Value Type";
            // 
            // txtopidescription
            // 
            this.txtopidescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopidescription.Location = new System.Drawing.Point(128, 13);
            this.txtopidescription.Name = "txtopidescription";
            this.txtopidescription.Size = new System.Drawing.Size(250, 23);
            this.txtopidescription.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "OPI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnopiclose);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 64);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.button1.Location = new System.Drawing.Point(8, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnopiremove
            // 
            this.btnopiremove.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnopiremove.Location = new System.Drawing.Point(33, 248);
            this.btnopiremove.Name = "btnopiremove";
            this.btnopiremove.Size = new System.Drawing.Size(80, 30);
            this.btnopiremove.TabIndex = 2;
            this.btnopiremove.Text = "Remove";
            this.btnopiremove.UseVisualStyleBackColor = true;
            // 
            // btnopedit
            // 
            this.btnopedit.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnopedit.Location = new System.Drawing.Point(33, 55);
            this.btnopedit.Name = "btnopedit";
            this.btnopedit.Size = new System.Drawing.Size(80, 30);
            this.btnopedit.TabIndex = 1;
            this.btnopedit.Text = "Edit";
            this.btnopedit.UseVisualStyleBackColor = true;
            // 
            // btnopiadd
            // 
            this.btnopiadd.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnopiadd.Location = new System.Drawing.Point(33, 19);
            this.btnopiadd.Name = "btnopiadd";
            this.btnopiadd.Size = new System.Drawing.Size(80, 30);
            this.btnopiadd.TabIndex = 0;
            this.btnopiadd.Text = "Add";
            this.btnopiadd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnopiremove);
            this.groupBox2.Controls.Add(this.btnopedit);
            this.groupBox2.Controls.Add(this.btnopiadd);
            this.groupBox2.Location = new System.Drawing.Point(493, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 296);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstOPIAmount);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.opimonthlyamount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.opieffectivedateto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.opieffectivedatefrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbvaluetype);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnopifinder);
            this.groupBox1.Controls.Add(this.txtopidescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 373);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // lstOPIAmount
            // 
            this.lstOPIAmount.Location = new System.Drawing.Point(9, 81);
            this.lstOPIAmount.Name = "lstOPIAmount";
            this.lstOPIAmount.Size = new System.Drawing.Size(466, 286);
            this.lstOPIAmount.TabIndex = 32;
            this.lstOPIAmount.UseCompatibleStateImageBehavior = false;
            // 
            // btnopifinder
            // 
            this.btnopifinder.Image = global::HRMS.Properties.Resources.finder;
            this.btnopifinder.Location = new System.Drawing.Point(383, 13);
            this.btnopifinder.Name = "btnopifinder";
            this.btnopifinder.Size = new System.Drawing.Size(30, 23);
            this.btnopifinder.TabIndex = 0;
            this.btnopifinder.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtemployeename);
            this.groupBox4.Controls.Add(this.btnemployeefinder);
            this.groupBox4.Controls.Add(this.txtemployeeserial);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(634, 56);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            // 
            // txtemployeename
            // 
            this.txtemployeename.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeename.Location = new System.Drawing.Point(224, 18);
            this.txtemployeename.Name = "txtemployeename";
            this.txtemployeename.Size = new System.Drawing.Size(376, 23);
            this.txtemployeename.TabIndex = 44;
            // 
            // btnemployeefinder
            // 
            this.btnemployeefinder.Image = global::HRMS.Properties.Resources.finder;
            this.btnemployeefinder.Location = new System.Drawing.Point(188, 18);
            this.btnemployeefinder.Name = "btnemployeefinder";
            this.btnemployeefinder.Size = new System.Drawing.Size(30, 23);
            this.btnemployeefinder.TabIndex = 42;
            this.btnemployeefinder.UseVisualStyleBackColor = true;
            // 
            // txtemployeeserial
            // 
            this.txtemployeeserial.Location = new System.Drawing.Point(94, 19);
            this.txtemployeeserial.Name = "txtemployeeserial";
            this.txtemployeeserial.Size = new System.Drawing.Size(92, 23);
            this.txtemployeeserial.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Employee Sl.";
            // 
            // frmOPIIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 537);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOPIIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPI - Apply to Individual";
            this.Load += new System.EventHandler(this.frmOPIIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opimonthlyamount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnopiclose;
        private System.Windows.Forms.NumericUpDown opimonthlyamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker opieffectivedateto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker opieffectivedatefrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbvaluetype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnopifinder;
        private System.Windows.Forms.TextBox txtopidescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnopiremove;
        private System.Windows.Forms.Button btnopedit;
        private System.Windows.Forms.Button btnopiadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstOPIAmount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtemployeename;
        private System.Windows.Forms.Button btnemployeefinder;
        private System.Windows.Forms.TextBox txtemployeeserial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}