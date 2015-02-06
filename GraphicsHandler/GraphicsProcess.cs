using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace GraphicsHandler
{
    public class GraphicsProcess
    {
        private string m_OldRootPath;
        private string m_NewRootPath;
        private int m_Width;
        private int m_Height;
        private int m_QualityNumber;
        private List<String> m_ConvertErrorData = new List<string>();
        private int m_ConvertedPercent;
        private int m_ConvertedNumber;
        private string m_Status;
        //private int m_ConvertFilesSum;

        public int ConvertedPercent
        {
            get { return this.m_ConvertedPercent; }
        }

        public int ConvertedNumber
        {
            get { return this.m_ConvertedNumber; }
        }

        public string Status
        {
            get { return this.m_Status; }
        }

        //public int ConvertFilesSum
        //{
        //    get { return this.m_ConvertFilesSum; }
        //}

        public GraphicsProcess(string oldPath, string newPath, int width, int height, int qualityNumber, ref List<String> convertErrorData)
        {
            this.m_OldRootPath = oldPath;
            this.m_NewRootPath = newPath;
            this.m_Width = width;
            this.m_Height = height;
            this.m_QualityNumber = qualityNumber;
            this.m_ConvertErrorData = convertErrorData;
            this.m_ConvertedPercent = 0;
        } 


        /// <summary>
        /// 压缩转换
        /// </summary>
        public bool ImageConvert(string strOldFileName, string strNewFileName, int intWidth, int intHeight, int qty)
        {
            System.Drawing.Bitmap oldBmp, newBmp;
            try
            {
                using (oldBmp = new Bitmap(strOldFileName))
                {
                    using (newBmp = new Bitmap(oldBmp, intWidth, intHeight))
                    {
                        if (strNewFileName.EndsWith(".png") || strNewFileName.EndsWith(".PNG"))
                            newBmp.Save(strNewFileName);
                        else
                            LostConvert(newBmp, strNewFileName, qty);
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// JPEG的有选择的压损转换
        /// </summary>
        public void LostConvert(Bitmap bmp, string fileName, int qty)
        {
            using (EncoderParameter p = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qty))
            {
                using (EncoderParameters ps = new EncoderParameters(1))
                {
                    ps.Param[0] = p;
                    bmp.Save(fileName, GetCodecInfo("image/jpeg"), ps);
                }
            }
        }

        private ImageCodecInfo GetCodecInfo(string mimeType)
        {
            ImageCodecInfo[] codecInfo = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo ici in codecInfo)
            {
                if (ici.MimeType == mimeType) return ici;
            }
            return null;
        }

        /// <summary>
        /// 创建新的文件夹
        /// </summary>
        /// <param name="_path"></param>
        public void CreateFolder(string path)
        {
            FileInfo file = new FileInfo(path);
            DirectoryInfo dirInfo = new DirectoryInfo(file.DirectoryName);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }


        public void ConvertProcess()
        {
            DirectoryInfo oldDir = new DirectoryInfo(this.m_OldRootPath);
            if (!oldDir.Exists)
                return;
            this.m_Status = "开始转换:";
            GetDirectoriesAndFilesAndConvert(oldDir.GetFileSystemInfos());
            this.m_Status = "完成转换:";
        }


        private void GetDirectoriesAndFilesAndConvert(FileSystemInfo[] FSInfo)
        {
            foreach (FileSystemInfo i in FSInfo)
            {
                if (i is DirectoryInfo)
                {
                    DirectoryInfo dInfo = (DirectoryInfo)i;
                    GetDirectoriesAndFilesAndConvert(dInfo.GetFileSystemInfos());
                }
                else if (i is FileInfo)
                {
                    string fileExtension = i.Extension;
                    if (fileExtension == ".jpg" || fileExtension == ".JPG" || fileExtension == ".png" || fileExtension == ".PNG")
                    {
                        StringBuilder oldFileName = new StringBuilder(i.FullName);
                        string newFileName = oldFileName.Replace(this.m_OldRootPath, this.m_NewRootPath).ToString();
                        CreateFolder(newFileName);
                        bool isSuccess = ImageConvert(i.FullName, newFileName, m_Width, m_Height, m_QualityNumber);
                        if (!isSuccess)
                        {
                            this.m_ConvertErrorData.Add(oldFileName.ToString());
                        }
                        this.m_ConvertedNumber++;
                    }
                }

            }
        }
    }

}
