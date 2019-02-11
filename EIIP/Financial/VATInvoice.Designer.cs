namespace EIIP.Financial
{
    partial class VATInvoice
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkPrtDlg = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbInvType = new System.Windows.Forms.ComboBox();
            this.btnCloseCard = new System.Windows.Forms.Button();
            this.chkAutoBill = new System.Windows.Forms.CheckBox();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnSureList = new System.Windows.Forms.Button();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.chkDateTo = new System.Windows.Forms.CheckBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.chkDateFrom = new System.Windows.Forms.CheckBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gColDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColBseqId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColTimeValidated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColBiller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColTAXCUSTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColTAXNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColBankAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColContactPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBseqId = new System.Windows.Forms.TextBox();
            this.btnPendingLoad = new System.Windows.Forms.Button();
            this.chkBillMode = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gColHasReturn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColSbseqid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColArtId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkBillMode);
            this.panel1.Controls.Add(this.btnPendingLoad);
            this.panel1.Controls.Add(this.txtBseqId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCust);
            this.panel1.Controls.Add(this.txtDept);
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.chkDateTo);
            this.panel1.Controls.Add(this.dtpDateFrom);
            this.panel1.Controls.Add(this.chkDateFrom);
            this.panel1.Size = new System.Drawing.Size(1117, 63);
            this.panel1.Controls.SetChildIndex(this.btnQuery, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateFrom, 0);
            this.panel1.Controls.SetChildIndex(this.chkDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.dtpDateTo, 0);
            this.panel1.Controls.SetChildIndex(this.txtDept, 0);
            this.panel1.Controls.SetChildIndex(this.txtCust, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.txtBseqId, 0);
            this.panel1.Controls.SetChildIndex(this.btnPendingLoad, 0);
            this.panel1.Controls.SetChildIndex(this.chkBillMode, 0);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 88);
            this.gridControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.gridControl1.Size = new System.Drawing.Size(1117, 238);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1062, 0);
            this.btnQuery.Size = new System.Drawing.Size(55, 63);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gColDeptName,
            this.gColCustName,
            this.gColBseqId,
            this.gColAmount,
            this.gColSbseqid,
            this.gColTimeValidated,
            this.gColBiller,
            this.gColNotes,
            this.gColHasReturn,
            this.gColArtId,
            this.gColTAXCUSTNAME,
            this.gColTAXNO,
            this.gColBankName,
            this.gColBankAccount,
            this.gColAddress,
            this.gColContactPhone});
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkPrtDlg);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbbInvType);
            this.panel2.Controls.Add(this.btnCloseCard);
            this.panel2.Controls.Add(this.chkAutoBill);
            this.panel2.Controls.Add(this.btnInvoice);
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Controls.Add(this.btnSureList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 29);
            this.panel2.TabIndex = 6;
            // 
            // chkPrtDlg
            // 
            this.chkPrtDlg.AutoSize = true;
            this.chkPrtDlg.Location = new System.Drawing.Point(620, 12);
            this.chkPrtDlg.Name = "chkPrtDlg";
            this.chkPrtDlg.Size = new System.Drawing.Size(96, 16);
            this.chkPrtDlg.TabIndex = 37;
            this.chkPrtDlg.Text = "显示打印选项";
            this.chkPrtDlg.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("宋体", 8F);
            this.lblInfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInfo.Location = new System.Drawing.Point(186, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(264, 11);
            this.lblInfo.TabIndex = 36;
            this.lblInfo.Text = "开票限0，金税卡有票可开，未到抄税期，未到锁死期";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "发票类别：";
            // 
            // cbbInvType
            // 
            this.cbbInvType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbInvType.FormattingEnabled = true;
            this.cbbInvType.Location = new System.Drawing.Point(784, 6);
            this.cbbInvType.Name = "cbbInvType";
            this.cbbInvType.Size = new System.Drawing.Size(97, 20);
            this.cbbInvType.TabIndex = 34;
            this.cbbInvType.SelectionChangeCommitted += new System.EventHandler(this.cbbInvType_SelectionChangeCommitted);
            // 
            // btnCloseCard
            // 
            this.btnCloseCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseCard.Enabled = false;
            this.btnCloseCard.Location = new System.Drawing.Point(100, 4);
            this.btnCloseCard.Name = "btnCloseCard";
            this.btnCloseCard.Size = new System.Drawing.Size(75, 20);
            this.btnCloseCard.TabIndex = 33;
            this.btnCloseCard.Text = "关闭金税卡";
            this.btnCloseCard.UseVisualStyleBackColor = true;
            this.btnCloseCard.Click += new System.EventHandler(this.btnCloseCard_Click);
            // 
            // chkAutoBill
            // 
            this.chkAutoBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoBill.AutoSize = true;
            this.chkAutoBill.Enabled = false;
            this.chkAutoBill.Location = new System.Drawing.Point(893, 10);
            this.chkAutoBill.Name = "chkAutoBill";
            this.chkAutoBill.Size = new System.Drawing.Size(72, 16);
            this.chkAutoBill.TabIndex = 32;
            this.chkAutoBill.Text = "自动开票";
            this.chkAutoBill.UseVisualStyleBackColor = true;
            this.chkAutoBill.CheckedChanged += new System.EventHandler(this.chkAutoBill_CheckedChanged);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoice.Location = new System.Drawing.Point(1026, 5);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(75, 20);
            this.btnInvoice.TabIndex = 31;
            this.btnInvoice.Text = "开具发票";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNote.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNote.Location = new System.Drawing.Point(187, 3);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(324, 11);
            this.lblNote.TabIndex = 30;
            this.lblNote.Text = "本单位税号：开票机号码：发票库存：当前发票号码：发票代码：";
            // 
            // btnSureList
            // 
            this.btnSureList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSureList.Location = new System.Drawing.Point(12, 4);
            this.btnSureList.Name = "btnSureList";
            this.btnSureList.Size = new System.Drawing.Size(75, 20);
            this.btnSureList.TabIndex = 29;
            this.btnSureList.Text = "连接金税卡";
            this.btnSureList.UseVisualStyleBackColor = true;
            this.btnSureList.Click += new System.EventHandler(this.btnSureList_Click);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(700, 35);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(121, 21);
            this.dtpDateTo.TabIndex = 30;
            // 
            // chkDateTo
            // 
            this.chkDateTo.AutoSize = true;
            this.chkDateTo.Location = new System.Drawing.Point(633, 38);
            this.chkDateTo.Name = "chkDateTo";
            this.chkDateTo.Size = new System.Drawing.Size(60, 16);
            this.chkDateTo.TabIndex = 29;
            this.chkDateTo.Text = "日期到";
            this.chkDateTo.UseVisualStyleBackColor = true;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(491, 35);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(121, 21);
            this.dtpDateFrom.TabIndex = 28;
            // 
            // chkDateFrom
            // 
            this.chkDateFrom.AutoSize = true;
            this.chkDateFrom.Location = new System.Drawing.Point(424, 38);
            this.chkDateFrom.Name = "chkDateFrom";
            this.chkDateFrom.Size = new System.Drawing.Size(60, 16);
            this.chkDateFrom.TabIndex = 27;
            this.chkDateFrom.Text = "日期从";
            this.chkDateFrom.UseVisualStyleBackColor = true;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(79, 7);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(330, 21);
            this.txtDept.TabIndex = 31;
            // 
            // txtCust
            // 
            this.txtCust.Location = new System.Drawing.Point(79, 35);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(330, 21);
            this.txtCust.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "部门：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "客户：";
            // 
            // gColDeptName
            // 
            this.gColDeptName.Caption = "部门";
            this.gColDeptName.FieldName = "DEPTNAME";
            this.gColDeptName.Name = "gColDeptName";
            this.gColDeptName.OptionsColumn.ReadOnly = true;
            this.gColDeptName.Visible = true;
            this.gColDeptName.VisibleIndex = 1;
            // 
            // gColCustName
            // 
            this.gColCustName.Caption = "往来单位";
            this.gColCustName.FieldName = "CUSTNAME";
            this.gColCustName.Name = "gColCustName";
            this.gColCustName.OptionsColumn.ReadOnly = true;
            this.gColCustName.Visible = true;
            this.gColCustName.VisibleIndex = 2;
            // 
            // gColBseqId
            // 
            this.gColBseqId.Caption = "票据流水";
            this.gColBseqId.FieldName = "BSEQID";
            this.gColBseqId.Name = "gColBseqId";
            this.gColBseqId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "BSEQID", "{0}")});
            this.gColBseqId.Visible = true;
            this.gColBseqId.VisibleIndex = 3;
            // 
            // gColAmount
            // 
            this.gColAmount.Caption = "金额";
            this.gColAmount.FieldName = "AMOUNT";
            this.gColAmount.Name = "gColAmount";
            this.gColAmount.OptionsColumn.AllowEdit = false;
            this.gColAmount.OptionsColumn.AllowFocus = false;
            this.gColAmount.Visible = true;
            this.gColAmount.VisibleIndex = 4;
            // 
            // gColTimeValidated
            // 
            this.gColTimeValidated.Caption = "捡配时间";
            this.gColTimeValidated.DisplayFormat.FormatString = "{0:G}";
            this.gColTimeValidated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gColTimeValidated.FieldName = "TIMEVALIDATED";
            this.gColTimeValidated.Name = "gColTimeValidated";
            this.gColTimeValidated.OptionsColumn.AllowEdit = false;
            this.gColTimeValidated.Visible = true;
            this.gColTimeValidated.VisibleIndex = 5;
            // 
            // gColBiller
            // 
            this.gColBiller.Caption = "开票人";
            this.gColBiller.FieldName = "WRITTERNAME";
            this.gColBiller.Name = "gColBiller";
            this.gColBiller.OptionsColumn.AllowEdit = false;
            this.gColBiller.Visible = true;
            this.gColBiller.VisibleIndex = 6;
            // 
            // gColNotes
            // 
            this.gColNotes.Caption = "备注";
            this.gColNotes.FieldName = "NOTES";
            this.gColNotes.Name = "gColNotes";
            this.gColNotes.Visible = true;
            this.gColNotes.VisibleIndex = 7;
            // 
            // gColTAXCUSTNAME
            // 
            this.gColTAXCUSTNAME.Caption = "客户抬头";
            this.gColTAXCUSTNAME.FieldName = "TAXCUSTNAME";
            this.gColTAXCUSTNAME.Name = "gColTAXCUSTNAME";
            this.gColTAXCUSTNAME.OptionsColumn.AllowEdit = false;
            this.gColTAXCUSTNAME.Visible = true;
            this.gColTAXCUSTNAME.VisibleIndex = 8;
            // 
            // gColTAXNO
            // 
            this.gColTAXNO.Caption = "客户税号";
            this.gColTAXNO.FieldName = "TAXNO";
            this.gColTAXNO.Name = "gColTAXNO";
            this.gColTAXNO.OptionsColumn.AllowEdit = false;
            this.gColTAXNO.Visible = true;
            this.gColTAXNO.VisibleIndex = 9;
            // 
            // gColBankName
            // 
            this.gColBankName.Caption = "开户行";
            this.gColBankName.FieldName = "BANKNAME";
            this.gColBankName.Name = "gColBankName";
            this.gColBankName.OptionsColumn.AllowEdit = false;
            this.gColBankName.Visible = true;
            this.gColBankName.VisibleIndex = 10;
            // 
            // gColBankAccount
            // 
            this.gColBankAccount.Caption = "银行账号";
            this.gColBankAccount.FieldName = "BANKACCOUNT";
            this.gColBankAccount.Name = "gColBankAccount";
            this.gColBankAccount.OptionsColumn.AllowEdit = false;
            this.gColBankAccount.Visible = true;
            this.gColBankAccount.VisibleIndex = 11;
            // 
            // gColAddress
            // 
            this.gColAddress.Caption = "开票地址";
            this.gColAddress.FieldName = "ADDRESS";
            this.gColAddress.Name = "gColAddress";
            this.gColAddress.OptionsColumn.AllowEdit = false;
            this.gColAddress.Visible = true;
            this.gColAddress.VisibleIndex = 12;
            // 
            // gColContactPhone
            // 
            this.gColContactPhone.Caption = "电话";
            this.gColContactPhone.FieldName = "CONTACTPHONE";
            this.gColContactPhone.Name = "gColContactPhone";
            this.gColContactPhone.OptionsColumn.AllowEdit = false;
            this.gColContactPhone.Visible = true;
            this.gColContactPhone.VisibleIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "单号：";
            // 
            // txtBseqId
            // 
            this.txtBseqId.Location = new System.Drawing.Point(491, 6);
            this.txtBseqId.Name = "txtBseqId";
            this.txtBseqId.Size = new System.Drawing.Size(168, 21);
            this.txtBseqId.TabIndex = 36;
            this.txtBseqId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBseqId_KeyPress);
            // 
            // btnPendingLoad
            // 
            this.btnPendingLoad.Location = new System.Drawing.Point(854, 31);
            this.btnPendingLoad.Name = "btnPendingLoad";
            this.btnPendingLoad.Size = new System.Drawing.Size(88, 23);
            this.btnPendingLoad.TabIndex = 37;
            this.btnPendingLoad.Text = "导入开票申请";
            this.btnPendingLoad.UseVisualStyleBackColor = true;
            // 
            // chkBillMode
            // 
            this.chkBillMode.AutoSize = true;
            this.chkBillMode.Location = new System.Drawing.Point(858, 8);
            this.chkBillMode.Name = "chkBillMode";
            this.chkBillMode.Size = new System.Drawing.Size(72, 16);
            this.chkBillMode.TabIndex = 38;
            this.chkBillMode.Text = "月开模式";
            this.chkBillMode.UseVisualStyleBackColor = true;
            this.chkBillMode.CheckedChanged += new System.EventHandler(this.chkBillMode_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 7;
            // 
            // gColHasReturn
            // 
            this.gColHasReturn.Caption = "退货金额";
            this.gColHasReturn.FieldName = "RETURNAMOUNT";
            this.gColHasReturn.Name = "gColHasReturn";
            this.gColHasReturn.Visible = true;
            this.gColHasReturn.VisibleIndex = 16;
            // 
            // gColSbseqid
            // 
            this.gColSbseqid.Caption = "捡配流水";
            this.gColSbseqid.FieldName = "SBSEQID";
            this.gColSbseqid.Name = "gColSbseqid";
            this.gColSbseqid.Visible = true;
            this.gColSbseqid.VisibleIndex = 14;
            // 
            // gColArtId
            // 
            this.gColArtId.Caption = "无分类编码";
            this.gColArtId.FieldName = "ARTID";
            this.gColArtId.Name = "gColArtId";
            this.gColArtId.Visible = true;
            this.gColArtId.VisibleIndex = 15;
            // 
            // VATInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 348);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Name = "VATInvoice";
            this.Text = "增值税普通发票快速开票";
            this.Load += new System.EventHandler(this.VATInvoice_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
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

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSureList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.CheckBox chkDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.CheckBox chkDateFrom;
        private System.Windows.Forms.CheckBox chkAutoBill;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Label lblNote;
        private DevExpress.XtraGrid.Columns.GridColumn gColDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn gColCustName;
        private DevExpress.XtraGrid.Columns.GridColumn gColBseqId;
        private DevExpress.XtraGrid.Columns.GridColumn gColAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gColTimeValidated;
        private DevExpress.XtraGrid.Columns.GridColumn gColBiller;
        private DevExpress.XtraGrid.Columns.GridColumn gColNotes;
        private System.Windows.Forms.Button btnCloseCard;
        private DevExpress.XtraGrid.Columns.GridColumn gColTAXCUSTNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gColTAXNO;
        private DevExpress.XtraGrid.Columns.GridColumn gColBankName;
        private DevExpress.XtraGrid.Columns.GridColumn gColBankAccount;
        private DevExpress.XtraGrid.Columns.GridColumn gColAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gColContactPhone;
        private System.Windows.Forms.TextBox txtBseqId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbInvType;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox chkPrtDlg;
        private System.Windows.Forms.Button btnPendingLoad;
        private System.Windows.Forms.CheckBox chkBillMode;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn gColHasReturn;
        private DevExpress.XtraGrid.Columns.GridColumn gColSbseqid;
        private DevExpress.XtraGrid.Columns.GridColumn gColArtId;
    }
}