using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Reflection;
using EIIP.Common;
using EIIP.MDForm;
using EIIP.Report;
using EIIP.DAO;
using EIIP;
using EIIP.BasicLibrary;

namespace EIIP
{
    public partial class frmMain : Form
    {
        public DataTable pDTMain;
        public DataTable pDTMainL;
        //public static UserInfo tUser = new UserInfo();
        //public DataSet myDs;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DateLoad();
        }

        private void DateLoad()
        {
             string SqlOraStrL = "SELECT NVL(B.TRANSTYPEID,0) AS TID,A.TRANSTYPEID,A.TRANSTYPENAME,A.OperMode,A.Parent,A.OperContex,A.TRANSTYPECODE,A.CLASSLEVEL,NVL(A.PARENT,0) AS  PARENT " +
                           " FROM t_trans_type a, "+
                           "      (                  " +
                           "       select transtypeid    " +
                           "          from(              " +
                           "                 (select transtypeid from t_user_trans where (userid = " + Global.tUser._UserId + ")) " +
                           "                 union " +
                           "                 (select b.transtypeid from t_person_staff a, t_position_trans b where(a.postid = b.postid) and(a.personid = " + Global.tUser._UserId + ")) " +
                           "                 union " +
                           "                 (select transtypeid from t_trans_type where (nvl(stopped, 0) = 0) and(nvl(needgrant, 0) = 1) and exists(select userid from sys_administrator where userid = " + Global.tUser._UserId + " and nvl(firmid, 0) = 0)) " +
                           "               ) " +
                           "      ) b " +
                           "    WHERE(nvl(a.stopped, 0) = 0) and " +
                           "          (nvl(a.needgrant, 0) = 1) and (a.opercontex is  not null) and " +                           
                           "            (a.transtypeid = b.transtypeid) " +
                 "  ORDER BY A.CLASSLEVEL,A.TRANSTYPECODE "; 

            string SqlOraStr = "SELECT  NVL(A.TRANSTYPEID,0) AS TID,A.TRANSTYPEID,A.TRANSTYPENAME,A.OperMode,A.OperContex,A.TRANSTYPECODE,A.CLASSLEVEL,NVL(A.PARENT,0) AS  PARENT " +
                             " FROM t_trans_type a   " +
                          "    WHERE (nvl(a.stopped, 0) = 0)  " +
                             "  ORDER BY A.CLASSLEVEL,A.TRANSTYPECODE ";

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                pDTMainL = pObj_Comm.ExeForDtl(SqlOraStrL);

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
            string sParent = "0";
            //TreeView tv;//树控件
            tv.Nodes.Clear();
            // 获得第一级数据
            DataRow[] drRoot = dtTree.Select("[PARENT]=" + sParent);
            foreach (DataRow dr in drRoot)
            {
                String sTransCode = "[TRANSTYPECODE] like \'" +  dr["TRANSTYPECODE"].ToString() + "%\'";
                DataRow[] drsL = pDTMainL.Select(sTransCode);

                if (drsL.Length > 0)
                {
                    MyTreeNode tn = new MyTreeNode();
                    tn.Text = dr["TRANSTYPENAME"].ToString();
                    tn.OperContex = dr["OperContex"].ToString();
                    tn.OperMode = dr["OperMode"].ToString();
                    tn.PermId = dr["TID"].ToString();


                    AppendChild(tn, dr["TRANSTYPEID"].ToString());
                    tv.Nodes.Add(tn);
                };
                

            }
        }

        private void AppendChild(TreeNode tnParent, string varid)
        {
            
            
            DataRow[] drs = pDTMain.Select("[PARENT]=" + varid);
            
            foreach (DataRow dr in drs)
            {
                String sTransCode = dr["TRANSTYPECODE"].ToString();
                DataRow[] drsL = pDTMainL.Select("[TRANSTYPECODE] like\'" + sTransCode + "%\'");

                if (drs.Length <= 0) return;

                if (drsL.Length > 0)
                {
                    MyTreeNode tn = new MyTreeNode();
                    tn.Text = dr["TRANSTYPENAME"].ToString();
                    tn.OperContex = dr["OperContex"].ToString();
                    tn.OperMode = dr["OperMode"].ToString();
                    tn.PermId = dr["TID"].ToString();
                    tn.ParentId = dr["Parent"].ToString();

                    AppendChild(tn, dr["TRANSTYPEID"].ToString());
                    tnParent.Nodes.Add(tn);
                }
               

            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            EIIP.MDForm.fHeader mMain = new EIIP.MDForm.fHeader();

            
            mMain.TopLevel = false;
            mMain.Dock = DockStyle.Fill;
            mMain.Parent = this.panel2;
            mMain.Show();  */
            CreateForm("EIIP.MDForm.fHeader", "EIIP");

        }

        void MenuDoubleClicked(object sender, EventArgs e)
        {
            if (sender is MyTreeNode)
            {
                switch((sender as MyTreeNode).OperMode)
                { 
                case "0":
                    CreateForm("EIIP." + (sender as MyTreeNode).OperContex,"EIIP");
                    break;
                }
            }
        }
        public  void CreateForm(string strName, string AssemblyName)
        {
            //int Index = strName.LastIndexOf(".");
            //string FormName = strName.Substring(23);
           // if (!ShowChildForm(FormName, MdiParentForm))
           // {
                string path = AssemblyName;//项目的Assembly选项名称  
                string name = strName; //类的名字 
                Form doc = (Form)Assembly.Load(path).CreateInstance(name);
                doc.TopLevel = false;
                doc.Dock = DockStyle.Fill;
                doc.Parent = panel2;
                doc.BringToFront();           
                doc.Show();
           // }
        }


        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MenuDoubleClicked(e.Node, e);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tv_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MenuDoubleClicked(e.Node, e);
        }
    }
}
