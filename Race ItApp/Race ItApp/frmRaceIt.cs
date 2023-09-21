using RaceItSystem;

namespace Race_ItApp
{
    public partial class frmRaceIt : Form
    {
        Game game = new Game();
        List<Label> lstlabels = new();

        public frmRaceIt()
        {
            InitializeComponent();
            lstlabels = new()
            {
                lblRed1, lblRed2, lblRed3, lblRed4, lblRed5, lblRed6, lblRed7, lblRed8, lblRed9, lblRed10,
                lblRed11, lblRed12, lblRed13, lblRed14, lblRed15, lblRed16, lblRed17, lblRed18, lblRed19, lblRed20,
                lblBlue1, lblBlue2, lblBlue3, lblBlue4, lblBlue5, lblBlue6, lblBlue7, lblBlue8, lblBlue9, lblBlue10,
                lblBlue11, lblBlue12, lblBlue13, lblBlue14, lblBlue15, lblBlue16, lblBlue17, lblBlue18, lblBlue19, lblBlue20
            };
            lstlabels.ForEach(l =>
            {
                Spot spot = game.lstspots[lstlabels.IndexOf(l)];
                l.Font = new Font("Wingdings", 20);
                l.DataBindings.Add("Text", spot, "spotvalue");
                l.DataBindings.Add("BackColor", spot, "backcolor");
            });
            btnDie.DataBindings.Add("Text", game, "txtdie");
            btnDie.DataBindings.Add("Enabled", game, "isenabled");
            lblStatus.DataBindings.Add("Text", game, "msg");
            btnStart.Click += BtnStart_Click;
            btnDie.Click += BtnDie_Click;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {            
            game.StartSetup();
        }

        private void BtnDie_Click(object? sender, EventArgs e)
        {
            game.GenerateDieNumber();
            game.SwitchTurn();
        }
    }
}
