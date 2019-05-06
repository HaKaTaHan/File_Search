﻿using System;
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
        string IP = "http://ec2-52-79-229-92.ap-northeast-2.compute.amazonaws.com/Project/";//your ServerIP
        string PHP;

        public Http(string PHP)
        {
            this.PHP = PHP;
        }
        
        public string Client_To_Server()//단순 문자열 반환
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
    }
}
