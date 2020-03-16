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
            BoatFactory _toto = new BoatFactory("Toyota");
            BoatFactoryMenu _factoryMenu = new BoatFactoryMenu(_toto);
            Console.ReadLine();
        }
    }
}
