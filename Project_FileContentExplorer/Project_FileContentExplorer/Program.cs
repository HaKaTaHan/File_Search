using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FileContentExplorer
{


    static class Program
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdSHow);
        [DllImport("user32.dll")]
        public static extern void BringWindowToTop(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern void SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                IntPtr hWnd = FindWindow(null, "File Content Explorer");
                if (hWnd == IntPtr.Zero)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Home());
                }
                else
                {
                    string rt = "File Content Explorer";
                    IntPtr wHandle = FindWindow(null, rt);
                    ShowWindow(wHandle, 5);
                    BringWindowToTop(wHandle);
                    SetForegroundWindow(wHandle);
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
