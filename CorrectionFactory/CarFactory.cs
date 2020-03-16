using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class CarFactory : Factory
    {
        public CarFactory(string _name) : base(_name)
        {

        }

        public override void CreateVehicule()
        {
            Random _randomSerial = new Random();
            int _serial = _randomSerial.Next(1000, 9999);
            Car _default = new Car(_serial, VehiculeColor.Cyan, 1, Car.RimColor.Silver, FactoryName);
            _default.Start();
            _default.Drive();
            _default.Brake();
            _default.Stop();
            FactoryVehicules.Add(_default);
        }
    }
}
