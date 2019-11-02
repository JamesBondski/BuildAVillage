using System;
using System.Collections.Generic;
using System.Text;

namespace BAV.Core
{
    public abstract class Ressource
    {
        public abstract string Name { get; }

        public abstract decimal InitialStorage { get; }

        public abstract decimal InitialProduction { get; }
    }
}
