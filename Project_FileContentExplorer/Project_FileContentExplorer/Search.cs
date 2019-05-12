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

namespace Project_FileContentExplorer
{

    public partial class Search : Form
    {

        // 일단 검색어 상관 없이, 드라이브 속 pdf, hwp, doc, docx, txt 총 개수
        // 프로젝트 -> 프로젝트 속성 -> 응용 프로그램 -> 출력 형식 -> 콘솔
        // search 누르면 개수 
        string keyword;
        string systemFolder = Environment.GetFolderPath(System.Environment.SpecialFolder.Windows);//윈도우 폴더
        int k=0;
        int p = 0;
        public Search()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_Search.Text.Length != 0)
            {
                k = 0;
                p = 0;
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
        }

        void txtWork()
        {
            FileStream txtFileStream = File.Open(@"D:\txtList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
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
            Console.WriteLine("찾은 txt 개수 : " + k);

            txtReader.Dispose();
            txtFileStream.Close();
        }

        void pdfWork()
        {
            FileStream pdfFileStream = File.Open(@"D:\pdfList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader pdfReader = new StreamReader(pdfFileStream);
            while (true)
            {
                string path = pdfReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)                                    
                    continue;               
                //Console.WriteLine(path);
            }
            Console.WriteLine("pdf 검색 끝");
            
            pdfReader.Dispose();
            pdfFileStream.Close();
        }

        void hwpWork()
        {
            FileStream hwpFileStream = File.Open(@"D:\hwpList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
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
            Console.WriteLine("찾은 hwp 개수 " + p);
            hwpReader.Dispose();
            hwpFileStream.Close();
        }
        void docWork()
        {
            FileStream docFileStream = File.Open(@"D:\docList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader docReader = new StreamReader(docFileStream);
            while (true)
            {
                string path = docReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                //Console.WriteLine(path);
            }
            Console.WriteLine("doc 검색 끝");
            docReader.Dispose();
            docFileStream.Close();
        }
        void docxWork()
        {
            FileStream docxFileStream = File.Open(@"D:\docxList.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader docxReader = new StreamReader(docxFileStream);
            while (true)
            {
                string path = docxReader.ReadLine();
                if (path == "End")
                    break;
                else if (path == null)
                    continue;
                //Console.WriteLine(path);
            }
            Console.WriteLine("docx 검색 끝");
            docxReader.Dispose();
            docxFileStream.Close();
        }

        public void txtExtract(string keyWord,string path)
        {
            try
            {
                Console.WriteLine("찾는중....");
                FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader textTxt = new StreamReader(fs);
                string all = textTxt.ReadToEnd();
                bool isExist = all.Contains(keyword);
                if (isExist)
                    k++;
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
                FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader textHwp = new StreamReader(fs);
                string all = textHwp.ReadToEnd();
                bool isExist = all.Contains(keyword);
                if (isExist)
                    p++;
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
