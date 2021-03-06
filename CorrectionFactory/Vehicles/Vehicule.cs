﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class Vehicule
    {
        int serialNumber = 0;
        public VehiculeColor Color { get; protected set; } = VehiculeColor.White;
        public uint EngineNumber { get; protected set; } = 1;
        public int SerialNumber
        {
            get => serialNumber;
            protected set
            {
                serialNumber = value;
                serialNumber = serialNumber < 0 ? 1234 : serialNumber;
            }
        }

        public string FactoryOwnerName { get; private set; }

        public virtual string VehiculeInfo
        {
            get
            {
                return $"Vehicule {SerialNumber} from {FactoryOwnerName} :\n" +
                    $"Engines : {EngineNumber}\n" +
                    $"Color : {Color}\n";
            }
        }

        public Vehicule()
        {
            Color = VehiculeColor.White;
            SerialNumber = 1234;
            EngineNumber = 1;
            FactoryOwnerName = "Unknown";
        }

        public Vehicule(int _serial, VehiculeColor _color, uint _engineNumber, string _factoryName = "Unknown")
        {
            Color = _color;
            SerialNumber = _serial;
            EngineNumber = _engineNumber;
            FactoryOwnerName = _factoryName;
        }


        public virtual void Start() => Console.WriteLine($"Vehicule {SerialNumber} {Color} is starting with {EngineNumber} engine(s).");

        public virtual void Stop() => Console.WriteLine($"Vehicule {SerialNumber} {Color} is stopping with {EngineNumber} engine(s).");

        void Demo() //Pour la leçon
        {
            VehiculeColor _color = VehiculeColor.Cyan;
            int _colorPos = (int)_color;
            _color = (VehiculeColor)_colorPos;
        }
    }


    public enum VehiculeColor
    {
        White,
        Black,
        Red,
        Green,
        Blue,
        Cyan,
        Magenta,
        Yellow,
        Grey,
        Custom
    } // enum = entier

}
