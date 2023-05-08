using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDV_Randomizer.Models
{
    public abstract class Character
    {
        public string Name { get; }

        public ImageSource ImageSource { get; }

        public Character(string name, ImageSource imageSource)
        {
            Name = name;
            ImageSource = imageSource;
        }
    }
}
