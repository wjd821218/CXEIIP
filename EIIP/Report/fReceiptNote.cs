using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraReports.UI;
using EIIP.DAO;
using EIIP.Common;

namespace EIIP.Report
{
    public partial class fReceiptNote : BaseReport
    {
        DataSet Print_DataSet = new DataSet();
        string frmName = "ReceiptReport";
        string sDseqid = "";
        public fReceiptNote()
        {
            InitializeComponent();
        }

         public override void  MyPrint()
        {

            if (gridView1.RowCount > 0)
            {
                sDseqid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
            }
            string[] _Parameters = new string[2] { "as_dseqid", "aors" };

            string[] _ParametersValue = new string[2] {sDseqid, "" };
            string[] _ParametersType = new string[2] { "Varchar2", "RefCursor" };
            string[] _ParametersDirection = new string[2] { "Input",  "Output" };

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                Print_DataSet = pObj_Comm.ExecuteSPSursor("NEIIP_REPORT.cur_receipt_note", _Parameters, _ParametersValue, _ParametersType, _ParametersDirection);
                pObj_Comm.Close();
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }


            //Print_DataSet = EIIP.Common.uDao.getDataSet(mysql);                       
            string dir = Directory.GetCurrentDirectory() + @"\" + frmName + ".repx";
            if (File.Exists(dir))
            {
                EIIP.PrintReport.ReceiptReport report = new EIIP.PrintReport.ReceiptReport();
                report.LoadLayout(dir);
                report.Report.DataSource = Print_DataSet;
                report.BindFormData(Print_DataSet);
                report.sDseqid = sDseqid;

                report.PrintingSystem.EndPrint +=  new System.EventHandler(this.UpdatePrintCount);
                // DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new Dxperience.LocalizationCHS.DxperienceXtraPrintingLocalizationCHS();
                report.ShowPreview();
            }
        }
        public void UpdatePrintCount(object sender, EventArgs e)
        {
            string SqlOraStr = "UPDATE T_DELIVER_BILL SET NOTEPRINTCOUNT =NVL(NOTEPRINTCOUNT,0) + 1,NOTEPRINTUID = " + Global.tUser._UserId + ",NOTETIMEPRINT = SYSDATE WHERE DSEQID =" + sDseqid;

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                pObj_Comm.Execute(SqlOraStr);

                pObj_Comm.Close();
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }
        public override void MyDesign()
        {
            EIIP.PrintReport.ReceiptReport report = new EIIP.PrintReport.ReceiptReport();
            report.ShowDesigner();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sDateFrom = dtpDateFrom.Value.ToString("yyyyMMdd");
            string sDateTo = dtpDateTo.Value.ToString("yyyyMMdd");

            string[] _Parameters = new string[3] { "as_datefrom", "as_dateto", "aors" };

            string[] _ParametersValue = new string[3] { sDateFrom, sDateTo, "" };
            string[] _ParametersType = new string[3] { "Varchar2", "Varchar2", "RefCursor" };
            string[] _ParametersDirection = new string[3] { "Input", "Input", "Output" };

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExecuteSPSursor("NEIIP_REPORT.P_GET_DISPATCH_RECORD", _Parameters, _ParametersValue, _ParametersType, _ParametersDirection).Tables[0];
                gridControl1.DataSource = pDTMain;

                pObj_Comm.Close();
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }

        }
    }
}
