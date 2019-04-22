using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DotNet.Utilities;
using System.IO;
namespace FTPUploadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"D:\03eBooks\02_后端系列";
            string folder = DateTime.Now.ToString("yyyy-MM-dd");
            FTPHelper ftp = new FTPHelper("192.168.0.101", "", "ftp", "ftp123");
            try
            {
                ftp.MakeDir(folder);
                if (!ftp.FileExist(filename.Remove(0, filename.LastIndexOf("\\") + 1)))
                {
                    ftp.GotoDirectory(folder, true);
                    ftp.Upload(filename);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        static void FtpUpload(string file)
        {
            if (Directory.Exists(file)) { }
        }
    }
}
