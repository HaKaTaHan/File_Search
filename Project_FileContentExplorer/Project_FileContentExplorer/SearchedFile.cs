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
        }

        public SearchedFile()
        {
            InitializeComponent();
            //Default
            Extension_Picture.Image = il.Images[0];
        }

        private void SearchedFile_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(this.FilePath_Label.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("파일 해당 프로그램으로 열기 실패" + ex.Message);

            }
        }

        //0: txt 1: pdf 2: hwp 3: doc, docx

    }
}
