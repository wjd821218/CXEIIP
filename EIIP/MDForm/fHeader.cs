using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using EIIP.DAO;

namespace EIIP.MDForm
{
    public partial class fHeader : Form
    {
        public const int pfPrint = 0;
        public const int pfAdd = 1;
        public const int pfEdit = 2;
        public const int pfView = 3;
        public const int pfDelete = 4;
        public const int pfSave = 5;

        public string sFilter;
        public static DataSet myDs;
        public string StoredProcedureName; //存储过程名

        public string[] AddParametersNames;
        public object[] AddParametersValue;

        public string[] EditParametersNames;
        public object[] EditParametersValue;

        public string[] DelParametersNames;
        public object[] DelParametersValue;

        public fHeader()
        {
            InitializeComponent();
        }
        // 
        public virtual string Operator(int sOperMode)
        {
            return "";
        }
        public virtual string Operator(int sOperMode,string iFinSeqId)
        {
            return "";
        }
        public virtual void SetParameter(int sOperMode)
        {
            //
        }
        public string FillInfo()
        {
            return "";
        }
        public virtual void DataRefresh()
        {
            //
        }

        public string ViewForm()
        {
            return "";
        }

        private void fHeader_Load(object sender, EventArgs e)
        {
            sFilter = "";
        }

        private void Excel_Import()

        {
            CompositeLink complink = new CompositeLink(new PrintingSystem());

            PrintableComponentLink link = new PrintableComponentLink();

            link.Component = gridControl1;

            complink.Links.Add(link);

            complink.CreatePageForEachLink();

            complink.ExportToXlsx("file1.xlsx", new XlsxExportOptions() { ExportMode = XlsxExportMode.SingleFilePageByPage });

        }
        public DataTable GetMainData(string ps_Sql)
        {

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExeForDtl(ps_Sql);

                pObj_Comm.Close();

                return pDTMain;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }

        public bool OperData(string StoredProcedureName, string[] ParametersNames, object[] ParametersValue)
        {
            bool iResturn;

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                iResturn = pObj_Comm.ExecuteSP(StoredProcedureName, ParametersNames, ParametersValue);

                pObj_Comm.Close();

                return iResturn;
            }
            catch (Exception e)
            {
                pObj_Comm.Close();
                throw e;
            }
        }
        public string OperData(string StoredProcedureName, string[] Parameters, string[] ParametersValue, string[] ParametersType, string[] ParametersDirection)
        {
            /*string[] _Parameters = new string[4] { "as_datefrom", "as_dateto", "an_deptid", "aors" };
            string[] _ParametersValue = new string[4] { sDateFrom, sDateTo, "24", "" };
            string[] _ParametersType = new string[4] { "Varchar2", "Varchar2", "Varchar2", "RefCursor" };
            string[] _ParametersDirection = new string[4] { "Input", "Input", "Input", "Output" };
            */
            string iResult;

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                iResult = pObj_Comm.ExecuteSP(StoredProcedureName, Parameters, ParametersValue, ParametersType, ParametersDirection);

                pObj_Comm.Close();

                return iResult;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }
        public virtual string GetQuerySql()
        {
            return "";
        }
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //Excel_Import();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel文件|*.XLS|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                gridView1.ExportToXls(filename);

                //this.ShowMessage("导出成功");
            }
        }

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
        public DataTable GetDataTableBySp(string sPName,string[] _Parameters, string[] _ParametersValue, string[] _ParametersType, string[] _ParametersDirection)
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExecuteSPSursor(sPName, _Parameters, _ParametersValue, _ParametersType, _ParametersDirection).Tables[0];

                pObj_Comm.Close();
                return pDTMain;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }
        public void btnDelete_Click(object sender, EventArgs e)
        {
            Operator(pfDelete);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            GetData();
        }
        public virtual void GetData()
        {
            //
        }  

        private void btnSelected_Click(object sender, EventArgs e)
        {
            Operator(pfAdd);

            btnQuery_Click(btnQuery,null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Operator(pfAdd);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Operator(pfEdit);
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string iResult = "0" ;
            iResult = Operator(pfSave);

            if (iResult == "1")
            {
                MessageBox.Show("保存失败");
            }
            else
            {
                MessageBox.Show("保存成功！");
            }
        }
    }
}
