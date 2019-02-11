namespace EIIP.Report
{
    partial class frmDuesAccList
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
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.chkDateTo = new System.Windows.Forms.CheckBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.chkDateFrom = new System.Windows.Forms.CheckBox();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCust);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDeptName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.chkDateTo);
            this.panel1.Controls.Add(this.dtpDateFrom);
            this.panel1.Controls.Add(this.chkDateFrom);
            this.panel1.Size = new System.Drawing.Size(791, 59);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.txtDeptName, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.txtCust, 0);
            // 
            // button1
            // 
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Size = new System.Drawing.Size(791, 270);
            // 
            // gridView1
            // 
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(46, 7);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(203, 21);
            this.txtDeptName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "部门：";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(553, 18);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(121, 21);
            this.dtpDateTo.TabIndex = 14;
            // 
            // chkDateTo
            // 
            this.chkDateTo.AutoSize = true;
            this.chkDateTo.Location = new System.Drawing.Point(486, 21);
            this.chkDateTo.Name = "chkDateTo";
            this.chkDateTo.Size = new System.Drawing.Size(60, 16);
            this.chkDateTo.TabIndex = 13;
            this.chkDateTo.Text = "日期到";
            this.chkDateTo.UseVisualStyleBackColor = true;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(344, 18);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(121, 21);
            this.dtpDateFrom.TabIndex = 12;
            // 
            // chkDateFrom
            // 
            this.chkDateFrom.AutoSize = true;
            this.chkDateFrom.Location = new System.Drawing.Point(277, 22);
            this.chkDateFrom.Name = "chkDateFrom";
            this.chkDateFrom.Size = new System.Drawing.Size(60, 16);
            this.chkDateFrom.TabIndex = 11;
            this.chkDateFrom.Text = "日期从";
            this.chkDateFrom.UseVisualStyleBackColor = true;
            // 
            // txtCust
            // 
            this.txtCust.Location = new System.Drawing.Point(46, 32);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(203, 21);
            this.txtCust.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "供应商：";
            // 
            // frmDuesAccList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 379);
            this.Name = "frmDuesAccList";
            this.Text = "应付账款统计";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.CheckBox chkDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.CheckBox chkDateFrom;
    }
}