﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public interface IFileDownloader
    {
        public void DownloadFile(string url, string path);
    }
    internal class FileDownloader:IFileDownloader
    {
        public void DownloadFile(string url, string path) {
            var client = new WebClient();
            client.DownloadFile(url,path);
        }
    }
}
