using IDV_Randomizer.Models;

namespace IDV_Randomizer;

public partial class MainPage : ContentPage
{
    private List<BaseCharacter> charactersList;
    private Random random;

    public MainPage()
    {
        InitializeComponent();
        random = new Random();
        Survivor magician = new("Magician", "magician.png", Survivor.Job.Kiter);
        Survivor forward = new("Forward", "forward.png", Survivor.Job.Assist, Survivor.Job.Rescuer);
        Hunter ripper = new("Ripper", "ripper.png");
        Hunter disciple = new("Disciple", "disciple.png");
        charactersList = new List<BaseCharacter>
        {
            magician,
            forward,
            ripper,
            disciple
        };
    }

    private void GenerateButton_Clicked(object sender, EventArgs e)
    {
        BaseCharacter chosenCharacter = charactersList[GetRandomIndex(charactersList)];
        CharacterLabel.Text = chosenCharacter.GetName();
        CharacterImage.Source = chosenCharacter.GetImageSource();
        if (chosenCharacter is Survivor)
        {
            Survivor survivor = chosenCharacter as Survivor;
            HunterSkillLabel.IsVisible = false;
            SurvivorPrimaryJobLabel.IsVisible = true;
            SurvivorPrimaryJobLabel.Text = survivor.GetPrimaryJob().ToString();
            if (survivor.HasSecondaryJob())
            {
                SurvivorSecondaryJobLabel.IsVisible = true;
                SurvivorSecondaryJobLabel.Text = survivor.GetSecondaryJob().ToString();
            }
            else
            {
                SurvivorSecondaryJobLabel.IsVisible = false;
            }
        }
        else
        {
            Hunter hunter = chosenCharacter as Hunter;
            SurvivorPrimaryJobLabel.IsVisible = false;
            SurvivorSecondaryJobLabel.IsVisible = false;
            HunterSkillLabel.IsVisible = true;
            HunterSkillLabel.Text = hunter.GetSkillsList()[GetRandomIndex(hunter.GetSkillsList())].ToString();
        }
    }

    private int GetRandomIndex<T>(List<T> list)
    {
        return random.Next(list.Count);
    }
}

