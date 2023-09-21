using RaceItSystem;
namespace MAUIRaceIt;

public partial class RaceIt : ContentPage
{
	Game game = new();

	List<Label> lstlabels;
	public RaceIt()
	{
		InitializeComponent();
		this.BindingContext = game;
		lstlabels = new()
		{
			lblRed1, lblRed2, lblRed3, lblRed4, lblRed5, lblRed6, lblRed7, lblRed8, lblRed9, lblRed10,
			lblRed11, lblRed12, lblRed13, lblRed14, lblRed15, lblRed16, lblRed17, lblRed18, lblRed19, lblRed20,
			lblBlue1, lblBlue2, lblBlue3, lblBlue4, lblBlue5, lblBlue6, lblBlue7, lblBlue8, lblBlue9, lblBlue10,
			lblBlue11, lblBlue12, lblBlue13, lblBlue14, lblBlue15, lblBlue16, lblBlue17, lblBlue18, lblBlue19, lblBlue20
		};
    }

    private void btnStart_Clicked(object sender, EventArgs e)
    {
        game.StartSetup();
    }

    private void btnDie_Clicked(object sender, EventArgs e)
    {
        game.GenerateDieNumber();
        game.SwitchTurn();
    }
}