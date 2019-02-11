using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.Basic;
using EIIP.Common;

namespace EIIP.BasicLibrary
{
    public partial class frmDeptCustAdd : frmBasicListBase
    {
        public int iDeptId = 0;
        public string sDeptName = "";
        public int iInvTypeId = 0;
        public int iDrId = 0;
        public int iBillMode = 0;
        public int iBuyerId = 0;
        public int iSellerId = 0;
        public int iUserId = 0;
        CommonClass oCommon = new CommonClass();

        public frmDeptCustAdd()
        {
            InitializeComponent();

            querySpName = "NEIIP_BASIC.sp_get_cust_unadd";
            operSpName = "NEIIP_BASIC.sp_deptcust_add_sumbit";

            oCommon.fLoadInvoiceType(cbbInvType);
            oCommon.fLoadDrId(cbbDrName);
            oCommon.fLoadBillMode(cbbBillMode);
            oCommon.fLoadBuyerId(cbbBuyer, iDeptId.ToString());
            oCommon.fLoadBsnUser(cbbBsnUser, iDeptId.ToString());
            //oCommon.fLoadDrId(cbbSeller);


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            frmSelectOtherData ofrmSelectOtherData = new frmSelectOtherData();
            ofrmSelectOtherData.sDeptId = iDeptId.ToString();
            ofrmSelectOtherData.ShowSelectData(ComStruct.selBuyer);
            if (ofrmSelectOtherData.Tag != null)
            {
                string[] arrValue = ofrmSelectOtherData.Tag.ToString().Split('|');

                if (arrValue.Length > 0)
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "CUSTID", arrValue[0]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "CUSTNAME", arrValue[1]);
                }
            }
        }

        private void txtDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                frmDept ofrmDept = new frmDept();
                ofrmDept.Select(txtDept.Text.Trim());
                ofrmDept.gridView1.MoveFirst();

                if (ofrmDept.ShowDialog(this) == DialogResult.OK)
                {
                    iDeptId = ofrmDept._Dept.Deptid;
                    sDeptName = ofrmDept._Dept.DeptName;
                    txtDept.Text = sDeptName;
                }

            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                gridView1.SetRowCellValue(i, "BUYERID", cbbBuyer.SelectedValue);
                gridView1.SetRowCellValue(i, "BUYER", cbbBuyer.Text.Trim());

                gridView1.SetRowCellValue(i, "SELLERID", cbbSeller.SelectedValue);
                gridView1.SetRowCellValue(i, "SELLER", cbbSeller.Text.Trim());

                gridView1.SetRowCellValue(i, "USERID", cbbBsnUser.SelectedValue);
                gridView1.SetRowCellValue(i, "USERNAME", cbbBsnUser.Text.Trim());

                gridView1.SetRowCellValue(i, "DRID", cbbDrName.SelectedValue);
                gridView1.SetRowCellValue(i, "DRNAME", cbbDrName.Text.Trim());

                gridView1.SetRowCellValue(i, "INVTYPEID", cbbInvType.SelectedValue);
                gridView1.SetRowCellValue(i, "INVTYPENAME", cbbInvType.Text.Trim());

                gridView1.SetRowCellValue(i, "BILLMODEID", cbbBillMode.SelectedValue);
                gridView1.SetRowCellValue(i, "BILLMODE", cbbBillMode.Text.Trim());
            }
        }
        private string GetXml()
        {
            string sXML = "<d>";

            foreach (int i in gridView1.GetSelectedRows())
            {
                sXML = sXML + "<r>";
                DataRow row = gridView1.GetDataRow(i);
                sXML = sXML + "<DEPTID>" + iDeptId.ToString() + "</DEPTID>";
                sXML = sXML + "<CUSTID>" + row["CUSTID"].ToString() + "</CUSTID>";
                sXML = sXML + "<SALERUSERID>" + row["USERID"].ToString() + "</SALERUSERID>";
                //sXML = sXML + "<SALERUSERID>" + row["USERID"].ToString() + "</SALERUSERID>";
                sXML = sXML + "<ISSUPPLIER>" + row["ISSUPPLIER"].ToString() + "</ISSUPPLIER>";
                sXML = sXML + "<ISCUSTOMER>" + row["ISCUSTOMER"].ToString() + "</ISCUSTOMER>";
                sXML = sXML + "<NOTES>" + "N" + "</NOTES>";
                sXML = sXML + "<USERID>" + row["SELLERID"].ToString() + "</USERID>";
                sXML = sXML + "<BRANCHID>" + row["BRANCHID"].ToString() + "</BRANCHID>";
                sXML = sXML + "<DRID>" + row["DRID"].ToString() + "</DRID>";
                sXML = sXML + "<LIMITPRICETYPEID>" + row["LIMITPRICETYPEID"].ToString() + "</LIMITPRICETYPEID>";
                sXML = sXML + "<INVTYPEID>" + row["INVTYPEID"].ToString() + "</INVTYPEID>";
                sXML = sXML + "<PAYTYPEID>" + row["PAYTYPEID"].ToString() + "</PAYTYPEID>";
                sXML = sXML + "<INVBILLINGMODE>" + row["BILLMODEID"].ToString() + "</INVBILLINGMODE>";
                sXML = sXML + "<BUYERID>" + row["BUYERID"].ToString() + "</BUYERID>";
                sXML = sXML + "<SERVICELIST>" + row["SERVICELIST"].ToString() + "</SERVICELIST>";

                sXML = sXML + "</r>";

            }
            sXML = sXML + "</d>";
            return sXML;

        }
        private void txtCust_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (iDeptId != 0 && sDeptName != "")
                {
                    sFilter = txtCust.Text.Trim().ToUpper();
                    Filter();
                }  
                else              
                MessageBox.Show("没有选择业务部门！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

            }
        }

        public override void SetParams()
        {
            string sXml = GetXml();
            //string myReturn = "";
            sParameters = new string[5] { "myReturn","anOperType", "anDetailXml", "as_userid", "asErrmsg" };

            sParametersValue = new string[5] { "0","pfAdd", sXml,Global.tUser._UserId.ToString(),"" };
            sParametersType = new string[5] { "Int32", "Varchar2", "Varchar2", "Varchar2", "Varchar2" };
            sParametersDirection = new string[5] { "ReturnValue", "Input", "Input", "Input", "Output" };
        }

        public override void SetQueryParams()
        {
            sParameters = new string[4] { "anDeptid", "anUserId", "anCustName", "aors" };

            sParametersValue = new string[4] { iDeptId.ToString(), Global.tUser._UserId.ToString(), sFilter, "" };
            sParametersType = new string[4] { "Varchar2", "Varchar2", "Varchar2", "RefCursor" };
            sParametersDirection = new string[4] { "Input", "Input", "Input", "Output" };
        }

        private void itemCbbBuyer_Click(object sender, EventArgs e)
        {

            frmSelectOtherData ofrmSelectOtherData = new frmSelectOtherData();
            ofrmSelectOtherData.sDeptId = iDeptId.ToString();
            ofrmSelectOtherData.ShowSelectData(ComStruct.selBuyer);
            if (ofrmSelectOtherData.Tag != null)
            {
                string[] arrValue = ofrmSelectOtherData.Tag.ToString().Split('|');

                if (arrValue.Length > 0)
                {

                    DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                    //DataRow row = (DataRow)gridView1.GetFocusedRow();
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BUYERID", arrValue[0]);
                    //row["BUYERID"] = arrValue[0];
                    //row["BUYER"] = arrValue[1];
                    //gridView1.UpdateCurrentRow();
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BUYER", arrValue[1]);


                }
            }
        }

        private void itemTxtBuyer_Click(object sender, EventArgs e)
        {
            frmSelectOtherData ofrmSelectOtherData = new frmSelectOtherData();
            ofrmSelectOtherData.sDeptId = iDeptId.ToString();
            ofrmSelectOtherData.ShowSelectData(ComStruct.selBuyer);
            if (ofrmSelectOtherData.Tag != null)
            {
                string[] arrValue = ofrmSelectOtherData.Tag.ToString().Split('|');
                if (arrValue.Length > 0)
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BUYERID", arrValue[0]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BUYER", arrValue[1]);
                    
                }
            }
            

        }
        private void selectData(int iType,string sId,string sName)
            {
            frmSelectOtherData ofrmSelectOtherData = new frmSelectOtherData();
            ofrmSelectOtherData.sDeptId = iDeptId.ToString();
            ofrmSelectOtherData.ShowSelectData(iType);
            if (ofrmSelectOtherData.Tag != null)
            {
                string[] arrValue = ofrmSelectOtherData.Tag.ToString().Split('|');
                if (arrValue.Length > 0)
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, sId, arrValue[0]);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, sName, arrValue[1]);
                }
            }
        }
        private void itemTxtDrName_Click(object sender, EventArgs e)
        {
            selectData(ComStruct.selDr, "DRID", "DRNAME");
        }

        private void itemTxtInvType_Click(object sender, EventArgs e)
        {
            selectData(ComStruct.selInvType, "INVTYPEID", "INVTYPENAME");
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            /*
            if (e.Column.FieldName == "BILLMODEID")
            {
                if (e.Value != null)
                {
                    switch (e.Value.ToString().Trim())
                    {
                        case "1":
                            e.DisplayText = "指定日期";
                            break;
                        case "0":
                            e.DisplayText = "随货同行";
                            break;
                        default:
                            e.DisplayText = "随货同行";
                            break;
                    }
                }
            }*/
        }

        private void ItemTxtBillMode_Click(object sender, EventArgs e)
        {
            selectData(ComStruct.selBillMode, "BILLMODEID", "BILLMODE");
        }
    }
}
