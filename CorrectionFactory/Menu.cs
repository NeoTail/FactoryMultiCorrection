using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class Menu
    {
        protected Factory factory = null;
        string title = "Menu";
        protected int lastSelection = 0;
        public string[] choices = new string[]
        {
            "choice1",
            "choice2"
        };

        public Menu(Factory _factoryRef, string _title, string[] _choices)
        {
            factory = _factoryRef;
            title = _title;
            choices = _choices;
        }

        public Menu(Factory _factoryRef)
        {
            factory = _factoryRef;
            title = $"Factory {_factoryRef.FactoryName}";
        }


        protected virtual void ShowMenu()
        {
            //Base
            Console.WriteLine($"\n******[{title.ToUpper()}]******\n");
            for (int i = 0; i < choices.Length; i++)
                Console.WriteLine($"{i + 1} - {choices[i]}");

            bool _result = int.TryParse(Console.ReadLine(), out int _resultChoice);
            IsValidChoice(_result);
            lastSelection = _resultChoice;
        }

        protected virtual void SelectChoices(int _select)
        {
            if (_select == 1) CreateVehiculeMenu();
            else if (_select == 2) factory.ReadAllVehicules();
            else if (_select == 3) Environment.Exit(0);
            else IsValidChoice(false);
        }

        protected virtual void CreateVehiculeMenu()
        {
            int _serial = new Random().Next(1000, 9999);
            string[] _allColors = Enum.GetNames(typeof(VehiculeColor));
            Console.WriteLine("Color vehicule choice :");

            for (int i = 0; i < _allColors.Length; i++)
                Console.WriteLine($"{i+1} - {_allColors[i]}");

            bool _result = int.TryParse(Console.ReadLine(), out int _resultChoice);
            _resultChoice = _resultChoice <= 0 ? 1 : _resultChoice;

            while (!_result || _resultChoice > _allColors.Length)
                _result = int.TryParse(Console.ReadLine(), out _resultChoice);

            VehiculeColor _color = (VehiculeColor)_resultChoice - 1;
            Console.WriteLine($"Color selected {_color}");
            CreateVehiculeCustomChoice(_serial, _color);
        }

        void IsValidChoice(bool _isValid = true)
        {
            if (_isValid) return;
            Console.WriteLine("Wrong choice !");
            Thread.Sleep(1000);
            Console.Clear();
            ShowMenu();
        }

        protected virtual void CreateVehiculeCustomChoice(int _serial, VehiculeColor _selectedColor)
        {
            Vehicule _vehicule = new Vehicule(_serial, _selectedColor, 1);
            factory.CreateVehicule(_vehicule);
            ShowMenu();
        }
    }
}
