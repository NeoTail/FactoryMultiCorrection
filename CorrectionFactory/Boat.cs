using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class Boat : Vehicule
    {
        public override string VehiculeInfo
        {
            get
            {
                return $"{base.VehiculeInfo}" +
                    $"{(hasSail == true ? "It has sails" : "It doesn't have sails")}";
            }
        }

       public bool hasSail = false;

        public Boat(int _serial, VehiculeColor _color, uint _engineNumber = 1, string _factoryName = "Unknown", bool _hasSail = false) : base(_serial, _color, _engineNumber, _factoryName)
        {
            hasSail = _hasSail;
        }

        public override void Start() => Console.WriteLine($"Boat {SerialNumber} {Color} is starting with {EngineNumber} engine(s) from {FactoryOwnerName}. {(hasSail == true ? "It has sails" : "It doesn't have sails")}");
        public override void Stop() => Console.WriteLine($"Boat {SerialNumber} {Color} is stopping with {EngineNumber} engine(s) from {FactoryOwnerName}. {(hasSail == true ? "It has sails" : "It doesn't have sails")}");

        public void Navigate() => Console.WriteLine($"Ploof => {SerialNumber}");
    }
}
