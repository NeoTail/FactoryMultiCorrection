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
            PlaneFactory _toto = new PlaneFactory("Toyota");
            PlaneFactoryMenu _factoryMenu = new PlaneFactoryMenu(_toto);
            Console.ReadLine();
        }
    }
}
