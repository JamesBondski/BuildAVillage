using System;
using System.Collections.Generic;
using System.Text;

namespace BAV.Core
{
    public interface IEffect
    {
        void Apply(object target);
    }
}
