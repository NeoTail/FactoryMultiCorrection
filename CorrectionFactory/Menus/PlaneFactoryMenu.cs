using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class PlaneFactoryMenu : Menu
    {
        public PlaneFactoryMenu(Factory _factoryRef, string _title, string[] _choices) : base(_factoryRef, _title, _choices)
        {

        }

        public PlaneFactoryMenu(Factory _factoryRef) : base(_factoryRef)
        {
            choices = new string[]
            {
                "Create plane",
                "Read all planes",
                "Exit"
            };
            ShowMenu();
        }
        protected override void ShowMenu()
        {
            base.ShowMenu();
            SelectChoices(lastSelection);
        }
        protected override void SelectChoices(int _select)
        {
            base.SelectChoices(_select);
        }

        protected override void CreateVehiculeMenu()
        {
            base.CreateVehiculeMenu();
        }

        protected override void CreateVehiculeCustomChoice(int _serial, VehiculeColor _selectedColor)
        {
            Console.Clear();
            Console.WriteLine("How many passengers the plane can hold ?");
            bool _result = uint.TryParse(Console.ReadLine(), out uint _passengers);
            while (!_result)
                _result = uint.TryParse(Console.ReadLine(), out _passengers);

            Plane _plane = new Plane(_serial, _selectedColor, 1, factory.FactoryName, _passengers);
            factory.CreateVehicule(_plane);
            ShowMenu();
        }
    }
}
