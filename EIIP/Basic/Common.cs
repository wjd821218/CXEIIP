using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.DAO;
using System.Data;

namespace EIIP.Basic
{
    public class CommonClass
    {
        public DataTable GetDataTable(string SqlOraStr)
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExeForDtl(SqlOraStr);

                pObj_Comm.Close();
                return pDTMain;

            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }

        public void fLoadInvoiceType(ComboBox oComboBox)
        {
            string sDeliverySql =
                "SELECT INVTYPEID,INVTYPENAME FROM T_INVOICE_TYPE ";

            oComboBox.DataSource = GetDataTable(sDeliverySql);
            oComboBox.ValueMember = "INVTYPEID";
            oComboBox.DisplayMember = "INVTYPENAME";

        }
        public void fLoadDrId(ComboBox oComboBox)
        {
            string sDeliverySql =
                "SELECT DRID,DRNAME FROM t_delivery_routes WHERE DEPTID = 2 AND VALIDATED = 1";

            oComboBox.DataSource = GetDataTable(sDeliverySql);
            oComboBox.ValueMember = "DRID";
            oComboBox.DisplayMember = "DRNAME";

        }
        public void fLoadBillMode(ComboBox oComboBox)
        {
            string sDeliverySql =
                "SELECT INVBILLMODEID,INVBILLMODENAME FROM T_INVOICE_BILlMODE ";

            oComboBox.DataSource = GetDataTable(sDeliverySql);
            oComboBox.ValueMember = "INVBILLMODEID";
            oComboBox.DisplayMember = "INVBILLMODENAME";

        }
        public void fLoadBuyerId(ComboBox oComboBox,string sDeptId)
        {
            string sDeliverySql =
                "SELECT a.userid,b.username FROM t_dept_buyer a left join t_user b on a.userid = b.userid WHERE a.DEPTID = " + sDeptId;

            oComboBox.DataSource = GetDataTable(sDeliverySql);
            oComboBox.ValueMember = "USERID";
            oComboBox.DisplayMember = "USERNAME";

        }

        public void fLoadBsnUser(ComboBox oComboBox, string sDeptId)
        {
            string sDeliverySql =
                "SELECT a.userid,b.username FROM t_dept_bsnuser a left join t_user b on a.userid = b.userid WHERE a.DEPTID = " + sDeptId;

            oComboBox.DataSource = GetDataTable(sDeliverySql);
            oComboBox.ValueMember = "USERID";
            oComboBox.DisplayMember = "USERNAME";

        }
        //public void fLoadServiceList(ComboBox oComboBox)
        //{
        //    oComboBox.Items.Add("当日开");
        //    oComboBox.Items.Add("按需开");
        //}

    }
}
