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