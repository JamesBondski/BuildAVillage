using BAV.Core.Packages;
using System;
using System.Collections.Generic;

namespace BAV.Core
{
    public class World
    {
        public Village Village { get; } = null;
        public List<Card> Deck { get; } = new List<Card>();

        public Dictionary<string, Ressource> Ressources { get; } = new Dictionary<string, Ressource>();

        public World(string villageName, List<IPackage> packages)
        {
            foreach (IPackage package in packages)
            {
                package.InitWorld(this);
            }

            this.Village = new Village(this)
            {
                Name = villageName
            };
        }

        public void Turn()
        {
            this.Village.Turn();
        }
    }
}
