using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EIIP.Common;

namespace EIIP.MDForm 
{
    public partial class frmSpecialDrug :fHeader
    {
        string sDseqid = "";
        public frmSpecialDrug()
        {
            InitializeComponent();
        }

        private void frmSpecialDrug_Load(object sender, EventArgs e)
        {
            btnSelected.Text = "签收";
            btnAdd.Visible = false;
            btnView.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;

            StoredProcedureName = "NEIIP_REPORT.P_SpecialDru_Recv";
        }
        public override void GetData()
        {
            gridControl1.DataSource = GetDataTable(GetQuerySql());
        }
        public override string GetQuerySql()
        {
            string sDateFrom = dtpDateFrom.Value.ToString("yyyyMMdd");
            string sDateTo = dtpDateTo.Value.ToString("yyyyMMdd");

            string sFilter = " AND to_char(A.timewritten,'YYYYMMDD') >= \'" + sDateFrom + "\' AND to_char(A.timewritten,'YYYYMMDD') <= \'" + sDateTo +"\'";
            String s_Sql =
                    " SELECT  " +
                    "             A.dseqid AS 配送单号,J.DRNAME AS 路线,rownum AS 行号,c.bseqid AS 销售单号,a.TimeWritten AS 派车日期,g.deptname AS 部门, " +
                    "             e.billdate AS 销售日期,K.CUSTNAME AS 客户名称,D.NAME AS 品名,D.SPEC AS 规格,D.FACTORY AS 产地, " +
                    "             (select serial from t_art_serial where serialid = c.serialid)  AS 批号,C.TOTAL AS 数量,             " +
                    "             (select username from t_user where userid = a.writterid)  AS 制单员, " +
                    "             h.TIMERECVSP AS 签收日期 ,i.username AS 签收人 " +
                    "  FROM  " +
                    "          t_deliver_bill A " +
                    "          LEFT JOIN t_deliver_bill_detail B " +
                    "          ON A.DSEQID = B.DSEQID " +
                    "          LEFT JOIN t_acc_bill_detail C " +
                    "          ON B.BSEQID = C.BSEQID " +
                    "          LEFT JOIN t_acc_bill_header E " +
                    "          ON B.BSEQID = E.BSEQID " +
                    "          LEFT JOIN T_ARTICLE D  " +
                    "          ON C.ARTID = D.ARTID " +
                    "          LEFT JOIN t_criterion_trait F " +
                    "          ON D.TRAITID = F.TRAITID " +
                    "          LEFT JOIN T_DEPT G  " +
                    "          ON E.DEPTID = G.DEPTID " +
                    "          LEFT JOIN T_ACC_BILL_HEADER_EXTRA H " +
                    "          ON E.BSEQID = H.BSEQID " +
                    "          LEFT JOIN T_USER I  " +
                    "          ON H.TIMESENDSPUSER = I.USERID " +
                    "          LEFT JOIN T_DELIVERY_ROUTES J  " +
                    "          ON A.DRID = J.DRID " +
                    "          LEFT JOIN T_CUST K " +
                    "          ON B.CUSTID = K.CUSTID " +
                    " WHERE (nvl(f.Specialdrugs, 0) = 1) AND  nvl(a.canceled, 0) = 0    " + sFilter;

            return s_Sql;
        }
        public override void SetParameter(int sOperMode)
        {

            if (gridView1.RowCount > 0)
            {
                string sUserId = Global.tUser._UserId;
                string guid = ((DataRowView)(gridView1.GetFocusedRow())).Row[3].ToString();
                AddParametersNames = new string[2] { "as_Bseqid", "as_UserId" };
                AddParametersValue = new string[2] { guid, sUserId };
            }

        }
        public override string Operator(int sOperMode)
        {
            SetParameter(sOperMode);
            OperData(StoredProcedureName, AddParametersNames, AddParametersValue);
            return "";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            
        }
    }
}
