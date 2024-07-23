using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class SimplePrinter : ISimplePrinter
    {
        public void Print(Documento documento)
        {
            Console.WriteLine($"Impresora Simple: Imprimiendo documento>>> {documento.Name}");
            Console.WriteLine("------------------------------------------------------------------\n\n");

        }
    }
}
