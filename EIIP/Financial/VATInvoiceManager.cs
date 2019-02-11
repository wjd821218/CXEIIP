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

namespace EIIP.Financial
{
    public partial class VATInvoiceManager : fHeader
    {
        public GoldTax MyTax = new GoldTax();

        public int iCurrentItemId = -1;
        public string sRetMsg = "";
        public int iTaxDetailCount = 0;
        public short iTaxRate = 0;
        public string iCurrentBseqId = "";


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
        DateTime dTaxClock;

        //开票返回状态    
        double dRetInfoAmount = 0;
        double dRetInfoTaxAmount = 0;
        DateTime dRetInfoInvDate;
        short dRetInfoMonth = 0;
        string sRetInfoTypeCode = "";
        long sRetInfoNumber = 0;
        short sRetGoodsListFlag = 0;
        public VATInvoiceManager()
        {
            InitializeComponent();
        }

        private void fLoadInvType()
        {
            string sDeliverySql =
                "SELECT INVTYPEID,INVTYPENAME FROM T_INVOICE_TYPE ";

            cbbInvType.DataSource = GetDataTable(sDeliverySql);
            cbbInvType.ValueMember = "INVTYPEID";
            cbbInvType.DisplayMember = "INVTYPENAME";

        }

        public override void GetData()
        {
            string sDeptid = txtDept.Text.Trim();
            string sCustId = txtCust.Text.Trim();
            string sBseqId = txtBseqId.Text.Trim();
            string sInvoiceno = txtInvoiceNo.Text.Trim();
            sInvTypeId = cbbInvType.SelectedValue.ToString();

            string spName = "NEIIP_FINANCE.sp_get_invoice";
            string sDateFrom = dtpDateFrom.Value.ToString("yyyyMMdd");
            string sDateTo = dtpDateTo.Value.ToString("yyyyMMdd");

            string[] sParameters = new string[8] { "anInvtypeId", "andeptid", "ancustid", "anbseqid", "aninvoicecode", "as_datefrom", "as_dateto", "aors" };

            string[] sParametersValue = new string[8] { sInvTypeId,sDeptid, sCustId, sBseqId, sInvoiceno, sDateFrom, sDateTo, "" };
            string[] sParametersType = new string[8] { "Varchar2", "Varchar2", "Varchar2", "Varchar2", "Varchar2", "Varchar2", "Varchar2", "RefCursor" };
            string[] sParametersDirection = new string[8] { "Input", "Input", "Input", "Input", "Input", "Input", "Input", "Output" };

            gridControl1.DataSource = GetDataTableBySp(spName, sParameters, sParametersValue, sParametersType, sParametersDirection);
        }

        private void btnSureList_Click(object sender, EventArgs e)
        {
            int iResult = 0;
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


                lblNote.Text = "本单位税号：" + sTaxCode + "开票机号码：" + sMachineNo.ToString() + "发票库存：" + iInvStock.ToString();
                lblInfo.Text = "开票限额：" + iInvLimit.ToString() + (iIsInvEmpty == 0 ? "，金税卡无票可开" : "，金税卡有票可开") + (iIsRepReached == 0 ? "，未到抄税期" : "，已到抄税期") + (iIsLockReached == 0 ? "，未到锁死期" : "，已到锁死期");

                btnCloseCard.Enabled = true;
                btnSureList.Enabled = false;
                txtBseqId.Enabled = true;

                btnCancled.Enabled = true;
                btnInvPrint.Enabled = true;
                btnListPrint.Enabled = true;
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
                btnListPrint.Enabled = false;

                btnCancled.Enabled = false;
                btnInvPrint.Enabled = false;
                btnQuery.Enabled = false;
                cbbInvType.Enabled = true;

            }
            else MessageBox.Show(sResultMsg);

        }

        public int InvoiceCancel(string sInvSeqid, string sUserName)
        {
            int iResult = 0;
            string spName = "EIIP_INVOICE.sp_invoice_cancel";

            string[] sParameters = new string[4] { "myReturn", "anInvseqid", "asUserName", "asErrmsg" };

            string[] sParametersValue = new string[4] { "0", sInvSeqid, Global.tUser._UserId, sRetMsg };
            string[] sParametersType = new string[4] { "Int32", "Varchar2", "Varchar2", "Varchar2" };
            string[] sParametersDirection = new string[4] { "ReturnValue", "Input", "Input", "Output" };

            iResult = int.Parse(OperData(spName, sParameters, sParametersValue, sParametersType, sParametersDirection));
            return iResult;
        }

        private void btnCancled_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iMyRetrun = 0;

            iCurrentItemId = gridView1.FocusedRowHandle;

            DataRow row = gridView1.GetDataRow(iCurrentItemId);

            iCurrentBseqId = Convert.ToString(row["INVSEQID"]);

