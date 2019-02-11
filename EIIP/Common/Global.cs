using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using EIIP.Basic;
using EIIP.BasicLibrary;

namespace EIIP.Common
{
        public class Global
        {
            #region 版本升级
            static string VFile = "rfclient.ini";
        static string VUrl = "http://192.168.0.5/EIIP/" + VFile;
        //static string VUrl = "http://218.93.6.222/" + VFile;

        public static bool needUpgrade()
            {
                string localVsn = getlocalVersion();
                string remoteVsn = getRemoteVersion();

                return !localVsn.Equals(remoteVsn);
            }

            public static string getlocalVersion()
            {
                try
                {
                    string localVfile = (getExecutingPath() + VFile);

                    //if (!new FileInfo(localVfile).Exists)
                    //throw new Exception("找不到本地" + VFile + "文件！");

                    FileStream fs = new FileStream(localVfile, FileMode.Open);
                    string version = getVersion("本地" + VFile, fs);
                    fs.Close();
                    return version;
                }
                catch (Exception ex)
                {
                    return "1.0";
                }
            }

            private static string getRemoteVersion()
            {
                HttpWebRequest oReq = (HttpWebRequest)HttpWebRequest.Create(VUrl);
                oReq.Timeout = 30000;
                Stream srRet = oReq.GetResponse().GetResponseStream();
                string version = getVersion("远程" + VFile, srRet);
                srRet.Close();
                return version;
            }

            private static string getVersion(string type, Stream stm)
            {
                string line = null;
                try
                {
                    StreamReader sreader = new StreamReader(stm);

                    while ((line = sreader.ReadLine()) != null)
                    {
                        if (line.StartsWith("[Version]"))
                        {
                            line = sreader.ReadLine();
                            break;
                        }
                    }
                    sreader.Close();
                }
                catch
                {
                    return "1.0.0.0";
                }
                string[] values = line.Split('_');
                if (values.Length > 1)
                    return values[0];
                else
                {
                    return "1.0.0.0";
                }
            }
            /// <summary>
            /// 执行文件所在目录
            /// </summary>
            private static string getExecutingPath()
            {
                string fullAppName = Assembly.GetExecutingAssembly().GetName().CodeBase;
                string fullAppPath = Path.GetDirectoryName(fullAppName);

                if (fullAppPath.StartsWith("file:"))
                    fullAppPath = fullAppPath.Substring(6);

                if (fullAppPath.Substring(fullAppPath.Length - 1, 1) != "\\")
                    fullAppPath += "\\";

                return fullAppPath;
            }

            class ProcessInfo
            {
                public IntPtr hProcess;
                public IntPtr hThread;
                public Int32 ProcessId;
                public Int32 ThreadId;
            }

