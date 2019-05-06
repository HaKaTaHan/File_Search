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
    public partial class Home : Form
    {
        Search F_Search;
        Account F_Account;
        Setting F_Setting;

        public Home()
        {
            InitializeComponent();

            //프로그램 실행할 시 Search 폼을 Display_Area 패널에 띄운다.
            F_Search = new Search();
            F_Search.TopLevel = false;
            F_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            Display_Area.Controls.Add(F_Search);
            F_Search.Show();

        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            //열려있는 창 닫기
            if (F_Search != null)
                F_Search.Close();
            if (F_Account != null)
                F_Account.Close();
            if (F_Setting != null)
                F_Setting.Close();
            
            //Search_Btn이 클릭되었으므로 배경색깔을 바꿔준다.
            Search_Btn.BackColor = Color.FromArgb(98, 50, 170);
            Account_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Setting_Btn.BackColor = Color.FromArgb(35, 45, 65);

            //Search폼을 Display_Area 패널에 띄운다.
            F_Search = new Search();
            F_Search.TopLevel = false;
            F_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            Display_Area.Controls.Add(F_Search);
            F_Search.Show();

        }

        private void Account_Btn_Click(object sender, EventArgs e)
        {
            //열려있는 창 닫기
            if (F_Search != null)
                F_Search.Close();
            if (F_Account != null)
                F_Account.Close();
            if (F_Setting != null)
                F_Setting.Close();

            //Account_Btn이 클릭되었으므로 배경색깔을 바꿔준다.
            Search_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Account_Btn.BackColor = Color.FromArgb(98, 50, 170);
            Setting_Btn.BackColor = Color.FromArgb(35, 45, 65);

            //Account폼을 Display_Area 패널에 띄운다.
            F_Account = new Account();
            F_Account.TopLevel = false;
            F_Account.Dock = System.Windows.Forms.DockStyle.Fill;
            Display_Area.Controls.Add(F_Account);
            F_Account.Show();

        }

        private void Setting_Btn_Click(object sender, EventArgs e)
        {
            //열려있는 창 닫기
            if (F_Search != null)
                F_Search.Close();
            if (F_Account != null)
                F_Account.Close();
            if (F_Setting != null)
                F_Setting.Close();

            //Setting_Btn이 클릭되었으므로 배경색깔을 바꿔준다.
            Search_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Account_Btn.BackColor = Color.FromArgb(35, 45, 65);
            Setting_Btn.BackColor = Color.FromArgb(98, 50, 170);

            //Setting폼을 Display_Area 패널에 띄운다.
            F_Setting = new Setting();
            F_Setting.TopLevel = false;
            F_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            Display_Area.Controls.Add(F_Setting);
            F_Setting.Show();

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Display_Area_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
