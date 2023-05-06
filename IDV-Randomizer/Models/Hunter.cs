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

        private List<Skill> skillsList;

        public Hunter(string name, ImageSource imageSource) : base(name, imageSource)
        {
            skillsList = new List<Skill>();
            foreach (Skill skill in Enum.GetValues(typeof(Skill)))
            {
                skillsList.Add(skill);
            }
        }

        public List<Skill> GetSkillsList()
        {
            return skillsList;
        }
    }
}
