namespace EIIP.Report
{
    partial class fDeptCapital
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
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.chkDateTo = new System.Windows.Forms.CheckBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.chkDateFrom = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDeptName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.chkDateTo);
            this.panel1.Controls.Add(this.dtpDateFrom);
            this.panel1.Controls.Add(this.chkDateFrom);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.txtDeptName, 0);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridView1
            // 
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(566, 16);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(121, 21);
            this.dtpDateTo.TabIndex = 8;
            // 
            // chkDateTo
            // 
            this.chkDateTo.AutoSize = true;
            this.chkDateTo.Location = new System.Drawing.Point(499, 19);
            this.chkDateTo.Name = "chkDateTo";
            this.chkDateTo.Size = new System.Drawing.Size(60, 16);
            this.chkDateTo.TabIndex = 7;
            this.chkDateTo.Text = "日期到";
            this.chkDateTo.UseVisualStyleBackColor = true;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(357, 16);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(121, 21);
            this.dtpDateFrom.TabIndex = 6;
            // 
            // chkDateFrom
            // 
            this.chkDateFrom.AutoSize = true;
            this.chkDateFrom.Location = new System.Drawing.Point(290, 20);
            this.chkDateFrom.Name = "chkDateFrom";
            this.chkDateFrom.Size = new System.Drawing.Size(60, 16);
            this.chkDateFrom.TabIndex = 5;
            this.chkDateFrom.Text = "日期从";
            this.chkDateFrom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "部门：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(51, 18);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(203, 21);
            this.txtDeptName.TabIndex = 10;
            // 
            // fDeptCapital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 379);
            this.Name = "fDeptCapital";
            this.Text = "部门资金认领明细查询";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.CheckBox chkDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.CheckBox chkDateFrom;
        private System.Windows.Forms.TextBox txtDeptName;
    }
}