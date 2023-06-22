namespace IDV_Randomizer.Models
{
    public sealed class Talent
    {
        public string Name { get; private set; }
        public ImageSource ImageSource { get; private set; }
        public int CurrentNbPoints { get; set; } = 0;
        public int MaxPoints { get; private set; }

        public Talent(string name, ImageSource imageSource, int maxPoints)
        {
            Name = name;
            ImageSource = imageSource;
            MaxPoints = maxPoints;
        }
    }
}