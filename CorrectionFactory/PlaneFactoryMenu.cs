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
    }
}
