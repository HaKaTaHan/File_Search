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
        bool sw = false;

        // 일단 검색어 상관 없이, 드라이브 속 pdf, hwp, doc, docx, txt 총 개수
        // 프로젝트 -> 프로젝트 속성 -> 응용 프로그램 -> 출력 형식 -> 콘솔
        // search 누르면 개수 
        int fileCount = 0;

        public static string currentDirectory = Directory.GetCurrentDirectory();
        //public static FileStream txtFileStream = File.Open(@"D:\txtList.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        //public static FileStream pdfFileStream = File.Open(@"D:\pdfList.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        //public static FileStream hwpFileStream = File.Open(@"D:\hwpList.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        //public static FileStream docFileStream = File.Open(@"D:\docList.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        //public static FileStream docxFileStream = File.Open(@"D:\docxList.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        public static FileStream txtFileStream = File.Open(currentDirectory + "\\txtList.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        public static FileStream pdfFileStream = File.Open(currentDirectory + "\\pdfList.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        public static FileStream hwpFileStream = File.Open(currentDirectory + "\\hwpList.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        public static FileStream docFileStream = File.Open(currentDirectory + "\\docList.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        public static FileStream docxFileStream = File.Open(currentDirectory + "\\docxList.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);

        public StreamWriter textTxt = new StreamWriter(txtFileStream, Encoding.Default);
        public StreamWriter textPdf = new StreamWriter(pdfFileStream, Encoding.Default);       
        public StreamWriter textHwp = new StreamWriter(hwpFileStream, Encoding.Default);
        public StreamWriter textDoc = new StreamWriter(docFileStream, Encoding.Default);
        public StreamWriter textDocx = new StreamWriter(docxFileStream, Encoding.Default);

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
            F_Search = new Search(Display_Area);
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
            //sync(@"D:\");

            textTxt.WriteLine("End");
            textPdf.WriteLine("End");
            textHwp.WriteLine("End");
            textDoc.WriteLine("End");
            textDocx.WriteLine("End");
            //텍스트 각자 다 분류함
            textTxt.Dispose();
            textPdf.Dispose();
            textHwp.Dispose();
            textDoc.Dispose();
            textDocx.Dispose();
        }
        void backgroundWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //백그라운드 검색 완료시 알림창 띄움
            Alarm alrm = new Alarm(fileCount.ToString());

            alrm.setLabel1("동기화 완료");
            //알림창 위치 조절
            System.Drawing.Rectangle ScreenRectangle = Screen.PrimaryScreen.WorkingArea;
            int xPos = ScreenRectangle.Width - alrm.Bounds.Width;
            int yPos = ScreenRectangle.Height - alrm.Bounds.Height;

            //오류메세지 바꿔줘야함 (if 에러시 오류창, 정상작동시 갯수 출력)
            if (e.Error != null)
            {
                alrm.Show();
                alrm.SetBounds(xPos, yPos, alrm.Size.Width, alrm.Size.Height, BoundsSpecified.Location);
                alrm.BringToFront();
                return;
            }

            alrm.Show();
            alrm.SetBounds(xPos, yPos, alrm.Size.Width, alrm.Size.Height, BoundsSpecified.Location);
            alrm.BringToFront();
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


            //Sign_Up 닫기
            if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Signup"))
            {
                Application.OpenForms.Cast<Form>().Last().Close();
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Searching"))
            {
                Application.OpenForms["Searching"].Enabled = false;
                Application.OpenForms["Searching"].Visible = false;
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("SearchedFile"))
            {
                Application.OpenForms["Searching"].Enabled = false;
                Application.OpenForms["Searching"].Visible = false;
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Findaccount"))
            {
                Application.OpenForms.Cast<Form>().Last().Close();
            }


            if (Application.OpenForms["Searching"] != null)
            {
                Application.OpenForms["Searching"].Enabled = true;
                Application.OpenForms["Searching"].Visible = true;
            }
            if (Application.OpenForms["Account"] != null)
            {
                Application.OpenForms["Account"].Enabled = false;
                Application.OpenForms["Account"].Visible = false;
            }
            if (Application.OpenForms["FileDownload"] != null)
            {
                Application.OpenForms["FileDownload"].Enabled = false;
                Application.OpenForms["FileDownload"].Visible = false;
            }

            //Application.OpenForms["Searching"].TopLevel = true;


            //Search_Btn이 클릭되었으므로 배경색깔을 바꿔준다.
            Search_Btn.BackColor = Color.FromArgb(98, 50, 170);
            Account_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Setting_Btn.BackColor = Color.FromArgb(35, 45, 65);

            //Search폼을 Display_Area 패널에 띄운다.
            F_Search = new Search(Display_Area);
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
            
            //Sign_Up 닫기
            if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Signup"))
            {
                Application.OpenForms.Cast<Form>().Last().Close();
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Search"))
            {
                Application.OpenForms["Search"].Enabled = false;
                Application.OpenForms["Search"].Visible = false;
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Searching"))
            {
                Application.OpenForms["Searching"].Enabled = false;
                Application.OpenForms["Searching"].Visible = false;
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("SearchedFile"))
            {
                Application.OpenForms["Searching"].Enabled = false;
                Application.OpenForms["Searching"].Visible = false;
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Findaccount"))
            {
                Application.OpenForms.Cast<Form>().Last().Close();
            }
            if((!Properties.Settings.Default.ID.Equals("")) && Application.OpenForms["FileDownload"] != null)
            {
                Application.OpenForms["FileDownload"].Enabled = true;
                Application.OpenForms["FileDownload"].Visible = true;
            }
            


            //Account_Btn이 클릭되었으므로 배경색깔을 바꿔준다.
            Search_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Account_Btn.BackColor = Color.FromArgb(98, 50, 170);
            Setting_Btn.BackColor = Color.FromArgb(35, 45, 65);

            //Account폼을 Display_Area 패널에 띄운다.
            F_Account = new Account(Display_Area);
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
                


            //Sign_Up 닫기
            if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Signup"))
            {
                Application.OpenForms.Cast<Form>().Last().Close();
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Searching"))
            {
                Application.OpenForms["Searching"].Enabled = false;
                Application.OpenForms["Searching"].Visible = false;
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("SearchedFile"))
            {
                Application.OpenForms["Searching"].Enabled = false;
                Application.OpenForms["Searching"].Visible = false;
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Findaccount"))
            {
                Application.OpenForms.Cast<Form>().Last().Close();
            }
            else if (Application.OpenForms.Cast<Form>().Last().Text.Equals("Search"))
            {
                Application.OpenForms.Cast<Form>().Last().Close();
            }


            if (Application.OpenForms["Account"] != null)
            {
                Application.OpenForms["Account"].Enabled = false;
                Application.OpenForms["Account"].Visible = false;
            }
            if (Application.OpenForms["FileDownload"] != null)
            {
                Application.OpenForms["FileDownload"].Enabled = false;
                Application.OpenForms["FileDownload"].Visible = false;
            }
            if (Application.OpenForms["Setting"] != null)
            {
                Application.OpenForms["Setting"].Enabled = true;
                Application.OpenForms["Setting"].Visible = true;
            }


            //Setting_Btn이 클릭되었으므로 배경색깔을 바꿔준다.
            Search_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Account_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Setting_Btn.BackColor = Color.FromArgb(98, 50, 170);

            //Setting폼을 Display_Area 패널에 띄운다.
            F_Setting = new Setting(Display_Area);
            F_Setting.TopLevel = false;
            F_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            Display_Area.Controls.Add(F_Setting);
            F_Setting.Show();

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!sw)
            {
                //MessageBox.Show("테스트");
                e.Cancel = true; //창이 닫히지 않게 설정해줌 defalut가 false
                                 //scope path 해제해야됨
                this.Visible = false;
            }
            else
                e.Cancel = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {            
            worker.Dispose();
            try
            {
                Searching.txtThread.Abort();
            }
            catch
            {

            }
            try
            {
                Searching.hwpThread.Abort();
            }
            catch
            {

            }
            try
            {
                Searching.docThread.Abort();
            }
            catch
            {

            }
            try
            {
                Searching.docxThread.Abort();
            }
            catch
            {
            }
            try
            {
                Searching.pdfThread.Abort();
            }
            catch
            {

            }
            
            sw = true;            
            Application.Exit();
            Properties.Settings.Default.Path_Scope = "";
            Properties.Settings.Default.ID = "";
            Properties.Settings.Default.Save();            
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

        private void Display_Area_Paint(object sender, PaintEventArgs e)
        {

        }

        //notifyicon 더블클릭 이벤트핸들러
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.Visible)
            {
                this.Visible = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Visible = true;
            }
        }
    }
}
