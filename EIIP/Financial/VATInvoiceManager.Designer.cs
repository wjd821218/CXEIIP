namespace EIIP.Financial
{
    partial class VATInvoiceManager
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.txtBseqId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.chkDateTo = new System.Windows.Forms.CheckBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.chkDateFrom = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnListPrint = new System.Windows.Forms.Button();
            this.btnInvPrint = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbInvType = new System.Windows.Forms.ComboBox();
            this.btnCloseCard = new System.Windows.Forms.Button();
            this.btnCancled = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnSureList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.gColInvseqId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColCustId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColInvoiceCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColInvoiceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColInvoiceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColWritter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColInvoiceTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInvoiceNo);
            this.panel1.Controls.Add(this.label5);
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
            this.panel1.Size = new System.Drawing.Size(1058, 56);
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
            this.panel1.Controls.SetChildIndex(this.label5, 0);
            this.panel1.Controls.SetChildIndex(this.txtInvoiceNo, 0);
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 81);
            this.gridControl1.Size = new System.Drawing.Size(1058, 315);
            // 
            // btnQuery
            // 
            this.btnQuery.Enabled = false;
            this.btnQuery.Location = new System.Drawing.Point(983, 0);
            this.btnQuery.Size = new System.Drawing.Size(75, 56);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gColInvseqId,
            this.gColCustId,
            this.gColCustName,
            this.gColInvoiceCode,
            this.gColInvoiceNo,
            this.gColInvoiceType,
            this.gColInvoiceAmount,
            this.gColInvoiceDate,
            this.gColWritter,
            this.gColInvoiceTypeId});
            // 
            // txtBseqId
            // 
            this.txtBseqId.Enabled = false;
            this.txtBseqId.Location = new System.Drawing.Point(320, 3);
            this.txtBseqId.Name = "txtBseqId";
            this.txtBseqId.Size = new System.Drawing.Size(168, 21);
            this.txtBseqId.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 45;
            this.label3.Text = "单号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "客户：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "部门：";
            // 
            // txtCust
            // 
            this.txtCust.Location = new System.Drawing.Point(56, 31);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(204, 21);
            this.txtCust.TabIndex = 42;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(56, 3);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(204, 21);
            this.txtDept.TabIndex = 41;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(677, 31);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(121, 21);
            this.dtpDateTo.TabIndex = 40;
            // 
            // chkDateTo
            // 
            this.chkDateTo.AutoSize = true;
            this.chkDateTo.Location = new System.Drawing.Point(610, 34);
            this.chkDateTo.Name = "chkDateTo";
            this.chkDateTo.Size = new System.Drawing.Size(60, 16);
            this.chkDateTo.TabIndex = 39;
            this.chkDateTo.Text = "日期到";
            this.chkDateTo.UseVisualStyleBackColor = true;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(676, 5);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(121, 21);
            this.dtpDateFrom.TabIndex = 38;
            // 
            // chkDateFrom
            // 
            this.chkDateFrom.AutoSize = true;
            this.chkDateFrom.Location = new System.Drawing.Point(609, 8);
            this.chkDateFrom.Name = "chkDateFrom";
            this.chkDateFrom.Size = new System.Drawing.Size(60, 16);
            this.chkDateFrom.TabIndex = 37;
            this.chkDateFrom.Text = "日期从";
            this.chkDateFrom.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnListPrint);
            this.panel2.Controls.Add(this.btnInvPrint);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbbInvType);
            this.panel2.Controls.Add(this.btnCloseCard);
            this.panel2.Controls.Add(this.btnCancled);
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Controls.Add(this.btnSureList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 29);
            this.panel2.TabIndex = 7;
            // 
            // btnListPrint
            // 
            this.btnListPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListPrint.Enabled = false;
            this.btnListPrint.Location = new System.Drawing.Point(793, 4);
            this.btnListPrint.Name = "btnListPrint";
            this.btnListPrint.Size = new System.Drawing.Size(88, 23);
            this.btnListPrint.TabIndex = 38;
            this.btnListPrint.Text = "劳务清单打印";
            this.btnListPrint.UseVisualStyleBackColor = true;
            this.btnListPrint.Click += new System.EventHandler(this.btnListPrint_Click);
            // 
            // btnInvPrint
            // 
            this.btnInvPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvPrint.Enabled = false;
            this.btnInvPrint.Location = new System.Drawing.Point(887, 3);
            this.btnInvPrint.Name = "btnInvPrint";
            this.btnInvPrint.Size = new System.Drawing.Size(75, 23);
            this.btnInvPrint.TabIndex = 37;
            this.btnInvPrint.Text = "打印发票";
            this.btnInvPrint.UseVisualStyleBackColor = true;
            this.btnInvPrint.Click += new System.EventHandler(this.btnInvPrint_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("宋体", 8F);
            this.lblInfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInfo.Location = new System.Drawing.Point(195, 18);
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
            this.label4.Location = new System.Drawing.Point(611, 9);
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
            this.cbbInvType.Location = new System.Drawing.Point(676, 4);
            this.cbbInvType.Name = "cbbInvType";
            this.cbbInvType.Size = new System.Drawing.Size(97, 20);
            this.cbbInvType.TabIndex = 34;
            this.cbbInvType.SelectedIndexChanged += new System.EventHandler(this.cbbInvType_SelectedIndexChanged);
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
            // btnCancled
            // 
            this.btnCancled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancled.Enabled = false;
            this.btnCancled.Location = new System.Drawing.Point(967, 5);
            this.btnCancled.Name = "btnCancled";
            this.btnCancled.Size = new System.Drawing.Size(75, 20);
            this.btnCancled.TabIndex = 31;
            this.btnCancled.Text = "发票作废";
            this.btnCancled.UseVisualStyleBackColor = true;
            this.btnCancled.Click += new System.EventHandler(this.btnCancled_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNote.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNote.Location = new System.Drawing.Point(196, 3);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(192, 11);
            this.lblNote.TabIndex = 30;
            this.lblNote.Text = "本单位税号：开票机号码：发票库存：";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 47;
            this.label5.Text = "代码：";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(320, 30);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(167, 21);
            this.txtInvoiceNo.TabIndex = 48;
            // 
            // gColInvseqId
            // 
            this.gColInvseqId.Caption = "发票流水";
            this.gColInvseqId.FieldName = "INVSEQID";
            this.gColInvseqId.Name = "gColInvseqId";
            this.gColInvseqId.Visible = true;
            this.gColInvseqId.VisibleIndex = 0;
            // 
            // gColCustId
            // 
            this.gColCustId.Caption = "客户编码";
            this.gColCustId.FieldName = "CUSTID";
            this.gColCustId.Name = "gColCustId";
            this.gColCustId.Visible = true;
            this.gColCustId.VisibleIndex = 1;
            // 
            // gColCustName
            // 
            this.gColCustName.Caption = "客户名称";
            this.gColCustName.FieldName = "CUSTNAME";
            this.gColCustName.Name = "gColCustName";
            this.gColCustName.Visible = true;
            this.gColCustName.VisibleIndex = 2;
            // 
            // gColInvoiceCode
            // 
            this.gColInvoiceCode.Caption = "发票代码";
            this.gColInvoiceCode.FieldName = "INVOICECODE";
            this.gColInvoiceCode.Name = "gColInvoiceCode";
            this.gColInvoiceCode.Visible = true;
            this.gColInvoiceCode.VisibleIndex = 3;
            // 
            // gColInvoiceNo
            // 
            this.gColInvoiceNo.Caption = "发票号码";
            this.gColInvoiceNo.FieldName = "INVOICENO";
            this.gColInvoiceNo.Name = "gColInvoiceNo";
            this.gColInvoiceNo.Visible = true;
            this.gColInvoiceNo.VisibleIndex = 4;
            // 
            // gColInvoiceType
            // 
            this.gColInvoiceType.Caption = "发票种类";
            this.gColInvoiceType.FieldName = "INVTYPENAME";
            this.gColInvoiceType.Name = "gColInvoiceType";
            this.gColInvoiceType.Visible = true;
            this.gColInvoiceType.VisibleIndex = 5;
            // 
            // gColInvoiceAmount
            // 
            this.gColInvoiceAmount.Caption = "发票金额";
            this.gColInvoiceAmount.FieldName = "AMOUNT";
            this.gColInvoiceAmount.Name = "gColInvoiceAmount";
            this.gColInvoiceAmount.Visible = true;
            this.gColInvoiceAmount.VisibleIndex = 6;
            // 
            // gColInvoiceDate
            // 
            this.gColInvoiceDate.Caption = "发票日期";
            this.gColInvoiceDate.FieldName = "INVDATE";
            this.gColInvoiceDate.Name = "gColInvoiceDate";
            this.gColInvoiceDate.Visible = true;
            this.gColInvoiceDate.VisibleIndex = 7;
            // 
            // gColWritter
            // 
            this.gColWritter.Caption = "录入员";
            this.gColWritter.FieldName = "USERNAME";
            this.gColWritter.Name = "gColWritter";
            this.gColWritter.Visible = true;
            this.gColWritter.VisibleIndex = 8;
            // 
            // gColInvoiceTypeId
            // 
            this.gColInvoiceTypeId.Caption = "发票种类ID";
            this.gColInvoiceTypeId.FieldName = "INVTYPEID";
            this.gColInvoiceTypeId.Name = "gColInvoiceTypeId";
            this.gColInvoiceTypeId.Visible = true;
            this.gColInvoiceTypeId.VisibleIndex = 9;
            // 
            // VATInvoiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 418);
            this.Controls.Add(this.panel2);
            this.Name = "VATInvoiceManager";
            this.Text = "发票管理";
            this.Load += new System.EventHandler(this.VATInvoiceManager_Load);
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

        private System.Windows.Forms.TextBox txtBseqId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.CheckBox chkDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.CheckBox chkDateFrom;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnListPrint;
        private System.Windows.Forms.Button btnInvPrint;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbInvType;
        private System.Windows.Forms.Button btnCloseCard;
        private System.Windows.Forms.Button btnCancled;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnSureList;
        private DevExpress.XtraGrid.Columns.GridColumn gColInvseqId;
        private DevExpress.XtraGrid.Columns.GridColumn gColCustId;
        private DevExpress.XtraGrid.Columns.GridColumn gColCustName;
        private DevExpress.XtraGrid.Columns.GridColumn gColInvoiceCode;
        private DevExpress.XtraGrid.Columns.GridColumn gColInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn gColInvoiceType;
        private DevExpress.XtraGrid.Columns.GridColumn gColInvoiceAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gColInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn gColWritter;
        private DevExpress.XtraGrid.Columns.GridColumn gColInvoiceTypeId;
    }
}