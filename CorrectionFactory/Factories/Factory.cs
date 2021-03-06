﻿using System;
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
            Console.WriteLine($"Factory {FactoryName} is open");
        }

        public virtual void CreateVehicule()
        {
            //Vehicule _default = new Vehicule();
            Vehicule _default = new Vehicule(4578, VehiculeColor.Cyan, 1, "Toyota");
            FactoryVehicules.Add(_default);
            _default.Start();
            _default.Stop();
        }

        public virtual void CreateVehicule(Vehicule _vehicule)
        {
            _vehicule.Start();
            _vehicule.Stop();
            FactoryVehicules.Add(_vehicule);
        }

        public virtual void ReadAllVehicules()
        {
            Console.Clear();
            for (int i = 0; i < FactoryVehicules.Count; i++)
            {
                Console.WriteLine(FactoryVehicules[i].VehiculeInfo);
            }
        }
    }
}
