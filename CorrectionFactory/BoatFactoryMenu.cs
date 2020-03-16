using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class BoatFactoryMenu : Menu
    {
        string[] sailsChoice = new string[]
        {
            "Yes",
            "No"
        };

        public BoatFactoryMenu(Factory _factoryRef, string _title, string[] _choices) : base(_factoryRef, _title, _choices)
        {

        }

        public BoatFactoryMenu(Factory _factoryRef) : base(_factoryRef)
        {
            choices = new string[]
            {
                "Create boat",
                "Read all boats",
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
            Console.WriteLine("Does the boat have sails ?");
            for (int i = 0; i < sailsChoice.Length; i++)
            {
                Console.WriteLine($"{i+1} - {sailsChoice[i]}");
            }


            bool _result = int.TryParse(Console.ReadLine(), out int _sails);
            while (!_result && _sails < 0 && _sails > 1)
                _result = int.TryParse(Console.ReadLine(), out _sails);

            Boat _boat = new Boat(_serial, _selectedColor, 1, factory.FactoryName, _sails);
            factory.CreateVehicule(_boat);
            ShowMenu();
        }
    }
}
