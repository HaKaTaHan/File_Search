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
    public partial class Alarm : Form
    {
        public Alarm(string mesg)
        {
            InitializeComponent();

            //적절한 폰트로 수정
            label3.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            //검색한 갯수 출력
            label3.Text = mesg;
        }

        public void setLabel1(string text)
        {   //처음 동기화 또는 검색 결과 labels text 를 바꿈
            label1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
