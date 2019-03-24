using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.Common;
using EIIP.DAO;
using Oracle.DataAccess.Client;

namespace EIIP.Basic
{
    public partial class frmSelCust : frmBasicSel
    {

        public frmSelCust()
        {
            InitializeComponent();
        }

        public override void Valid()
        {
            /* SpName = "eiip_quality.sp_check_cust_doc_expiry";
             string sCustid = ((DataRowView)(gridView1.GetFocusedRow())).Row["CUSTID"].ToString();
             string[] sParameters = new string[5] { "result","anDeptid", "anCustid", "anBsnCatID", "asErrmsg" };

             string[] sParametersValue = new string[5] {"0" ,Global.iDeptId.ToString(), sCustid, "1", ""};            
             string[] sParametersType = new string[5] { "Int32", "Int32", "Int32", "Int32", "Varchar2"};
             string[] sParametersDirection = new string[5] { "ReturnValue", "Input", "Input", "Input", "Output" };


             iReturn = OperData(SpName, sParameters, sParametersValue, sParametersType, sParametersDirection,out asErrmsg);
             */
             string sCustId = ((DataRowView)(gridView1.GetFocusedRow())).Row["CUSTID"].ToString();
            // ValidArtLimitType(sCustid,sArtId);
            // ValidArtLimitCustClass(sCustid, sArtId);
            // ValidArtDocExpiry(sCustid, sBsnCatID, sTypeID);
            ValidCustDocExpiry(sCustId,"1");
        }

    }
}
