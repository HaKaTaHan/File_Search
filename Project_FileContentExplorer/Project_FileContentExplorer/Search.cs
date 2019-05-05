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
    
    public partial class Search : Form
    {
        // 일단 검색어 상관 없이, 드라이브 속 pdf, hwp, doc, docx, txt 총 개수
        // 프로젝트 -> 프로젝트 속성 -> 응용 프로그램 -> 출력 형식 -> 콘솔
        // search 누르면 개수 
        int fileCount = 0;
        
        string systemFolder = Environment.GetFolderPath(System.Environment.SpecialFolder.Windows);//윈도우 폴더
        public Search()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            foreach (string path in Environment.GetLogicalDrives())
            {
                search(txt_Search.Text, path);
            }

            MessageBox.Show("pdf, hwp, doc, docx, txt 총 개수 : " + fileCount.ToString());
        }

        public void search(string keyWord, string path)
        {
            Stack<string> dirs = new Stack<string>(200);

            if (!System.IO.Directory.Exists(path))
            {
                throw new ArgumentException();
            }
            dirs.Push(path);

            while(dirs.Count > 0)
            {
                Application.DoEvents();

                string currentDIr = dirs.Pop();
                string[] subDirs;
                try
                {
                    subDirs = System.IO.Directory.GetDirectories(currentDIr);
                }
                catch(UnauthorizedAccessException e)
                {
                    //MessageBox.Show(e.Message);
                    continue;
                }
                catch(System.IO.DirectoryNotFoundException e)
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
                catch(UnauthorizedAccessException e)
                {
                    //MessageBox.Show(e.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    //MessageBox.Show(e.Message);
                    continue;
                }
                catch(Exception e)
                {
                    continue;
                }

                foreach(string file in files)
                {
                    try
                    {
                        //FileInfo fi = new FileInfo(file);                        
                        string[] split = file.Split('.');
                        switch (split[split.Length - 1])
                        {
                            case "pdf":
                            case "hwp":
                            case "txt":
                            case "doc":
                            case "docx":                                
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
    }
}
