using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace Project_FileContentExplorer
{
    public partial class FileDownload : Form
    {
        Panel Home_Panel;
        

        static string[] txtExtensions =
        {
            "txt"
        };

        static string[] hwpExtensions =
        {
            "hwp"
        };

        static string[] pdfExtensions =
        {
            "pdf"
        };

        static string[] docxExtensions =
        {
           "doc", "docx"
        };

        Font normal = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        string downpath;

        public FileDownload(Panel panel)
        {
            InitializeComponent();
            Home_Panel = panel;
        }

        private void FileDownload_Load(object sender, EventArgs e)
        {/*
            download_ListView.BeginUpdate();
            ListViewItem item;

            string userID = Properties.Settings.Default.ID;
            Http Get_User = new Http("Get_User_File.php");
            Get_User.PostParam.Append("ID=" + userID);
            Get_User.Data = UTF8Encoding.UTF8.GetBytes(Get_User.PostParam.ToString());

            string json = Get_User.Client_To_Server();
            //MessageBox.Show(json);
            JArray jArray = JArray.Parse(json);

            foreach (JObject jObject in jArray)
            {
                
                //MessageBox.Show(jObject["File_Name"].ToString());
                //MessageBox.Show(jObject["File_Extension"].ToString());
                //MessageBox.Show(jObject["File_URL"].ToString());
                

                item = new ListViewItem(jObject["File_Name"].ToString());
                item.SubItems.Add(jObject["File_Extension"].ToString());
                item.SubItems.Add(jObject["File_URL"].ToString());

                if (Array.IndexOf(txtExtensions, jObject["File_Extension"].ToString()) != -1)
                {
                    item.ImageIndex = 0;

                }
                else if (Array.IndexOf(pdfExtensions, jObject["File_Extension"].ToString()) != -1)
                {
                    item.ImageIndex = 1;

                }
                else if (Array.IndexOf(hwpExtensions, jObject["File_Extension"].ToString()) != -1)
                {
                    item.ImageIndex = 2;

                }
                else if (Array.IndexOf(docxExtensions, jObject["File_Extension"].ToString()) != -1)
                {
                    item.ImageIndex = 3;

                }
                else
                {

                }

                item.Font = normal;
                download_ListView.Items.Add(item);
            }
            download_ListView.EndUpdate();*/
        }

        private void download_ListView_DoubleClick(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                downpath = fbd.SelectedPath;
                int index;
                index = download_ListView.FocusedItem.Index;
                string name = download_ListView.Items[index].SubItems[0].Text;
                string url = download_ListView.Items[index].SubItems[2].Text;
                Http down = new Http(url);

                string fin = down.File_Download(downpath +"\\"+ name);
                if (fin.Equals("fin"))
                {
                    MessageBox.Show("다운이 완료되었습니다.");
                }
            }
        }

        private void FileDownload_VisibleChanged(object sender, EventArgs e)
        {
            download_ListView.BeginUpdate();
            ListViewItem item;
            download_ListView.Clear();
            string userID = Properties.Settings.Default.ID;
            Http Get_User = new Http("Get_User_File.php");
            Get_User.PostParam.Append("ID=" + userID);
            Get_User.Data = UTF8Encoding.UTF8.GetBytes(Get_User.PostParam.ToString());

            string json = Get_User.Client_To_Server();
            //MessageBox.Show(json);
            JArray jArray = JArray.Parse(json);
            
            foreach (JObject jObject in jArray)
            {
                /*
                MessageBox.Show(jObject["File_Name"].ToString());
                MessageBox.Show(jObject["File_Extension"].ToString());
                MessageBox.Show(jObject["File_URL"].ToString());
                */

                item = new ListViewItem(jObject["File_Name"].ToString());
                item.SubItems.Add(jObject["File_Extension"].ToString());
                item.SubItems.Add(jObject["File_URL"].ToString());

                if (Array.IndexOf(txtExtensions, jObject["File_Extension"].ToString()) != -1)
                {
                    item.ImageIndex = 0;

                }
                else if (Array.IndexOf(pdfExtensions, jObject["File_Extension"].ToString()) != -1)
                {
                    item.ImageIndex = 1;

                }
                else if (Array.IndexOf(hwpExtensions, jObject["File_Extension"].ToString()) != -1)
                {
                    item.ImageIndex = 2;

                }
                else if (Array.IndexOf(docxExtensions, jObject["File_Extension"].ToString()) != -1)
                {
                    item.ImageIndex = 3;

                }
                else
                {

                }

                item.Font = normal;
                download_ListView.Items.Add(item);
            }
            download_ListView.EndUpdate();
        }
    }
}
