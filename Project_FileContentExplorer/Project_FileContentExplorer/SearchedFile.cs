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
            MessageBox.Show(path);
            
        }



        //0: txt 1: pdf 2: hwp 3: doc, docx

    }
}
