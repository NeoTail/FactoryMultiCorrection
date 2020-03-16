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
            Boat _boat = new Boat(_serial, VehiculeColor.Black, 1, FactoryName, true);
            FactoryVehicules.Add(_boat);
            _boat.Start();
            _boat.Navigate();
            _boat.ThrowAnchor();
            _boat.Stop();
            FactoryVehicules.Add(_boat);
        }

        public override void CreateVehicule(Vehicule _vehicule)
        {
            Boat _boat = (Boat)_vehicule;
            _boat.Start();
            _boat.Navigate();
            _boat.ThrowAnchor();
            _boat.Stop();
            FactoryVehicules.Add(_boat);
        }

        public override void ReadAllVehicules()
        {
            base.ReadAllVehicules();
        }
    }
}
