using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Data;
using System.Windows.Forms;
using EIIP.DAO;

namespace EIIP.Common
{
    class  PublicUtility
    {
        public  static string getXmlByGridView(GridView _GridView, int sCheck)
        {
            string sXML = "<d>";
            for (int i = 0; i < _GridView.SelectedRowsCount-1; i++)
            {
                sXML = sXML + "<r>";
                sXML = "<>" + _GridView.GetRowCellValue(i, "列名").ToString() + "<>";
                sXML = sXML + "</r>";
            }
            sXML = sXML + "</d>";
            return sXML;
        }
        public static DataTable GetDataTable(string SqlOraStr)
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

        public static void  fLoadCapitalType(ComboBox oComboBox)
        {
            string sDeliverySql =
                "SELECT INVTYPEID,INVTYPENAME FROM T_INVOICE_TYPE ";

            oComboBox.DataSource = GetDataTable(sDeliverySql);
            oComboBox.ValueMember = "INVTYPEID";
            oComboBox.DisplayMember = "INVTYPENAME";

        }

        public static void fLoadDelivery(ComboBox oComboBox)
        {
            string sDeliverySql = "SELECT DRID,DRNAME FROM T_DELIVERY_ROUTES WHERE DEPTID = 2 AND NVL(VALIDATED ,0)=1  ORDER BY DRNAME";
            oComboBox.DataSource = GetDataTable(sDeliverySql);
            oComboBox.ValueMember = "DRID";
            oComboBox.DisplayMember = "DRNAME";

        }
        public static void fLoadDeliver(ComboBox oComboBox)
        {
            string sDeliverySql = "SELECT A.USERID,B.USERNAME FROM t_dept_deliver A LEFT JOIN T_USER B ON A.USERID = B.USERID WHERE A.DEPTID = 2  ORDER BY B.USERNAME";
            oComboBox.DataSource = GetDataTable(sDeliverySql);
            oComboBox.ValueMember = "USERID";
            oComboBox.DisplayMember = "USERNAME";

        }
        public static void fLoadDeptBranch(ComboBox oComboBox)
        {
            string sDeliverySql = "SELECT BRANCHID,BRANCHNAME FROM T_DEPT_BRANCH WHERE DEPTID =" + Global.iDeptId.ToString();
            oComboBox.DataSource = GetDataTable(sDeliverySql);
            oComboBox.ValueMember = "BRANCHID";
            oComboBox.DisplayMember = "BRANCHNAME";

        }
    }
}
