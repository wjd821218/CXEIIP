using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.MDForm;
using EIIP.Common;
using TaxCardX;
using System.Xml;

namespace EIIP.Financial
{
    public partial class VATInvoice : fHeader
    {
        public GoldTax MyTax = new GoldTax();

        public int iCurrentItemId = -1;
        public string sRetMsg = "";
        public int iTaxDetailCount = 0;
        public short iTaxRate = 0;
        public string iCurrentBseqId = "";
        public int iBillMode = 0; //开票模式
        //待开列表变量
        string sInvTypeId = "2"; //发票类型 普通发票
        //OpenCard 
        double iInvLimit = 0;
        string sTaxCode = "";
        int sMachineNo = 0;
        int iIsInvEmpty = 0;
        int iIsRepReached = 0;
        int iIsLockReached = 0;

        //GetStock
        short iInfoKind = 0;
        string sInfoTypeCode = "";
        int iInfoNumber = 0;
        int iInvStock = 0;
        DateTime dTaxClock ;

        //开票返回状态    
        double dRetInfoAmount = 0;
        double dRetInfoTaxAmount = 0;
        DateTime dRetInfoInvDate;
        short dRetInfoMonth = 0;
        string sRetInfoTypeCode = "";
        long sRetInfoNumber = 0;
        short sRetGoodsListFlag = 0;

        string sBatchUpXml= "";

        public VATInvoice()
        {
            InitializeComponent();
        }

        private void fLoadCapitalType()
        {
            string sDeliverySql =
                "SELECT INVTYPEID,INVTYPENAME FROM T_INVOICE_TYPE ";

            cbbInvType.DataSource = GetDataTable(sDeliverySql);
            cbbInvType.ValueMember = "INVTYPEID";
            cbbInvType.DisplayMember = "INVTYPENAME";

        }
        private string getDataXml(string sGoodsNoVer, string sGoodsTaxNo, string sTaxPre, string sZeroTax, string sCropGoodsNo)
        {
            string sTaxPreCon = "";

            string sDataXml = 
            "<?xml version=\"1.0\" encoding=\"GBK\"?>" + 
            "<FPXT>" + 
                "<INPUT>" + 
                    "<GoodsNo>" + 
                    "<GoodsNoVer>" + sGoodsNoVer + "</GoodsNoVer>" +
                    "<GoodsTaxNo>" + sGoodsTaxNo + "</GoodsTaxNo>" + 
                    "<TaxPre>" + sTaxPre + "</TaxPre>" +
                    "<TaxPreCon>" + sTaxPreCon + "</TaxPreCon>" + 
                    "<ZeroTax>" + sZeroTax + "</ZeroTax>" + 
                    "<CropGoodsNo>" + sCropGoodsNo + "</CropGoodsNo>" + 
                    "<TaxDeduction></TaxDeduction>" + 
                    "</GoodsNo>" + 
                    "</INPUT>" + 
            "</FPXT>";

            return sDataXml;
        }
        private string BatchUpLoad(string sDataXml)
        {
            string sResultXml = "";
            //Base64 cBase64 = new Base64();
            
            sResultXml =
                "<?xml version=\"1.0\" encoding=\"GBK\"?>" + 
                "<FPXT_COM_INPUT>" + 
                "<ID>1100</ID> " + 
                "<DATA>" + Base64.EncodeBase64(sDataXml) + "</DATA> " + 
                "</FPXT_COM_INPUT>";

            return sResultXml;
        }

        private int fVaildBatchUp(string sXml)
        {
            string sCode = "";
            string sMess = "";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(sXml);

            foreach (XmlNode node in doc.SelectNodes("FPXT_COM_OUTPUT"))
            {
                sCode = node.ChildNodes[1].FirstChild.Value.ToString();
                sMess = node.ChildNodes[2].FirstChild.Value.ToString();
            }

            if (sCode != "0000") 
            {
                sRetMsg = "校验税收分类编码错误，错误代码：" + sCode + "--" + sMess + "!";
                return 1;

            }
           return 0;

        }
        private int fGetTax(string sBseqId )
        {
            DataTable myDt = new DataTable();
            string sDeliverySql =
                "SELECT NVL(TAXRATE,0) AS  TAXRATE FROM T_Inv_Pending_BILL_DETAIL WHERE BSEQID = " +sBseqId+ " GROUP BY TAXRATE";

            myDt = GetDataTable(sDeliverySql);

            if (myDt.Rows.Count != 1) return 1;
            iTaxRate = short.Parse(myDt.Rows[0][0].ToString());
            return 0;

        }

