namespace IDV_Randomizer.Models
{
    public sealed class Hunter : Character
    {      
        public Skill Skill { get; set; }

        public Hunter(string name, ImageSource imageSource) : base(name, imageSource)
        {
            
        }
    }
}