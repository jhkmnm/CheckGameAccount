using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using Utilities;

namespace 账号检测
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Get("https://secure.runescape.com/m=weblogin/loginform.ws?mod=www&ssl=0&dest=community");
        }

        public void Get(string url)
        {
            HttpWebRequest wrq = (HttpWebRequest)WebRequest.Create(url);
            wrq.Method = "GET";
            wrq.KeepAlive = false;
            wrq.ProtocolVersion = HttpVersion.Version10;
            wrq.CookieContainer = new CookieContainer();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            var v = wrq.GetResponse();
        }

        //public static string Post(string postData)
        //{
        //    Encoding dataEncode = Encoding.GetEncoding("utf-8");
        //    byte[] byteArray = dataEncode.GetBytes(postData); //转化
        //    HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("https://secure.runescape.com/m=weblogin/login.ws");
        //    webReq.Method = "POST";
        //    webReq.Accept = "*/*";
        //    webReq.Referer = postUrl;
        //    webReq.ContentType = "application/x-www-form-urlencoded";
        //    webReq.Headers.Add("Accept-Language", "zh-cn");
        //    webReq.Headers.Add("Accept-Encoding", "text");
        //    webReq.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0)";
        //    webReq.Host = host;
        //    webReq.CookieContainer = cookies;
        //    webReq.ContentLength = byteArray.Length;
        //    Stream newStream = webReq.GetRequestStream();
        //    newStream.Write(byteArray, 0, byteArray.Length);//写入参数
        //    newStream.Close();
        //    HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
        //    responseUrl = response.ResponseUri.AbsolutePath;
        //    StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
        //    var ret = sr.ReadToEnd();
        //    HtmlDocument htmlDoc = new HtmlDocument();
        //    htmlDoc.LoadHtml(ret);
        //    sr.Close();
        //    response.Close();
        //    newStream.Close();
        //    return htmlDoc;
        //}
    }
}
