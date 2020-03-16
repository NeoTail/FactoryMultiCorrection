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

        public override void CreateVehicule(Vehicule _vehicule)
        {
            Car _car = (Car)_vehicule;
            _car.Start();
            _car.Drive();
            _car.Brake();
            _car.Stop();
            FactoryVehicules.Add(_car);
        }

        public override void ReadAllVehicules()
        {
            base.ReadAllVehicules();
        }
    }
}
