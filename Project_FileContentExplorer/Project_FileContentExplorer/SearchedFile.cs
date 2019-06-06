using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Project_FileContentExplorer
{
    public partial class SearchedFile : Form
    {
        Panel Home_Panel;
        
        public SearchedFile(Panel panel)
        {
            InitializeComponent();
            Home_Panel = panel;
            Extension_Picture.Image = il.Images[0];
        }

        public SearchedFile()
        {
            InitializeComponent();
            //Default
           
        }

        private void SearchedFile_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(this.FilePath_Label.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("파일을 연결프로그램으로 열기 실패" + ex.ToString());
            }
        }

        private void SearchedFile_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(47, 57, 78);
        }

        private void SearchedFile_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(69, 79, 100);
        }

        private void Upload_Btn_Click(object sender, EventArgs e)
        {
            string path = this.FilePath_Label.Text;
            string user_name = Properties.Settings.Default.ID;

            if (user_name.Equals(""))
            {
                MessageBox.Show("로그인 후 업로드가 가능합니다.");
                return;
            }


            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);
            fs.Close();

            Http http = new Http("File_Upload.php");
            string footer = "\r\n--" + http.Boundary + "--\r\n";
            http.formDataStream = new MemoryStream();

            string header = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\"\r\nContent-Type: {3}\r\n\r\n",//파일
                        http.Boundary,
                        "file",//php 변수 'file'
                        path, //파일 풀 경로
                        "application/octet-stream"); //확장자

            http.formDataStream.Write(Encoding.UTF8.GetBytes(header), 0, Encoding.UTF8.GetByteCount(header));
            http.formDataStream.Write(data, 0, data.Length);
            http.formDataStream.Write(Encoding.UTF8.GetBytes(footer), 0, Encoding.UTF8.GetByteCount(footer));

            http.formDataStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));

            string postData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
                    http.Boundary,
                    "ID",
                    user_name);
            http.formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));


            http.formDataStream.Write(Encoding.UTF8.GetBytes(footer), 0, Encoding.UTF8.GetByteCount(footer));

            http.formDataStream.Position = 0;
            http.Data = new byte[http.formDataStream.Length]; //완성된 데이터 복사
            http.formDataStream.Read(http.Data, 0, http.Data.Length);
            http.formDataStream.Close();

            string result = http.File_Upload();

            if (result.Equals("1"))
            {
                MessageBox.Show("업로드 되었습니다.");
            }
        }



        //0: txt 1: pdf 2: hwp 3: doc, docx

    }
}
