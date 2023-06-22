namespace IDV_Randomizer.Models
{
    public sealed class Survivor : Character
    {
        public Type PrimaryType { get; }
        public Type SecondaryType { get; }

        public Survivor(string name, ImageSource imageSource, Type primaryType, Type secondaryType = Type.None) : base(name, imageSource)
        {
            PrimaryType = primaryType;
            SecondaryType = secondaryType;
        }

        public bool HasSecondaryType()
        {
            return SecondaryType != Type.None;
        }
    }
}