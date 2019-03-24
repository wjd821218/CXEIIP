namespace EIIP.Basic
{
    partial class frmSelCust
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
            this.gColCustId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Size = new System.Drawing.Size(800, 277);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gColCustId,
            this.gColCustName});
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 277);
            this.panel1.Size = new System.Drawing.Size(800, 40);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(703, 8);
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(609, 8);
            this.btnSure.Size = new System.Drawing.Size(75, 22);
            // 
            // gColCustId
            // 
            this.gColCustId.Caption = "客户编码";
            this.gColCustId.FieldName = "CUSTID";
            this.gColCustId.Name = "gColCustId";
            this.gColCustId.OptionsColumn.AllowEdit = false;
            this.gColCustId.OptionsColumn.AllowFocus = false;
            this.gColCustId.Visible = true;
            this.gColCustId.VisibleIndex = 0;
            // 
            // gColCustName
            // 
            this.gColCustName.Caption = "客户名称";
            this.gColCustName.FieldName = "CUSTNAME";
            this.gColCustName.Name = "gColCustName";
            this.gColCustName.OptionsColumn.AllowEdit = false;
            this.gColCustName.OptionsColumn.AllowFocus = false;
            this.gColCustName.Visible = true;
            this.gColCustName.VisibleIndex = 1;
            this.gColCustName.Width = 240;
            // 
            // frmSelCust
            // 
            this.AcceptButton = this.btnSure;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 317);
            this.Name = "frmSelCust";
            this.Text = "选择往来单位";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gColCustId;
        private DevExpress.XtraGrid.Columns.GridColumn gColCustName;
    }
}