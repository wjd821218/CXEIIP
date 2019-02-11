namespace EIIP.BasicLibrary
{
    partial class frmDept
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
            this.gColDeptId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColTerminated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColCanceled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CentrePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gColDeptId,
            this.gColDeptName,
            this.gColTerminated,
            this.gColCanceled,
            this.gColNote});
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gColDeptId
            // 
            this.gColDeptId.Caption = "部门编码";
            this.gColDeptId.FieldName = "DEPTID";
            this.gColDeptId.Name = "gColDeptId";
            this.gColDeptId.OptionsColumn.AllowEdit = false;
            this.gColDeptId.OptionsColumn.ReadOnly = true;
            this.gColDeptId.Visible = true;
            this.gColDeptId.VisibleIndex = 0;
            // 
            // gColDeptName
            // 
            this.gColDeptName.Caption = "部门名称";
            this.gColDeptName.FieldName = "DEPTNAME";
            this.gColDeptName.Name = "gColDeptName";
            this.gColDeptName.OptionsColumn.AllowEdit = false;
            this.gColDeptName.OptionsColumn.ReadOnly = true;
            this.gColDeptName.Visible = true;
            this.gColDeptName.VisibleIndex = 1;
            // 
            // gColTerminated
            // 
            this.gColTerminated.Caption = "gridColumn3";
            this.gColTerminated.Name = "gColTerminated";
            this.gColTerminated.OptionsColumn.AllowEdit = false;
            this.gColTerminated.OptionsColumn.ReadOnly = true;
            // 
            // gColCanceled
            // 
            this.gColCanceled.Caption = "作废标记";
            this.gColCanceled.FieldName = "CANCELED";
            this.gColCanceled.Name = "gColCanceled";
            this.gColCanceled.OptionsColumn.AllowEdit = false;
            this.gColCanceled.OptionsColumn.ReadOnly = true;
            this.gColCanceled.Visible = true;
            this.gColCanceled.VisibleIndex = 2;
            // 
            // gColNote
            // 
            this.gColNote.Caption = "备注";
            this.gColNote.FieldName = "NOTES";
            this.gColNote.Name = "gColNote";
            this.gColNote.OptionsColumn.AllowEdit = false;
            this.gColNote.OptionsColumn.ReadOnly = true;
            this.gColNote.Visible = true;
            this.gColNote.VisibleIndex = 3;
            // 
            // frmDept
            // 
            this.AcceptButton = this.btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 352);
            this.Name = "frmDept";
            this.Text = "部门信息";
            this.CentrePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gColDeptId;
        private DevExpress.XtraGrid.Columns.GridColumn gColDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn gColTerminated;
        private DevExpress.XtraGrid.Columns.GridColumn gColCanceled;
        private DevExpress.XtraGrid.Columns.GridColumn gColNote;
    }
}