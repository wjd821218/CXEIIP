using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using EIIP.DAO;
using EIIP.BasicLibrary;
using EIIP;
using EIIP.Common;

namespace EIIP.PrintReport
{
    public partial class ReceiptReport : DevExpress.XtraReports.UI.XtraReport
    {
        public  string sDseqid;
        public ReceiptReport()
        {
            InitializeComponent();
        }
        public void BindFormData(DataSet ds)
        {
            this.lblNo.DataBindings.Add("Text", ds, "DSEQID"); //
            this.tabDelivery.DataBindings.Add("Text", ds, "DRNAME");
            this.lblLineNo.DataBindings.Add("Text", ds, "LINENO");
            this.lblDeliver.DataBindings.Add("Text", ds, "USERNAME"); //
            this.tabDeptName.DataBindings.Add("Text", ds, "deptname");
            this.tabCustName.DataBindings.Add("Text", ds, "CUSTNAME");
            this.tabAmount.DataBindings.Add("Text", ds, "AMOUNT");
            
            this.tabAmount1.DataBindings.Add("Text", ds, "AMOUNT1");
            
            this.tabInvType.DataBindings.Add("Text", ds, "INVTYPENAME");
            this.tabInvCode.DataBindings.Add("Text", ds, "INVOICENO");
            //this.tabWpacks.DataBindings.Add("Text", ds, "WPACKS");
        }

        private void ReceiptReport_AfterPrint(object sender, EventArgs e)
        {

        }

        private void ReceiptReport_PrintProgress(object sender, DevExpress.XtraPrinting.PrintProgressEventArgs e)
        {

        }


    }
}
