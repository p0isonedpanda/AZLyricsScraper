using System;
using System.Xml;
using System.Net;
using HtmlAgilityPack;

namespace HTMLAgilityTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            string html;
            using (WebClient client = new WebClient())
            {
                html = client.DownloadString("https://www.azlyrics.com/lyrics/handslikehouses/afireonahill.html");
            }

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
    
            HtmlNodeCollection htmlBody = htmlDoc.DocumentNode.SelectNodes("//comment()/..");
		    
		    Console.WriteLine(htmlBody[8].InnerText);		
        }
    }
}
