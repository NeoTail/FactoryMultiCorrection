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
            Factory _toto = new Factory("Toto");
            _toto.CreateVehicule();
        }
    }
}
