﻿using System;
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
        public Account()
        {
            InitializeComponent();
        }

        private void SingUp_Btn_Click(object sender, EventArgs e)
        {
            Account_Panel.Controls.Clear();
            F_Signup = new Signup();
            F_Signup.TopLevel = false;
            F_Signup.Dock = System.Windows.Forms.DockStyle.Fill;
            Account_Panel.Controls.Add(F_Signup);
            F_Signup.Show();

        }

        private void SignIn_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                //아이디 입력 안 했을 때
                if (ID_Text.Text.Length == 0)
                {
                    MessageBox.Show("아이디를 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //비밀번호 입력 안 했을 때
                if (PW_Text.Text.Length == 0)
                {
                    MessageBox.Show("비밀번호를 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
                    MessageBox.Show(Properties.Settings.Default.ID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
