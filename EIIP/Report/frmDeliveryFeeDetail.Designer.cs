namespace EIIP.Report
{
    partial class frmDeliveryFeeDetail
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
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.dtpDateFrom);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateTo, 0);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridView1
            // 
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(46, 14);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(200, 21);
            this.dtpDateFrom.TabIndex = 1;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(378, 14);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(200, 21);
            this.dtpDateTo.TabIndex = 2;
            // 
            // frmDeliveryFeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 379);
            this.Name = "frmDeliveryFeeDetail";
            this.Text = "配送明细";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
    }
}