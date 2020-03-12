using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionFactory
{
    public class Factory
    {
        public string FactoryName { get; protected set; } = "Factory";
        public List<Vehicule> FactoryVehicules { get; protected set; } = new List<Vehicule>();
        public Factory(string _name)
        {
            FactoryName = _name;
        }

        public virtual void CreateVehicule()
        {

        }
    }
}
