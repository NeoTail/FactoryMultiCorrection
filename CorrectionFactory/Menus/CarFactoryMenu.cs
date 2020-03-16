using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class CarFactoryMenu : Menu
    {
        public CarFactoryMenu(Factory _factoryRef, string _title, string[] _choices) : base(_factoryRef, _title, _choices)
        {
            
        }

        public CarFactoryMenu(Factory _factoryRef) : base(_factoryRef)
        {
            choices = new string[]
            {
                "Create car",
                "Read all cars",
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
            string[] _allColors = Enum.GetNames(typeof(Car.RimColor));
            Console.WriteLine("Rims color choice :");

            for (int i = 0; i < _allColors.Length; i++)
                Console.WriteLine($"{i + 1} - {_allColors[i]}");

            bool _result = int.TryParse(Console.ReadLine(), out int _resultChoice);
            _resultChoice = _resultChoice <= 0 ? 1 : _resultChoice;

            while (!_result || _resultChoice > _allColors.Length)
                _result = int.TryParse(Console.ReadLine(), out _resultChoice);

            Car.RimColor _rimColor = (Car.RimColor)_resultChoice - 1;
            Console.WriteLine($"Rim color selected {_rimColor}");

            Car _car = new Car(_serial, _selectedColor, 1, _rimColor, factory.FactoryName);
            factory.CreateVehicule(_car);
            ShowMenu();
        }
    }
}
