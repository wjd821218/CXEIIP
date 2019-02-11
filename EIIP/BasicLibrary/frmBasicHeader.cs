using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.DAO;

namespace EIIP.BasicLibrary
{
    public partial class frmBasicHeader : Form
    {
        public int iId;
        public string sFilter;

        public const int pfPrint = 0;
        public const int pfAdd = 1;
        public const int pfEdit = 2;
        public const int pfView = 3;
        public const int pfDelete = 4;
        public const int pfSave = 5;

        public string operSpName = "";
        public string querySpName = "";

        public string[] sParameters;   //参数列表
        public string[] sParametersValue;  //参数值
        public string[] sParametersType;   //参数类型
        public string[] sParametersDirection;  //参数传递方向

        public virtual void Select(string Filter)
        {
            txtFilter.Text = Filter;
            sFilter = Filter;
            SetQueryParams();
            GetData();
            gridView1.Focus();
        }

        public frmBasicHeader()
        {
            InitializeComponent();
            //GetData();


        }
        public void GetData()
        {
            SetQueryParams();
            gridControl1.DataSource = GetDataTableBySp();

        }
        public DataTable GetDataTableBySp()
        {
            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExecuteSPSursor(querySpName, sParameters, sParametersValue, sParametersType, sParametersDirection).Tables[0];

                pObj_Comm.Close();
                return pDTMain;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }

        public virtual void SetOperParams()
        {
            //
        }

        public virtual void SetQueryParams()
        {
            //
        }
        public string OperData()
        {
            string iResult;

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                iResult = pObj_Comm.ExecuteSP(operSpName, sParameters, sParametersValue, sParametersType, sParametersDirection);

                pObj_Comm.Close();

                return iResult;
            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }

        public virtual int Selected()
        {
            //iId =
            return 1; 
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Filter();
            }
        }

        public virtual void Filter()
        {
            sFilter = txtFilter.Text.ToString();

            SetQueryParams();
            GetData();
        }
        private void btnSelected_Click(object sender, EventArgs e)
        {
            btnSelect_Click(this, new EventArgs());
            DialogResult = DialogResult.OK;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Selected();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            btnSelect_Click(this, new EventArgs());
            DialogResult = DialogResult.OK;
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSelect_Click(this, new EventArgs());
                DialogResult = DialogResult.OK;
            }
        }
    }
}
