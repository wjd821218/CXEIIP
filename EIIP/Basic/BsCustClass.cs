using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EIIP.MDForm;

namespace EIIP.Basic
{
    public partial class BsCustClass : fHeader
    {
        public BsCustClass()
        {
            InitializeComponent();
        }

        private void BsCustClass_Load(object sender, EventArgs e)
        {

        }
        public new string GetQuerySql()
        {
            //string s_Sql = "select artid as 编码,name as 名称 from t_article ";
            String s_Sql =
            "SELECT " +           
            "       B.CLASSID  AS 类别编码,B.CLASSNAME AS 客户类别" +
            "FROM T_CUST_CLASS " +
            "   WHERE 1=1 " + sFilter;
            return s_Sql;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
