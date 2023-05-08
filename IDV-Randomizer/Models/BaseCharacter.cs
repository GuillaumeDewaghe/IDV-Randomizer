using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDV_Randomizer.Models
{
    public abstract class BaseCharacter
    {
        public string Name
        {
            get; 
            private set;
        }

        public ImageSource ImageSource 
        { 
            get; 
            private set;
        }

        public BaseCharacter(string name, ImageSource imageSource)
        {
            Name = name;
            ImageSource = imageSource;
        }
    }
}
