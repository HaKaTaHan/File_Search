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
            label3.Font = new Font("Arial", 8, FontStyle.Bold);

            //검색한 갯수 출력
            label3.Text = mesg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
