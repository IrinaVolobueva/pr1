using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1
{
    internal class File
    {
        double size;
        string author, name, expansion;
        
        public File(double size, string author, string name, string expansion)
        {
            this.size = size;
            this.author = author;
            this.name = name;
            this.expansion = expansion;
        }


    }
}
