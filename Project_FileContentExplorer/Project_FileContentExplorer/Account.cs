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
    public partial class Account : Form
    {
        Signup F_Signup;
        Findaccount F_Findaccount;
        Panel Home_Panel;
        public Account(Panel panel)//Home에서 넘어올 때 Findaccount에서 넘어올 때
        {
            InitializeComponent();
            Home_Panel = panel;
        }

        public Account(Panel panel,String ID)//Sign_Up에서 넘어올 때
        {
            InitializeComponent();
            ID_Text.Text = ID;
            Home_Panel = panel;
        }

        private void SingUp_Btn_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            F_Signup = new Signup(Home_Panel);
            F_Signup.TopLevel = false;
            F_Signup.Dock = System.Windows.Forms.DockStyle.Fill;
            Home_Panel.Controls.Add(F_Signup);
            
            F_Signup.Show();
            Close();
        }

        private void SignIn_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Http http = new Http("Login.php");

                http.PostParam.Append("ID="+ID_Text.Text);
                http.PostParam.Append("&PW="+PW_Text.Text);

                http.Data = UTF8Encoding.UTF8.GetBytes(http.PostParam.ToString());
                
                string result = http.Client_To_Server();

                
                
                if (result.Equals("-1"))//아이디가 존재하지 않는다.
                {
                    MessageBox.Show("존재하지 않는 회원입니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID_Text.Text = "";
                    PW_Text.Text = "";
                }
                else if (result.Equals("0"))//비밀번호가 틀렸다.
                {
                    MessageBox.Show("비밀번호가 맞지 않습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID_Text.Text = "";
                    PW_Text.Text = "";
                }
                else//로그인 후 폼으로 넘어간다. 로그인 정보 저장
                {
                    Properties.Settings.Default.ID = ID_Text.Text;
                    MessageBox.Show("로그인이 되었습니다.", "환영합니다", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show(Properties.Settings.Default.ID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            F_Findaccount = new Findaccount(Home_Panel);
            F_Findaccount.TopLevel = false;
            F_Findaccount.Dock = System.Windows.Forms.DockStyle.Fill;
            Home_Panel.Controls.Add(F_Findaccount);

            F_Findaccount.Show();
            Close();
        }
    }
}
