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
    public partial class fStockCheck : BaseReport
    {
        public fStockCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string sDateFrom = dtpDateFrom.Value.ToString("yyyyMMdd");
            string sDateTo = dtpDateTo.Value.ToString("yyyyMMdd");

            string[] _Parameters = new string[3] { "as_datefrom", "as_dateto", "aors" };

            string[] _ParametersValue = new string[3] { sDateFrom, sDateTo, "" };
            string[] _ParametersType = new string[3] { "Varchar2", "Varchar2", "RefCursor" };
            string[] _ParametersDirection = new string[3] { "Input", "Input", "Output" };

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExecuteSPSursor("NEIIP_REPORT.P_GET_STOCK_CHECK_REPORT", _Parameters, _ParametersValue, _ParametersType, _ParametersDirection).Tables[0];
                gridControl1.DataSource = pDTMain;

                pObj_Comm.Close();
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }

        }
    }
}
