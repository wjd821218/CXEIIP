using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.DAO;
using EIIP.Basic;

namespace EIIP.Basic
{
    public partial class frmSelectOtherData : Form
    {
        int intFlag = 0;
        public string sDeptId = "0";
        public frmSelectOtherData()
        {
            InitializeComponent();
        }
        public void ShowSelectData(int flag)
        {
            intFlag = flag;
            string sSQL = "";

            DataTable dtl = new DataTable();
            switch (flag)
            {
                case ComStruct.selInvType: //发票类型
                    sSQL = "SELECT INVTYPEID AS ID,INVTYPENAME AS NAME FROM T_INVOICE_TYPE ";
                    break;
                case ComStruct.selDr:     //路线
                    sSQL = "SELECT DRID AS ID,DRNAME  AS NAME FROM T_DELIVERY_ROUTES WHERE DEPTID = 2 AND NVL(VALIDATED,0) = 1";
                    break;
                case ComStruct.selBillMode:    //开票模式
                    sSQL = "SELECT INVBILLMODEID AS ID,INVBILLMODENAME AS NAME FROM T_INVOICE_BILlMODE ";
                    break;
                case ComStruct.selBuyer:    //采购员
                    sSQL = "SELECT a.userid  AS ID,b.username  AS NAME FROM t_dept_buyer a left join t_user b on a.userid = b.userid WHERE a.DEPTID = " + sDeptId;
                    break;
                case ComStruct.selSeller:    //业务员
                    sSQL = "SELECT a.userid AS ID,b.username  AS NAME  FROM t_dept_bsnuser a left join t_user b on a.userid = b.userid WHERE a.DEPTID = " + sDeptId;
                    break;
                case ComStruct.selCustomer:    //客户
                    sSQL = "SELECT CUSTID,CUSTNAME  FROM T_CUST WHERE NVL(CHECKED,0) = 1 " ;
                    break;
                case ComStruct.selArt:    //商品
                    sSQL = "SELECT ARTID,NAME  FROM T_ARTICLE WHERE NVL(CHECKED,0) = 1 ";
                    break;
            }
            dtl = GetDataBySelect(sSQL);
            gridControl1.DataSource = dtl;
            gridView1.Columns[0].Caption = "编码";
            gridView1.Columns[1].Caption = "名称";
            gridView1.Columns[2].Caption = "规格";
            gridView1.Columns[3].Caption = "产地";

            if (flag != ComStruct.selArt)
            {
                gridView1.Columns[2].Visible = false;
                gridView1.Columns[3].Visible = false;
            }
            this.Text = "选择";
            gridView1.MoveFirst();


            gridView1.Columns[0].Visible = false;
            this.ShowDialog();
        }

        private void SelectData()
        {
            string strguid = "";
            string strname = "";
            if (gridView1.RowCount > 0)
            {
                        strguid = ((DataRowView)(gridView1.GetFocusedRow())).Row["ID"].ToString();
                        strname = ((DataRowView)(gridView1.GetFocusedRow())).Row["NAME"].ToString();
                        this.Tag = strguid + "|" + strname;

                this.Close();
            }
        }
        public DataTable GetDataBySelect(string sSQL)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExeForDtl(sSQL);

                pObj_Comm.Close();

                return pDTMain;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            SelectData();
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SelectData();
            }
        }
    }
}
