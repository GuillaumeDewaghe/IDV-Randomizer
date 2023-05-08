using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDV_Randomizer.Models
{
    public sealed class Hunter : BaseCharacter
    {      
        public Skill Skill
        {
            get;
            set;
        }

        public Hunter(string name, ImageSource imageSource) : base(name, imageSource)
        {
            
        }
    }
}
