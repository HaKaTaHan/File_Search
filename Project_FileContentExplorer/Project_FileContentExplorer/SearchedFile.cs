using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //0: txt 1: pdf 2: hwp 3: doc, docx
        
    }
}
