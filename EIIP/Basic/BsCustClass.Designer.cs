namespace EIIP.Basic
{
    partial class BsCustClass
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(709, 53);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 78);
            this.gridControl1.Size = new System.Drawing.Size(709, 161);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(634, 0);
            this.btnQuery.Size = new System.Drawing.Size(75, 53);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // BsCustClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 261);
            this.Name = "BsCustClass";
            this.Text = "BsCustClass";
            this.Load += new System.EventHandler(this.BsCustClass_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}