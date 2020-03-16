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
    }
}
