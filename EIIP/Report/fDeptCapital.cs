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
    public partial class fDeptCapital : BaseReport
    {
        public fDeptCapital()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sDateFrom = dtpDateFrom.Value.ToString("yyyy-MM-dd");
            string sDateTo = dtpDateTo.Value.ToString("yyyy-MM-dd");
            string sDept = "%" + txtDeptName.Text.Trim() + "%";

            string[] _Parameters = new string[4] { "as_datefrom", "as_dateto", "an_deptid", "aors" };
            string[] _ParametersValue = new string[4] { sDateFrom, sDateTo, sDept, "" };
            string[] _ParametersType = new string[4] { "Varchar2", "Varchar2", "Varchar2", "RefCursor" };
            string[] _ParametersDirection = new string[4] { "Input", "Input", "Input", "Output" };
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExecuteSPSursor("CX_SALE.cur_fin_dept_capital", _Parameters, _ParametersValue, _ParametersType, _ParametersDirection).Tables[0];
                gridControl1.DataSource = pDTMain;

                pObj_Comm.Close();
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
