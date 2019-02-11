namespace EIIP.BasicLibrary
{
    partial class frmTaxArt
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
            this.gColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColFactory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColTaxItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFactory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.CentrePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(760, 25);
            // 
            // CentrePanel
            // 
            this.CentrePanel.Controls.Add(this.txtFactory);
            this.CentrePanel.Controls.Add(this.label2);
            this.CentrePanel.Controls.Add(this.txtSpec);
            this.CentrePanel.Controls.Add(this.label1);
            this.CentrePanel.Controls.Add(this.txtName);
            this.CentrePanel.Controls.Add(this.lblName);
            this.CentrePanel.Size = new System.Drawing.Size(760, 41);
            this.CentrePanel.Controls.SetChildIndex(this.lblName, 0);
            this.CentrePanel.Controls.SetChildIndex(this.txtName, 0);
            this.CentrePanel.Controls.SetChildIndex(this.label1, 0);
            this.CentrePanel.Controls.SetChildIndex(this.txtSpec, 0);
            this.CentrePanel.Controls.SetChildIndex(this.label2, 0);
            this.CentrePanel.Controls.SetChildIndex(this.txtFactory, 0);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(0, 66);
            this.gridControl1.Size = new System.Drawing.Size(760, 239);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gColArtId,
            this.gColName,
            this.gColSpec,
            this.gColFactory,
            this.gColTaxItem});
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gColArtId
            // 
            this.gColArtId.Caption = "药品编码";
            this.gColArtId.FieldName = "ARTID";
            this.gColArtId.Name = "gColArtId";
            this.gColArtId.OptionsColumn.AllowEdit = false;
            this.gColArtId.Visible = true;
            this.gColArtId.VisibleIndex = 0;
            // 
            // gColName
            // 
            this.gColName.Caption = "名称";
            this.gColName.FieldName = "NAME";
            this.gColName.Name = "gColName";
            this.gColName.OptionsColumn.AllowEdit = false;
            this.gColName.Visible = true;
            this.gColName.VisibleIndex = 1;
            // 
            // gColSpec
            // 
            this.gColSpec.Caption = "规格";
            this.gColSpec.FieldName = "SPEC";
            this.gColSpec.Name = "gColSpec";
            this.gColSpec.OptionsColumn.AllowEdit = false;
            this.gColSpec.Visible = true;
            this.gColSpec.VisibleIndex = 2;
            // 
            // gColFactory
            // 
            this.gColFactory.Caption = "产地";
            this.gColFactory.FieldName = "FACTORY";
            this.gColFactory.Name = "gColFactory";
            this.gColFactory.OptionsColumn.AllowEdit = false;
            this.gColFactory.Visible = true;
            this.gColFactory.VisibleIndex = 3;
            // 
            // gColTaxItem
            // 
            this.gColTaxItem.Caption = "分类编码";
            this.gColTaxItem.FieldName = "TAXITEM";
            this.gColTaxItem.Name = "gColTaxItem";
            this.gColTaxItem.Visible = true;
            this.gColTaxItem.VisibleIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名称:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 21);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "规格";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(234, 9);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(100, 21);
            this.txtSpec.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "产地";
            // 
            // txtFactory
            // 
            this.txtFactory.Location = new System.Drawing.Point(402, 9);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(143, 21);
            this.txtFactory.TabIndex = 5;
            // 
            // frmTaxArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 305);
            this.Name = "frmTaxArt";
            this.Text = "金税系统商品目录";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.CentrePanel.ResumeLayout(false);
            this.CentrePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraGrid.Columns.GridColumn gColArtId;
        private DevExpress.XtraGrid.Columns.GridColumn gColName;
        private DevExpress.XtraGrid.Columns.GridColumn gColSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gColFactory;
        private DevExpress.XtraGrid.Columns.GridColumn gColTaxItem;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;

        #endregion

        // private Oracle.DataAccess.Client.OracleDataAdapter sda;
    }
}