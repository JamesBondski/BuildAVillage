using System;
using System.Collections.Generic;
using System.Text;

namespace BAV.Core
{
    public abstract class Card
    {
        public abstract string Name { get; }

        public abstract IReadOnlyList<IEffect> Effects { get; }

        public virtual Type TargetType { get; } = typeof(Village);

        public virtual void Play(object target)
        {
            if(target.GetType() != TargetType)
            {
                throw new InvalidOperationException("Wrong target type.");
            }
            foreach(IEffect effect in Effects)
            {
                effect.Apply(target);
            }
        }
    }
}
