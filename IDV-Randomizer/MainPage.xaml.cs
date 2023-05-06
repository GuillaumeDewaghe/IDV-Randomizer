using IDV_Randomizer.Models;

namespace IDV_Randomizer;

public partial class MainPage : ContentPage
{
    private List<BaseCharacter> charactersList;

    public MainPage()
    {
        InitializeComponent();
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
        Random random = new Random();
        var chosenCharacter = charactersList[random.Next(charactersList.Count)];
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
            HunterSkillLabel.Text = hunter.GetSkillsList()[random.Next(hunter.GetSkillsList().Count)].ToString();
        }
    }
}