        [System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
        public class SECURITY_ATTRIBUTES
        {
            public int nLength;
            public string lpSecurityDescriptor;
            public bool bInheritHandle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STARTUPINFO
        {
            public int cb;
            public string lpReserved;
            public string lpDesktop;
            public int lpTitle;
            public int dwX;
            public int dwY;
            public int dwXSize;
            public int dwYSize;
            public int dwXCountChars;
            public int dwYCountChars;
            public int dwFillAttribute;
            public int dwFlags;
            public int wShowWindow;
            public int cbReserved2;
            public byte lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }
        [DllImport("Kernel32.DLL", CharSet = CharSet.Ansi)]
        public static extern bool CreateProcess(
                                                StringBuilder lpApplicationName, 
                                                StringBuilder lpCommandLine,
                                                SECURITY_ATTRIBUTES lpProcessAttributes,
                                                SECURITY_ATTRIBUTES lpThreadAttributes,
                                                bool bInheritHandles,
                                                int dwCreationFlags,
                                                StringBuilder lpEnvironment,
                                                StringBuilder lpCurrentDirectory,
                                                ref STARTUPINFO lpStartupInfo,
                                                ref PROCESS_INFORMATION lpProcessInformation
                                                );

        // [DllImport("CoreDll.dll")]
        // private extern static Int32 GetLastError();

        #region Win32 Api : WaitForSingleObject
        //检测一个系统核心对象(线程，事件，信号)的信号状态，当对象执行时间超过dwMilliseconds就返回，否则就一直等待对象返回信号
        [DllImport("Kernel32.dll")]
        public static extern uint WaitForSingleObject(System.IntPtr hHandle, uint dwMilliseconds);

        #endregion

        #region Win32 Api : CloseHandle
        //关闭一个内核对象,释放对象占有的系统资源。其中包括文件、文件映射、进程、线程、安全和同步对象等
        [DllImport("Kernel32.dll")]
        public static extern bool CloseHandle(System.IntPtr hObject);

        #endregion       

        #region Win32 Api : GetExitCodeProcess
        //获取一个已中断进程的退出代码,非零表示成功，零表示失败。
        //参数hProcess，想获取退出代码的一个进程的句柄，参数lpExitCode，用于装载进程退出代码的一个长整数变量。
        [DllImport("Kernel32.dll")]
        static extern bool GetExitCodeProcess(System.IntPtr hProcess, ref uint lpExitCode);

        #endregion

        public static void beginUpgrade()
            {
            string exefile = getExecutingPath() + "Upgrade.exe";            
            byte[] si = new byte[128];           

            STARTUPINFO sInfo = new STARTUPINFO();
            PROCESS_INFORMATION pInfo = new PROCESS_INFORMATION();
            SECURITY_ATTRIBUTES sa = new SECURITY_ATTRIBUTES();

            if (!CreateProcess(null, new StringBuilder(exefile), sa, sa, false, 0, null, null, ref sInfo, ref pInfo))
            {
                throw new Exception("调用失败");
            }
            uint i = 0;
            WaitForSingleObject(pInfo.hProcess, int.MaxValue);
            GetExitCodeProcess(pInfo.hProcess, ref i);
            CloseHandle(pInfo.hProcess);
            CloseHandle(pInfo.hThread);
       }
            #endregion

            public class ASNInfo
            {
                public string TraceId;
                public string ASNNO;
                public string ASNLineNo;
                public string CUSTOMERID;
                public string SKU;
                public string SKUDESCRC;
                public string PACKID;
                public string TiHi;
                public string RECEIVINGLOCATION;
                public string UOM;
                public string UOM_NAME;
                public string EXPECTEDQTY;
                public string RECEIVEDQTY;
                public string ExpectedQty_Each;
                public string HoldRejectCode_NAME;
                public string UDF1;
                public string UDF2;
                public string UDF3;
                public string LotAtt01;
                public string LotAtt02;
                public string LotAtt03;
                public string LotAtt04;
                public string LotAtt05;
                public string LotAtt06;
                public string LotAtt07;
                public string LotAtt08;
                public string LotAtt09;
                public string LotAtt10;
                public string LotAtt11;
                public string LotAtt12;
                public string TotalCubic;
                public string TotalGrossWeight;
                public string TotalNetWeight;
                public string TotalPrice;
                public string TOLocation;
                public string ReceivingTime;

            }

            public class PutAwayInfo
            {
                public string SKU;
                public string SKU_NAME;
                public string Package;
                public string UDF1;
                public int Qty = 0;
                public string UOM = "";
                public string UOM_NAME = "";
                public string Location = "";
                public string PageInfo = "";
                public string Sequence = "";
                public string PlanToId = "";
                public string PlanToUOM = "";
                public int PlanToQty = 0;
                public string CloseTime = "";
                public string ChangeReason = "";
                public string TaskId = "";

                public string LotAtt01 = "";
                public string LotAtt02 = "";
                public string LotAtt03 = "";
            }

            public class ListItem
            {
                private string value = string.Empty;
                private string name = string.Empty;
                public ListItem(string name, string value)
                {
                    this.name = name;
                    this.value = value;
                }
                public override string ToString()
                {
                    return this.name;
                }
                public string Value
                {
                    get { return this.value; }
                    set { this.value = value; }
                }
                public string Name
                {
                    get { return this.name; }
                    set { this.name = value; }
                }
            }

            #region 全局变量
            /// <summary>
            /// 数据库连接
            /// </summary>
            public static string progPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            //public static ArrayList ASN_TYPE = Get_ASN_Type();
            public static string gUserName = null;
            public static UserInfo tUser = new UserInfo();

            public static string ZoneGroup = null;
            public static string ZoneGroup_Code = null;

            public static string Warehouse = null;
            public static string WH_Code = null;
            public static int Width; // 显示器宽度
            public static Form FormMain; // 主窗体
            #endregion



            #region 通用界面配置
            /// <summary>
            /// 依据名称查找控件
            /// </summary>
            static public Control FindControlByName(string Name, ContainerControl ctrl)
            {
                foreach (Control control in ctrl.Controls)
                    if (control is Label)
                        if ((control as Label).Name == Name)
                            return control;
                return null;
            }

            /// <summary>
            /// 通用1：设置按钮得到和失去焦点
            /// </summary>

            /// <summary>
            /// 通用2：文本框输入转换为大写
            /// </summary>
            static public void SetToUpper(Control ctrl)
            {
                foreach (Control c in ctrl.Controls)
                    if (c is TextBox)
                        c.KeyPress += txtKeypress;
            }
            static void txtKeypress(object sender, KeyPressEventArgs e)
            {
                TextBox tt = (TextBox)sender;
                if ((e.Handled == false) && (Char.IsLower(e.KeyChar)))
                {
                    tt.SelectedText = char.ToUpper(e.KeyChar).ToString();
                    e.Handled = true;
                }
            }

            /// <summary>
            /// 通用3：文本框得到焦点时全选
            /// </summary>
            static public void SelectAll(Control ctrl)
            {
                foreach (Control c in ctrl.Controls)
                    if (c is TextBox)
                        c.GotFocus += Global.txtGotFocus;
            }

            static void txtGotFocus(object sender, EventArgs e)
            {
                if (sender is TextBox)
                    (sender as TextBox).SelectAll();
            }

            /// <summary>
            /// 通用4：设置日期控件
            /// </summary>
            static public void SetDateTimePicker(Control ctrl)
            {
                foreach (Control c in ctrl.Controls)
                    if (c is DateTimePicker)
                    {
                        DateTimePicker dtp = c as DateTimePicker;
                        dtp.CustomFormat = "yyyy-MM-dd";
                        dtp.Format = DateTimePickerFormat.Custom;
                        dtp.Value = DateTime.Parse("2014-01-01");
                    }
            }

            /// <summary>
            /// 文本框只能输入数值
            /// </summary>
            static public void SetQtyKeyPress(Control ctrl)
            {
                if (ctrl is TextBox)
                    ctrl.KeyPress += Global.onQtyKeyPress;
            }
            static void onQtyKeyPress(object sender, KeyPressEventArgs e)
            {
                if ((e.KeyChar < '0' && e.KeyChar != '.' || e.KeyChar > '9' && e.KeyChar != '.'
                    || ((TextBox)(sender)).Text.IndexOf('.') >= 0 && e.KeyChar == '.')
                    && e.KeyChar != (char)13 && e.KeyChar != (char)8)
                    e.Handled = true;
            }

            /// <summary>
            /// 设置按钮单击事件
            /// </summary>
            static public void SetButtonClick(Control ctrl, EventHandler handler)
            {
                foreach (Control c in ctrl.Controls)
                    if (c is Button || c is CheckBox)
                        c.Click += handler;
            }

            static public void SetKeyPress(Control ctrl, KeyPressEventHandler handler)
            {
                foreach (Control c in ctrl.Controls)
                    if (c is Button || c is TextBox || c is ComboBox || c is DateTimePicker)
                        c.KeyPress += handler;
            }

            public static void setDataTableReadOnly(DataTable dt)
            {
                foreach (DataColumn dc in dt.Columns)
                    dc.ReadOnly = true;
            }

            /// <summary>
            /// DataGrid自动列宽
            /// </summary>
            public static void AutoSizeTable(DataGrid dgData)
            {
                int numCols = dgData.TableStyles[0].GridColumnStyles.Count;
                for (int i = 0; i < numCols; i++)
                    AutoSizeCol(dgData, i);
            }

            private static void AutoSizeCol(DataGrid dgData, int colIndex)
            {
                DataView dv = dgData.DataSource as DataView;


                int rowNums = dv.Table.Rows.Count;
                Byte[] myByte = System.Text.Encoding.Default.GetBytes(dv.Table.Columns[colIndex].Caption);
                int textCount = myByte.Length;
                int tempCount = 0;

                for (int i = 0; i < rowNums; i++)
                {
                    if (dgData[i, colIndex] != null)
                    {
                        myByte = System.Text.Encoding.Default.GetBytes(dgData[i, colIndex].ToString().Trim());
                        tempCount = myByte.Length;

                        if (tempCount > textCount)
                            textCount = tempCount;
                    }
                }
                //if (dgData.TableStyles[0].GridColumnStyles[colIndex].Width < textCount * 7)
                float fontSize = dgData.Font.Size;
                dgData.TableStyles[0].GridColumnStyles[colIndex].Width = Convert.ToInt16(Math.Ceiling(textCount * fontSize));
            }

            public static void setFormSize(Form fm)
            {
                if (1000 > Global.Width && Global.Width > 500)
                    fm.WindowState = FormWindowState.Maximized;
                else
                    fm.Width = 320;
            }

            #endregion

            #region 设置系统时间
            [StructLayout(LayoutKind.Sequential)]
            public struct SYSTEMTIME
            {
                public ushort wYear;
                public ushort wMonth;
                public ushort wDayOfWeek;
                public ushort wDay;
                public ushort wHour;
                public ushort wMinute;
                public ushort wSecond;
                public ushort wMilliseconds;
            }
            [DllImport("coredll.dll")]
            private static extern bool SetLocalTime(ref SYSTEMTIME lpSystemTime);
            [DllImport("coredll.dll")]
            private static extern bool GetLocalTime(ref SYSTEMTIME lpSystemTime);
            public static void SetSysTime(DateTime date)
            {
                SYSTEMTIME lpTime = new SYSTEMTIME();
                lpTime.wYear = Convert.ToUInt16(date.Year);
                lpTime.wMonth = Convert.ToUInt16(date.Month);
                lpTime.wDay = Convert.ToUInt16(date.Day);
                lpTime.wHour = Convert.ToUInt16(date.Hour);
                lpTime.wMinute = Convert.ToUInt16(date.Minute);
                lpTime.wSecond = Convert.ToUInt16(date.Second);
                SetLocalTime(ref lpTime);
            }
            #endregion

            #region 系统配置
            private static Hashtable _Config;
            private static string getConfigFile()
            {
                return "\\Application Data\\WmsConfig.ini";
            }
            public static Hashtable GetConfig()
            {
                if (!new FileInfo(getConfigFile()).Exists)
                {
                    Hashtable defConfig = new Hashtable();
                    defConfig.Add("Server", "10.0.0.7");
                    defConfig.Add("DBName", "YB_WMS");
                    defConfig.Add("DBUser", "wms");
                    defConfig.Add("DBPwd", "yabang");
                    SaveConfig(defConfig);
                }
                else if (_Config == null)
                    _Config = readConfigFile();

                return _Config;
            }

            public static void SaveConfig(Hashtable config)
            {
                _Config = config;
                try
                {
                    StreamWriter sw = new StreamWriter(getConfigFile(), false, System.Text.Encoding.Default);

                    StringBuilder sb = new StringBuilder();
                    foreach (string key in _Config.Keys)
                        sb.Append(key).Append('=').Append(_Config[key]).Append("\r");

                    sw.WriteLine(sb);
                    sw.Flush();
                    sw.Close();
                }
                catch { }
            }

            public static string getDBStr()
            {
                if (null == _Config)
                    GetConfig();
                if (!_Config.ContainsKey("DBStr"))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Persist Security Info=False;Integrated Security=False;Server=").Append(_Config["Server"]);
                    sb.Append(";database=").Append(_Config["DBName"]);
                    sb.Append(";User Id=").Append(_Config["DBUser"]);
                    sb.Append(";Password=").Append(_Config["DBPwd"]);
                    _Config.Add("DBStr", sb.ToString());
                }
                return (string)_Config["DBStr"];
            }

            private static Hashtable readConfigFile()
            {
                Hashtable result = new Hashtable();
                try
                {
                    StreamReader sr = new StreamReader(getConfigFile(), System.Text.Encoding.Default);
                    while (true)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split('=');
                        if (values.Length > 1)
                            result.Add(values[0], values[1]);
                        else break;
                    }
                    sr.Close();
                }
                catch { }
                return result;
            }
            #endregion
        }
    }
