using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Documento
    {
        public string Description { get; set; }
        public string Name { get; set; }

        public Documento(string name) 
        { 
            Name = name;
        }
    }
}
