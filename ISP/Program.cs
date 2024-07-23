using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimplePrinter printer = new SimplePrinter();
            MultiFunctionPrinter multiPrinter = new MultiFunctionPrinter();
            Documento document = new Documento("La Programacion");

            printer.Print(document);
            multiPrinter.Scan(document);
            multiPrinter.Print(document);
            
            Console.ReadKey();
        }
    }
}
