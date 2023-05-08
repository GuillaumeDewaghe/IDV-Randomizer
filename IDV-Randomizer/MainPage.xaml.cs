using IDV_Randomizer.Models;

namespace IDV_Randomizer;

public partial class MainPage : ContentPage
{
    private List<BaseCharacter> charactersList;
    private List<Hunter.Skill> skillsList;
    private Random random;

    public MainPage()
    {
        InitializeComponent();
        random = new Random();
        skillsList = new List<Hunter.Skill>();
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
        foreach (Hunter.Skill skill in Enum.GetValues(typeof(Hunter.Skill)))
        {
            skillsList.Add(skill);
        }
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
            hunter.SetSkill(skillsList[GetRandomIndex(skillsList)]);
            HunterSkillLabel.IsVisible = true;
            HunterSkillLabel.Text = hunter.GetSkill().ToString();
        }
    }

    private int GetRandomIndex<T>(List<T> list)
    {
        return random.Next(list.Count);
    }
}

