using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class MultiFunctionPrinter : IMultiFuctionPrinter
    {
        public void Print(Documento documento)
        {
            Console.WriteLine($"Impresora Multi-funcion: Impriendo documento>>> {documento.Name}");
            Console.WriteLine("------------------------------------------------------------------\n\n");

        }

        public void Scan(Documento documento)
        {
            Console.WriteLine($"Impresora Multi-funcion: Escaneando documento>>> {documento.Name}");
            Console.WriteLine("------------------------------------------------------------------\n\n");

        }
    }
}
