using System;
using System.Collections.Generic;
using System.Text;

namespace BAV.Core
{
    public class Ressource
    {
        public string Name { get; }

        public decimal InitialStorage { get; }

        public decimal InitialProduction { get; }

        public Ressource(string name, decimal initialStorage, decimal initialProduction)
        {
            this.Name = name;
            this.InitialStorage = initialStorage;
            this.InitialProduction = initialProduction;
        }
    }
}
