namespace EIIP.Financial
{
    partial class frmReceivableAudit
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
            this.cxColDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColbranchname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColfinseqid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColfintypename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColcustname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColamount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColwriter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColCONTRIBUTEUname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColtimewritten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColflowname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColnotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.chkDateTo = new System.Windows.Forms.CheckBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.chkDateFrom = new System.Windows.Forms.CheckBox();
            this.cbbCapitalType = new System.Windows.Forms.ComboBox();
            this.lblCapitalType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSureList = new System.Windows.Forms.Button();
            this.cxColMediaType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.chkDateTo);
            this.panel1.Controls.Add(this.dtpDateFrom);
            this.panel1.Controls.Add(this.chkDateFrom);
            this.panel1.Size = new System.Drawing.Size(877, 37);
            this.panel1.Controls.SetChildIndex(this.btnQuery, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateTo, 0);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 62);
            this.gridControl1.Size = new System.Drawing.Size(877, 273);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(818, 0);
            this.btnQuery.Size = new System.Drawing.Size(59, 37);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cxColDeptName,
            this.cxColbranchname,
            this.cxColfinseqid,
            this.cxColfintypename,
            this.cxColcustname,
            this.gridColumn5,
            this.cxColamount,
            this.cxColwriter,
            this.cxColCONTRIBUTEUname,
            this.cxColtimewritten,
            this.cxColflowname,
            this.cxColnotes,
            this.cxColMediaType});
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // cxColDeptName
            // 
            this.cxColDeptName.Caption = "部门名称";
            this.cxColDeptName.FieldName = "DEPTNAME";
            this.cxColDeptName.Name = "cxColDeptName";
            this.cxColDeptName.Visible = true;
            this.cxColDeptName.VisibleIndex = 1;
            // 
            // cxColbranchname
            // 
            this.cxColbranchname.Caption = "子部门名称";
            this.cxColbranchname.FieldName = "BRANCHNAME";
            this.cxColbranchname.Name = "cxColbranchname";
            this.cxColbranchname.Visible = true;
            this.cxColbranchname.VisibleIndex = 2;
            // 
            // cxColfinseqid
            // 
            this.cxColfinseqid.Caption = "财务流水";
            this.cxColfinseqid.FieldName = "FINSEQID";
            this.cxColfinseqid.Name = "cxColfinseqid";
            this.cxColfinseqid.Visible = true;
            this.cxColfinseqid.VisibleIndex = 3;
            // 
            // cxColfintypename
            // 
            this.cxColfintypename.Caption = "票据类型";
            this.cxColfintypename.FieldName = "FINTYPENAME";
            this.cxColfintypename.Name = "cxColfintypename";
            this.cxColfintypename.Visible = true;
            this.cxColfintypename.VisibleIndex = 4;
            // 
            // cxColcustname
            // 
            this.cxColcustname.Caption = "往来单位";
            this.cxColcustname.FieldName = "CUSTNAME";
            this.cxColcustname.Name = "cxColcustname";
            this.cxColcustname.Visible = true;
            this.cxColcustname.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "业务员";
            this.gridColumn5.FieldName = "USERNAME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // cxColamount
            // 
            this.cxColamount.Caption = "金额";
            this.cxColamount.FieldName = "AMOUNT";
            this.cxColamount.Name = "cxColamount";
            this.cxColamount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AMOUNT", "SUM={0:0.##}")});
            this.cxColamount.Visible = true;
            this.cxColamount.VisibleIndex = 7;
            // 
            // cxColwriter
            // 
            this.cxColwriter.Caption = "制单人";
            this.cxColwriter.FieldName = "WRITER";
            this.cxColwriter.Name = "cxColwriter";
            this.cxColwriter.Visible = true;
            this.cxColwriter.VisibleIndex = 8;
            // 
            // cxColCONTRIBUTEUname
            // 
            this.cxColCONTRIBUTEUname.Caption = "请/缴款人";
            this.cxColCONTRIBUTEUname.FieldName = "CONTRIBUTEUNAME";
            this.cxColCONTRIBUTEUname.Name = "cxColCONTRIBUTEUname";
            this.cxColCONTRIBUTEUname.Visible = true;
            this.cxColCONTRIBUTEUname.VisibleIndex = 9;
            // 
            // cxColtimewritten
            // 
            this.cxColtimewritten.Caption = "制单日期";
            this.cxColtimewritten.FieldName = "TIMEWRITTEN";
            this.cxColtimewritten.Name = "cxColtimewritten";
            this.cxColtimewritten.Visible = true;
            this.cxColtimewritten.VisibleIndex = 10;
            // 
            // cxColflowname
            // 
            this.cxColflowname.Caption = "流程状态";
            this.cxColflowname.FieldName = "FLOWNAME";
            this.cxColflowname.Name = "cxColflowname";
            this.cxColflowname.Visible = true;
            this.cxColflowname.VisibleIndex = 11;
            // 
            // cxColnotes
            // 
            this.cxColnotes.Caption = "摘要";
            this.cxColnotes.FieldName = "NOTES";
            this.cxColnotes.Name = "cxColnotes";
            this.cxColnotes.Visible = true;
            this.cxColnotes.VisibleIndex = 13;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(299, 7);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(121, 21);
            this.dtpDateTo.TabIndex = 26;
            // 
            // chkDateTo
            // 
            this.chkDateTo.AutoSize = true;
            this.chkDateTo.Location = new System.Drawing.Point(232, 10);
            this.chkDateTo.Name = "chkDateTo";
            this.chkDateTo.Size = new System.Drawing.Size(60, 16);
            this.chkDateTo.TabIndex = 25;
            this.chkDateTo.Text = "日期到";
            this.chkDateTo.UseVisualStyleBackColor = true;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(90, 7);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(121, 21);
            this.dtpDateFrom.TabIndex = 24;
            // 
            // chkDateFrom
            // 
            this.chkDateFrom.AutoSize = true;
            this.chkDateFrom.Location = new System.Drawing.Point(23, 10);
            this.chkDateFrom.Name = "chkDateFrom";
            this.chkDateFrom.Size = new System.Drawing.Size(60, 16);
            this.chkDateFrom.TabIndex = 23;
            this.chkDateFrom.Text = "日期从";
            this.chkDateFrom.UseVisualStyleBackColor = true;
            // 
            // cbbCapitalType
            // 
            this.cbbCapitalType.FormattingEnabled = true;
            this.cbbCapitalType.Location = new System.Drawing.Point(107, 6);
            this.cbbCapitalType.Name = "cbbCapitalType";
            this.cbbCapitalType.Size = new System.Drawing.Size(559, 20);
            this.cbbCapitalType.TabIndex = 28;
            // 
            // lblCapitalType
            // 
            this.lblCapitalType.AutoSize = true;
            this.lblCapitalType.Location = new System.Drawing.Point(1, 10);
            this.lblCapitalType.Name = "lblCapitalType";
            this.lblCapitalType.Size = new System.Drawing.Size(101, 12);
            this.lblCapitalType.TabIndex = 27;
            this.lblCapitalType.Text = "请选择资金类别：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSureList);
            this.panel2.Controls.Add(this.cbbCapitalType);
            this.panel2.Controls.Add(this.lblCapitalType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 32);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSureList
            // 
            this.btnSureList.Location = new System.Drawing.Point(698, 4);
            this.btnSureList.Name = "btnSureList";
            this.btnSureList.Size = new System.Drawing.Size(75, 23);
            this.btnSureList.TabIndex = 29;
            this.btnSureList.Text = "开始执行";
            this.btnSureList.UseVisualStyleBackColor = true;
            this.btnSureList.Click += new System.EventHandler(this.btnSureList_Click);
            // 
            // cxColMediaType
            // 
            this.cxColMediaType.Caption = "含麻标记";
            this.cxColMediaType.FieldName = "MEDIATYPE";
            this.cxColMediaType.Name = "cxColMediaType";
            this.cxColMediaType.Visible = true;
            this.cxColMediaType.VisibleIndex = 12;
            // 
            // frmReceivableAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 357);
            this.Controls.Add(this.panel2);
            this.Name = "frmReceivableAudit";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmReceivableAudit_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn cxColDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn cxColbranchname;
        private DevExpress.XtraGrid.Columns.GridColumn cxColfinseqid;
        private DevExpress.XtraGrid.Columns.GridColumn cxColfintypename;
        private DevExpress.XtraGrid.Columns.GridColumn cxColcustname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn cxColamount;
        private DevExpress.XtraGrid.Columns.GridColumn cxColwriter;
        private DevExpress.XtraGrid.Columns.GridColumn cxColCONTRIBUTEUname;
        private DevExpress.XtraGrid.Columns.GridColumn cxColtimewritten;
        private DevExpress.XtraGrid.Columns.GridColumn cxColflowname;
        private DevExpress.XtraGrid.Columns.GridColumn cxColnotes;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.CheckBox chkDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.CheckBox chkDateFrom;
        private System.Windows.Forms.ComboBox cbbCapitalType;
        private System.Windows.Forms.Label lblCapitalType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSureList;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn cxColMediaType;
    }
}