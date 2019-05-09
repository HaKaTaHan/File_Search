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
        public Signup()
        {
            InitializeComponent();
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
            if (PW_text.Text.Length < 8)
            {
                MessageBox.Show("비밀번호는 8자 이상 입력하셔야합니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PW_text.Focus();
                return;
            }

            //이메일까지 해서 날려야함
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
    }
}