        private void fGetDetailCount(int iItemId)
        {
            DataRow row = gridView1.GetDataRow(iItemId);

            string sBseqId = Convert.ToString(row["BSEQID"]);

            DataTable myDt = new DataTable();
            string sDeliverySql =
                "SELECT ARTID FROM T_Inv_Pending_BILL_DETAIL  WHERE BSEQID = " + sBseqId;

            myDt = GetDataTable(sDeliverySql);

            iTaxDetailCount = myDt.Rows.Count;            

        }
        public override void GetData()
        {
            string sDeptid = txtDept.Text.Trim();
            string sCustId = txtCust.Text.Trim();
            string sBseqId = txtBseqId.Text.Trim();
            sInvTypeId = cbbInvType.SelectedValue.ToString();

            string spName = "NEIIP_FINANCE.sp_get_pending_inv";
            string sDateFrom = dtpDateFrom.Value.ToString("yyyyMMdd");
            string sDateTo = dtpDateTo.Value.ToString("yyyyMMdd");

            string[] sParameters = new string[8] { "anBillMode", "anBseqId", "anInvTypeId", "anDeptId", "anCustId", "as_datefrom", "as_dateto", "aors" };

            string[] sParametersValue = new string[8] {iBillMode.ToString(),sBseqId, sInvTypeId, sDeptid, sCustId, sDateFrom, sDateTo, "" };
            string[] sParametersType = new string[8] { "Varchar2", "Varchar2", "Varchar2", "Varchar2", "Varchar2", "Varchar2", "Varchar2", "RefCursor" };
            string[] sParametersDirection = new string[8] { "Input", "Input", "Input", "Input", "Input", "Input", "Input", "Output" };

            gridControl1.DataSource = GetDataTableBySp(spName, sParameters, sParametersValue, sParametersType, sParametersDirection);
        }
        public int InvoiceBill()
        {

            //MyTax
            //int iRetCode = 0;
            sRetInfoTypeCode = "0";
            sRetInfoNumber = 0;

            MyTax.InfoKind = iInfoKind;
            int iRetrun = 0;

            if (iCurrentItemId != -1)
            {                
                fGetDetailCount(iCurrentItemId);
                InvoiceBillHeader(iCurrentItemId);
                if (InvoiceBillDetail(iCurrentItemId) == 1) return 1;                          

                int iRetCode = 0;
                MyTax.Invoice();
                iRetCode = MyTax.RetCode;

                if (iRetCode == 4011)
                {
                    dRetInfoAmount = MyTax.InfoAmount;
                    dRetInfoTaxAmount = MyTax.InfoTaxAmount;
                    dRetInfoInvDate = MyTax.InfoDate;
                    dRetInfoMonth = MyTax.InfoMonth;
                    sRetInfoTypeCode = MyTax.InfoTypeCode;
                    sRetInfoNumber = MyTax.InfoNumber;
                    sRetGoodsListFlag = MyTax.GoodsListFlag;

                    MyTax.GoodsListFlag = 0;
                    if (chkPrtDlg.Checked) MyTax.InfoShowPrtDlg = 1;
                    else MyTax.InfoShowPrtDlg = 0;
                                        
                    MyTax.PrintInv();

                    if ((MyTax.RetCode != 5001)&& MyTax.RetCode != 5011&& MyTax.RetCode != 5012&& MyTax.RetCode != 5013)
                    { sRetMsg = MyTax.RetCode.ToString() + " 打印失败:其他原因！"; iRetrun = 1; return 1; }

                    if (MyTax.RetCode == 5001) { sRetMsg = MyTax.RetCode.ToString() + " 未找到发票或清单"; iRetrun = 1; return 1; }
                    if (MyTax.RetCode == 5011) { sRetMsg = MyTax.RetCode.ToString() + " 打印成功"; iRetrun = 0;}
                    if (MyTax.RetCode == 5012) { sRetMsg = MyTax.RetCode.ToString() + " 未打印"; iRetrun = 0; return 1; }
                    if (MyTax.RetCode == 5013) { sRetMsg = MyTax.RetCode.ToString() + " 打印失败"; iRetrun = 1; return 1; }
                    
                }
                else
                {
                    sRetMsg = iRetCode.ToString() + " 开票失败";

                    if (iRetCode == 4001) { sRetMsg = iRetCode.ToString() + " 传入发票数据不合法"; return 1; }
                    if (iRetCode == 4002) { sRetMsg = iRetCode.ToString() + " 开票前金税卡状态错"; return 1; }
                    if (iRetCode == 4003) { sRetMsg = iRetCode.ToString() + " 金税卡开票调用错误"; return 1; }
                    if (iRetCode == 4001) { sRetMsg = iRetCode.ToString() + " 开票后取金税卡状态错"; return 1; }
                    if (iRetCode == 4012) { sRetMsg = iRetCode.ToString() + " 开票失败"; return 1; }
                    if (iRetCode == 4013) { sRetMsg = iRetCode.ToString() + " 所开发票已作废"; return 1; }

                    iRetrun =  1;                    
                }

            }
            return iRetrun;
        }
        public int InvoiceBillHeader(int iItemId)
        {            
            MyTax.InvInfoInit();

            DataRow row = gridView1.GetDataRow(iItemId);

            if (
            (sInvTypeId == "1") &&
            (
                   (row["TAXCUSTNAME"].ToString().Trim() == "")
                || (row["TAXNO"].ToString().Trim() == "")
                || (row["BANKNAME"].ToString().Trim() == "")
                || (row["BANKACCOUNT"].ToString().Trim() == "")
                || (row["ADDRESS"].ToString().Trim() == "")
                || (row["CONTACTPHONE"].ToString().Trim() == "")
                || (row["ARTID"].ToString().Trim() != "")
            )
            ) 
            { sRetMsg = "开票失败客户开票资料不完整。"; return 1; }

            if (fGetTax(Convert.ToString(row["BSEQID"])) == 1) { sRetMsg = "填写发票头失败，明细中或存在多种税率。"; return 1; }

            MyTax.InfoClientName = Convert.ToString(row["TAXCUSTNAME"]);
            MyTax.InfoClientTaxCode = Convert.ToString(row["TAXNO"]);
            MyTax.InfoClientBankAccount = Convert.ToString(row["BANKNAME"]) + Convert.ToString(row["BANKACCOUNT"]);
            MyTax.InfoClientAddressPhone = Convert.ToString(row["ADDRESS"]) + Convert.ToString(row["CONTACTPHONE"]);                
            MyTax.InfoSellerBankAccount = "江南农村商业银行大学城支行 88801019012010000001281";
            MyTax.InfoSellerAddressPhone = "江苏省常州市武进经济开发区长扬路15号 0519-69698289";
            MyTax.InfoTaxRate = iTaxRate;
            MyTax.InfoNotes = Convert.ToString(row["NOTES"]);
            MyTax.InfoInvoicer = Global.tUser._UserName;
            MyTax.InfoChecker = "王鸿坤";
            MyTax.InfoCashier = "王鸿坤";
            if (iTaxDetailCount >8) MyTax.InfoListName = "详见销货清单";
            MyTax.InfoBillNumber = Convert.ToString(row["BSEQID"]);

            return 0;
        }
        public int InvoiceBillDetail(int iItemId)
        {
            MyTax.ClearInvList();
            DataRow row = gridView1.GetDataRow(iItemId);
            string sBseqId = row["BSEQID"].ToString();
            DataTable myDt = new DataTable();

            string spName = "NEIIP_FINANCE.sp_get_pending_invDetail";

            string[] sParameters = new string[2] { "anFinseqId", "aors" };

            string[] sParametersValue = new string[2] { sBseqId, "" };
            string[] sParametersType = new string[2] { "Varchar2","RefCursor" };
            string[] sParametersDirection = new string[2] { "Input","Output" };

            myDt = GetDataTableBySp(spName, sParameters, sParametersValue, sParametersType, sParametersDirection);
            iTaxDetailCount = myDt.Rows.Count;

            if (iTaxDetailCount > 0)
            {
                for (int i = 0; i < myDt.Rows.Count; i++)
                {
                    MyTax.InvListInit();
                    //商品名称
                    MyTax.ListGoodsName = myDt.Rows[i]["NAME"].ToString();

                    //BacthUpLoad 
                    string sTaxItem = myDt.Rows[i]["TAXITEM"].ToString();
                    string sTaxRate = myDt.Rows[i]["TAXRATE"].ToString();
                    string sZeroTax = "";
                    if (sTaxRate == "0") { sZeroTax = "3"; }
                    sBatchUpXml = getDataXml("30.0", sTaxItem, "0", sZeroTax, myDt.Rows[i]["ARTID"].ToString());
                    sBatchUpXml = BatchUpLoad(sBatchUpXml);
                    string sRetXml = MyTax.BatchUpload(sBatchUpXml);
                    if (fVaildBatchUp(sRetXml) == 1) { return 1; }

                    //其他信息
                    MyTax.ListTaxItem = myDt.Rows[i]["TAXITEM"].ToString();
                    MyTax.ListStandard = myDt.Rows[i]["SPEC"].ToString();
                    MyTax.ListUnit = myDt.Rows[i]["UNIT"].ToString();
                    MyTax.ListNumber = double.Parse(myDt.Rows[i]["BILLTOTAL"].ToString());
                    MyTax.ListPrice = double.Parse(myDt.Rows[i]["BILLPRICE"].ToString());
                    MyTax.ListAmount = double.Parse(myDt.Rows[i]["BILLAMOUNT"].ToString()); ;      //金额
                    MyTax.ListPriceKind = 1;   //含税价标志
                    MyTax.ListTaxAmount = 0; //税额

                    MyTax.AddInvList();
                }
                return 0;
            }
            else
            {
                sRetMsg = "发票开具失败，无可开的发票明细。";
                return 1;
            }


        }

