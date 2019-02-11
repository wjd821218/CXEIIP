using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.DAO;
using Oracle.DataAccess.Client;

namespace EIIP.BasicLibrary
{
    public partial class frmBasicListBase : Form
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


        public CommonInterface pObj_Comm;

        public frmBasicListBase()
        {
            InitializeComponent();
        }

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
        public virtual void Filter()
        {
            //sFilter = txtFilter.Text.ToString();

            SetQueryParams();
            gridControl1.DataSource = GetDataTableBySp();
        }


        public virtual void SetParams()
        {
            //
        }
        public virtual void SetQueryParams()
        {
            //
        }
        public virtual string Verify()
        {
            return "";
        }

        public string Operator()
        {
            string sResult = "";

            sResult = OperData(operSpName, sParameters, sParametersValue, sParametersType, sParametersDirection);
            return sResult;
        }
        public string OperData(string StoredProcedureName, string[] Parameters, string[] ParametersValue, string[] ParametersType, string[] ParametersDirection)
        {
            string iResult;

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                iResult = pObj_Comm.ExecuteSP(StoredProcedureName, Parameters, ParametersValue, ParametersType, ParametersDirection).ToString();

                pObj_Comm.Close();

                return iResult;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                gridView1.ExportToXls(filename);

                //this.ShowMessage("导出成功");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            sErrorMessage = Verify();
            if (sErrorMessage != "") MessageBox.Show(sErrorMessage, "错误");
            else
            {
                SetParams();
                if (Operator() != "0") MessageBox.Show( "错误失败！");
                else { MessageBox.Show("保存成功"); Filter(); }
            }

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            GetData();
        }

        public virtual void GetData()
        {
            //
        }

    }
}
