using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EIIP.MDForm;
using EIIP.Common;
using EIIP.DAO;
using EIIP;
using EIIP.BasicLibrary;

namespace EIIP.Delivery
{
    public partial class fRouteSite:fHeader
    {
        public DataTable pDTMain;
        public string sCurDrId;
        public fRouteSite()
        {
            InitializeComponent();
        }

        private void fRouteSite_Load(object sender, EventArgs e)
        {
            btnEdit.Visible = false;

            DataLoad();

        }

        private void DataLoad()
        {

            string SqlOraStr = "SELECT * FROM T_DELIVERY_ROUTES WHERE DEPTID = 2 AND NVL(VALIDATED,0) =1 ";

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                pDTMain = pObj_Comm.ExeForDtl(SqlOraStr);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count != 0) //&&(myDs.Tables[0] !=null)
                {
                    LoadParentTree(pDTMain);
                }
                else
                {
                    MessageBox.Show("没有菜单！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }

            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }
        private void LoadParentTree(DataTable dtTree)
        {
            tv.Nodes.Clear();
            // 获得第一级数据
            DataRow[] drRoot = dtTree.Select();
            foreach (DataRow dr in drRoot)
            {
                MyTreeNode tn = new MyTreeNode();
                tn.Text = dr["DRNAME"].ToString();
                tn.PermId = dr["DRID"].ToString();

                tv.Nodes.Add(tn);
            }
        }

        private void tv_Click(object sender, EventArgs e)
        {

        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (sender is MyTreeNode)
            {
                sCurDrId = (sender as MyTreeNode).PermId;
            }
        }
    }
}
