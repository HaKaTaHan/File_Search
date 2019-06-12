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
using System.Collections;

namespace Project_FileContentExplorer
{
    public partial class Searching : Form
    {
        Search F_Search;
        SearchedFile F_SearchedFile;
        Panel Home_Panel;
        Searching F_Searching;
        String Keyword;
        public static Thread txtThread;
        public static Thread pdfThread;
        public static Thread hwpThread;
        public static Thread docThread;
        public static Thread docxThread;
        // 일단 검색어 상관 없이, 드라이브 속 pdf, hwp, doc, docx, txt 총 개수
        // 프로젝트 -> 프로젝트 속성 -> 응용 프로그램 -> 출력 형식 -> 콘솔
        // search 누르면 개수 
        string currentDirectory = Directory.GetCurrentDirectory();
        string keyword;
        string systemFolder = Environment.GetFolderPath(System.Environment.SpecialFolder.Windows);//윈도우 폴더

        ArrayList sf = new ArrayList();

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

        bool txtCompleted = false;
        bool txtsw = false;
        bool pdfCompleted = false;
        bool pdfsw = false;
        bool hwpCompleted = false;
        bool hwpsw = false;
        bool docCompleted = false;
        bool docsw = false;
        bool docxCompleted = false;
        bool docxsw = false;

        bool completesw = false;

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


