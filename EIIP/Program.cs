using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EIIP.Common;

namespace EIIP
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

             if (chkUpgrade()) // 检查版本更新
             {
                 Global.beginUpgrade();
                 Application.Exit();
             }
             else
             {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            }
        }

        private static bool chkUpgrade()
        {
            bool needUpgrade = false;
            try
            {
                needUpgrade = Global.needUpgrade();
                if (needUpgrade)
                    MessageBox.Show("发现程序更新，立刻升级！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

            }
            catch (Exception ex)
            {
                //Global.showError(ex.ToString() + " " + ex.StackTrace.ToString());

                needUpgrade = false;
            }
            return needUpgrade;
        }
    }
}
