using System;
using System.Collections.Generic;
using System.Text;

namespace BAV.Core
{
    public class Village
    {
        public string Name { get; set; } = "Hello World";
        public Dictionary<Ressource, decimal> Storage { get; } = new Dictionary<Ressource, decimal>();
        public Dictionary<Ressource, decimal> Production { get; } = new Dictionary<Ressource, decimal>();

        public Village(World world)
        {
            foreach(var ressourcePair in world.Ressources)
            {
                this.Storage.Add(ressourcePair.Value, ressourcePair.Value.InitialStorage);
                this.Production.Add(ressourcePair.Value, ressourcePair.Value.InitialProduction);
            }
        }

        public void Turn()
        {
            foreach(var ressourcePair in this.Production)
            {
                this.Storage[ressourcePair.Key] += ressourcePair.Value;
            }
        }
    }
}
