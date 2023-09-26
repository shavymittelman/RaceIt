using RaceItSystem;
namespace MAUIRaceIt;

public partial class RaceIt : ContentPage
{
	Game activegame;
    List<Game> lstgames = new() { new Game(), new Game(), new Game() };
	
	public RaceIt()
	{
		InitializeComponent();
        lstgames.ForEach(game => game.ScoreChanged += Game_ScoreChanged);
        Game1Rb.BindingContext = lstgames[0];
        Game2Rb.BindingContext = lstgames[1];
        Game3Rb.BindingContext = lstgames[2];
        activegame = lstgames[0];
		this.BindingContext = activegame;
    }

    private void Game_ScoreChanged(object sender, EventArgs e)
    {
        ScoreLbl.Text = Game.Score;
    }

    private void btnStart_Clicked(object sender, EventArgs e)
    {
        activegame.StartSetup();
    }

    private void btnDie_Clicked(object sender, EventArgs e)
    {
        activegame.GenerateDieNumber();
        activegame.SwitchTurn();
    }

    private void Game_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        if (rb.IsChecked == true && rb.BindingContext != null)
        {
            activegame = (Game)rb.BindingContext;
            this.BindingContext = activegame;
        }
    }
}