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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void ChangeLocation_Btn_Click(object sender, EventArgs e)
        {
           
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    Scope_Text.Clear();
                    Scope_Text.AppendText(fbd.SelectedPath);
                }

                return;
            
        }

        private void PDF__Check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TXT_Check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HWP_Check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DOC_Text_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Scope_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void MonthFrom_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DayFrom_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YearFrom_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MonthTo_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DayTo_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YearTo_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
