using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI;
using rcc.h2tlib.parser;
using System.Threading;
using System.IO;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.pdmodel.edit;
using org.apache.pdfbox.util;
using Aspose.Words;

namespace Project_FileContentExplorer
{
    public partial class Searching : Form
    {
        SearchedFile F_SearchedFile;
        Panel Home_Panel;
        Searching F_Searching;
        String Keyword;
        public Thread txtThread;
        Thread pdfThread;
        Thread hwpThread;
        Thread docThread;
        Thread docxThread;
        // 일단 검색어 상관 없이, 드라이브 속 pdf, hwp, doc, docx, txt 총 개수
        // 프로젝트 -> 프로젝트 속성 -> 응용 프로그램 -> 출력 형식 -> 콘솔
        // search 누르면 개수 
        string currentDirectory = Directory.GetCurrentDirectory();
        string keyword;
        string systemFolder = Environment.GetFolderPath(System.Environment.SpecialFolder.Windows);//윈도우 폴더
        int txtCount = 0;
        int hwpCount = 0;
        int pdfCount = 0;
        int docCount = 0;
        int docxCount = 0;

        int txtChecked;
        int pdfChecked;
        int hwpChecked;
        int docChecked;
        int docxChecked;

        bool txtCompleted=false;
        bool txtsw = false;
        bool pdfCompleted=false;
        bool pdfsw = false;
        bool hwpCompleted=false;
        bool hwpsw = false;
        bool docCompleted=false;
        bool docsw = false;
        bool docxCompleted=false;
        bool docxsw = false;

        int time = 0;

        static string[] txtExtensions =
        {
            ".txt"
        };

        static string[] hwpExtensions =
        {
            ".hwp"
        };

        static string[] pdfExtensions =
        {
            ".pdf"
        };

        static string[] docxExtensions =
        {
           ".doc", ".docx"
        };


        public Searching(String Keyword)
        {
            InitializeComponent();
            this.Keyword = Keyword;
            ProgressInit();
        }