        public int InvoiceValidated(string sBseqId, string sInvoiceCode,string sInvoiceNo)
        {
            int iResult = 0;
            string spName = "NEIIP_FINANCE.sp_fin_invoice_bill";

            string[] sParameters = new string[6] { "myReturn", "anBseqId", "anInvoiceCode", "anInvoiceNo", "anUserId", "asErrmsg" };

            string[] sParametersValue = new string[6] { "0",sBseqId, sRetInfoTypeCode, sRetInfoNumber.ToString(), Global.tUser._UserId, sRetMsg };
            string[] sParametersType = new string[6] { "Int32", "Varchar2", "Varchar2", "Varchar2", "Varchar2", "Varchar2" };
            string[] sParametersDirection = new string[6] { "ReturnValue", "Input", "Input", "Input", "Input", "Output" };
            
            iResult = int.Parse(OperData(spName, sParameters, sParametersValue, sParametersType, sParametersDirection));
            return iResult;
        }
        private void btnSureList_Click(object sender, EventArgs e)
        {
            int iResult = 0 ;
            string sResultMsg = "";

            MyTax.OpenCard();

            iResult = MyTax.RetCode;
            sResultMsg = MyTax.RetMsg;

            if (iResult == 1011)
            {
                iInvLimit = MyTax.InvLimit;
                sTaxCode = MyTax.TaxCode;
                sMachineNo = MyTax.MachineNo;
                iIsInvEmpty = MyTax.IsInvEmpty;
                iIsRepReached = MyTax.IsRepReached;
                iIsLockReached = MyTax.IsLockReached;

                //查询库存发票
                MyTax.InfoKind = iInfoKind;
                MyTax.GetInfo();

                sInfoTypeCode = MyTax.InfoTypeCode;
                iInfoNumber = MyTax.InfoNumber;
                iInvStock = MyTax.InvStock;
                dTaxClock = MyTax.TaxClock;


                lblNote.Text = "本单位税号：" + sTaxCode + "开票机号码：" + sMachineNo.ToString() + "发票库存：" + iInvStock.ToString() + "当前发票号码："+ sInfoTypeCode +"发票代码："+ iInfoNumber.ToString();
                lblInfo.Text = "开票限额："+ iInvLimit.ToString() + (iIsInvEmpty==0? "，金税卡无票可开" : "，金税卡有票可开") + (iIsRepReached == 0 ? "，未到抄税期" : "，已到抄税期") + (iIsLockReached == 0 ? "，未到锁死期" : "，已到锁死期") ;

                btnCloseCard.Enabled = true;
                btnSureList.Enabled = false;
                txtBseqId.Enabled = true;

                btnInvoice.Enabled = true;
                chkAutoBill.Enabled = true;
                btnQuery.Enabled = true;
                cbbInvType.Enabled = false;
            }
            else
            {
                MessageBox.Show(sResultMsg);
            }

        }

