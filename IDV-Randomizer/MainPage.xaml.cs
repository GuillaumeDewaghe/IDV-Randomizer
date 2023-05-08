using IDV_Randomizer.Models;
using Type = IDV_Randomizer.Models.Type;

namespace IDV_Randomizer;

public partial class MainPage : ContentPage
{
    private List<BaseCharacter> charactersList;
    private List<Skill> skillsList;
    private Random random;

    public MainPage()
    {
        InitializeComponent();
        random = new Random();
        skillsList = new List<Skill>();
        Survivor magician = new("Magician", "magician.png", Type.Contain);
        Survivor forward = new("Forward", "forward.png", Type.Assist, Type.Rescue);
        Hunter ripper = new("Ripper", "ripper.png");
        Hunter disciple = new("Disciple", "disciple.png");
        charactersList = new List<BaseCharacter>
        {
            magician,
            forward,
            ripper,
            disciple
        };
        foreach (Skill skill in Enum.GetValues(typeof(Skill)))
        {
            skillsList.Add(skill);
        }
    }

    private void GenerateButton_Clicked(object sender, EventArgs e)
    {
        BaseCharacter chosenCharacter = charactersList[GetRandomIndex(charactersList)];
        CharacterLabel.Text = chosenCharacter.Name;
        CharacterImage.Source = chosenCharacter.ImageSource;
        if (chosenCharacter is Survivor)
        {
            Survivor survivor = chosenCharacter as Survivor;
            HunterSkillLabel.IsVisible = false;
            SurvivorPrimaryJobLabel.IsVisible = true;
            SurvivorPrimaryJobLabel.Text = survivor.PrimaryType.ToString();
            if (survivor.HasSecondaryType())
            {
                SurvivorSecondaryJobLabel.IsVisible = true;
                SurvivorSecondaryJobLabel.Text = survivor.SecondaryType.ToString();
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
            hunter.Skill = skillsList[GetRandomIndex(skillsList)];
            HunterSkillLabel.IsVisible = true;
            HunterSkillLabel.Text = hunter.Skill.ToString();
        }
    }

    private int GetRandomIndex<T>(List<T> list)
    {
        return random.Next(list.Count);
    }
}

