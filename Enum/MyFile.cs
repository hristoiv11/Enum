using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class MyFile
    {
        public MyFile(string name, string path, Rights fileRigths, byte[] fileData) {
            
            Name = name;
            Path = path;
            FileRights = fileRigths;
            FileData = fileData;
            
        
        }
        public string Name { get; set; }
        public string Path { get; set; }

        public Rights FileRights { get; set; }

        public byte[] FileData { get; set; }
    }
}
