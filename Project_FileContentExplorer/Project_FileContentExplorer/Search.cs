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

    public partial class Search : Form
    {

        Panel Home_Panel;
        Searching F_Searching;
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
            if (txt_Search.Text.Length > 0) //검색어가 적혀 있을 때 Search 버튼 눌러야 폼 바뀜
            {
                F_Searching = new Searching(Home_Panel ,txt_Search.Text);
                F_Searching.TopLevel = false;
                F_Searching.Dock = System.Windows.Forms.DockStyle.Fill;
                Home_Panel.Controls.Add(F_Searching);
                F_Searching.Show();
                Close();
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
