namespace EIIP.Basic
{
    partial class frmSelArt
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
            this.gColArtId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColArtName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColFactory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Size = new System.Drawing.Size(800, 366);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gColArtId,
            this.gColArtName,
            this.gColSpec,
            this.gColFactory,
            this.gColUnit});
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Size = new System.Drawing.Size(800, 39);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(614, 8);
            this.btnCancel.Size = new System.Drawing.Size(75, 60);
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(520, 8);
            this.btnSure.Size = new System.Drawing.Size(75, 60);
            // 
            // gColArtId
            // 
            this.gColArtId.Caption = "编码";
            this.gColArtId.FieldName = "ARTID";
            this.gColArtId.Name = "gColArtId";
            this.gColArtId.OptionsColumn.AllowEdit = false;
            this.gColArtId.OptionsColumn.AllowFocus = false;
            this.gColArtId.Visible = true;
            this.gColArtId.VisibleIndex = 0;
            // 
            // gColArtName
            // 
            this.gColArtName.Caption = "品名";
            this.gColArtName.FieldName = "NAME";
            this.gColArtName.Name = "gColArtName";
            this.gColArtName.OptionsColumn.AllowEdit = false;
            this.gColArtName.OptionsColumn.AllowFocus = false;
            this.gColArtName.Visible = true;
            this.gColArtName.VisibleIndex = 1;
            // 
            // gColSpec
            // 
            this.gColSpec.Caption = "规格";
            this.gColSpec.FieldName = "SPEC";
            this.gColSpec.Name = "gColSpec";
            this.gColSpec.OptionsColumn.AllowEdit = false;
            this.gColSpec.OptionsColumn.AllowFocus = false;
            this.gColSpec.Visible = true;
            this.gColSpec.VisibleIndex = 2;
            // 
            // gColFactory
            // 
            this.gColFactory.Caption = "产地";
            this.gColFactory.FieldName = "FACTORY";
            this.gColFactory.Name = "gColFactory";
            this.gColFactory.OptionsColumn.AllowEdit = false;
            this.gColFactory.OptionsColumn.AllowFocus = false;
            this.gColFactory.Visible = true;
            this.gColFactory.VisibleIndex = 3;
            // 
            // gColUnit
            // 
            this.gColUnit.Caption = "单位";
            this.gColUnit.FieldName = "UNIT";
            this.gColUnit.Name = "gColUnit";
            this.gColUnit.OptionsColumn.AllowEdit = false;
            this.gColUnit.OptionsColumn.AllowFocus = false;
            this.gColUnit.Visible = true;
            this.gColUnit.VisibleIndex = 4;
            // 
            // frmSelArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Name = "frmSelArt";
            this.Text = "frmSelArt";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gColArtId;
        private DevExpress.XtraGrid.Columns.GridColumn gColArtName;
        private DevExpress.XtraGrid.Columns.GridColumn gColSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gColFactory;
        private DevExpress.XtraGrid.Columns.GridColumn gColUnit;
    }
}