        private void btnCloseCard_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            string sResultMsg = "";

            MyTax.CloseCard();

            iResult = MyTax.RetCode;
            sResultMsg = MyTax.RetMsg;

            if (iResult == 9000)
            {
                btnSureList.Enabled = true;
                btnCloseCard.Enabled = false;
                txtBseqId.Enabled = false;

                btnInvoice.Enabled = false;
                chkAutoBill.Enabled = false;
                btnQuery.Enabled = false;
                cbbInvType.Enabled = true;
            }
            else MessageBox.Show(sResultMsg);

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            iCurrentItemId = -1;            

            if (gridView1.SelectedRowsCount >0)
            {                
                iCurrentItemId = gridView1.FocusedRowHandle;

                DataRow row = gridView1.GetDataRow(iCurrentItemId);

                iCurrentBseqId = Convert.ToString(row["BSEQID"]);

                if (InvoiceBill() == 1) MessageBox.Show(sRetMsg);
                if (InvoiceValidated(iCurrentBseqId,sRetInfoTypeCode, sRetInfoNumber.ToString()) ==1) MessageBox.Show(sRetMsg);

                txtBseqId.Clear();
                txtBseqId.Focus();
            }
        }

        private void txtBseqId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && txtBseqId.Text.Trim() != "")
            {
                GetData();

                if (gridView1.RowCount == 1)
                {
                    iCurrentItemId = 0;
                    if (InvoiceBill() == 1) MessageBox.Show(sRetMsg);

                    DataRow row = gridView1.GetDataRow(iCurrentItemId);

                    
                    iCurrentBseqId = Convert.ToString(row["BSEQID"]);

                    if (InvoiceValidated(iCurrentBseqId, sRetInfoTypeCode, sRetInfoNumber.ToString()) == 1) MessageBox.Show(sRetMsg);

                    txtBseqId.Clear();
                    txtBseqId.Focus();
                }  
            }
        }

        private void VATInvoice_Load(object sender, EventArgs e)
        {
            fLoadCapitalType();
            if (int.Parse(cbbInvType.SelectedValue.ToString()) == 4) iInfoKind = 2;
            if (int.Parse(cbbInvType.SelectedValue.ToString()) == 2) iInfoKind = 2;
            if (int.Parse(cbbInvType.SelectedValue.ToString()) == 1) iInfoKind = 0;
        }

        private void cbbInvType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (int.Parse(cbbInvType.SelectedValue.ToString()) ==4 ) iInfoKind = 2;
            if(int.Parse(cbbInvType.SelectedValue.ToString()) == 2) iInfoKind = 2;
            if (int.Parse(cbbInvType.SelectedValue.ToString()) ==1) iInfoKind = 0;
        }

        private void chkBillMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBillMode.Checked) iBillMode = 1;
            else iBillMode = 0;
        }

        private void chkAutoBill_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoBill.Checked)
            {
                if (QuikBill() == 1) MessageBox.Show(sRetMsg);
            }
            
        }
        private int QuikBill()
        {            
            /*
            for (int i = 0; i < gridControl1.Views[0].RowCount; i++)
            {
                object row = this.gridControl1.Views[0].GetRow(i);
            }*/

            if (gridView1.SelectedRowsCount <= 0)
            {
                MessageBox.Show("没有被选中的记录，请检查！");
                return 1;
            }
            else
            {
                foreach (int i in gridView1.GetSelectedRows())
                {

                    sRetMsg = "";

                    DataRow row = gridView1.GetDataRow(i);

                    iCurrentItemId = i;

                    iCurrentBseqId = Convert.ToString(row["BSEQID"]);

                    if (InvoiceBill() == 1)
                    {
                        sRetMsg = "业务单据号：" + iCurrentBseqId.ToString() + " 开票发生错误！" + sRetMsg;
                        return 1;
                    }
                    if (InvoiceValidated(iCurrentBseqId, sRetInfoTypeCode, sRetInfoNumber.ToString()) == 1)
                    {
                        sRetMsg = "业务单据号：" + iCurrentBseqId.ToString() + " 开票已经业务系统回写发生错误！" + sRetMsg;
                        return 1;
                    }

                    label5.Text = "自动开票中：单据" + iCurrentBseqId + "开票已完成";
                }

                gridControl1.DataSource = null;

            }

            return 0;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        private void gridView1_RowCellStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DevExpress.Utils.AppearanceDefault appNotPass1 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Salmon, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            DevExpress.Utils.AppearanceDefault appNotPass2 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Yellow, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

            DataRow dr = gridView1.GetDataRow(e.RowHandle);
            if (dr != null)
            {   //普通发票
                if (
                    (
                        (sInvTypeId =="2")
                        &&
                        (
                            (dr["TAXCUSTNAME"].ToString().Trim() == "") 
                            || (dr["ARTID"].ToString().Trim() != "")
                            || (dr["TAXNO"].ToString().Trim() == "")
                        )
                        )
                    )
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                //专用发票
                if (
                    (sInvTypeId == "1")&&
                    (
                           (dr["TAXCUSTNAME"].ToString().Trim() == "")
                        || (dr["TAXNO"].ToString().Trim() == "")
                        || (dr["BANKNAME"].ToString().Trim() == "")
                        || (dr["BANKACCOUNT"].ToString().Trim() == "")
                        || (dr["ADDRESS"].ToString().Trim() == "")
                        || (dr["CONTACTPHONE"].ToString().Trim() == "")
                        || (dr["ARTID"].ToString().Trim() != "")
                    )
                    )
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                    
            }
        }
    }
}
