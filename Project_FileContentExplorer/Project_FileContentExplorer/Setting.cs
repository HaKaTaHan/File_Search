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

                    textBox1.Clear();
                    textBox1.AppendText(fbd.SelectedPath);
                }

                return;
            
        }
    }
}
