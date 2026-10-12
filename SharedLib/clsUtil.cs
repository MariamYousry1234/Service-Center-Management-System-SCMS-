using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;

namespace SharedLib
{
    public static class clsUtil
    {

        private static void _CreateFolder(string FolderName)
        {
            if(!Directory.Exists(FolderName))
               Directory.CreateDirectory(FolderName);
        }

        private static string _CreateNewImagePath(string FolderName, string SourceImagePath)
        {
            FileInfo file =new FileInfo( SourceImagePath);

           
           return  FolderName+(Guid.NewGuid()+file.Extension).ToString();
        }
        public static bool SaveImageToFolder(string SourceImagePath,string FolderName,ref string NewImagePath)
        {
            _CreateFolder(FolderName);

            NewImagePath= _CreateNewImagePath(FolderName,SourceImagePath);

            File.Copy(SourceImagePath, NewImagePath);

            return true;
        }

        public static bool DeleteImageFromFolder(string ImagePath)
        {
            if (!File.Exists(ImagePath))
                return false;


            File.Delete(ImagePath);

            return true;
        }


    }
}
