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

namespace EIIP.MDForm
{
    public partial class DeptFeeConfig : EIIP.MDForm.fHeader
    {
        public DeptFeeConfig()
        {
            InitializeComponent();
        }
        public new string Operator(int sOperMode)
        {
            if (sOperMode == pfAdd || sOperMode == pfEdit)
            {
                DeptFeeConfigInfo fDeptFeeConfigInfo = new DeptFeeConfigInfo();
                fDeptFeeConfigInfo.ShowDialog();
            }

            if (sOperMode == pfEdit)
            {
                FillInfo();
            }

            SetParameter(sOperMode);

            OperData(StoredProcedureName, AddParametersNames, AddParametersValue);

            return "";
        }
        public new void SetParameter(int sOperMode)
        {
            if (gridView1.RowCount > 0)
            {
                //int intRow = gridView1.GetSelectedRows()[0];
                //((DataRowView)(gridView1.GetFocusedRow())).Row.get
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[0].ToString();
            }
        }
        public new string FillInfo()
        {
            return "";
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {

        }
        public override string GetQuerySql()
        {
            //string s_Sql = "select artid as 编码,name as 名称 from t_article ";
            String s_Sql =
            "SELECT " +
            "       A.DEPTID AS 产品线编码,D.DEPTNAME AS 产品线名称," +
            "       B.CLASSID  AS 类别编码,B.CLASSNAME AS 客户类别," + 
            "       C.TAKEMETHODID AS ,C.TAKEMETHODNAME " +
            "FROM T_DEPT_CUST_FEE_CONFIG A " +
            "   LEFT JOIN T_CUST_CLASS B ON A.CUSTCLASSID = B.CLASSID " +
            "   LEFT JOIN t_take_method c on a.deliverytype = C.TAKEMETHODID " +
            "   LEFT JOIN T_DEPT D ON A.DEPTID = D.DEPTID " +
            "WHERE 1=1 " + sFilter;
            return s_Sql;
        }

        public new void btnDelete_Click(object sender, EventArgs e)
        {
            //
        }
        public new void toolStripButton1_Click(object sender, EventArgs e)
        {
            //
        }

        private void DeptFeeConfig_Load(object sender, EventArgs e)
        {
            StoredProcedureName = "";
            btnSelected.Text = "签收";
        }

        private void btnQuery_Click_1(object sender, EventArgs e)
        {

        }
    }
}
