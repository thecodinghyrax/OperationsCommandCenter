using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary
{
    public class FilesModel
    {
        public int Id { get; set; }
        public string fileName { get; set; }
        public string filePath { get; set; }

        public string nameWithExt
        {
            get
            {
                var splitPath = filePath.Split('\\');
                return splitPath[splitPath.Length - 1];
            }
        }

        public override string ToString()
        {
            return filePath;
        }
    }

    public class ConfigModel
    {
        public int id { get; set; }
        public string settingName { get; set; }
        public string settingText { get; set; }

        public override string ToString()
        {
            return settingText;
        }
    }
}
