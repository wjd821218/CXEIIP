using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.DAO;

namespace EIIP.Business
{
    public partial class frmBaseBusiness : Form
    {
        public int iId;
        public string sFilter;

        public const int pfPrint = 0;
        public const int pfAdd = 1;
        public const int pfEdit = 2;
        public const int pfView = 3;
        public const int pfDelete = 4;
        public const int pfSave = 5;

        public string operSpName = "";
        public string querySpName = "";

        public string[] sParameters;   //参数列表
        public string[] sParametersValue;  //参数值
        public string[] sParametersType;   //参数类型

        public string[] sParametersDirection;  //参数传递方向
        public frmBaseBusiness()
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
        //查询
        public DataTable GetDataTableBySp()
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExecuteSPSursor(querySpName, sParameters, sParametersValue, sParametersType, sParametersDirection).Tables[0];

                pObj_Comm.Close();
                return pDTMain;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }
        //操作
        public string OperData()
        {
            string iResult;

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                iResult = pObj_Comm.ExecuteSP(operSpName, sParameters, sParametersValue, sParametersType, sParametersDirection);

                pObj_Comm.Close();

                return iResult;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }
    }
}
