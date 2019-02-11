using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.Basic;
using static EIIP.Basic.ComStruct;
using EIIP.Common;
namespace EIIP.BasicLibrary
{
    public partial class frmDept : frmBasicHeader
    {
        public Dept _Dept = new Dept();

        public frmDept()
        {
            InitializeComponent();

            operSpName = "";
            querySpName = "NEIIP_BASIC.sp_get_dept";

            sFilter = txtFilter.Text.ToString();
        }

        public override void SetOperParams()
        {
            sParameters = new string[5] { "myReturn", "anFINSEQID", "an_CAPITALTYPEID", "as_userid", "asErrmsg" };

            sParametersValue = new string[5] { "0", "", "","", "" };
            sParametersType = new string[5] { "Int32", "Varchar2", "Varchar2", "Varchar2", "Varchar2" };
            sParametersDirection = new string[5] { "ReturnValue", "Input", "Input", "Input", "Output" };

        }

        public override void SetQueryParams()
        {            
            sParameters = new string[3] { "anDeptName", "anUserId", "aors" };

            sParametersValue = new string[3] { sFilter, Global.tUser._UserId, "" };
            sParametersType = new string[3] {"Varchar2", "Varchar2", "RefCursor" };
            sParametersDirection = new string[3] { "Input", "Input","Output" };

        }

        public override int Selected()
        {            
            DataRowView row = (DataRowView)gridView1.GetFocusedRow();
            _Dept.Deptid = int.Parse(row["DEPTID"].ToString());
            _Dept.DeptName = row["DEPTNAME"].ToString();
            //_Dept.Terminated = int.Parse(row["TERMINATED"].ToString());
            _Dept.Canceled = int.Parse(row["CANCELED"].ToString());
            _Dept.Note = row["NOTES"].ToString();

            return 1;
        }
    }
}
