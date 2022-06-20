using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Extensions
{
    public static class FileInfoExtensions
    {
        public static string GetNameWithOutExtension(this FileInfo file)
        {
            return file.Name.Replace(file.Extension, string.Empty);
        }
    }
}
