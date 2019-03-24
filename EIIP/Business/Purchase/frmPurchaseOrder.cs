 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.Basic;
using EIIP;
using EIIP.Common;
namespace EIIP.Business.Purchase
{
    public partial class frmPurchaseOrder : frmBaseBusiness
    {
        string iCustId;
        public frmPurchaseOrder()
        {
            InitializeComponent();            
        }

        private DataTable IniBindTable()
        {
            DataTable _dt = new DataTable();
            DataColumn _datacol1 = new DataColumn("ARTID");
            DataColumn _datacol2 = new DataColumn("NAME");
            DataColumn _datacol3 = new DataColumn("SPEC");
            DataColumn _datacol4 = new DataColumn("FACTORY");
            DataColumn _datacol5 = new DataColumn("Unit");
            DataColumn _datacol6 = new DataColumn("TOTAL");
            DataColumn _datacol7 = new DataColumn("PRICE");
            DataColumn _datacol8 = new DataColumn("AMOUNT");
            DataColumn _datacol9 = new DataColumn("TAXRATE");
            DataColumn _datacol10 = new DataColumn("PACKAGE");
            DataColumn _datacol11 = new DataColumn("PACKAGECOUNT");
            DataColumn _datacol12 = new DataColumn("COSTPRICE");
            DataColumn _datacol13 = new DataColumn("SETTLEPRICE");

            _dt.Columns.Add(_datacol1);
            _dt.Columns.Add(_datacol2);
            _dt.Columns.Add(_datacol3);
            _dt.Columns.Add(_datacol4);
            _dt.Columns.Add(_datacol5);
            _dt.Columns.Add(_datacol6);
            _dt.Columns.Add(_datacol7);
            _dt.Columns.Add(_datacol8);
            _dt.Columns.Add(_datacol9);
            _dt.Columns.Add(_datacol10);
            _dt.Columns.Add(_datacol11);
            _dt.Columns.Add(_datacol12);
            _dt.Columns.Add(_datacol13);

            return _dt;
        }
        private void txtCust_DoubleClick(object sender, EventArgs e)
        {
            GetCust();
        }
        private void GetCust()
        {
            string sFilter = txtCust.Text.Trim();
            string sFilterSql =
                "SELECT A.CUSTID,B.CUSTNAME FROM T_DEPT_CUST A " +
                "LEFT JOIN T_CUST B ON A.CUSTID = B.CUSTID " +
                "LEFT JOIN(SELECT CUSTID, wm_concat(ALIASNAME) AS ALIASNAME FROM T_CUST_ALIAS GROUP BY CUSTID) C " +
                "ON A.CUSTID = C.CUSTID " +
                "WHERE A.ISSUPPLIER = 1 AND A.DEPTID = " + Global.iDeptId.ToString() +
                 "      AND(B.CUSTNAME LIKE '%" + sFilter + "% ' OR C.ALIASNAME LIKE '%" + sFilter + "%') ";

            if (txtCust.Text.Trim() != "")
            {
                frmSelCust ofrmSelCust = new frmSelCust();
                ofrmSelCust.ShowSelectData(sFilterSql);
                ofrmSelCust.ShowDialog(this);

                if (ofrmSelCust.DialogResult == DialogResult.OK)
                {
                    iCustId = ((DataRowView)(ofrmSelCust.gridView1.GetFocusedRow())).Row["CUSTID"].ToString();
                    txtCust.Text = ((DataRowView)(ofrmSelCust.gridView1.GetFocusedRow())).Row["CUSTNAME"].ToString();

                }
            }
        }

