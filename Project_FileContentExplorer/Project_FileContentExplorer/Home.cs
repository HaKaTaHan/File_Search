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

namespace Project_FileContentExplorer
{
    public partial class Home : Form
    {
        Search F_Search;
        Account F_Account;
        Setting F_Setting;

        // 일단 검색어 상관 없이, 드라이브 속 pdf, hwp, doc, docx, txt 총 개수
        // 프로젝트 -> 프로젝트 속성 -> 응용 프로그램 -> 출력 형식 -> 콘솔
        // search 누르면 개수 
        int fileCount = 0;
        //
        StreamWriter textTxt = new StreamWriter(@"D:\txtList.txt", append: true);
        StreamWriter textPdf = new StreamWriter(@"D:\pdfList.txt", append: true);
        StreamWriter textHwp = new StreamWriter(@"D:\hwpList.txt", append: true);
        StreamWriter textDoc = new StreamWriter(@"D:\docList.txt", append: true);
        StreamWriter textDocx = new StreamWriter(@"D:\docxList.txt", append: true);

        string systemFolder = Environment.GetFolderPath(System.Environment.SpecialFolder.Windows);//윈도우 폴더

        private BackgroundWorker worker;

        public Home()
        {
            InitializeComponent();

            //백그라운드로 전체 드라이브 돌면서 파일 목록 모으기
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(backgroundWork);    //백그라운드에서 어떤 작업을 할지
            //worker.ProgressChanged += new ProgressChangedEventHandler();  //백그라운드에서  진행되는 상태
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkCompleted); //백그라운드에서 작업 완료

            //프로그램 실행할 시 Search 폼을 Display_Area 패널에 띄운다.
            F_Search = new Search();
            F_Search.TopLevel = false;
            F_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            Display_Area.Controls.Add(F_Search);
            F_Search.Show();

            //실행하자마자 백그라운드 아이콘 올려지고 열기/종료 선택 가능하도록
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

        void backgroundWork(object sender, DoWorkEventArgs e)
        {
            foreach (string path in Environment.GetLogicalDrives())
            {
                sync(path);
            }

            MessageBox.Show("pdf, hwp, doc, docx, txt 총 개수 : " + fileCount.ToString());
           
            //텍스트 각자 다 분류함
            textTxt.Dispose();
            textPdf.Dispose();
            textHwp.Dispose();
            textDoc.Dispose();
            textDocx.Dispose();
        }
        void backgroundWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error");
                return;
            }

            MessageBox.Show("백그라운드 작업 완료");
        }

        public void sync(string path)
        {
            Stack<string> dirs = new Stack<string>(200);            

            if (!System.IO.Directory.Exists(path))
            {
                throw new ArgumentException();
            }
            dirs.Push(path);

            while (dirs.Count > 0)
            {
                Application.DoEvents();

                string currentDIr = dirs.Pop();
                string[] subDirs;
                try
                {
                    subDirs = System.IO.Directory.GetDirectories(currentDIr);
                }
                catch (UnauthorizedAccessException e)
                {
                    //MessageBox.Show(e.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    //MessageBox.Show(e.Message);
                    continue;
                }
                catch (Exception e)
                {
                    continue;
                }

                string[] files = null;
                try
                {
                    files = System.IO.Directory.GetFiles(currentDIr);
                }
                catch (UnauthorizedAccessException e)
                {
                    //MessageBox.Show(e.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    //MessageBox.Show(e.Message);
                    continue;
                }
                catch (Exception e)
                {
                    continue;
                }

                foreach (string file in files)
                {
                    try
                    {
                        //FileInfo fi = new FileInfo(file);                        
                        string[] split = file.Split('.');
                        switch (split[split.Length - 1])
                        {
                            case "pdf":
                                textPdf.WriteLine(file);
                                fileCount++;
                                Console.WriteLine(fileCount);
                                break;
                            case "hwp":
                                textHwp.WriteLine(file);
                                fileCount++;
                                Console.WriteLine(fileCount);
                                break;
                            case "txt":
                                textTxt.WriteLine(file);
                                fileCount++;
                                Console.WriteLine(fileCount);
                                break;
                            case "doc":
                                textDoc.WriteLine(file);
                                fileCount++;
                                Console.WriteLine(fileCount);
                                break;
                            case "docx":
                                textDocx.WriteLine(file);
                                fileCount++;
                                Console.WriteLine(fileCount);
                                break;
                        }

                    }
                    catch (System.IO.FileNotFoundException e)
                    {
                        //MessageBox.Show(e.Message);
                        continue;
                    }
                }

                foreach (string str in subDirs)
                    dirs.Push(str);

            }

        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            //열려있는 창 닫기
            if (F_Search != null)
                F_Search.Close();
            if (F_Account != null)
                F_Account.Close();
            if (F_Setting != null)
                F_Setting.Close();
            
            //Search_Btn이 클릭되었으므로 배경색깔을 바꿔준다.
            Search_Btn.BackColor = Color.FromArgb(98, 50, 170);
            Account_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Setting_Btn.BackColor = Color.FromArgb(35, 45, 65);

            //Search폼을 Display_Area 패널에 띄운다.
            F_Search = new Search();
            F_Search.TopLevel = false;
            F_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            Display_Area.Controls.Add(F_Search);
            F_Search.Show();

        }

        private void Account_Btn_Click(object sender, EventArgs e)
        {
            //열려있는 창 닫기
            if (F_Search != null)
                F_Search.Close();
            if (F_Account != null)
                F_Account.Close();
            if (F_Setting != null)
                F_Setting.Close();

            //Account_Btn이 클릭되었으므로 배경색깔을 바꿔준다.
            Search_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Account_Btn.BackColor = Color.FromArgb(98, 50, 170);
            Setting_Btn.BackColor = Color.FromArgb(35, 45, 65);

            //Account폼을 Display_Area 패널에 띄운다.
            F_Account = new Account();
            F_Account.TopLevel = false;
            F_Account.Dock = System.Windows.Forms.DockStyle.Fill;
            Display_Area.Controls.Add(F_Account);
            F_Account.Show();

        }

        private void Setting_Btn_Click(object sender, EventArgs e)
        {
            //열려있는 창 닫기
            if (F_Search != null)
                F_Search.Close();
            if (F_Account != null)
                F_Account.Close();
            if (F_Setting != null)
                F_Setting.Close();

            //Setting_Btn이 클릭되었으므로 배경색깔을 바꿔준다.
            Search_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Account_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Setting_Btn.BackColor = Color.FromArgb(98, 50, 170);

            //Setting폼을 Display_Area 패널에 띄운다.
            F_Setting = new Setting();
            F_Setting.TopLevel = false;
            F_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            Display_Area.Controls.Add(F_Setting);
            F_Setting.Show();

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //창이 닫히지 않게 설정해줌 defalut가 false
            Properties.Settings.Default.Save();
            this.ShowInTaskbar = true;
            this.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;
            //this.ShowInTaskbar = false;
            Application.Exit();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Visible = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }
    }
}
