using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Data;

namespace EIIP.Common
{
    class  PublicUtility
    {
        public  static string getXmlByGridView(GridView _GridView, int sCheck)
        {
            string sXML = "<d>";
            for (int i = 0; i < _GridView.SelectedRowsCount-1; i++)
            {
                sXML = sXML + "<r>";
                sXML = "<>" + _GridView.GetRowCellValue(i, "列名").ToString() + "<>";
                sXML = sXML + "</r>";
            }
            sXML = sXML + "</d>";
            return sXML;
        }
    }
}
