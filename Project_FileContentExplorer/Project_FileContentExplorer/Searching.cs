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
    public partial class Searching : Form
    {
        SearchedFile F_SearchedFile;


        String Keyword;
        public Searching(String Keyword)
        {
            InitializeComponent();
            this.Keyword = Keyword;
        }

        private void Searching_Load(object sender, EventArgs e)
        {
            Keyword_Label.Text = Keyword; 
        }

        private void Pause_Btn_Click(object sender, EventArgs e)
        {
            Resume_Btn.Visible = true;
            Pause_Btn.Visible = false;
            Stop_Btn.Visible = true;
            //pause
        }

        private void Resume_Btn_Click(object sender, EventArgs e)
        {
            Resume_Btn.Visible = false;
            Stop_Btn.Visible = false;
            Pause_Btn.Visible = true;
        }

        private void Stop_Btn_Click(object sender, EventArgs e)
        {
            //quit thread
        }

        private void Test_Btn_Click(object sender, EventArgs e)
        {
            F_SearchedFile = new SearchedFile(Item_Panel);
            F_SearchedFile.TopLevel = false;
            F_SearchedFile.Dock = System.Windows.Forms.DockStyle.Top;
            Item_Panel.Controls.Add(F_SearchedFile);
            F_SearchedFile.Show();
        }
    }
}
