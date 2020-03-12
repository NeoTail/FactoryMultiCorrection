using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class Vehicule
    {
        public string Color { get; protected set; }
        public uint SerialNumber { get; protected set; } = 1234;

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
