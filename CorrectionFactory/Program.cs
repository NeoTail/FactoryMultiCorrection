using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory _toto = new CarFactory("Toyota");
            CarFactoryMenu _factoryMenu = new CarFactoryMenu(_toto);
            Console.ReadLine();
        }
    }
}
