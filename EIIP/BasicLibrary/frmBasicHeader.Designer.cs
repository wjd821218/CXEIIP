namespace EIIP.BasicLibrary
{
    partial class frmBasicHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBasicHeader));
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnView = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFilter = new System.Windows.Forms.Button();
            this.CentrePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.CentrePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 22);
            this.btnAdd.Text = "新增";
            // 
            // btnView
            // 
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(52, 22);
            this.btnView.Text = "查看";
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(52, 22);
            this.btnDel.Text = "删除";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 22);
            this.btnSave.Text = "保存";
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
            this.btnQuery.Text = "刷新";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(52, 22);
            this.btnExport.Text = "导出";
            // 
            // btnSelected
            // 
            this.btnSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnSelected.Image")));
            this.btnSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(52, 22);
            this.btnSelected.Text = "选中";
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "过滤";
            // 
            // txtFilter
            // 
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 25);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnView,
            this.btnDel,
            this.btnSave,
            this.btnQuery,
            this.btnExport,
            this.btnSelected,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(695, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(607, 11);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 22);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "查询";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // CentrePanel
            // 
            this.CentrePanel.Controls.Add(this.btnFilter);
            this.CentrePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CentrePanel.Location = new System.Drawing.Point(0, 25);
            this.CentrePanel.Name = "CentrePanel";
            this.CentrePanel.Size = new System.Drawing.Size(695, 46);
            this.CentrePanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 281);
            this.panel1.TabIndex = 10;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(695, 281);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridView1_KeyPress);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(509, 1);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "选中";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmBasicHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 352);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CentrePanel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBasicHeader";
            this.Text = "frmBasicHeader";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.CentrePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.Button btnFilter;
        public System.Windows.Forms.Panel CentrePanel;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.ToolStripTextBox txtFilter;
        public System.Windows.Forms.ToolStripButton btnSelected;
        private System.Windows.Forms.Button btnSelect;
    }
}