using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class Plane : Vehicule
    {
        public override string VehiculeInfo
        {
            get
            {
                return $"{base.VehiculeInfo}" +
                    $"Passengers number : {passengersNumber}";
            }
        }

        public uint passengersNumber = 0;

        public Plane(int _serial, VehiculeColor _color, uint _engineNumber = 1, uint _passengersNumber, string _factoryName = "Unknown") : base(_serial, _color, _engineNumber, _factoryName)
        {
            passengersNumber = _passengersNumber;
        }

        public override void Start() => Console.WriteLine($"Plane {SerialNumber} {Color} with {passengersNumber} passengers is starting with {EngineNumber} engine(s) from {FactoryOwnerName}.");
        public override void Stop() => Console.WriteLine($"Plane {SerialNumber} {Color} with {passengersNumber} passengers is stopping with {EngineNumber} engine(s) from {FactoryOwnerName}.");

        public void Fly() => Console.WriteLine($"Roar => {SerialNumber}");
        public void Land() => Console.WriteLine($"No more Roar => {SerialNumber}");
    }
}
