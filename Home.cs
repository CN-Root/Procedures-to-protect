using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Net;//其下有WebRequest和WebResponse
using System.Text.RegularExpressions;//正则表达式，比截取字符串要好用的多
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;
using System.Resources;
using System.Reflection;
using System.Xml;
using System.Management;
using System.Runtime;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Procedures_to_protect
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        /*
         *  廊坊纽扣网络技术有限公司
         */

        #region A1
        string wendang = (Environment.GetFolderPath(Environment.SpecialFolder.Personal));//判断电脑文档路径

        string zhuomian = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);//判断电脑桌面路径

        string Time = DateTime.Now.ToLocalTime().ToString();//检测当前电脑时间

        [DllImport("user32.dll", EntryPoint = "AnimateWindow")]
        private static extern bool AnimateWindow(IntPtr handle, int ms, int flags);

        [DllImport("shell32.dll")]
        public static extern int ShellExecute(IntPtr hwnd, StringBuilder lpszOp, StringBuilder lpszFile, StringBuilder lpszParams, StringBuilder lpszDir, int FsShowCmd);
        #endregion

        #region 快捷键
        public class HotKey
        {
            //如果函数执行成功，返回值不为0。
            //如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool RegisterHotKey(
                IntPtr hWnd,                //要定义热键的窗口的句柄
                int id,                     //定义热键ID（不能与其它ID重复）           
                KeyModifiers fsModifiers,   //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效
                Keys vk                     //定义热键的内容
                );

            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool UnregisterHotKey(
                IntPtr hWnd,                //要取消热键的窗口的句柄
                int id                      //要取消热键的ID
                );

            //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）
            [Flags()]
            public enum KeyModifiers
            {
                None = 0,
                Alt = 1,
                Ctrl = 2,
                Shift = 4,
                WindowsKey = 8
            }

        }
        #endregion

        #region 加载主页
        private void Home_Load(object sender, EventArgs e)
        {
            HotKey.RegisterHotKey(Handle, 103, HotKey.KeyModifiers.None, Keys.Insert);//注册热键INS,ID为103
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            //按快捷键    
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 103:
                            buttonbox();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        string Hidden_display = "真";
        void buttonbox() 
        {
            if (Hidden_display == "真")
            {
                this.Hide();
                Hidden_display = "假";
            }
            else 
            {
                this.Show();
                Hidden_display = "真";
            }
        }
        #endregion

        #region 选择路径
        private void button1_Click(object sender, EventArgs e)
        {
            PS1.Focus();//重设焦点

            if (button1.Text == "查询")
            {
                #region 选取文件
                //此时弹出一个可以选择文件的窗体
                OpenFileDialog fileDialog = new OpenFileDialog();
                //一次只能选取一个文件
                fileDialog.Multiselect = false;
                fileDialog.Title = "请选择需要保护的进程源文件";
                fileDialog.Filter = "所有文件(*.exe*)|*.exe*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = fileDialog.FileName;
                }
                #endregion

                #region 获取文件名
                string strFilePaht = fileDialog.FileName;
                string str = Path.GetFileNameWithoutExtension(strFilePaht);
                #endregion

                #region 获取进程信息
                if (System.Diagnostics.Process.GetProcessesByName(str).ToList().Count > 0)
                {//运行中
                    Process[] ps = Process.GetProcesses();//获取计算机上所有进程
                    foreach (Process p in ps)
                    {
                        if (p.ProcessName == str)//判断进程名称
                        {
                            string a = p.Id.ToString();

                            information1.Text = a;

                            information2.Text = p.ProcessName;

                            information3.Text = fileDialog.FileName;
                        }
                    }

                    DialogResult result = MessageBox.Show("是否开启保护" + "\n\n" + "点击<是>开始保护" + "\n" + "点击<否>取消操作", "是否开启进程保护？", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        string strFilePaht2 = textBox.Text;
                        string str2 = Path.GetFileNameWithoutExtension(strFilePaht2);

                        guardian.Enabled = true;//开启计时器
                    }
                    else if (result == DialogResult.No)
                    {
                        textBox.Text = "";
                        information1.Text = "NULL";
                        information2.Text = "NULL";
                        information3.Text = "NULL";
                    }
                }
                else
                {
                    textBox.Text = "";
                    information1.Text = "NULL";
                    information2.Text = "NULL";
                    information3.Text = "NULL";
                    information4.Text = "NULL";

                    MessageBox.Show("可能是<文件名>输入有误", "未检测到需要保护的进程");//信息提示
                }
                #endregion
            }

            #region 结束保护
            if (button1.Text == "结束")
            {
                textBox.Text = "";
                information1.Text = "NULL";
                information2.Text = "NULL";
                information3.Text = "NULL";
                information4.Text = "NULL";

                button1.Text = "查询";
                guardian.Enabled = false;
                MessageBox.Show("已结束进程保护", "提示：");
            }
            #endregion
        }
        #endregion

        #region 开始保护进程(计时器)
        int record1 = 1;//记录值
        private void guardian_Tick(object sender, EventArgs e)
        {//开始保护进程
            if (button1.Text == "查询")
            {
                button1.Text = "结束";

                string strFilePaht2 = textBox.Text;
                string str2 = Path.GetFileNameWithoutExtension(strFilePaht2);

                information4.Text = "0";

                MessageBox.Show("进程保护已开启" + "\n\n" + "保护的进程：[ " + str2 + " ]", "提示：");
            }

            #region 获取文件名
            string strFilePaht = textBox.Text;
            string str = Path.GetFileNameWithoutExtension(strFilePaht);
            #endregion

            if (System.Diagnostics.Process.GetProcessesByName(str).ToList().Count > 0)
            {//运行中

            }
            else
            {//未运行
                if (!File.Exists(@strFilePaht))//检测系统是否通过检测
                {//不存在文件
                    guardian.Enabled = false;//进程保护结束

                    textBox.Text = "";
                    information1.Text = "NULL";
                    information2.Text = "NULL";
                    information3.Text = "NULL";
                    information4.Text = "NULL";

                    button1.Text = "查询";

                    MessageBox.Show("进程保护已结束！！！" 
                        + "\n\n" 
                        + "原因：" 
                        + "\n" 
                        + "1.文件移动" 
                        + "\n" 
                        + "2.文件删除"
                        +"\n"
                        +"3.文件重命名"
                        ,"提示：");
                }
                else
                {//存在文件
                    System.Diagnostics.Process.Start(@strFilePaht);//启动外部程序

                    float flNum1 = Convert.ToSingle(information4.Text);
                    float flNum2 = Convert.ToSingle(record1);
                    float sum = flNum1 + flNum2;
                    information4.Text = Convert.ToString(sum);

                    Process[] ps = Process.GetProcesses();//获取计算机上所有进程
                    foreach (Process p in ps)
                    {
                        if (p.ProcessName == str)//判断进程名称
                        {
                            string a = p.Id.ToString();

                            information1.Text = a;
                        }
                    }
                }
            }
        }
        #endregion
    }
}