        public Searching(Panel panel, String Keyword)
        {
            InitializeComponent();
            this.Keyword = Keyword;
            ProgressInit();
            this.Home_Panel = panel;
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

        public void SearchingComplete()
        {
            completesw = true;
            int filenum = txtCount + hwpCount + pdfCount + docCount + docxCount;
            //MessageBox.Show("검색이 완료되었습니다");
  
            Resume_Btn.Visible = false;
            Stop_Btn.Visible = false;
            Pause_Btn.Visible = false;
            Task.Run(() =>
            {
                change_button();
            });
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

                if (txtChecked + pdfChecked + hwpChecked + docxChecked + docChecked + docxChecked == 0)
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
            txtCompleted = true;
            //if (txtCompleted) MessageBox.Show("txt끝"); 
            if (txtCompleted && pdfCompleted && hwpCompleted && docCompleted && docxCompleted)
            {
                SearchingComplete();
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
            pdfCompleted = true;
            //if (pdfCompleted) MessageBox.Show("pdf끝");
            if (txtCompleted && pdfCompleted && hwpCompleted && docCompleted && docxCompleted)
            {
                SearchingComplete();
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
            hwpCompleted = true;
            //if (hwpCompleted) MessageBox.Show("hwp끝");
            if (txtCompleted && pdfCompleted && hwpCompleted && docCompleted && docxCompleted)
            {
                SearchingComplete();
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
            docCompleted = true;
            //if (docCompleted) MessageBox.Show("doc끝");
            if (txtCompleted && pdfCompleted && hwpCompleted && docCompleted && docxCompleted)
            {
                SearchingComplete();
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
            docxCompleted = true;
            //if (docxCompleted) MessageBox.Show("docx끝");
            if (txtCompleted && pdfCompleted && hwpCompleted && docCompleted && docxCompleted)
            {
                SearchingComplete();
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


                    Task.Run(() =>
                    {
                        Add_Item(Path.GetFileNameWithoutExtension(path), path, Path.GetExtension(path));
                    });
                    Thread.Sleep(200);
                }
                fs.Close();
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

                    Task.Run(() =>
                    {
                        Add_Item(Path.GetFileNameWithoutExtension(path), path, Path.GetExtension(path));
                    });
                    Thread.Sleep(200);
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
                    Task.Run(() =>
                    {
                        Add_Item(Path.GetFileNameWithoutExtension(path), path, Path.GetExtension(path));
                    });
                    Thread.Sleep(200);
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

                    Task.Run(() =>
                    {
                        Add_Item(Path.GetFileNameWithoutExtension(path), path, Path.GetExtension(path));
                    });                    
                    Thread.Sleep(200);
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

                    Task.Run(() =>
                    {
                        Add_Item(Path.GetFileNameWithoutExtension(path), path, Path.GetExtension(path));
                    });
                    Thread.Sleep(200);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return;
            }
        }



        private void Pause_Btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Resume_Btn.Visible = true;
            Pause_Btn.Visible = false;
            Stop_Btn.Visible = true;
            //pause
            try
            {
                if (txtChecked != 0 && txtThread.ThreadState.ToString() != "Stopped")
                {
                    txtThread.Suspend();                    
                }
                if (pdfChecked != 0 && pdfThread.ThreadState.ToString() != "Stopped")
                {
                    pdfThread.Suspend();                    
                }
                if (hwpChecked != 0 && hwpThread.ThreadState.ToString() != "Stopped")
                {
                    hwpThread.Suspend();                    
                }
                if (docChecked != 0 && docThread.ThreadState.ToString() != "Stopped")
                {
                    docThread.Suspend();                    
                }
                if (docxChecked != 0 && docxThread.ThreadState.ToString() != "Stopped")
                {
                    docxThread.Suspend();                    
                }
                if (txtChecked + pdfChecked + hwpChecked + docxChecked + docChecked + docxChecked == 0)
                {
                    if (txtThread.ThreadState.ToString() != "Stopped")
                    {
                        txtThread.Suspend();                        
                    }
                    if (pdfThread.ThreadState.ToString() != "Stopped")
                    {
                        pdfThread.Suspend();                        
                    }
                    if (hwpThread.ThreadState.ToString() != "Stopped")
                    {
                        hwpThread.Suspend();                        
                    }
                    if (docThread.ThreadState.ToString() != "Stopped")
                    {
                        docThread.Suspend();                        
                    }
                    if (docxThread.ThreadState.ToString() != "Stopped")
                    {
                        docxThread.Suspend();                        
                    }
                }
            }
            catch
            {
                return;
            }

        }

        private void Tohome_Btn_Click (object sender, EventArgs e)
        {
            F_Search = new Search(Home_Panel);
            F_Search.TopLevel = false;
            F_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            Home_Panel.Controls.Add(F_Search);
            foreach(SearchedFile F_SearchedFile in sf)
            {
                F_SearchedFile.Close();
            }
            F_Search.Show();
            this.Close();

        }

        private void Resume_Btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Resume_Btn.Visible = false;
            Stop_Btn.Visible = false;
            Pause_Btn.Visible = true;
            //Console.WriteLine(pdfThread.ThreadState.ToString());
            try
            {
                if (txtChecked != 0 && txtThread.ThreadState.ToString() == "Suspended")
                {
                    txtThread.Resume();                    
                }
                if (pdfChecked != 0 && pdfThread.ThreadState.ToString() == "Suspended")
                {
                    pdfThread.Resume();                    
                }
                if (hwpChecked != 0 && hwpThread.ThreadState.ToString() == "Suspended")
                {
                    hwpThread.Resume();                    
                }
                if (docChecked != 0 && docThread.ThreadState.ToString() == "Suspended")
                {
                    docThread.Resume();                    
                }
                if (docxChecked != 0 && docxThread.ThreadState.ToString() == "Suspended")
                {
                    docxThread.Resume();                    
                }
                if (txtChecked + pdfChecked + hwpChecked + docxChecked + docChecked + docxChecked == 0)
                {
                    txtThread.Resume();                    
                    pdfThread.Resume();                    
                    hwpThread.Resume();                    
                    docThread.Resume();                    
                    docxThread.Resume();                    
                }
            }
            catch
            {
                return;
            }
        }

        private void Stop_Btn_Click(object sender, EventArgs e)
        {
            Resume_Btn.Visible = false;
            Stop_Btn.Visible = false;
            Tohome_Btn.Visible = true;

            //quit thread

            try
            {
                //Console.WriteLine(txtThread.ThreadState);
                //Console.WriteLine(hwpThread.ThreadState);
                //Console.WriteLine(pdfThread.ThreadState);
                //Console.WriteLine(docThread.ThreadState);
                //Console.WriteLine(docxThread.ThreadState);                                

                if (txtThread.ThreadState.ToString() == "Suspended")
                {
                    //txtThread.Resume();
                    try
                    {
                        txtThread.Abort();
                    }
                    catch
                    {

                    }
                    
                }
                if (pdfThread.ThreadState.ToString() == "Suspended")
                {
                    //pdfThread.Resume();
                    try
                    {
                        pdfThread.Abort();
                    }
                    catch
                    {

                    }
                    
                }
                if (hwpThread.ThreadState.ToString() == "Suspended")
                {
                    //hwpThread.Resume();
                    try
                    {
                        hwpThread.Abort();
                    }
                    catch
                    {

                    }
                    
                }
                if (docThread.ThreadState.ToString() == "Suspended")
                {
                    //docThread.Resume();
                    try
                    {
                        docThread.Abort();
                    }
                    catch
                    {

                    }
                    
                }
                if (docxThread.ThreadState.ToString() == "Running" || docxThread.ThreadState.ToString() == "Suspended")
                {
                    //docxThread.Resume();
                    try
                    {
                        docxThread.Abort();
                    }
                    catch
                    {

                    }
                    
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
        private void change_button()
        {
            this.Invoke((System.Action)(() =>
            {
                Tohome_Btn.Visible = true;
            }));
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
                sf.Add(F_SearchedFile);
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
            if (time < 2)
            {
                time++;
                if (completesw)
                {
                    Search_Progress.Value = Search_Progress.Maximum;
                }
            }
            else
            {
                if (Search_Progress.Value < 900)
                {
                    if (completesw)
                    {
                        Search_Progress.Value = Search_Progress.Maximum;
                    }
                    else
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
                        Search_Progress.Value += 5;
                    }
                }
                else if (Search_Progress.Value < 1000 && Search_Progress.Value >= 900)
                {
                    if (completesw)
                    {
                        Search_Progress.Value = Search_Progress.Maximum;
                    }
                    else
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

                }
                else
                    timer1.Stop();
            }
        }
    }
}
