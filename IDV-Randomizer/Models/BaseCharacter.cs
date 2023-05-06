using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDV_Randomizer.Models
{
    public abstract class BaseCharacter
    {
        private string name;
        private ImageSource imageSource;

        public BaseCharacter(string name, ImageSource imageSource)
        {
            this.name = name;
            this.imageSource = imageSource;
        }

        public string GetName()
        {
            return name;
        }

        public ImageSource GetImageSource()
        {
            return imageSource;
        }
    }
}
