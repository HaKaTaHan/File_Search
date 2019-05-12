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
using org.apache.pdfbox.util;
using Aspose.Words;

namespace Project_FileContentExplorer
{

    public partial class Search : Form
    {

        // 일단 검색어 상관 없이, 드라이브 속 pdf, hwp, doc, docx, txt 총 개수
        // 프로젝트 -> 프로젝트 속성 -> 응용 프로그램 -> 출력 형식 -> 콘솔
        // search 누르면 개수 
        string currentDirectory = Directory.GetCurrentDirectory();
        string keyword;
        string systemFolder = Environment.GetFolderPath(System.Environment.SpecialFolder.Windows);//윈도우 폴더
        int txtCount=0;
        int hwpCount = 0;
        int pdfCount = 0;
        int docCount = 0;
        int docxCount = 0;
        Searching F_Searching;
        Panel Home_Panel;
        public Search(Panel panel)
        {
            InitializeComponent();
            Home_Panel = panel;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_Search.Text.Length != 0)
            {
                txtCount = 0;
                hwpCount = 0;
                //p = 0;
                keyword = txt_Search.Text;
                Thread t1 = new Thread(new ThreadStart(txtWork));
                Thread t2 = new Thread(new ThreadStart(pdfWork));
                Thread t3 = new Thread(new ThreadStart(hwpWork));
                Thread t4 = new Thread(new ThreadStart(docWork));
                Thread t5 = new Thread(new ThreadStart(docxWork));
                t1.Start();                
                t2.Start();                
                t3.Start();                
                t4.Start();                
                t5.Start();             
            }

            F_Searching = new Searching(txt_Search.Text);
            F_Searching.TopLevel = false;
            F_Searching.Dock = System.Windows.Forms.DockStyle.Fill;
            Home_Panel.Controls.Add(F_Searching);

            F_Searching.Show();
            Close();
        }

        void txtWork()
        {
            //FileStream txtFileStream = File.Open(@"D:\txtList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            FileStream txtFileStream = File.Open(currentDirectory + "\\txtList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader txtReader = new StreamReader(txtFileStream);            
            while (true)
            {               
                string path = txtReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)                                   
                    continue;
                else
                    txtExtract(keyword, path);

                //Console.WriteLine(path);
            }
            Console.WriteLine("txt 검색 끝");
            Console.WriteLine("keyword가 들어있는 txt 개수 : " + txtCount);

            txtReader.Dispose();
            txtFileStream.Close();
        }

        void pdfWork()
        {
            FileStream pdfFileStream = File.Open(currentDirectory + "\\pdfList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader pdfReader = new StreamReader(pdfFileStream);
            while (true)
            {
                string path = pdfReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                else
                    pdfExtract(keyword, path);
            }
            Console.WriteLine("pdf 검색 끝");
            Console.WriteLine("keyword가 들어있는 pdf 개수 " + pdfCount);
            
            pdfReader.Dispose();
            pdfFileStream.Close();
        }

        void hwpWork()
        {
            FileStream hwpFileStream = File.Open(currentDirectory + "\\hwpList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader hwpReader = new StreamReader(hwpFileStream);
            while (true)
            {
                string path = hwpReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                else
                    hwpExtract(keyword, path);

                //Console.WriteLine(path);
            }
            Console.WriteLine("hwp 검색 끝");
            Console.WriteLine("keyword가 들어있는 hwp 개수 " + hwpCount);
            hwpReader.Dispose();
            hwpFileStream.Close();
        }
        void docWork()
        {
            FileStream docFileStream = File.Open(currentDirectory + "\\docList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader docReader = new StreamReader(docFileStream);
            while (true)
            {
                string path = docReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                else
                    docExtract(keyword, path);
            }
            Console.WriteLine("doc 검색 끝");
            Console.WriteLine("keyword가 들어있는 doc 개수 " + docCount);

            docReader.Dispose();
            docFileStream.Close();
        }

        void docxWork()
        {
            FileStream docxFileStream = File.Open(currentDirectory + "\\docxList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader docxReader = new StreamReader(docxFileStream);
            while (true)
            {
                string path = docxReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                else
                    docxExtract(keyword, path);
                //Console.WriteLine(path);
            }
            Console.WriteLine("docx 검색 끝");
            Console.WriteLine("keyword가 들어있는 docx 개수 " + docxCount);
            docxReader.Dispose();
            docxFileStream.Close();
        }

        public void txtExtract(string keyWord,string path)
        {
            try
            {
                //Console.WriteLine("txt 찾는중....");
                FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader textTxt = new StreamReader(fs);
                string all = textTxt.ReadToEnd();
                bool isExist = all.Contains(keyword);
                if (isExist)
                    txtCount++;
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
                //Console.WriteLine(path + " : pdf 찾는중....");
                doc = PDDocument.load(path);
                //doc = PDDocument.load(@"D:\Download\Chrome download\5 (1).pdf");
                PDFTextStripper stripper = new PDFTextStripper();
                //MessageBox.Show(stripper.getText(doc));
                bool isExist = stripper.getText(doc).Contains(keyWord);
                if (isExist)
                    pdfCount++;
                doc.close();
            }
            catch
            {
                return;
            }
          
        }
        public void hwpExtract(string keyWord, string path)
        {
            try
            {               
                //Console.WriteLine("hwp 찾는중....");
                StringBuilder sb = new StringBuilder();
                HWPMeta meta = new HWPMeta();
                H2TParser parser = new H2TParser();
                bool flg = parser.GetText(path, meta, sb);
                bool isExist = false;
                if (flg)
                {
                   isExist = sb.ToString().Contains(keyword);
                }
                if (isExist)
                    hwpCount++;
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

                bool isExist = doc.GetText().Contains(keyword);
                if (isExist)
                    docCount++;
                    
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
                bool isExist = doc.GetText().Contains(keyword);
                if (isExist)
                    docxCount++;
            }
            catch
            {
                return;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
