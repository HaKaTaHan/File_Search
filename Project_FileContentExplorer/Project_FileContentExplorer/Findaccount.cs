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
    public partial class Findaccount : Form
    {
        Panel Home_Panel;
        Account F_Account;

        public Findaccount(Panel panel)
        {
            InitializeComponent();
            Home_Panel = panel;
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            Http http = new Http("Find_Info_Mail.php");

            http.PostParam.Append("Email=" + Email_Text.Text);
            

            http.Data = UTF8Encoding.UTF8.GetBytes(http.PostParam.ToString());

            string result = http.Client_To_Server();

            if (result.Equals("-1"))//없는 이메일
            {
                MessageBox.Show("이메일이 정확하지 않습니다 다시 입력해주세요");
                Email_Text.Text = "";
                Email_Text.Focus();
            }
            else//이메일 발송함
            {
                MessageBox.Show("회원님의 메일로 이메일이 발송되었습니다.");
                F_Account = new Account(Home_Panel);
                F_Account.TopLevel = false;
                F_Account.Dock = System.Windows.Forms.DockStyle.Fill;
                Home_Panel.Controls.Add(F_Account);
                F_Account.Show();
                Close();
            }
            
        }
    }
}
