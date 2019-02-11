using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using EIIP.MDForm;
using EIIP.Common;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace EIIP.Financial
{
    public partial class frmReceivableAudit : fHeader
    {
        public  string sCapitalTypeId = "";
       
        public frmReceivableAudit()
        {
            InitializeComponent();
        }
        private void fLoadCapitalType()
        {
            string sDeliverySql = 
                "select "+
                "  t_capital_type.capitaltypeid ," +
                "  t_capital_type.capitaltypename ," +
                "  t_capital_type.isbankbill ," +
                "  t_capital_type.isbankaccount ," +
                "  t_capital_type.iscash ," +
                "  t_capital_type.ischeque ," +
                "  t_capital_type.bankid ," +
                "  t_capital_type.bankaccount ," +
                "  t_capital_type.receivable ," +
                "  t_capital_type.payable ," +
                "  t_capital_type.quickcode," +
                "  a.priority " +
                "from t_capital_type, " +
                "   t_dept_capital a  " +
              "where(t_capital_type.capitaltypeid = a.capitaltypeid) and " +
              "   (a.deptid = 1) and " +
              "   (nvl(t_capital_type.receivable, 0) = 1) " ;

            cbbCapitalType.DataSource = GetDataTable(sDeliverySql);
            cbbCapitalType.ValueMember = "CAPITALTYPEID";
            cbbCapitalType.DisplayMember = "CAPITALTYPENAME";

        }
        public string getXml()
        {
            string sXML = "<d>";
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                sXML = sXML + "<r>";
                sXML = sXML + "<BSEQID>" + gridView1.GetRowCellValue(i, "BSEQID").ToString() + "</BSEQID>";
                sXML = sXML + "</r>";
            }
            sXML = sXML + "</d>";
            return sXML;
        }
        public override string Operator(int sOperMode,string iFinSeqId)
        {
            string sResult;
            string sErrmsg = "";
            string spName = "NEIIP_FINANCE.sp_fin_uncheck_sumbit";
            string sDateTo = dtpDateTo.Value.ToString("yyyyMMdd");


            string[] sParameters = new string[5] { "myReturn", "anFINSEQID", "an_CAPITALTYPEID", "as_userid", "asErrmsg" };

            string[] sParametersValue = new string[5] { "0", iFinSeqId, sCapitalTypeId, Global.tUser._UserId, sErrmsg };
            string[] sParametersType = new string[5] { "Int32", "Varchar2", "Varchar2", "Varchar2", "Varchar2" };
            string[] sParametersDirection = new string[5] { "ReturnValue", "Input", "Input", "Input", "Output" };

            sResult = OperData(spName, sParameters, sParametersValue, sParametersType, sParametersDirection);
            return sResult;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        public override void GetData()
        {
            string spName = "NEIIP_FINANCE.sp_get_uncheck_fin";
            string sDateFrom = dtpDateFrom.Value.ToString("yyyyMMdd");
            string sDateTo = dtpDateTo.Value.ToString("yyyyMMdd");

            string[] sParameters = new string[4] { "anDeptId", "as_datefrom", "as_dateto", "aors" };

            string[] sParametersValue = new string[4] { "0", sDateFrom, sDateTo, "" };
            string[] sParametersType = new string[4] { "Varchar2", "Varchar2", "Varchar2", "RefCursor" };
            string[] sParametersDirection = new string[4] { "Input", "Input", "Input", "Output" };

            gridControl1.DataSource = GetDataTableBySp(spName, sParameters, sParametersValue, sParametersType, sParametersDirection);
        }

        private void cbbDelivery_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbbDeliver_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sCapitalTypeId = cbbCapitalType.SelectedValue.ToString();
        }

        private void frmReceivableAudit_Load(object sender, EventArgs e)
        {
            fLoadCapitalType();
            cbbCapitalType.SelectedValue = 323;
            sCapitalTypeId = cbbCapitalType.SelectedValue.ToString();
        }


        string GetSelectedRows()
        {
            string ret = "";
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                if (ret != "") ret += "\r\n";
                ret +=  row["FINSEQID"].ToString();
            }            
            return ret;
        }

        private void btnSureList_Click(object sender, EventArgs e)
        {
            string iResult = "0";

            if (gridView1.SelectedRowsCount <= 0) MessageBox.Show("没有被选中的记录，请检查！");
            else
            {
                foreach (int i in gridView1.GetSelectedRows())
                {
                    DataRow row = gridView1.GetDataRow(i);

                    //MessageBox.Show(row["FINSEQID"].ToString());
                    iResult = Operator(pfSave, row["FINSEQID"].ToString());
                   
                    if (iResult == "1")
                    {
                        MessageBox.Show("保存失败");
                        break;

                    }

                    //    row.Delete();
                    //gridView1.DeleteRow(i);
                }

                MessageBox.Show("保存成功！");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetSelectedRows());
        }

        private void btnQuery_Click_1(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "MEDIATYPE")
            {
                GridCellInfo sGridCellInfo = e.Cell as GridCellInfo;
                if (sGridCellInfo.IsDataCell && int.Parse(sGridCellInfo.CellValue.ToString()) != 0)
                {                    
                    e.Appearance.BackColor = Color.Red;                    
                    
                }
            }
                
         }
    }
}
