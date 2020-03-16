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

        public override void CreateVehicule()
        {
            Random _randomSerial = new Random();
            int _serial = _randomSerial.Next(1000, 9999);
            Boat _default = new Boat(_serial, VehiculeColor.Black, 1, true, FactoryName);
            FactoryVehicules.Add(_default);
            _default.Start();
            _default.Navigate();
            _default.Stop();
            FactoryVehicules.Add(_default);
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
