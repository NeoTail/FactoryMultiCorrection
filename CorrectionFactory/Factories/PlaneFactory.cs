using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class PlaneFactory : Factory
    {
        public PlaneFactory(string _name): base(_name)
        {

        }

        public override void CreateVehicule(Vehicule _vehicule)
        {
            Plane _plane = (Plane)_vehicule;
            _plane.Start();
            _plane.Fly();
            _plane.Land();
            _plane.Stop();
            FactoryVehicules.Add(_plane);
        }

        public override void ReadAllVehicules()
        {
            base.ReadAllVehicules();
        }

    }
}
