namespace EIIP.Delivery
{
    partial class fDeliverStoreReport
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
            this.lblDelivery = new System.Windows.Forms.Label();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDelivery);
            this.panel1.Controls.Add(this.lblDelivery);
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.chkDateTo);
            this.panel1.Controls.Add(this.dtpDateFrom);
            this.panel1.Controls.Add(this.chkDateFrom);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.lblDelivery, 0);
            this.panel1.Controls.SetChildIndex(this.txtDelivery, 0);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridView1
            // 
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(296, 16);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(121, 21);
            this.dtpDateTo.TabIndex = 16;
            // 
            // chkDateTo
            // 
            this.chkDateTo.AutoSize = true;
            this.chkDateTo.Location = new System.Drawing.Point(229, 19);
            this.chkDateTo.Name = "chkDateTo";
            this.chkDateTo.Size = new System.Drawing.Size(60, 16);
            this.chkDateTo.TabIndex = 15;
            this.chkDateTo.Text = "日期到";
            this.chkDateTo.UseVisualStyleBackColor = true;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(87, 16);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(121, 21);
            this.dtpDateFrom.TabIndex = 14;
            // 
            // chkDateFrom
            // 
            this.chkDateFrom.AutoSize = true;
            this.chkDateFrom.Location = new System.Drawing.Point(20, 20);
            this.chkDateFrom.Name = "chkDateFrom";
            this.chkDateFrom.Size = new System.Drawing.Size(60, 16);
            this.chkDateFrom.TabIndex = 13;
            this.chkDateFrom.Text = "日期从";
            this.chkDateFrom.UseVisualStyleBackColor = true;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(440, 22);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(41, 12);
            this.lblDelivery.TabIndex = 17;
            this.lblDelivery.Text = "路线：";
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(487, 14);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(164, 21);
            this.txtDelivery.TabIndex = 18;
            // 
            // fDeliverStoreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 379);
            this.Name = "fDeliverStoreReport";
            this.Text = "整货理货单查询";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.CheckBox chkDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.CheckBox chkDateFrom;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.Label lblDelivery;
    }
}