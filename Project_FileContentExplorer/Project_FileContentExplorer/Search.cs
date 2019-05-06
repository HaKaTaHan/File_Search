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
        
        int timer=0;
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
            //Setting.ext = 
            /*
            foreach (string path in Environment.GetLogicalDrives())
            {
                search(txt_Search.Text, path);
            }
            */
            //MessageBox.Show("pdf, hwp, doc, docx, txt 총 개수 : " + fileCount.ToString());
            Alarm alrm = new Alarm(fileCount.ToString());

            System.Drawing.Rectangle ScreenRectangle = Screen.PrimaryScreen.WorkingArea;

            int xPos = ScreenRectangle.Width - alrm.Bounds.Width;
            int yPos = ScreenRectangle.Height - alrm.Bounds.Height;
            alrm.Show();
            alrm.SetBounds(xPos, yPos, alrm.Size.Width, alrm.Size.Height, BoundsSpecified.Location);
            alrm.BringToFront();
        }      
    }
}
