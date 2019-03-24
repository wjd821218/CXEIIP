using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.DAO;
using EIIP.Common;

namespace EIIP.Basic
{
    public partial class frmBasicSel : Form
    {
        public int iDeptid = 0;
        public string sCustid = "0";
        public string sBsnCatID = "0";
        public string sTypeID = "0";

        public string asErrmsg = "";
        public string iReturn = "";

        public string SpName = "";

        public string[] sParameters;   //参数列表
        public string[] sParametersValue;  //参数值
        public string[] sParametersType;   //参数类型

        public string[] sParametersDirection;  //参数传递方向

        public frmBasicSel()
        {
            InitializeComponent();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        public DataTable GetDataBySql(string sSql)
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExeForDtl(sSql);

                pObj_Comm.Close();

                return pDTMain;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }

        public void ShowSelectData(string sSql)
        {
            gridControl1.DataSource = GetDataBySql(sSql);
        }

        public DataTable GetDataTableBySp()
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExecuteSPSursor(SpName, sParameters, sParametersValue, sParametersType, sParametersDirection).Tables[0];

                pObj_Comm.Close();
                return pDTMain;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            Valid();

            if (iReturn == "-1")
            {
                MessageBox.Show(asErrmsg);
                this.Close();
            }
            if (iReturn == "0")
            {
                MessageBox.Show(asErrmsg);
                this.DialogResult = DialogResult.OK;
            }
            if ((iReturn != "0") &&(iReturn != "-1"))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public virtual void Valid()
        {
           // string sArtId = ((DataRowView)(gridView1.GetFocusedRow())).Row["CUSTID"].ToString();
           // ValidArtLimitType(sCustid,sArtId);
           // ValidArtLimitCustClass(sCustid, sArtId);
           // ValidArtDocExpiry(sCustid, sBsnCatID, sTypeID);
            //
        }
        public void ValidArtLimitType(string sCustid,string sArtId)
        {
            SpName = "EIIP_SALE.SP_CUST_ART_LIMIT_TYPE";
            //string sCustid = ((DataRowView)(gridView1.GetFocusedRow())).Row["CUSTID"].ToString();
            string[] sParameters = new string[3] { "result", "anCustid", "anArtid"};

            string[] sParametersValue = new string[3] { "0", sCustid, sArtId };
            string[] sParametersType = new string[3] { "Int32", "Int32", "Int32"};
            string[] sParametersDirection = new string[3] { "ReturnValue", "Input", "Input"};


            iReturn = OperData(SpName, sParameters, sParametersValue, sParametersType, sParametersDirection, out asErrmsg);

        }
        public void ValidArtLimitCustClass(string sCustid,string sArtId)
        {
            SpName = "EIIP_SALE.SP_CUST_ART_LIMIT_CUSTCLASS";            
            string[] sParameters = new string[3] { "result", "anCustid", "anArtid"};

            string[] sParametersValue = new string[3] { "0",sCustid, sArtId};
            string[] sParametersType = new string[3] { "Int32", "Int32", "Int32" };
            string[] sParametersDirection = new string[3] { "ReturnValue", "Input", "Input"};


            iReturn = OperData(SpName, sParameters, sParametersValue, sParametersType, sParametersDirection, out asErrmsg);

        }
        public void ValidArtDocExpiry(string sCustid,string sBsnCatID,string sTypeID)
        {
            SpName = "EIIP_SALE.SP_CHECK_FCUST_ART_DOC_EXPIRY";            
            string[] sParameters = new string[6] { "result", "anDeptid", "anCustid", "anBsnCatID", "anTypeID", "asErrmsg" };

            string[] sParametersValue = new string[6] {"0", Global.iDeptId.ToString(), sCustid, "1", "","" };
            string[] sParametersType = new string[6] {"Int32", "Int32", "Int32", "Int32", "Int32" ,"Varchar2" };
            string[] sParametersDirection = new string[6] {"ReturnValue", "Input", "Input" ,"Input","Input", "Output" };


            iReturn = OperData(SpName, sParameters, sParametersValue, sParametersType, sParametersDirection, out asErrmsg);

        }
        public void ValidCustDocExpiry(string sCustid,string sBsnCatID)
        {
            SpName = "eiip_quality.sp_check_cust_doc_expiry";

            string[] sParameters = new string[5] { "result", "anDeptid", "anCustid", "anBsnCatID", "asErrmsg" };

            string[] sParametersValue = new string[5] { "0", Global.iDeptId.ToString(), sCustid, sBsnCatID, "" };
            string[] sParametersType = new string[5] { "Int32", "Int32", "Int32", "Int32", "Varchar2" };
            string[] sParametersDirection = new string[5] { "ReturnValue", "Input", "Input", "Input", "Output" };


            iReturn = OperData(SpName, sParameters, sParametersValue, sParametersType, sParametersDirection, out asErrmsg);

        }
        private int OperData()
        {
            int iResult = 0;
            
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                iResult = int.Parse(pObj_Comm.ExecuteSP(SpName, sParameters, sParametersValue, sParametersType, sParametersDirection));

                pObj_Comm.Close();

                return iResult;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }            
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (iReturn == "-1")
                {
                    MessageBox.Show(asErrmsg);
                    this.Close();
                }
                if (iReturn == "0")
                {
                    MessageBox.Show(asErrmsg);
                    this.DialogResult = DialogResult.OK;
                }
                if ((iReturn != "0") && (iReturn != "-1"))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
         }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (iReturn == "-1")
            {
                MessageBox.Show(asErrmsg);
                this.Close();
            }
            if (iReturn == "0")
            {
                MessageBox.Show(asErrmsg);
                this.DialogResult = DialogResult.OK;
            }
            if ((iReturn != "0") && (iReturn != "-1"))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public string OperData(string StoredProcedureName, string[] Parameters, string[] ParametersValue, string[] ParametersType, string[] ParametersDirection,out string asErrmsg)
        {
            string iResult;

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                iResult = pObj_Comm.ExecuteSP(StoredProcedureName, Parameters, ParametersValue, ParametersType, ParametersDirection, out asErrmsg);

                pObj_Comm.Close();

                return iResult;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }
    }
}