        public void ProgressInit()
        {
            Search_Progress.Style = ProgressBarStyle.Continuous;
            Search_Progress.Minimum = 0;
            Search_Progress.Maximum = 1000;
            //Search_Progress.Step = 1;
            Search_Progress.Value = 0;

            timer1.Interval = 500;  //0.5초 간격
            timer1.Start();
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        public void SerachingComplete()
        {
            int filenum = txtCount + hwpCount + pdfCount + docCount + docxCount;
            MessageBox.Show("검색이 완료되었습니다");
        } 

        private void Searching_Load(object sender, EventArgs e)
        {            
            Keyword_Label.Text = Keyword;          

            if (Keyword.Length != 0)
            {
                txtCount = 0;
                hwpCount = 0;
                pdfCount = 0;
                docCount = 0;
                docxCount = 0;
                //p = 0;
                keyword = Keyword;
                                               
                txtChecked = Properties.Settings.Default.txtList.Length;
                pdfChecked = Properties.Settings.Default.pdfList.Length;
                hwpChecked = Properties.Settings.Default.hwpList.Length;
                docChecked = Properties.Settings.Default.docList.Length;
                docxChecked = Properties.Settings.Default.docxList.Length;


                if (txtChecked != 0)
                {
                    txtThread = new Thread(new ThreadStart(txtWork));
                    txtThread.Start();
                }
                else txtCompleted = true;

                
                if (pdfChecked != 0)
                {
                    pdfThread = new Thread(new ThreadStart(pdfWork));
                    pdfThread.Start();
                }
                else pdfCompleted = true;
                if (hwpChecked != 0)
                {
                    hwpThread = new Thread(new ThreadStart(hwpWork));
                    hwpThread.Start();
                }
                else hwpCompleted = true;
                if (docChecked != 0)
                {
                    docThread = new Thread(new ThreadStart(docWork));
                    docThread.Start();
                }
                else docCompleted = true;
                if (docxChecked != 0)
                {
                    docxThread = new Thread(new ThreadStart(docxWork));
                    docxThread.Start();
                }
                else docxCompleted = true;

                if(txtChecked + pdfChecked + hwpChecked + docxChecked + docChecked + docxChecked == 0)
                {
                    txtThread = new Thread(new ThreadStart(txtWork));
                    txtThread.Start();
                    pdfThread = new Thread(new ThreadStart(pdfWork));
                    pdfThread.Start();
                    hwpThread = new Thread(new ThreadStart(hwpWork));
                    hwpThread.Start();
                    docThread = new Thread(new ThreadStart(docWork));
                    docThread.Start();
                    docxThread = new Thread(new ThreadStart(docxWork));
                    docxThread.Start();
                }                
            }          
        }       

        void txtWork()
        {            
            //FileStream txtFileStream = File.Open(@"D:\txtList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            FileStream txtFileStream = File.Open(currentDirectory + "\\txtList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader txtReader = new StreamReader(txtFileStream, Encoding.Default);            
            while (true)
            {                
                string path = txtReader.ReadLine();                
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                else if (Properties.Settings.Default.Path_Scope.Length == 0)                                   
                    txtExtract(keyword, path);               
                else if (path.Contains(Properties.Settings.Default.Path_Scope))                                    
                    txtExtract(keyword, path);
                //Console.WriteLine(path);
                               
            }
            Console.WriteLine("txt 검색 끝");
            Console.WriteLine("keyword가 들어있는 txt 개수 : " + txtCount);
            txtCompleted = true;
            //if (txtCompleted) MessageBox.Show("txt끝"); 
            if (txtCompleted && pdfCompleted && hwpCompleted && docCompleted && docxCompleted)
            {
                MessageBox.Show("검색이 완료되었습니다");
            }

            txtReader.Dispose();
            txtFileStream.Close();
        }

        void pdfWork()
        {
            FileStream pdfFileStream = File.Open(currentDirectory + "\\pdfList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);           
            StreamReader pdfReader = new StreamReader(pdfFileStream, Encoding.Default);           
            while (true)
            {
                string path = pdfReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                else if (Properties.Settings.Default.Path_Scope.Length == 0)
                    pdfExtract(keyword, path);
                else if (path.Contains(Properties.Settings.Default.Path_Scope))
                    pdfExtract(keyword, path);
                //Console.WriteLine(path);
            }                        
            Console.WriteLine("pdf 검색 끝");
            Console.WriteLine("keyword가 들어있는 pdf 개수 " + pdfCount);
            pdfCompleted = true;
            //if (pdfCompleted) MessageBox.Show("pdf끝");
            if (txtCompleted && pdfCompleted && hwpCompleted && docCompleted && docxCompleted)
            {
                SerachingComplete();
            }

            pdfReader.Dispose();
            pdfFileStream.Close();
        }

        void hwpWork()
        {
            FileStream hwpFileStream = File.Open(currentDirectory + "\\hwpList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader hwpReader = new StreamReader(hwpFileStream, Encoding.Default);
            while (true)
            {
                string path = hwpReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                else if (Properties.Settings.Default.Path_Scope.Length == 0)
                    hwpExtract(keyword, path);
                else if (path.Contains(Properties.Settings.Default.Path_Scope))
                    hwpExtract(keyword, path);

                //Console.WriteLine(path);
            }
            Console.WriteLine("hwp 검색 끝");
            Console.WriteLine("keyword가 들어있는 hwp 개수 " + hwpCount);
            hwpCompleted = true;
            //if (hwpCompleted) MessageBox.Show("hwp끝");
            if (txtCompleted && pdfCompleted && hwpCompleted && docCompleted && docxCompleted)
            {
                SerachingComplete();
            }


            hwpReader.Dispose();
            hwpFileStream.Close();
        }
        void docWork()
        {
            FileStream docFileStream = File.Open(currentDirectory + "\\docList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader docReader = new StreamReader(docFileStream, Encoding.Default);
            while (true)
            {
                string path = docReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                else if (Properties.Settings.Default.Path_Scope.Length == 0)
                    docExtract(keyword, path);
                else if (path.Contains(Properties.Settings.Default.Path_Scope))
                    docExtract(keyword, path);
                //Console.WriteLine(path);
            }
            Console.WriteLine("doc 검색 끝");
            Console.WriteLine("keyword가 들어있는 doc 개수 " + docCount);
            docCompleted = true;
            //if (docCompleted) MessageBox.Show("doc끝");
            if (txtCompleted && pdfCompleted && hwpCompleted && docCompleted && docxCompleted)
            {
                SerachingComplete();
            }

            docReader.Dispose();
            docFileStream.Close();
        }

        void docxWork()
        {
            FileStream docxFileStream = File.Open(currentDirectory + "\\docxList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader docxReader = new StreamReader(docxFileStream, Encoding.Default);
            while (true)
            {
                string path = docxReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                else if (Properties.Settings.Default.Path_Scope.Length == 0)
                    docxExtract(keyword, path);
                else if (path.Contains(Properties.Settings.Default.Path_Scope))
                    docxExtract(keyword, path);
                //Console.WriteLine(path);
            }
            Console.WriteLine("docx 검색 끝");
            Console.WriteLine("keyword가 들어있는 docx 개수 " + docxCount);
            docxCompleted = true;
            //if (docxCompleted) MessageBox.Show("docx끝");
            if (txtCompleted && pdfCompleted && hwpCompleted && docCompleted && docxCompleted)
            {
                SerachingComplete();
            }

            docxReader.Dispose();
            docxFileStream.Close();
        }

        public void txtExtract(string keyWord, string path)
        {            
            try
            {                
                FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader textTxt = new StreamReader(fs, Encoding.Default);
                string all = textTxt.ReadToEnd();
                bool isExist = all.ToLower().Contains(keyword);
                if (isExist)
                {
                    txtCount++;
                    Console.WriteLine(path);
                    

                    Task.Run(() =>
                    {
                        Add_Item(Path.GetFileNameWithoutExtension(path), path, Path.GetExtension(path));
                    });
                }
            }
            catch
            {
                return;
            }
        }

        public void pdfExtract(string keyWord, string path)
        {
            PDDocument doc = null;            
            try
            {                             
                doc = PDDocument.load(path);               
                if (doc.isEncrypted())
                {
                    doc.close();
                    return;
                }              
                PDFTextStripper stripper = new PDFTextStripper();                
                bool isExist = stripper.getText(doc).ToLower().Contains(keyword);
                if (isExist)
                {
                    pdfCount++;
                    Console.WriteLine(path);

                    Task.Run(() =>
                    {
                        Add_Item(Path.GetFileNameWithoutExtension(path), path, Path.GetExtension(path));
                    });
                }
                    doc.close();
            }
            catch
            {
                try
                {
                    if (doc != null)
                        doc.close();
                }
                catch
                {
                    return;
                }
                return;
            }

        }
        public void hwpExtract(string keyWord, string path)
        {
            try
            {                
                StringBuilder sb = new StringBuilder();
                HWPMeta meta = new HWPMeta();
                H2TParser parser = new H2TParser();
                bool flg = parser.GetText(path, meta, sb);
                bool isExist = false;
                if (flg)
                {
                    isExist = sb.ToString().ToLower().Contains(keyword);
                }
                if (isExist)
                {
                    hwpCount++;
                    Console.WriteLine(path);

                    Task.Run(() =>
                    {
                        Add_Item(Path.GetFileNameWithoutExtension(path), path, Path.GetExtension(path));
                    });
                }
            }
            catch
            {
                return;
            }
        }

        public void docExtract(string keyWord, string path)
        {
            try
            {                
                Document doc = new Document(path);
                DocumentBuilder builder = new DocumentBuilder(doc);

                bool isExist = doc.GetText().ToLower().Contains(keyword);
                if (isExist)
                {
                    docCount++;
                    Console.WriteLine(path);

                    Task.Run(() =>
                    {
                        Add_Item(Path.GetFileNameWithoutExtension(path), path, Path.GetExtension(path));
                    });
                }
            }
            catch
            {
                return;
            }
        }

        public void docxExtract(string keyWord, string path)
        {
            try
            {                
                Document doc = new Document(path);
                DocumentBuilder builder = new DocumentBuilder(doc);
                //MessageBox.Show(doc.GetText());
                bool isExist = doc.GetText().ToLower().Contains(keyword);
                if (isExist)
                {
                    docxCount++;
                    Console.WriteLine(path);

                    Task.Run(() =>
                    {
                        Add_Item(Path.GetFileNameWithoutExtension(path), path, Path.GetExtension(path));
                    });
                    
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        

        private void Pause_Btn_Click(object sender, EventArgs e)
        {
            Resume_Btn.Visible = true;
            Pause_Btn.Visible = false;
            Stop_Btn.Visible = true;
            //pause
            try
            {
                if (txtChecked != 0 && txtThread.ThreadState.ToString() != "Stopped")
                {
                    txtThread.Suspend();                   
                    Console.WriteLine("txtThread 중단됨");
                }
                if (pdfChecked != 0 && pdfThread.ThreadState.ToString() != "Stopped")
                {
                    pdfThread.Suspend();
                    Console.WriteLine(pdfThread.ThreadState.ToString());
                    Console.WriteLine("pdfThread 중단됨");
                }
                if (hwpChecked != 0 && hwpThread.ThreadState.ToString() != "Stopped")
                {
                    hwpThread.Suspend();
                    Console.WriteLine("hwpThread 중단됨");
                }
                if (docChecked != 0 && docThread.ThreadState.ToString() != "Stopped")
                {
                    docThread.Suspend();
                    Console.WriteLine("tdocThread 중단됨");
                }
                if (docxChecked != 0 && docxThread.ThreadState.ToString() != "Stopped")
                {
                    docxThread.Suspend();
                    Console.WriteLine("tdocxThread 중단됨");
                }
                if (txtChecked + pdfChecked + hwpChecked + docxChecked + docChecked + docxChecked == 0)
                {
                    if (txtThread.ThreadState.ToString() != "Stopped")
                    {
                        txtThread.Suspend();
                        Console.WriteLine("txtThread 중단됨");
                    }
                    if (pdfThread.ThreadState.ToString() != "Stopped")
                    {
                        pdfThread.Suspend();
                        Console.WriteLine("pdfThread 중단됨");
                    }
                    if (hwpThread.ThreadState.ToString() != "Stopped")
                    {
                        hwpThread.Suspend();
                        Console.WriteLine("hwpThread 중단됨");
                    }
                    if (docThread.ThreadState.ToString() != "Stopped")
                    {
                        docThread.Suspend();
                        Console.WriteLine("tdocThread 중단됨");
                    }
                    if (docxThread.ThreadState.ToString() != "Stopped")
                    {
                        docxThread.Suspend();
                        Console.WriteLine("tdocxThread 중단됨");
                    }
                }
            }
            catch
            {
                return;
            }

        }

        private void Resume_Btn_Click(object sender, EventArgs e)
        {
            Resume_Btn.Visible = false;
            Stop_Btn.Visible = false;
            Pause_Btn.Visible = true;
            Console.WriteLine(pdfThread.ThreadState.ToString());
            try
            {
                if (txtChecked != 0 && txtThread.ThreadState.ToString() == "Suspended")
                {
                    txtThread.Resume();
                    Console.WriteLine("txtThread 다시 시작됨");
                }
                if (pdfChecked != 0 && pdfThread.ThreadState.ToString() == "Suspended")
                {
                    pdfThread.Resume();
                    Console.WriteLine("pdfThread 다시 시작됨");
                }
                if (hwpChecked != 0 && hwpThread.ThreadState.ToString() == "Suspended")
                {
                    hwpThread.Resume();
                    Console.WriteLine("hwpThread 다시 시작됨");
                }
                if (docChecked != 0 && docThread.ThreadState.ToString() == "Suspended")
                {
                    docThread.Resume();
                    Console.WriteLine("tdocThread 다시 시작됨");
                }
                if (docxChecked != 0 && docxThread.ThreadState.ToString() == "Suspended")
                {
                    docxThread.Resume();
                    Console.WriteLine("tdocxThread 다시 시작됨");
                }
                if (txtChecked + pdfChecked + hwpChecked + docxChecked + docChecked + docxChecked == 0)
                {
                    txtThread.Resume();
                    Console.WriteLine("txtThread 다시 시작됨");
                    pdfThread.Resume();
                    Console.WriteLine("pdfThread 다시 시작됨");
                    hwpThread.Resume();
                    Console.WriteLine("hwpThread 다시 시작됨");
                    docThread.Resume();
                    Console.WriteLine("tdocThread 다시 시작됨");
                    docxThread.Resume();
                    Console.WriteLine("tdocxThread 다시 시작됨");
                }
            }
            catch
            {
                return;
            }
        }

        private void Stop_Btn_Click(object sender, EventArgs e)
        {
            //quit thread
            
            try
            {
                if (txtThread.ThreadState.ToString() == "Suspended")
                {
                    txtThread.Resume();
                    txtThread.Abort();
                    Console.WriteLine("txtThread 종료");
                }
                if (pdfThread.ThreadState.ToString() == "Suspended")
                {
                    pdfThread.Resume();
                    pdfThread.Abort();
                    Console.WriteLine("pdfThread 종료");
                }
                if (hwpThread.ThreadState.ToString() == "Suspended")
                {
                    hwpThread.Resume();
                    hwpThread.Abort();
                    Console.WriteLine("hwpThread 종료");
                }
                if (docThread.ThreadState.ToString() == "Suspended")
                {
                    docThread.Resume();
                    docThread.Abort();
                    Console.WriteLine("tdocThread 종료");
                }
                if (docxThread.ThreadState.ToString() == "Running" || docxThread.ThreadState.ToString() == "Suspended")
                {
                    docxThread.Resume();
                    docxThread.Abort();
                    Console.WriteLine("tdocxThread 종료");
                }
            }
            catch
            {
                return;
            }
        }

        private void Test_Btn_Click(object sender, EventArgs e)
        {
            this.F_SearchedFile = new SearchedFile(Item_Panel);
            this.F_SearchedFile.TopLevel = false;
            this.F_SearchedFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.F_SearchedFile.FileName_Label.Text = "Fixed_Text";
            this.F_SearchedFile.FilePath_Label.Text = "Fixed_Path";
            this.Item_Panel.Controls.Add(F_SearchedFile);
            this.F_SearchedFile.Show();
        }

        private void Add_Item(string name, string path, string extension)
        {
            this.Invoke((System.Action)(() =>
            {
                F_SearchedFile = new SearchedFile(Item_Panel);
                F_SearchedFile.TopLevel = false;
                F_SearchedFile.Dock = System.Windows.Forms.DockStyle.Top;
                F_SearchedFile.FileName_Label.Text = name;
                F_SearchedFile.FilePath_Label.Text = path;
                if (Array.IndexOf(txtExtensions, extension) != -1)
                {
                    F_SearchedFile.Extension_Picture.Image = F_SearchedFile.il.Images[0];

                }
                else if (Array.IndexOf(pdfExtensions, extension) != -1)
                {
                    F_SearchedFile.Extension_Picture.Image = F_SearchedFile.il.Images[1];

                }
                else if (Array.IndexOf(hwpExtensions, extension) != -1)
                {
                    F_SearchedFile.Extension_Picture.Image = F_SearchedFile.il.Images[2];

                }
                else if (Array.IndexOf(docxExtensions, extension) != -1)
                {
                    F_SearchedFile.Extension_Picture.Image = F_SearchedFile.il.Images[3];

                }
                else
                {

                }


                Item_Panel.Controls.Add(F_SearchedFile);

                F_SearchedFile.Show();
            }
                ));                                                
            //Console.WriteLine("Test: " + path);
        }

        private void Item_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time < 20)
            {
                time++;
            }
            else
            {
                if (Search_Progress.Value < 700)
                    Search_Progress.Value += 5;
                else if (Search_Progress.Value < 1000 && Search_Progress.Value >= 700)
                {
                    if (txtCompleted)
                    {
                        if (!txtsw)
                        {
                            txtsw = true;
                            Search_Progress.Value += 50;
                        }
                    }
                    if (docCompleted)
                    {
                        if (!docsw)
                        {
                            docsw = true;
                            Search_Progress.Value += 50;
                        }
                    }
                    if (docxCompleted)
                    {
                        if (!docxsw)
                        {
                            docxsw = true;
                            Search_Progress.Value += 50;
                        }
                    }
                    if (hwpCompleted)
                    {
                        if (!hwpsw)
                        {
                            hwpsw = true;
                            Search_Progress.Value += 50;
                        }
                    }
                    if (pdfCompleted)
                    {
                        if (!pdfsw)
                        {
                            pdfsw = true;
                            Search_Progress.Value += 100;
                        }
                    }

                }
                else
                    timer1.Stop();
            }
        }
    }
}
