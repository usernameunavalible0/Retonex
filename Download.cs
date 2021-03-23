using System;
using System.IO.Compression;
using System.IO;
using System.Net;

namespace Retonex
{
    public class Download
    {
        public static void Downloader()
        {
            using (WebClient webClient = new WebClient())
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                webClient.DownloadFileAsync(new Uri("https://files.minecraftforge.net/maven/net/minecraftforge/forge/1.12.2-14.23.5.2854/forge-1.12.2-14.23.5.2854-installer.jar"), desktop);
            }
        }
    }
}