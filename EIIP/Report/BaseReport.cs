using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EIIP.DAO;


namespace EIIP.Report
{
    public partial class BaseReport : Form
    {
        public string MySql = "";
        public BaseReport()
        {
            InitializeComponent();
        }

        /* public string GetQuerySql()
         {
             string MySql = "";
             return MySql;
         }*/

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = GetMainData(MySql);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MySql = GetQuerySql();

            //gridControl1.DataSource = GetMainData(MySql);
        }

        private void btnExport_Click_1(object sender, EventArgs e)
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MyPrint();
        }
        public virtual void MyPrint()
        {
            ReportCenter rc = new ReportCenter(gridControl1, "盘点表", "");
            rc.Preview();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            MyDesign();
        }
        public virtual void MyDesign()
        {

        }
    }
}
