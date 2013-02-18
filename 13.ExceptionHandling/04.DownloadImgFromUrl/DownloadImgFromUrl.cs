using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

    class DownloadImgFromUrl
    {
        static void Main()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../Logo-BASD.jpg");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Theres no such file!");
                }
                catch (WebException)
                {
                    Console.WriteLine("Connection error!");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("File not supported!");
                }
            }
        }
    }
