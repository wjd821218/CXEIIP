namespace EIIP.Business.Purchase
{
    partial class frmPurchaseOrder
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
            this.gColUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColPackage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColPackageCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColCostPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColSettlePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.txtCustPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuyer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContractNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResponsible = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInvType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpShipStart = new System.Windows.Forms.DateTimePicker();
            this.dtpShipArrive = new System.Windows.Forms.DateTimePicker();
            this.cbbDept = new System.Windows.Forms.ComboBox();
            this.cbbTranport = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColMINSALEPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColLastPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColMinPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plDetail.SuspendLayout();
            this.plHeader.SuspendLayout();
            this.plFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // plDetail
            // 
            this.plDetail.Location = new System.Drawing.Point(0, 142);
            this.plDetail.Size = new System.Drawing.Size(1124, 369);
            // 
            // plHeader
            // 
            this.plHeader.Controls.Add(this.comboBox2);
            this.plHeader.Controls.Add(this.cbbTranport);
            this.plHeader.Controls.Add(this.cbbDept);
            this.plHeader.Controls.Add(this.dtpShipArrive);
            this.plHeader.Controls.Add(this.dtpShipStart);
            this.plHeader.Controls.Add(this.label18);
            this.plHeader.Controls.Add(this.textBox17);
            this.plHeader.Controls.Add(this.label17);
            this.plHeader.Controls.Add(this.textBox15);
            this.plHeader.Controls.Add(this.label15);
            this.plHeader.Controls.Add(this.txtNote);
            this.plHeader.Controls.Add(this.label16);
            this.plHeader.Controls.Add(this.txtInvType);
            this.plHeader.Controls.Add(this.label14);
            this.plHeader.Controls.Add(this.textBox13);
            this.plHeader.Controls.Add(this.label13);
            this.plHeader.Controls.Add(this.label9);
            this.plHeader.Controls.Add(this.txtClient);
            this.plHeader.Controls.Add(this.label10);
            this.plHeader.Controls.Add(this.txt);
            this.plHeader.Controls.Add(this.label11);
            this.plHeader.Controls.Add(this.label12);
            this.plHeader.Controls.Add(this.label5);
            this.plHeader.Controls.Add(this.txtResponsible);
            this.plHeader.Controls.Add(this.label6);
            this.plHeader.Controls.Add(this.textBox7);
            this.plHeader.Controls.Add(this.label7);
            this.plHeader.Controls.Add(this.label8);
            this.plHeader.Controls.Add(this.txtContractNo);
            this.plHeader.Controls.Add(this.label4);
            this.plHeader.Controls.Add(this.txtBuyer);
            this.plHeader.Controls.Add(this.label3);
            this.plHeader.Controls.Add(this.txtCustPro);
            this.plHeader.Controls.Add(this.label2);
            this.plHeader.Controls.Add(this.txtCust);
            this.plHeader.Controls.Add(this.label1);
            this.plHeader.Size = new System.Drawing.Size(1124, 117);
            // 
            // plFilter
            // 
            this.plFilter.Controls.Add(this.label19);
            this.plFilter.Controls.Add(this.txtArt);
            this.plFilter.Location = new System.Drawing.Point(0, 333);
            this.plFilter.Size = new System.Drawing.Size(1124, 36);
            // 
            // gridControl1
            // 
            this.gridControl1.Size = new System.Drawing.Size(1124, 333);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gColArtId,
            this.gColName,
            this.gColSpec,
            this.gColFactory,
            this.gColUnit,
            this.gColTotal,
            this.gColPrice,
            this.gColAmount,
            this.gColTaxRate,
            this.gColPackage,
            this.gColPackageCount,
            this.gColCostPrice,
            this.gColSettlePrice,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gColMINSALEPRICE,
            this.gColLastPrice,
            this.gColMinPrice});
            this.gridView1.IndicatorWidth = 20;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gColArtId
            // 
            this.gColArtId.Caption = "编码";
            this.gColArtId.FieldName = "ARTID";
            this.gColArtId.Name = "gColArtId";
            this.gColArtId.Visible = true;
            this.gColArtId.VisibleIndex = 1;
            // 
            // gColName
            // 
            this.gColName.Caption = "名称";
            this.gColName.FieldName = "NAME";
            this.gColName.Name = "gColName";
            this.gColName.Visible = true;
            this.gColName.VisibleIndex = 2;
            // 
            // gColSpec
            // 
            this.gColSpec.Caption = "规格";
            this.gColSpec.FieldName = "SPEC";
            this.gColSpec.Name = "gColSpec";
            this.gColSpec.Visible = true;
            this.gColSpec.VisibleIndex = 3;
            // 
            // gColFactory
            // 
            this.gColFactory.Caption = "产地";
            this.gColFactory.FieldName = "FACTORY";
            this.gColFactory.Name = "gColFactory";
            this.gColFactory.Visible = true;
            this.gColFactory.VisibleIndex = 4;
            // 
            // gColUnit
            // 
            this.gColUnit.Caption = "单位";
            this.gColUnit.FieldName = "UNIT";
            this.gColUnit.Name = "gColUnit";
            this.gColUnit.Visible = true;
            this.gColUnit.VisibleIndex = 5;
            // 
            // gColTotal
            // 
            this.gColTotal.Caption = "数量";
            this.gColTotal.FieldName = "TOTAL";
            this.gColTotal.Name = "gColTotal";
            this.gColTotal.Visible = true;
            this.gColTotal.VisibleIndex = 6;
            // 
            // gColPrice
            // 
            this.gColPrice.Caption = "单价";
            this.gColPrice.FieldName = "PRICE";
            this.gColPrice.Name = "gColPrice";
            this.gColPrice.Visible = true;
            this.gColPrice.VisibleIndex = 7;
            // 
            // gColAmount
            // 
            this.gColAmount.Caption = "金额";
            this.gColAmount.FieldName = "AMOUNT";
            this.gColAmount.Name = "gColAmount";
            this.gColAmount.Visible = true;
            this.gColAmount.VisibleIndex = 8;
            // 
            // gColTaxRate
            // 
            this.gColTaxRate.Caption = "税率";
            this.gColTaxRate.FieldName = "TAXRATE";
            this.gColTaxRate.Name = "gColTaxRate";
            this.gColTaxRate.Visible = true;
            this.gColTaxRate.VisibleIndex = 9;
            // 
            // gColPackage
            // 
            this.gColPackage.Caption = "包装";
            this.gColPackage.FieldName = "PACKQUANTITIES";
            this.gColPackage.Name = "gColPackage";
            this.gColPackage.Visible = true;
            this.gColPackage.VisibleIndex = 10;
            // 
            // gColPackageCount
            // 
            this.gColPackageCount.Caption = "件数";
            this.gColPackageCount.FieldName = "PACKAGECOUNT";
            this.gColPackageCount.Name = "gColPackageCount";
            this.gColPackageCount.Visible = true;
            this.gColPackageCount.VisibleIndex = 11;
            // 
            // gColCostPrice
            // 
            this.gColCostPrice.Caption = "进货低价";
            this.gColCostPrice.FieldName = "COSTPRICE";
            this.gColCostPrice.Name = "gColCostPrice";
            this.gColCostPrice.Visible = true;
            this.gColCostPrice.VisibleIndex = 14;
            // 
            // gColSettlePrice
            // 
            this.gColSettlePrice.Caption = "结算价";
            this.gColSettlePrice.FieldName = "SETTLEPRICE";
            this.gColSettlePrice.Name = "gColSettlePrice";
            this.gColSettlePrice.Visible = true;
            this.gColSettlePrice.VisibleIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供应商";
            // 
            // txtCust
            // 
            this.txtCust.Location = new System.Drawing.Point(95, 12);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(258, 21);
            this.txtCust.TabIndex = 1;
            this.txtCust.DoubleClick += new System.EventHandler(this.txtCust_DoubleClick);
            this.txtCust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCust_KeyPress);
            // 
            // txtCustPro
            // 
            this.txtCustPro.Location = new System.Drawing.Point(420, 12);
            this.txtCustPro.Name = "txtCustPro";
            this.txtCustPro.Size = new System.Drawing.Size(289, 21);
            this.txtCustPro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "所属客户";
            // 
            // txtBuyer
            // 
            this.txtBuyer.Location = new System.Drawing.Point(776, 12);
            this.txtBuyer.Name = "txtBuyer";
            this.txtBuyer.Size = new System.Drawing.Size(100, 21);
            this.txtBuyer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "采购员";
            // 
            // txtContractNo
            // 
            this.txtContractNo.Location = new System.Drawing.Point(943, 12);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(100, 21);
            this.txtContractNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(882, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "合同编号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(882, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "启运时间";
            // 
            // txtResponsible
            // 
            this.txtResponsible.Location = new System.Drawing.Point(776, 36);
            this.txtResponsible.Name = "txtResponsible";
            this.txtResponsible.Size = new System.Drawing.Size(100, 21);
            this.txtResponsible.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "责任人";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(420, 36);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "采购入库";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "采购类型";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "业务部门";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(882, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "预计到货";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(776, 61);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 21);
            this.txtClient.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(715, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 20;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(420, 61);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 21);
            this.txt.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "承运方式";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "承运单位";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(253, 36);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 21);
            this.textBox13.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "辅助核算";
            // 
            // txtInvType
            // 
            this.txtInvType.Location = new System.Drawing.Point(609, 36);
            this.txtInvType.Name = "txtInvType";
            this.txtInvType.Size = new System.Drawing.Size(100, 21);
            this.txtInvType.TabIndex = 27;
            this.txtInvType.Text = "增值税发票";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(548, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "发票类型";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(420, 86);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 21);
            this.textBox15.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(359, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "预付货款";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(95, 86);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(258, 21);
            this.txtNote.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 28;
            this.label16.Text = "说明备注";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(609, 61);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 21);
            this.textBox17.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(548, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 32;
            this.label17.Text = "付款方式";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(721, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 34;
            this.label18.Text = "委托人";
            // 
            // dtpShipStart
            // 
            this.dtpShipStart.Location = new System.Drawing.Point(943, 36);
            this.dtpShipStart.Name = "dtpShipStart";
            this.dtpShipStart.Size = new System.Drawing.Size(100, 21);
            this.dtpShipStart.TabIndex = 35;
            // 
            // dtpShipArrive
            // 
            this.dtpShipArrive.Location = new System.Drawing.Point(943, 59);
            this.dtpShipArrive.Name = "dtpShipArrive";
            this.dtpShipArrive.Size = new System.Drawing.Size(100, 21);
            this.dtpShipArrive.TabIndex = 36;
            // 
            // cbbDept
            // 
            this.cbbDept.FormattingEnabled = true;
            this.cbbDept.Location = new System.Drawing.Point(95, 36);
            this.cbbDept.Name = "cbbDept";
            this.cbbDept.Size = new System.Drawing.Size(97, 20);
            this.cbbDept.TabIndex = 37;
            // 
            // cbbTranport
            // 
            this.cbbTranport.FormattingEnabled = true;
            this.cbbTranport.Location = new System.Drawing.Point(95, 63);
            this.cbbTranport.Name = "cbbTranport";
            this.cbbTranport.Size = new System.Drawing.Size(258, 20);
            this.cbbTranport.TabIndex = 38;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(550, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 39;
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(93, 6);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(169, 21);
            this.txtArt.TabIndex = 0;
            this.txtArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArt_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "商品编码（N）";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "限销客户数";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 15;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "返点率";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 16;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "返点金额";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 17;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "底价";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 18;
            // 
            // gColMINSALEPRICE
            // 
            this.gColMINSALEPRICE.Caption = "最低限价";
            this.gColMINSALEPRICE.FieldName = "MINSALEPRICE";
            this.gColMINSALEPRICE.Name = "gColMINSALEPRICE";
            this.gColMINSALEPRICE.Visible = true;
            this.gColMINSALEPRICE.VisibleIndex = 19;
            // 
            // gColLastPrice
            // 
            this.gColLastPrice.Caption = "最近采购价";
            this.gColLastPrice.FieldName = "LASTPRICE";
            this.gColLastPrice.Name = "gColLastPrice";
            this.gColLastPrice.Visible = true;
            this.gColLastPrice.VisibleIndex = 12;
            // 
            // gColMinPrice
            // 
            this.gColMinPrice.Caption = "最低采购价";
            this.gColMinPrice.FieldName = "MINPRICE";
            this.gColMinPrice.Name = "gColMinPrice";
            this.gColMinPrice.Visible = true;
            this.gColMinPrice.VisibleIndex = 13;
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 511);
            this.Name = "frmPurchaseOrder";
            this.Text = "编制非计划订单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.plDetail.ResumeLayout(false);
            this.plHeader.ResumeLayout(false);
            this.plHeader.PerformLayout();
            this.plFilter.ResumeLayout(false);
            this.plFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gColArtId;
        private DevExpress.XtraGrid.Columns.GridColumn gColName;
        private DevExpress.XtraGrid.Columns.GridColumn gColSpec;
        private DevExpress.XtraGrid.Columns.GridColumn gColFactory;
        private DevExpress.XtraGrid.Columns.GridColumn gColUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gColTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gColPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gColAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gColTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn gColPackage;
        private DevExpress.XtraGrid.Columns.GridColumn gColPackageCount;
        private DevExpress.XtraGrid.Columns.GridColumn gColCostPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gColSettlePrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtInvType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResponsible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContractNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuyer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpShipArrive;
        private System.Windows.Forms.DateTimePicker dtpShipStart;
        private System.Windows.Forms.ComboBox cbbTranport;
        private System.Windows.Forms.ComboBox cbbDept;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtArt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gColMINSALEPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn gColLastPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gColMinPrice;
    }
}