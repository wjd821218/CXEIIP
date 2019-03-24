namespace EIIP.Basic
{
    partial class frmSelDept
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Size = new System.Drawing.Size(632, 261);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gColDeptId,
            this.gColDeptName});
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Size = new System.Drawing.Size(632, 49);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(275, 8);
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(181, 8);
            this.btnSure.Size = new System.Drawing.Size(75, 31);
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // gColDeptId
            // 
            this.gColDeptId.Caption = "部门编码";
            this.gColDeptId.FieldName = "DEPTID";
            this.gColDeptId.Name = "gColDeptId";
            this.gColDeptId.OptionsColumn.AllowEdit = false;
            this.gColDeptId.OptionsColumn.AllowFocus = false;
            this.gColDeptId.Visible = true;
            this.gColDeptId.VisibleIndex = 0;
            // 
            // gColDeptName
            // 
            this.gColDeptName.Caption = "部门名称";
            this.gColDeptName.FieldName = "DEPTNAME";
            this.gColDeptName.Name = "gColDeptName";
            this.gColDeptName.OptionsColumn.AllowEdit = false;
            this.gColDeptName.OptionsColumn.AllowFocus = false;
            this.gColDeptName.Visible = true;
            this.gColDeptName.VisibleIndex = 1;
            this.gColDeptName.Width = 264;
            // 
            // frmSelDept
            // 
            this.AcceptButton = this.btnSure;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(632, 310);
            this.Name = "frmSelDept";
            this.Text = "可管理部门";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gColDeptId;
        private DevExpress.XtraGrid.Columns.GridColumn gColDeptName;
    }
}