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
        private int count=0;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        //폼이 로드되면 timer 시작
        private void Alarm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;  //1초 간격
            timer1.Start();
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer에서 3초가 되면 알림창 종료
            if(count>=3)
            {
                timer1.Enabled = false;
                count = 0;
                this.Close();
            }
            //3초 미만시 count증가
            else
            {
                count++;
            }
        }
    }
}
