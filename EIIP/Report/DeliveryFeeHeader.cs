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
using System.Configuration;
using Oracle.DataAccess.Client;

namespace EIIP.Report
{
    public partial class DeliveryFeeHeader : BaseReport
    {
        public DeliveryFeeHeader()
        {
            InitializeComponent();
        }


        private  void button1_Click(object sender, EventArgs e)
        {
            string sDateFrom = dtpDateFrom.Value.ToString("yyyyMMdd");
            string sDateTo = dtpDateTo.Value.ToString("yyyyMMdd");

            string[] _Parameters = new string[4] { "as_datefrom", "as_dateto", "an_deptid", "aors" };
            string[] _ParametersValue = new string[4] { sDateFrom, sDateTo, "24",""};            
            string[] _ParametersType = new string[4] { "Varchar2", "Varchar2", "Varchar2", "RefCursor" };
            string[] _ParametersDirection = new string[4] { "Input", "Input", "Input", "Output" };

 
     /*                          
                      try
                      {
                          OracleConnection _connObj = new OracleConnection(ConfigurationSettings.AppSettings["ConnStr"]);
                          _connObj.Open();
                          OracleCommand _cmdObj = _connObj.CreateCommand();
                          _cmdObj.CommandText = "CX_SALE.cur_fin_fee_sum";
                          _cmdObj.CommandType = CommandType.StoredProcedure;

                          OracleParameter _refParam1 = new OracleParameter();
                          _refParam1.ParameterName = "as_datefrom";
                          _refParam1.OracleDbType = OracleDbType.Varchar2;
                          _refParam1.Direction = ParameterDirection.Input;
                          _refParam1.Value = "20170701";
                          _cmdObj.Parameters.Add(_refParam1);

                          OracleParameter _refParam2 = new OracleParameter();
                          _refParam2.ParameterName = "as_dateto";
                          _refParam2.OracleDbType = OracleDbType.Varchar2;
                          _refParam2.Direction = ParameterDirection.Input;
                          _refParam1.Value = "20170710";
                          _cmdObj.Parameters.Add(_refParam2);

                          OracleParameter _refParam3 = new OracleParameter();
                          _refParam3.ParameterName = "an_deptid";
                          _refParam3.OracleDbType = OracleDbType.Varchar2;
                          _refParam3.Direction = ParameterDirection.Input;
                          _refParam3.Value = "24";
                          _cmdObj.Parameters.Add(_refParam3);

                          OracleParameter _refParam = new OracleParameter();
                          _refParam.ParameterName = "aors";
                          _refParam.OracleDbType = OracleDbType.RefCursor;
                          _refParam.Direction = ParameterDirection.Output;
                          _cmdObj.Parameters.Add(_refParam);

                           OracleDataAdapter _adapterObj = new OracleDataAdapter(_cmdObj);
                          DataSet _datasetObj = new DataSet();
                          _adapterObj.Fill(_datasetObj);
                          gridControl1.DataSource = _datasetObj.Tables[0];
                         
                          _connObj.Close();
                          _connObj.Dispose();
                          _connObj = null;

                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.ToString());
                      }


            */          
                CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
                try
                {
                    DataTable pDTMain = pObj_Comm.ExecuteSPSursor("CX_SALE.cur_fin_fee_sum", _Parameters, _ParametersValue, _ParametersType, _ParametersDirection).Tables[0];
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
