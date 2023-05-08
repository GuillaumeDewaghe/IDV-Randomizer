using Microsoft.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDV_Randomizer.Models
{
    public sealed class Survivor : BaseCharacter
    {
        public Type PrimaryType
        {
            get;
            private set;
        }

        public Type SecondaryType
        {
            get;
            private set;
        }

        public Survivor(string name, ImageSource imageSource, Type primaryType, Type secondaryType = Type.None) : base(name, imageSource)
        {
            PrimaryType = primaryType;
            SecondaryType = secondaryType;
        }

        public bool HasSecondaryType()
        {
            return SecondaryType != Type.None;
        }
    }
}
