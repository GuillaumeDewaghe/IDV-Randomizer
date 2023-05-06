using IDV_Randomizer.Models;

namespace IDV_Randomizer;

public partial class MainPage : ContentPage
{
    private List<BaseCharacter> charactersList;

    public MainPage()
    {
        InitializeComponent();
        BaseCharacter magician = new("Magician", "magician.png");
        BaseCharacter ripper = new("Ripper", "ripper.png");
        BaseCharacter disciple = new("Disciple", "disciple.png");
        charactersList = new List<BaseCharacter>
        {
            magician,
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
    }
}

