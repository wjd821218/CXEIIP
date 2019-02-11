namespace EIIP.Delivery
{
    partial class fDeliveryBill
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
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cxColBseqId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColOperator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColDeliveryRoutes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxColDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.chkDateTo = new System.Windows.Forms.CheckBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.chkDateFrom = new System.Windows.Forms.CheckBox();
            this.cbbDelivery = new System.Windows.Forms.ComboBox();
            this.cxColLineNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbbDeliver = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbDeliver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbDelivery);
            this.panel1.Controls.Add(this.lblDelivery);
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.chkDateTo);
            this.panel1.Controls.Add(this.dtpDateFrom);
            this.panel1.Controls.Add(this.chkDateFrom);
            this.panel1.Size = new System.Drawing.Size(833, 75);
            this.panel1.Controls.SetChildIndex(this.btnQuery, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.lblDelivery, 0);
            this.panel1.Controls.SetChildIndex(this.cbbDelivery, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.cbbDeliver, 0);
            // 
            // gridControl1
            // 
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(833, 168);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(758, 0);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cxColLineNo,
            this.cxColBseqId,
            this.cxColCustName,
            this.cxColAmount,
            this.cxColAdress,
            this.cxColOperator,
            this.cxColDeliveryRoutes,
            this.cxColDeptName,
            this.cxColDate});
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // cxColBseqId
            // 
            this.cxColBseqId.Caption = "票据流水";
            this.cxColBseqId.FieldName = "BSEQID";
            this.cxColBseqId.Name = "cxColBseqId";
            this.cxColBseqId.Visible = true;
            this.cxColBseqId.VisibleIndex = 2;
            // 
            // cxColCustName
            // 
            this.cxColCustName.Caption = "客户名称";
            this.cxColCustName.FieldName = "CUSTNAME";
            this.cxColCustName.Name = "cxColCustName";
            this.cxColCustName.Visible = true;
            this.cxColCustName.VisibleIndex = 3;
            // 
            // cxColAdress
            // 
            this.cxColAdress.Caption = "送货地址";
            this.cxColAdress.FieldName = "ADDRESS";
            this.cxColAdress.Name = "cxColAdress";
            this.cxColAdress.Visible = true;
            this.cxColAdress.VisibleIndex = 4;
            // 
            // cxColAmount
            // 
            this.cxColAmount.Caption = "金额";
            this.cxColAmount.FieldName = "AMOUNT";
            this.cxColAmount.Name = "cxColAmount";
            this.cxColAmount.Visible = true;
            this.cxColAmount.VisibleIndex = 5;
            // 
            // cxColOperator
            // 
            this.cxColOperator.Caption = "制单人";
            this.cxColOperator.FieldName = "WRITERNAME";
            this.cxColOperator.Name = "cxColOperator";
            this.cxColOperator.Visible = true;
            this.cxColOperator.VisibleIndex = 6;
            // 
            // cxColDeliveryRoutes
            // 
            this.cxColDeliveryRoutes.Caption = "路线";
            this.cxColDeliveryRoutes.FieldName = "DRNAME";
            this.cxColDeliveryRoutes.Name = "cxColDeliveryRoutes";
            this.cxColDeliveryRoutes.Visible = true;
            this.cxColDeliveryRoutes.VisibleIndex = 7;
            // 
            // cxColDeptName
            // 
            this.cxColDeptName.Caption = "产品线";
            this.cxColDeptName.FieldName = "DEPTNAME";
            this.cxColDeptName.Name = "cxColDeptName";
            this.cxColDeptName.Visible = true;
            this.cxColDeptName.VisibleIndex = 8;
            // 
            // cxColDate
            // 
            this.cxColDate.Caption = "审核日期";
            this.cxColDate.FieldName = "TIMEVALIDATED";
            this.cxColDate.Name = "cxColDate";
            this.cxColDate.Visible = true;
            this.cxColDate.VisibleIndex = 9;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(437, 23);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(41, 12);
            this.lblDelivery.TabIndex = 23;
            this.lblDelivery.Text = "路线：";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(293, 17);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(121, 21);
            this.dtpDateTo.TabIndex = 22;
            // 
            // chkDateTo
            // 
            this.chkDateTo.AutoSize = true;
            this.chkDateTo.Location = new System.Drawing.Point(226, 20);
            this.chkDateTo.Name = "chkDateTo";
            this.chkDateTo.Size = new System.Drawing.Size(60, 16);
            this.chkDateTo.TabIndex = 21;
            this.chkDateTo.Text = "日期到";
            this.chkDateTo.UseVisualStyleBackColor = true;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(84, 17);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(121, 21);
            this.dtpDateFrom.TabIndex = 20;
            // 
            // chkDateFrom
            // 
            this.chkDateFrom.AutoSize = true;
            this.chkDateFrom.Location = new System.Drawing.Point(17, 21);
            this.chkDateFrom.Name = "chkDateFrom";
            this.chkDateFrom.Size = new System.Drawing.Size(60, 16);
            this.chkDateFrom.TabIndex = 19;
            this.chkDateFrom.Text = "日期从";
            this.chkDateFrom.UseVisualStyleBackColor = true;
            // 
            // cbbDelivery
            // 
            this.cbbDelivery.FormattingEnabled = true;
            this.cbbDelivery.Location = new System.Drawing.Point(484, 17);
            this.cbbDelivery.Name = "cbbDelivery";
            this.cbbDelivery.Size = new System.Drawing.Size(158, 20);
            this.cbbDelivery.TabIndex = 26;
            this.cbbDelivery.SelectionChangeCommitted += new System.EventHandler(this.cbbDelivery_SelectionChangeCommitted);
            // 
            // cxColLineNo
            // 
            this.cxColLineNo.Caption = "行号";
            this.cxColLineNo.FieldName = "LINENO";
            this.cxColLineNo.Name = "cxColLineNo";
            this.cxColLineNo.Visible = true;
            this.cxColLineNo.VisibleIndex = 1;
            // 
            // cbbDeliver
            // 
            this.cbbDeliver.FormattingEnabled = true;
            this.cbbDeliver.Location = new System.Drawing.Point(484, 44);
            this.cbbDeliver.Name = "cbbDeliver";
            this.cbbDeliver.Size = new System.Drawing.Size(158, 20);
            this.cbbDeliver.TabIndex = 28;
            this.cbbDeliver.SelectionChangeCommitted += new System.EventHandler(this.cbbDeliver_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "送货员：";
            // 
            // fDeliveryBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 290);
            this.Name = "fDeliveryBill";
            this.Text = "销售配送分配";
            this.Load += new System.EventHandler(this.fDeliveryBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn cxColBseqId;
        private DevExpress.XtraGrid.Columns.GridColumn cxColCustName;
        private DevExpress.XtraGrid.Columns.GridColumn cxColAdress;
        private DevExpress.XtraGrid.Columns.GridColumn cxColAmount;
        private DevExpress.XtraGrid.Columns.GridColumn cxColOperator;
        private DevExpress.XtraGrid.Columns.GridColumn cxColDeliveryRoutes;
        private DevExpress.XtraGrid.Columns.GridColumn cxColDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn cxColDate;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.CheckBox chkDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.CheckBox chkDateFrom;
        private System.Windows.Forms.ComboBox cbbDelivery;
        private DevExpress.XtraGrid.Columns.GridColumn cxColLineNo;
        private System.Windows.Forms.ComboBox cbbDeliver;
        private System.Windows.Forms.Label label1;
    }
}