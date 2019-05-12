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
            if (!Properties.Settings.Default.pdfList.Equals(""))
            {
                PDF__Check.Checked = true;
            }
            if (!Properties.Settings.Default.txtList.Equals(""))
            {
                TXT_Check.Checked = true;
            }
            if (!Properties.Settings.Default.hwpList.Equals(""))
            {
                HWP_Check.Checked = true;
            }
            if (!Properties.Settings.Default.docList.Equals(""))
            {
                DOC_Text.Checked = true;
            }
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
            if (PDF__Check.Checked)
            {
                Properties.Settings.Default.pdfList = "pdfList.txt";
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.pdfList = "";
                Properties.Settings.Default.Save();
            }
            
        }

        private void TXT_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (TXT_Check.Checked)
            {
                Properties.Settings.Default.txtList = "txtList.txt";
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.txtList = "";
                Properties.Settings.Default.Save();
            }
            
        }

        private void HWP_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (HWP_Check.Checked)
            {
                Properties.Settings.Default.hwpList = "hwpList.txt";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.hwpList = "";
                Properties.Settings.Default.Save();
            }
            
        }

        private void DOC_Text_CheckedChanged(object sender, EventArgs e)
        {
            if (DOC_Text.Checked)
            {
                Properties.Settings.Default.docList = "docList.txt";
                Properties.Settings.Default.docxList = "docxList.txt";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.docList = "";
                Properties.Settings.Default.docxList = "";
                Properties.Settings.Default.Save();
            }
            
        }

        private void Scope_Text_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Path_Scope = fbd.SelectedPath;
            Properties.Settings.Default.Save();
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
