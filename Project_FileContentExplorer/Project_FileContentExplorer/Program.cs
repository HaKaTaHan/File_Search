using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

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

        static string ext = ".1myext";
        static string fileTypeDesc = "my ext sample";
        static string extType = "yourext" + ext + ".v1";
        static string assocExeFileName = "YourExt.exe";
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool register = true;

            if (args.Length >= 1)
            {
                if (args[0] == "-u")
                {
                    register = false;
                }
            }

            ProcessFileExtReg(register);
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
        private static void ProcessFileExtReg(bool register)
        {
            using (RegistryKey classesKey = Registry.CurrentUser.OpenSubKey(@"Software\Classes", true))
            {
                if (register == true)
                {
                    using (RegistryKey extKey = classesKey.CreateSubKey(ext))
                    {
                        extKey.SetValue(null, extType);
                    }

                    // or, use Registry.SetValue method
                    using (RegistryKey typeKey = classesKey.CreateSubKey(extType))
                    {
                        typeKey.SetValue(null, fileTypeDesc);
                        using (RegistryKey shellKey = typeKey.CreateSubKey("shell"))
                        {
                            using (RegistryKey openKey = shellKey.CreateSubKey("open"))
                            {
                                using (RegistryKey commandKey = openKey.CreateSubKey("command"))
                                {
                                    string assocExePath = GetProcessPath();
                                    string assocCommand = string.Format("\"{0}\" \"%1\"", assocExePath);

                                    commandKey.SetValue(null, assocCommand);
                                }
                            }
                        }
                    }
                }
                else
                {
                    DeleteRegistryKey(classesKey, ext, false);
                    DeleteRegistryKey(classesKey, extType, true);
                }
            }
        }

        private static void DeleteRegistryKey(RegistryKey classesKey, string subKeyName, bool deleteAllSubKey)
        {
            if (CheckRegistryKeyExists(classesKey, subKeyName) == false)
            {
                return;
            }

            if (deleteAllSubKey == true)
            {
                classesKey.DeleteSubKeyTree(subKeyName);
            }
            else
            {
                classesKey.DeleteSubKey(subKeyName);
            }
        }

        private static bool CheckRegistryKeyExists(RegistryKey classesKey, string subKeyName)
        {
            RegistryKey regKey = null;

            try
            {
                regKey = classesKey.OpenSubKey(subKeyName);
                return regKey != null;
            }
            finally
            {
                if (regKey != null)
                {
                    regKey.Close();
                }
            }
        }

        private static string GetProcessPath()
        {
            string path = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            return Path.Combine(path, assocExeFileName);
        }
    }
}
