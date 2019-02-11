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
    public partial class frmBasicBase : frmBase
    {
        public int iId;

        public const int pfPrint = 0;
        public const int pfAdd = 1;
        public const int pfEdit = 2;
        public const int pfView = 3;
        public const int pfDelete = 4;
        public const int pfSave = 5;


        public CommonInterface pObj_Comm;
        public DataTable dt = null;
        public DataSet ds = new DataSet();

        public OracleDataAdapter sda = null;
        
        public OracleConnection connection = new OracleConnection(CommonDataConfig.ConnectionDefaultStr);


        public frmBasicBase()
        {
            InitializeComponent();
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

        public string Operator(int sOperMode)
        {
            if (sOperMode == pfSave) { Save(); };
            return "";
        }

        public virtual string Save()
        {
            return "";
        }

        public virtual void Filter()
        {
            //
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Operator(pfSave);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            GetData();
        }

        public virtual void GetData()
        {
            //
        }
        public void DataRefresh(string sSQL,string sTable)
        {
            //CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            /*try
            {
                ds = pObj_Comm.ExeForDst(sSQL,sda);
                //sda = (OracleDataAdapter)pObj_Comm.getDataAdapter(sSQL);
                //sda.SelectCommand = (OracleCommand)pObj_Comm.GetCommand();                

                //OracleCmdBuilder cb = (OracleCmdBuilder)pObj_Comm.getCommandBuilder();

                dt = ds.Tables[0];
                //pObj_Comm.Close();

                gridControl1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
            */

            //connection = new OracleConnection(CommonDataConfig.ConnectionDefaultStr);

            if (connection.State == ConnectionState.Open) { connection.Close(); }
            ds.Clear();          

            sda = new OracleDataAdapter(
            sSQL, connection);
            OracleCommandBuilder builder = new OracleCommandBuilder(sda);
            //builder.QuotePrefix = "[";
            //builder.QuoteSuffix = "]";

            //DataSet custDS = new DataSet();           
            connection.Open();
            sda.Fill(ds, sTable);

            gridControl1.DataSource = ds.Tables[0];


        }

        private void frmBasicBase_Load(object sender, EventArgs e)
        {
            //pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
        }

        private void frmBasicBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
            connection.Dispose();
            connection = null;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