        private void txtCust_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                GetCust();
            }
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            PublicUtility.fLoadDeptBranch(cbbDept);
            gridControl1.DataSource = IniBindTable();
        }

        private void txtArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sFilter = txtArt.Text.Trim();
            string sFilterSql =
            "SELECT " +
            "    a.artid,a.name,a.spec,a.factory,a.unit,b.stopin, a.taxrate," +
            "    a.custid as artcustid,a.validated as artvalidated,b.validated as deptvalidated, " +
            "    e.lastprice,e.minprice, " +
            "    (select minsaleprice from t_dept_art_sale_policy where deptid =" + Global.iDeptId.ToString() + " artid = a.artid) as minsaleprice, " +
            "    (select lastprice from t_dept_art_buy_policy where deptid =" + Global.iDeptId.ToString() + " artid = a.artid) as lastprice, " +
            "    (select lastprice from t_dept_art_buy_policy where deptid =" + Global.iDeptId.ToString() + " artid = a.artid) as lastprice, " +
            "    (select min(tenderprice) from t_tender_art_price where artid = a.artid) as tenderprice,d.PACKQUANTITIES, " +
            "    0 as xz " +
            "FROM(" +
            "            (select artid from t_article where ('%' = '"+ sFilter +" ') or instr(name, '"+ sFilter +"% ') > 0) " +
            "            union " +
            "            (select distinct artid from t_art_alias where ('%' = '"+ sFilter +"') or instr(aliasname, '"+ sFilter +"') > 0) " +
            "        ) c, " +
            "        t_article a, " +
            "        t_dept_art  b, " +
            "        (" +
            "            select a.custid,min(a.custname) custname,min(a.nickname) nickname " +
            "            from t_cust a, t_cust_alias b " +
            "            where a.custid = b.custid(+) and " +
            "                ('%' = '"+ sFilter  +"' or instr(a.custname, '"+ sFilter +"') > 0 or instr(a.nickname, '"+ sFilter +"') > 0 or instr(b.aliasname, '"+ sFilter +"') > 0) " +
            "            group by a.custid " +
            "        ) cust ," +
            "        (SELECT ARTID,PACKQUANTITIES FROM T_ART_PACK WHERE NVL(CANCELED,0) = 1 AND ROWNUM = 1) d ," +
            "        t_dept_art  e " +
            "WHERE(b.artid = a.artid)and " +
            "        (a.artid = c.artid) and " +
            "        (a.artid = d.artid) and " +
            "        (a.artid = e.artid) and (b.deptid = e.deptid) and e.custid =" + iCustId + " and "+
            "        (nvl(a.checked, 0) = 1 and nvl(b.checked, 0) = 1) and " +
            "            (a.custid = cust.custid) and " +
            "            (b.deptid = "+ Global.iDeptId.ToString() +")  " +
            "order by a.name ";


            if (txtArt.Text.Trim() != "")
            {
                frmSelArt ofrmSelArt = new frmSelArt();
                ofrmSelArt.ShowSelectData(sFilterSql);
                ofrmSelArt.ShowDialog(this);

                if (ofrmSelArt.DialogResult == DialogResult.OK)
                {
                    gridView1.AddNewRow();     
                    int newRowHandle = gridView1.FocusedRowHandle;
   
                    gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[0], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["ARTID"].ToString());
                    gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[1], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["NAME"].ToString());
                    gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[2], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["SPEC"].ToString());
                    gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[3], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["FACTORY"].ToString());
                    gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[4], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["UNIT"].ToString());
                    //gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[5], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["TOTAL"].ToString());
                    //gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[6], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["PRICE"].ToString());
                    //gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[7], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["AMOUNT"].ToString());
                    gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[8], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["TAXRATE"].ToString());
                    gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[9], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["PACKQUANTITIES"].ToString());
                    //gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[10], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["PACKAGECOUNT"].ToString());
                    //gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[11], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["COSTPRICE"].ToString());
                    //gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[12], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["SETTLEPRICE"].ToString());
                    //gridView1.SetRowCellValue(newRowHandle, gridView1.Columns[13], ((DataRowView)(ofrmSelArt.gridView1.GetFocusedRow())).Row["ARTID"].ToString());

                    gridView1.UpdateCurrentRow();
                }
            }
        }
    }
}
