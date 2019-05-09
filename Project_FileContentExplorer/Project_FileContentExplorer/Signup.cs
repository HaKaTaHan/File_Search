using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FileContentExplorer
{
    public partial class Signup : Form
    {
        Account F_Account;
        Panel Home_Panel;
        public Signup(Panel Home_Panel)
        {
            InitializeComponent();
            this.Home_Panel = Home_Panel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckID_Btn_Click(object sender, EventArgs e)
        {
            //아이디가 6자 미만일 경우
            if (ID_text.Text.Length < 6)
            {
                MessageBox.Show("아이디는 6자 이상 입력하셔야합니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            Http http = new Http("ID_Check.php");
            http.PostParam.Append("ID=" + ID_text.Text);

            http.Data = UTF8Encoding.UTF8.GetBytes(http.PostParam.ToString());

            string result = http.Client_To_Server();

            if (result.Equals("-1"))//이미 있는 아이디인 경우
            {
                ID_Error.Visible = true;

            }
            else if (result.Equals("1"))//아닌 경우
            {
                CheckID_Btn.BackColor = Color.FromArgb(12, 180, 82);
                CheckID_Btn.ForeColor = Color.FromArgb(255, 255, 255);
                CheckID_Btn.Enabled = false;
                ID_Error.Text = "Available ID";
                ID_Error.ForeColor = Color.Green;
                ID_Error.Visible = true;
                ID_text.ReadOnly = true;
            }
        }

        private void ID_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsLower(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ID_text_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[a-zA-Z0-9]");
            Boolean ismatch = regex.IsMatch(ID_text.Text);

            if (ID_text.Text.Length == 0)
            {
                MessageBox.Show("아이디를 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID_text.Focus();
            }

            if (!ismatch)
            {
                MessageBox.Show("아이디는 영문자,숫자만 가능합니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID_text.Text = "";
                ID_text.Focus();
            }
        }

        private void SingUp_Btn_Click(object sender, EventArgs e)
        {
            if (CheckID_Btn.Enabled)
            {
                MessageBox.Show("아이디 확인을 해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID_text.Focus();
                return;
            }


            if (PW_text.Text.Length < 8)
            {
                MessageBox.Show("비밀번호는 8자 이상 입력하셔야합니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PW_text.Focus();
                return;
            }

            if(Email_text.Text.Length ==0 || Email_Combo.SelectedItem.ToString().Length == 0)
            {
                MessageBox.Show("이메일을 입력하세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Email_text.Focus();
                return;
            }


            Http http = new Http("SignUp.php");
            http.PostParam.Append("ID=" + ID_text.Text);
            http.PostParam.Append("&PW=" + PW_text.Text);
            http.PostParam.Append("&Email=" + Email_text.Text + "@" + Email_Combo.SelectedItem.ToString());
            http.Data = UTF8Encoding.UTF8.GetBytes(http.PostParam.ToString());

            string result = http.Client_To_Server();

            if (result.Equals("-1"))//회원 가입 실패
            {
                MessageBox.Show("회원 가입도중 오류가 났습니다 잠시 후 다시 실행해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result.Equals("1"))//회원 가입 성공
            {
                F_Account = new Account(Home_Panel,ID_text.Text);
                F_Account.TopLevel = false;
                F_Account.Dock = System.Windows.Forms.DockStyle.Fill;
                Home_Panel.Controls.Add(F_Account);
                F_Account.Show();
                Close();
            }
        }

        private void Confirm_text_TextChanged(object sender, EventArgs e)
        {
            if (PW_text.Text.Equals(Confirm_text.Text))
            {

                PW_Check_Label.Text = "Correct!";
                PW_Check_Label.ForeColor = Color.Green;
                PW_Check_Label.Visible = true;
            }
            else
            {
                PW_Check_Label.Text = "* Passwords don't match!";
                PW_Check_Label.ForeColor = Color.Red;
                PW_Check_Label.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Email_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (Email_Combo.SelectedIndex == 0)//직접입력 시
            {
                
                Email_Combo.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                Email_Combo.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
    }
}
