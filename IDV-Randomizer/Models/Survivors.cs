using IDV_Randomizer.Resources;

namespace IDV_Randomizer.Models
{
    public static class Survivors
    {
        public static Survivor Doctor { get; } = new Survivor(AppResources.DoctorName, AppResources.DoctorImage, Type.Contain, Type.Assist);
        public static Survivor Lawyer { get; } = new Survivor(AppResources.LawyerName, AppResources.LawyerImage, Type.Decode);
        public static Survivor Thief { get; } = new Survivor(AppResources.ThiefName, AppResources.ThiefImage, Type.Contain);
        public static Survivor Gardener { get; } = new Survivor(AppResources.GardenerName, AppResources.GardenerImage, Type.Contain, Type.Assist);
        public static Survivor Magician { get; } = new Survivor(AppResources.MagicianName, AppResources.MagicianImage, Type.Contain);
        public static Survivor Explorer { get; } = new Survivor(AppResources.ExplorerName, AppResources.ExplorerImage, Type.Decode);
        public static Survivor Mercenary { get; } = new Survivor(AppResources.MercenaryName, AppResources.MercenaryImage, Type.Rescue);
        public static Survivor Coordinator { get; } = new Survivor(AppResources.CoordinatorName, AppResources.CoordinatorImage, Type.Rescue);
        public static Survivor Priestess { get; } = new Survivor(AppResources.PriestessName, AppResources.PriestessImage, Type.Assist, Type.Contain);
        public static Survivor Mechanic { get; } = new Survivor(AppResources.MechanicName, AppResources.MechanicImage, Type.Decode);
        public static Survivor Forward { get; } = new Survivor(AppResources.ForwardName, AppResources.ForwardImage, Type.Assist, Type.Rescue);
        public static Survivor MindsEye { get; } = new Survivor(AppResources.MindsEyeName, AppResources.MindsEyeImage, Type.Decode);
        public static Survivor Perfumer { get; } = new Survivor(AppResources.PerfumerName, AppResources.PerfumerImage, Type.Contain);
        public static Survivor Cowboy { get; } = new Survivor(AppResources.CowboyName, AppResources.CowboyImage, Type.Assist, Type.Contain);
        public static Survivor FemaleDancer { get; } = new Survivor(AppResources.FemaleDancerName, AppResources.FemaleDancerImage, Type.Contain, Type.Assist);
        public static Survivor Seer { get; } = new Survivor(AppResources.SeerName, AppResources.SeerImage, Type.Assist);
        public static Survivor Embalmer { get; } = new Survivor(AppResources.EmbalmerName, AppResources.EmbalmerImage, Type.Assist);
        public static Survivor Prospector { get; } = new Survivor(AppResources.ProspectorName, AppResources.ProspectorImage, Type.Contain, Type.Assist);
        public static Survivor Enchantress { get; } = new Survivor(AppResources.EnchantressName, AppResources.EnchantressImage, Type.Contain, Type.Assist);
        public static Survivor Wildling { get; } = new Survivor(AppResources.WildlingName, AppResources.WildlingImage, Type.Assist, Type.Rescue);
        public static Survivor Acrobat { get; } = new Survivor(AppResources.AcrobatName, AppResources.AcrobatImage, Type.Contain);
        public static Survivor FirstOfficer { get; } = new Survivor(AppResources.FirstOfficerName, AppResources.FirstOfficerImage, Type.Rescue);
        public static Survivor Barmaid { get; } = new Survivor(AppResources.BarmaidName, AppResources.BarmaidImage, Type.Assist, Type.Contain);
        public static Survivor Postman { get; } = new Survivor(AppResources.PostmanName, AppResources.PostmanImage, Type.Assist);
        public static Survivor GraveKeeper { get; } = new Survivor(AppResources.GraveKeeperName, AppResources.GraveKeeperImage, Type.Rescue);
        public static Survivor Prisoner { get; } = new Survivor(AppResources.PrisonerName, AppResources.PrisonerImage, Type.Decode, Type.Assist);
        public static Survivor Entomologist { get; } = new Survivor(AppResources.EntomologistName, AppResources.EntomologistImage, Type.Contain, Type.Assist);
        public static Survivor Painter { get; } = new Survivor(AppResources.PainterName, AppResources.PainterImage, Type.Contain, Type.Assist);
        public static Survivor Batter { get; } = new Survivor(AppResources.BatterName, AppResources.BatterImage, Type.Assist, Type.Rescue);
        public static Survivor ToyMerchant { get; } = new Survivor(AppResources.ToyMerchantName, AppResources.ToyMerchantImage, Type.Contain, Type.Assist);
        public static Survivor Patient { get; } = new Survivor(AppResources.PatientName, AppResources.PatientImage, Type.Contain, Type.Rescue);
        public static Survivor Psychologist { get; } = new Survivor(AppResources.PsychologistName, AppResources.PsychologistImage, Type.Assist);
        public static Survivor Novelist { get; } = new Survivor(AppResources.NovelistName, AppResources.NovelistImage, Type.Assist);
        public static Survivor LittleGirl { get; } = new Survivor(AppResources.LittleGirlName, AppResources.LittleGirlImage, Type.Assist);
        public static Survivor WeepingClown { get; } = new Survivor(AppResources.WeepingClownName, AppResources.WeepingClownImage, Type.Contain, Type.Assist);
        public static Survivor Professor { get; } = new Survivor(AppResources.ProfessorName, AppResources.ProfessorImage, Type.Contain, Type.Assist);
        public static Survivor Antiquarian { get; } = new Survivor(AppResources.AntiquarianName, AppResources.AntiquarianImage, Type.Contain);
        public static Survivor Composer { get; } = new Survivor(AppResources.ComposerName, AppResources.ComposerImage, Type.Decode);
        public static Survivor Journalist { get; } = new Survivor(AppResources.JournalistName, AppResources.JournalistImage, Type.Rescue);
        public static Survivor LuckyGuy { get; } = new Survivor(AppResources.LuckyGuyName, AppResources.LuckyGuyImage, Type.Contain);
    }
}