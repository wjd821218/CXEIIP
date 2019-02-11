namespace EIIP.Delivery
{
    partial class fRouteSite
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
            this.components = new System.ComponentModel.Container();
            this.drid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stopid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stopname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.validated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordernum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tv = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(745, 48);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(153, 73);
            this.gridControl1.Size = new System.Drawing.Size(592, 249);
            // 
            // btnQuery
            // 
            this.btnQuery.Size = new System.Drawing.Size(75, 48);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.drid,
            this.stopid,
            this.stopname,
            this.validated,
            this.ordernum,
            this.notes});
            // 
            // drid
            // 
            this.drid.Caption = "路线ID";
            this.drid.FieldName = "drid";
            this.drid.Name = "drid";
            this.drid.Visible = true;
            this.drid.VisibleIndex = 0;
            // 
            // stopid
            // 
            this.stopid.Caption = "站点ID";
            this.stopid.FieldName = "stopid";
            this.stopid.Name = "stopid";
            this.stopid.Visible = true;
            this.stopid.VisibleIndex = 1;
            // 
            // stopname
            // 
            this.stopname.Caption = "站点名称";
            this.stopname.FieldName = "stopname";
            this.stopname.Name = "stopname";
            this.stopname.Visible = true;
            this.stopname.VisibleIndex = 2;
            // 
            // validated
            // 
            this.validated.Caption = "有效性";
            this.validated.FieldName = "validated";
            this.validated.Name = "validated";
            this.validated.Visible = true;
            this.validated.VisibleIndex = 3;
            // 
            // ordernum
            // 
            this.ordernum.Caption = "优先级";
            this.ordernum.FieldName = "ordernum";
            this.ordernum.Name = "ordernum";
            this.ordernum.Visible = true;
            this.ordernum.VisibleIndex = 4;
            // 
            // notes
            // 
            this.notes.Caption = "备注";
            this.notes.FieldName = "notes";
            this.notes.Name = "notes";
            this.notes.Visible = true;
            this.notes.VisibleIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(150, 73);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 249);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Location = new System.Drawing.Point(0, 73);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(150, 249);
            this.tv.TabIndex = 6;
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            this.tv.Click += new System.EventHandler(this.tv_Click);
            // 
            // fRouteSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 344);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.splitter1);
            this.Name = "fRouteSite";
            this.Text = "站点维护";
            this.Load += new System.EventHandler(this.fRouteSite_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.tv, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn drid;
        private DevExpress.XtraGrid.Columns.GridColumn stopid;
        private DevExpress.XtraGrid.Columns.GridColumn stopname;
        private DevExpress.XtraGrid.Columns.GridColumn validated;
        private DevExpress.XtraGrid.Columns.GridColumn ordernum;
        private DevExpress.XtraGrid.Columns.GridColumn notes;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView tv;
    }
}