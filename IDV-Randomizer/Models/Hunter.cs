using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDV_Randomizer.Models
{
    public sealed class Hunter : BaseCharacter
    {
        public enum Skill
        {
            Listen,
            Abnormal,
            Excitement,
            Patroller,
            Teleport,
            Peeper,
            Blink
        }

        private Skill skill;

        public Hunter(string name, ImageSource imageSource) : base(name, imageSource)
        {

        }

        public Skill GetSkill()
        {
            return skill;
        }

        public void SetSkill(Skill skill)
        {
            this.skill = skill;
        }
    }
}
