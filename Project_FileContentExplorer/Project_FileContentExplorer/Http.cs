using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project_FileContentExplorer
{
    class Http
    {
        public StringBuilder PostParam = new StringBuilder();
        public byte[] Data;
        HttpWebRequest Request;
        public Stream formDataStream;
        string IP = "";//your ServerIP
        string PHP;
        public string Boundary = String.Format("----------{0:N}", Guid.NewGuid());
        public Http(string PHP)
        {
            this.PHP = PHP;
        }
        //test용 차후에 Json 반환해야할듯
        public string Client_To_Server()
        {
            
            Request = (HttpWebRequest)WebRequest.Create(IP+PHP);
            Request.Credentials = CredentialCache.DefaultCredentials;
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";
            Request.ContentLength = Data.Length;

            //데이터 전송
            Stream Write_Data = Request.GetRequestStream();
            Write_Data.Write(Data, 0, Data.Length);
            Write_Data.Close();

            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            
            StreamReader reader = new StreamReader(dataStream);
            string From_Server = reader.ReadToEnd();

            reader.Close();
            response.Close();

            return From_Server;
        }

        public string File_Upload()
        {

            string ContentType = "multipart/form-data; boundary=" + Boundary;


            Request = (HttpWebRequest)WebRequest.Create(IP + PHP);
            Request.Credentials = CredentialCache.DefaultCredentials;
            Request.Method = "POST";
            Request.ContentType = ContentType;
            Request.CookieContainer = new CookieContainer();
            Request.ContentLength = Data.Length;
            Request.KeepAlive = true;


            //데이터 전송
            Stream Write_Data = Request.GetRequestStream();
            Write_Data.Write(Data, 0, Data.Length);
            Write_Data.Flush();
            Write_Data.Close();

            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);
            string From_Server = reader.ReadToEnd();

            reader.Close();
            response.Close();

            return From_Server;
        }

        public string File_Download(string path)
        {
            Request = (HttpWebRequest)WebRequest.Create(IP + PHP);
            Request.Credentials = CredentialCache.DefaultCredentials;
            Request.Method = "POST";
            Request.ContentType = "application/x-www-form-urlencoded";

            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            byte[] read = new byte[4096];

            int bytes = dataStream.Read(read, 0, read.Length);

            FileStream FileStr = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            Encoding encode;
            encode = System.Text.Encoding.Default;

            // FileStream에 byte 쓰기
            // 스트림의 끝에 도달 하면 0 이 Return
            while (bytes > 0)
            {
                // 버퍼의 데이터를 사용하여 이 스트림에 바이트 블록을 씀
                FileStr.Write(read, 0, bytes);
                bytes = dataStream.Read(read, 0, read.Length);

            }
            // Save File
            BinaryWriter Savefile = new BinaryWriter(FileStr, encode);
            Savefile.Close();

            return "fin";
        }
    }
}
