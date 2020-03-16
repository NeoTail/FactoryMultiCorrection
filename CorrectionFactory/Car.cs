using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class Car : Vehicule
    {
        public RimColor ColorRim { get; private set; } = RimColor.Silver;

        public Car(int _serial, VehiculeColor _color, uint _engineNumber = 1, RimColor _rimColor = RimColor.Silver, string _factoryName = "Unknown") : base(_serial, _color, _engineNumber, _factoryName)
        {
            ColorRim = _rimColor;
        }

        public override void Start() => Console.WriteLine($"Car {SerialNumber} {Color} is starting with {EngineNumber} engine(s) from {FactoryOwnerName}.");
        public override void Stop() => Console.WriteLine($"Car {SerialNumber} {Color} is stopping with {EngineNumber} engine(s) from {FactoryOwnerName}.");

        public void Drive() => Console.WriteLine($"Vroom => {SerialNumber}");

        public void Brake() => Console.WriteLine($"Brake => {SerialNumber}");

        public enum RimColor
        {
            Silver,
            Onyx,
            Cobalt
        }
    }


}
