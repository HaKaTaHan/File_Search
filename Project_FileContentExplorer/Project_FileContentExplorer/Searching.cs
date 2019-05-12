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
    public partial class Searching : Form
    {
        String Keyword;
        public Searching(String Keyword)
        {
            InitializeComponent();
            this.Keyword = Keyword;
        }
    }
}
