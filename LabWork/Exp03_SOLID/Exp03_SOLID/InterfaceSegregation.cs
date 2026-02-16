using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp03_SOLID
{
    
        // Small, specific interface
        public interface IPrinter
        {
            void Print();
        }

        public interface IScanner
        {
            void Scan();
        }

        // Printer machine only implements what it needs
        public class SimplePrinter : IPrinter
        {
            public void Print()
            {
                System.Console.WriteLine("Printing document...");
            }
        }

}