            MyTax.InfoKind = iInfoKind;
            MyTax.InfoTypeCode = Convert.ToString(row["INVOICECODE"]); ;
            MyTax.InfoNumber = Convert.ToInt32(row["INVOICENO"]); ;

            MyTax.CancelInv();
            iResult = MyTax.RetCode;

            if (iResult == 6001) { sRetMsg = MyTax.RetCode.ToString() + " 当月发票库未找到该发票"; iMyRetrun = 1; }
            if (iResult == 6002) { sRetMsg = MyTax.RetCode.ToString() + " 该发票已作废"; iMyRetrun = 1; }
            if (iResult == 6011)
            {
                sRetMsg = MyTax.RetCode.ToString() + " 作废成功";
                InvoiceCancel(iCurrentBseqId,"");

                if (iResult ==-1) { sRetMsg =  " 业务系统作废失败" + sRetMsg; iMyRetrun = 1; }
            }
            if (iResult == 6012) { sRetMsg = MyTax.RetCode.ToString() + " 未作废"; iMyRetrun = 1; }
            if (iResult == 6013) { sRetMsg = MyTax.RetCode.ToString() + " 作废失败"; iMyRetrun = 1; }


            MessageBox.Show(sRetMsg);

        }

        private void btnInvPrint_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iRetrun = 0;
            int iInvNumber = 0;

            iCurrentItemId = gridView1.FocusedRowHandle;
            DataRow row = gridView1.GetDataRow(iCurrentItemId);
            iInvNumber = Convert.ToInt32(row["INVOICENO"]);

            MyTax.InfoKind = iInfoKind;
            MyTax.InfoTypeCode = Convert.ToString(row["INVOICECODE"]);
            MyTax.InfoNumber = iInvNumber;
            MyTax.GoodsListFlag = 0;
            MyTax.InfoShowPrtDlg = 1;

            MyTax.PrintInv();

            iResult = MyTax.RetCode;

            if ((MyTax.RetCode != 5011) && (MyTax.RetCode != 5001) && (MyTax.RetCode != 5012) && (MyTax.RetCode != 5013))
            { sRetMsg = MyTax.RetCode.ToString() + " 打印失败,其他原因！"; iRetrun = 1; }

            if (MyTax.RetCode == 5001) { sRetMsg = MyTax.RetCode.ToString() + " 未找到发票或清单"; iRetrun = 1; }
            if (MyTax.RetCode == 5011) { sRetMsg = MyTax.RetCode.ToString() + " 打印成功"; iRetrun = 0; }
            if (MyTax.RetCode == 5012) { sRetMsg = MyTax.RetCode.ToString() + " 未打印"; iRetrun = 0; }
            if (MyTax.RetCode == 5013) { sRetMsg = MyTax.RetCode.ToString() + " 打印失败"; iRetrun = 1; }

            MessageBox.Show(sRetMsg);

        }

        private void btnListPrint_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iRetrun = 0;
            int iInvNumber = 0;

            iCurrentItemId = gridView1.FocusedRowHandle;
            DataRow row = gridView1.GetDataRow(iCurrentItemId);
            iInvNumber = Convert.ToInt32(row["INVOICENO"]);

            MyTax.InfoKind = iInfoKind;
            MyTax.InfoTypeCode = Convert.ToString(row["INVOICECODE"]);
            MyTax.InfoNumber = iInvNumber;
            MyTax.GoodsListFlag = 1;
            MyTax.InfoShowPrtDlg = 1;

            MyTax.PrintInv();

            iResult = MyTax.RetCode;

            if ((MyTax.RetCode != 5011) && (MyTax.RetCode != 5001) && (MyTax.RetCode != 5012) && (MyTax.RetCode != 5013))
            { sRetMsg = MyTax.RetCode.ToString() + " 打印失败,其他原因！"; iRetrun = 1; }

            if (MyTax.RetCode == 5001) { sRetMsg = MyTax.RetCode.ToString() + " 未找到发票或清单"; iRetrun = 1; }
            if (MyTax.RetCode == 5011) { sRetMsg = MyTax.RetCode.ToString() + " 打印成功"; iRetrun = 0; }
            if (MyTax.RetCode == 5012) { sRetMsg = MyTax.RetCode.ToString() + " 未打印"; iRetrun = 0; }
            if (MyTax.RetCode == 5013) { sRetMsg = MyTax.RetCode.ToString() + " 打印失败"; iRetrun = 1; }

            MessageBox.Show(sRetMsg);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void VATInvoiceManager_Load(object sender, EventArgs e)
        {
            fLoadInvType();
        }

        private void cbbInvType_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void cbbInvType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (int.Parse(cbbInvType.SelectedValue.ToString()) == 4) iInfoKind = 2;
            if (int.Parse(cbbInvType.SelectedValue.ToString()) == 1) iInfoKind = 0;
            if (int.Parse(cbbInvType.SelectedValue.ToString()) == 2) iInfoKind = 2;
        }
    }
}
