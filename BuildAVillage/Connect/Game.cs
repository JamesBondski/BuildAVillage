using BAV.Core;
using BAV.Core.Packages.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildAVillage.Connect
{
    public class Game
    {
        public World world { get; set; } = null;

        public void NewGame(string villageName)
        {
            this.world = new World(villageName, new List<IPackage>()
            {
                new BasicPackage()
            });

        }
    }
}
