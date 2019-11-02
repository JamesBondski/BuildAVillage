using System;
using System.Collections.Generic;
using System.Text;

namespace BAV.Core.Packages.Basic
{
    public class BasicPackage : IPackage
    {
        public void InitWorld(World world)
        {
            world.Ressources.Add("Gold", new Ressource("Gold", 20, 1));
            world.Ressources.Add("Wood", new Ressource("Wood", 0, 0));
        }
    }
}
