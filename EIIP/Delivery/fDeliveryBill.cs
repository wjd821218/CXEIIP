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

namespace EIIP.Delivery
{
    public partial class fDeliveryBill : fHeader
    {
        public static string sDeliveryRouteId = "";
        public static string sDeliverId = "";
        
        public fDeliveryBill()
        {
            InitializeComponent();            
        }
        private void fLoadDelivery()
        {
            string sDeliverySql = "SELECT DRID,DRNAME FROM T_DELIVERY_ROUTES WHERE DEPTID = 2 AND NVL(VALIDATED ,0)=1  ORDER BY DRNAME";
            cbbDelivery.DataSource = GetDataTable(sDeliverySql);
            cbbDelivery.ValueMember = "DRID";
            cbbDelivery.DisplayMember = "DRNAME";
            
        }
        private void fLoadDeliver()
        {
            string sDeliverySql = "SELECT A.USERID,B.USERNAME FROM t_dept_deliver A LEFT JOIN T_USER B ON A.USERID = B.USERID WHERE A.DEPTID = 2  ORDER BY B.USERNAME";
            cbbDeliver.DataSource = GetDataTable(sDeliverySql);
            cbbDeliver.ValueMember = "USERID";
            cbbDeliver.DisplayMember = "USERNAME";

        }

        private void fDeliveryBill_Load(object sender, EventArgs e)
        {
            fLoadDelivery();
            sDeliveryRouteId= cbbDelivery.SelectedValue.ToString();
            fLoadDeliver();
            sDeliverId = cbbDeliver.SelectedValue.ToString();
        }
        public  string getXml()
        {
            string sXML = "<d>";
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                sXML = sXML + "<r>";
                sXML = sXML + "<BSEQID>" + gridView1.GetRowCellValue(i, "BSEQID").ToString() + "</BSEQID>";
                sXML = sXML + "</r>";
            }
            sXML = sXML + "</d>";
            return sXML;
        }
        public override string Operator(int sOperMode)
        {
            string sResult;
            string spName = "NEIIP_DELIVER.sp_deliver_bill_sumbit";
            string sXML =  getXml();
            string sErrmsg = "";
            string sDateTo = dtpDateTo.Value.ToString("yyyyMMdd");
            

            string[] sParameters = new string[6] { "myReturn", "anDrId", "anWRITTERID", "anUSERID", "anXmlStr", "asErrmsg"};

            string[] sParametersValue = new string[6] { "0", sDeliveryRouteId, sDeliverId, Global.tUser._UserId, sXML, sErrmsg};
            string[] sParametersType = new string[6] { "Int32", "Varchar2", "Varchar2", "Varchar2", "Varchar2", "Varchar2" };
            string[] sParametersDirection = new string[6] { "ReturnValue","Input", "Input", "Input", "Input", "Output" };

            sResult = OperData(spName, sParameters, sParametersValue, sParametersType, sParametersDirection);
            return sResult;
        }
        private  void btnQuery_Click(object sender, EventArgs e)
        {
            
        }

        public override void GetData()
        {
            string spName = "NEIIP_REPORT.P_GET_DISPATCH_BILL_REPORT";
            string sDateFrom = dtpDateFrom.Value.ToString("yyyyMMdd");
            string sDateTo = dtpDateTo.Value.ToString("yyyyMMdd");

            string[] sParameters = new string[4] { "as_deliveryId", "as_datefrom", "as_dateto", "aors" };

            string[] sParametersValue = new string[4] { sDeliveryRouteId, sDateFrom, sDateTo, "" };
            string[] sParametersType = new string[4] { "Varchar2", "Varchar2", "Varchar2", "RefCursor" };
            string[] sParametersDirection = new string[4] { "Input", "Input", "Input", "Output" };

            gridControl1.DataSource = GetDataTableBySp(spName, sParameters, sParametersValue, sParametersType, sParametersDirection);
        }

        private void cbbDelivery_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sDeliveryRouteId = cbbDelivery.SelectedValue.ToString();
            GetData();
        }

        private void cbbDeliver_SelectionChangeCommitted(object sender, EventArgs e)
        {           
            sDeliverId = cbbDeliver.SelectedValue.ToString();
        }
    }
}
