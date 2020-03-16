using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class BoatFactory : Factory
    {
        public BoatFactory(string _name) : base(_name)
        {

        }

        public override void CreateVehicule(Vehicule _vehicule)
        {
            Boat _boat = (Boat)_vehicule;
            _boat.Start();
            _boat.Navigate();
            _boat.Stop();
            FactoryVehicules.Add(_boat);
        }

        public override void ReadAllVehicules()
        {
            base.ReadAllVehicules();
        }
    }
}
