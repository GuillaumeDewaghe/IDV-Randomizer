using Microsoft.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDV_Randomizer.Models
{
    public class Survivor : BaseCharacter
    {
        public enum Job
        {
            Kiter,
            Assist,
            Rescuer,
            Decoder
        }

        private Job primaryJob;
        private Job? secondaryJob;

        public Survivor(string name, ImageSource imageSource, Job primaryJob, Job? secondaryJob = null) : base(name, imageSource)
        {
            this.primaryJob = primaryJob;
            this.secondaryJob = secondaryJob;
        }

        public Job GetPrimaryJob()
        {
            return primaryJob;
        }

        public Job? GetSecondaryJob() 
        {
            return secondaryJob;
        }

        public bool HasSecondaryJob()
        {
            return secondaryJob != null;
        }
    }
}
