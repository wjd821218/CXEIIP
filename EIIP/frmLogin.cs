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
using System.Security.Cryptography;
using EIIP.DAO;
using EIIP.Common;
using Microsoft.Win32;

namespace EIIP
{
    public partial class frmLogin : Form
    {
        EIIP.Common.uDao LoginDao = new EIIP.Common.uDao();
        public static DataSet myDs;
        //public static UserInfo tUser ;
        //UserInfo tUser = new UserInfo();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            String sUserCode = txtUser.Text.Trim();
            string sPassWord = MD5(txtPwd.Text.Trim()).ToLower();
            string SqlOraStr = "SELECT USERID,USERNAME FROM T_USER A WHERE USERCODE = '" + sUserCode + "' AND PASSWORD ='" + sPassWord + "'";

            CommonInterface pObj_Comm = CommonFactory.CreateInstance(CommonData.Oracle);
            try
            {
                DataTable pDTMain = pObj_Comm.ExeForDtl(SqlOraStr);

                pObj_Comm.Close();

                if (pDTMain.Rows.Count != 0) //&&(myDs.Tables[0] !=null)
                {
                    //this.Parent.Container.Add(new frmMain());
                    frmMain mMain = new frmMain();
                    Global.tUser._UserId = pDTMain.Rows[0]["USERID"].ToString();
                    Global.tUser._UserName = pDTMain.Rows[0]["USERNAME"].ToString();
                    mMain.Show();
                    this.Hide();
                    RegistryKey regkey = Registry.CurrentUser.CreateSubKey("EiipInfo");
                    regkey.SetValue("UserName", sUserCode);
                    regkey.Close();
                }
                else
                {
                    MessageBox.Show("用户名密码不正确！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }

            }
            catch (Exception ex)
            {
                pObj_Comm.Close();
                throw ex;
            }
        }
        public static string MD5(string encryptString)
        {
            byte[] result = Encoding.Default.GetBytes(encryptString);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            string encryptResult = BitConverter.ToString(output).Replace("-", "");
            return encryptResult;
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try

            {

                RegistryKey regkey = Registry.CurrentUser.OpenSubKey("EiipInfo");

                if (regkey != null)

                {

                    txtUser.Text = regkey.GetValue("UserName").ToString();

                    regkey.Close();

                }

            }

            catch (Exception ex)

            {
                throw ex;
            }
        }
    }
}
