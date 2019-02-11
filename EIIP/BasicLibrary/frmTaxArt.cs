using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EIIP.BasicLibrary
{
    public partial class frmTaxArt : frmBasicBase
    {
        String sFilter = "";
        public frmTaxArt()
        {
            InitializeComponent();
        }

        public override void GetData()
        {
            string sSQL = "SELECT artid,name,spec,factory,taxitem FROM T_ARTICLE WHERE TAXITEM IS NULL AND ARTID IN "+
                        "(select artid from t_acc_bill_header a left join t_acc_bill_detail b on a.bseqid = b.bseqid where a.billdate > '20180501' group by artid)";
            DataRefresh(sSQL, "T_ARTICLE");
        }



        public override void Filter()
        {
            sFilter = "";
            string sSQL = "";

            // if (txtName.Text.Trim() != "") { sFilter = sFilter + " AND ARTID IN (SELECT ARTID FROM T_ART_ALIAS  WHERE ALIASNAME LIKE '%" + txtName.Text.Trim() + "%' GROUP BY ARTID) "; }
             if (txtName.Text.Trim() != "") { sFilter = sFilter + " AND  （NAME LIKE '%" + txtName.Text.Trim() + "%' OR TO_CHAR(ARTID) ='" + txtName.Text.Trim() +"')"; }

            if (txtSpec.Text.Trim() != "") { sFilter = sFilter + " AND SPEC  LIKE '%" + txtSpec.Text.Trim() + "%' "; }

            if (txtFactory.Text.Trim() != "") { sFilter = sFilter + " AND FACTORY LIKE '%" + txtFactory.Text.Trim() + "%' "; }

            sSQL = "SELECT artid,name,spec,factory,taxitem FROM T_ARTICLE WHERE 1=1  " + sFilter;         
            DataRefresh(sSQL, "T_ARTICLE");
        }
        public override string Save()
        {
            //gridView1.UpdateCurrentRow();
            sda.Update(ds, "T_ARTICLE");
            
            //connection.Close();
            //connection.Dispose();
            //connection = null;
            MessageBox.Show("保存成功！", "正确", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

            return "";
        }
    }

}
