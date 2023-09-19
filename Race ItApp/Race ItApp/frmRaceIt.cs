using System.Data;

namespace Race_ItApp
{
    public partial class frmRaceIt : Form
    {
        Random rnd = new Random();
        List<Label> lstlblred;
        List<Label> lstlblblue;
        enum SymbolEnum { A, G, H }
        enum TurnEnum { Red, Blue };
        TurnEnum currentturn = TurnEnum.Red;

        public frmRaceIt()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
            btnDie.Click += BtnDie_Click;
            NotPlaying();
            lstlblred = new()
            {
                lblRed1, lblRed2, lblRed3, lblRed4, lblRed5, lblRed6, lblRed7, lblRed8, lblRed9, lblRed10,
                lblRed11, lblRed12, lblRed13, lblRed14, lblRed15, lblRed16, lblRed17, lblRed18, lblRed19, lblRed20
            };
            lstlblblue = new()
            {
                lblBlue1, lblBlue2, lblBlue3, lblBlue4, lblBlue5, lblBlue6, lblBlue7, lblBlue8, lblBlue9, lblBlue10,
                lblBlue11, lblBlue12, lblBlue13, lblBlue14, lblBlue15, lblBlue16, lblBlue17, lblBlue18, lblBlue19, lblBlue20
            };
            
        }

        private void NotPlaying()
        {
            btnDie.Enabled = false;
            lblStatus.Text = "Click Start to begin game.";
        }

        private void RandomSymbol(List<Label> list)
        {
            list.ForEach(lst => lst.Text = "");
            int randomlbl1 = rnd.Next(2, list.Count);
            int randomlbl2 = rnd.Next(2, list.Count);
            int randomlbl3 = rnd.Next(2, list.Count);
            int randomlbl4 = rnd.Next(2, list.Count);
            int randomlbl5 = rnd.Next(2, list.Count);
            int randomlbl6 = rnd.Next(2, list.Count);
            list.ForEach(lst => lst.Font = new Font("Wingdings", 20));
            list[randomlbl1].Text = SymbolEnum.A.ToString();
            list[randomlbl2].Text = SymbolEnum.A.ToString();
            list[randomlbl3].Text = SymbolEnum.G.ToString();
            list[randomlbl4].Text = SymbolEnum.G.ToString();
            list[randomlbl5].Text = SymbolEnum.H.ToString();
            list[randomlbl6].Text = SymbolEnum.H.ToString();
        }

        private void StatusMessage(TurnEnum color)
        {
            lblStatus.Text = color + "'s turn to race!";
        }

        private void HitSymbol(List<Label> filllabels, List<Label> turnslist, Color turnscolor)
        {
            Label lastlabel = turnslist.LastOrDefault();
            if (filllabels.LastOrDefault().Text == SymbolEnum.A.ToString())
            {
                turnslist.Where(lst => lst.BackColor.Equals(Color.Gainsboro)).Take(2).ToList().ForEach(lst => lst.BackColor = turnscolor);
            }
            if (filllabels.LastOrDefault().Text == SymbolEnum.G.ToString())
            {
                turnslist.Where(lst => lst.BackColor.Equals(Color.Gainsboro)).Take(1).ToList().ForEach(lst => lst.BackColor = turnscolor);
            }                
            if (filllabels.LastOrDefault().Text == SymbolEnum.H.ToString() && filllabels.LastOrDefault() != lastlabel)
            {
                turnslist.Where(lst => lst.BackColor.Equals(turnscolor)).TakeLast(1).ToList().ForEach(lst => lst.BackColor = Color.Gainsboro);
            }            
        }

        private void FillSquares(List<Label> list, Color turnscolor)
        {
            string advancestring = btnDie.Text;
            int.TryParse(advancestring, out int advancenumber);   

            //AF This variable name is very long so it's hard to read, I think you can shorten it a bit

            List<Label> filllabels = list.Where(lst => lst.BackColor.Equals(Color.Gainsboro)).Take(advancenumber).ToList();
            filllabels.ForEach(lst => lst.BackColor = turnscolor);

            /*AF It would be good to refactor the code below.  It would be more efficient to only call HitSymbol once, and you can have if statements inside
             * that procedure on what to do based on the text of that last button, instead of calling it 3 times here*/

            HitSymbol(filllabels, list, turnscolor);
        }

        private void SwitchTurn()
        {
            if (currentturn == TurnEnum.Red)
            {
                FillSquares(lstlblred, Color.Red);
                currentturn = TurnEnum.Blue;
                StatusMessage(TurnEnum.Blue);
                DetectWinner(lstlblred, Color.Red, TurnEnum.Red);
            }
            else
            {
                FillSquares(lstlblblue, Color.Blue);
                currentturn = TurnEnum.Red;
                StatusMessage(TurnEnum.Red);
                DetectWinner(lstlblblue, Color.Blue, TurnEnum.Blue);
            }
        }

        private void DetectWinner(List<Label> list, Color turnscolor, Enum color)
        {
            if (list.All(lst => lst.BackColor.Equals(turnscolor)))
            {
                lblStatus.Text = color + " Won!!!!!!!!!!";
                btnDie.Enabled = false;
            }
        }

        private void StartSetup()
        {
            btnDie.Enabled = true;
            lblStatus.Text = "Red's turn to race!";
            lstlblblue.ForEach(lst => lst.BackColor = Color.Gainsboro);
            lstlblred.ForEach(lst => lst.BackColor = Color.Gainsboro);
            lblRed1.BackColor = Color.Red;
            lblBlue1.BackColor = Color.Blue;
            RandomSymbol(lstlblred);
            RandomSymbol(lstlblblue);
            currentturn = TurnEnum.Red;
            btnDie.Text = "Die";
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartSetup();
        }

        private void BtnDie_Click(object? sender, EventArgs e)
        {
            btnDie.Text = rnd.Next(1, 7).ToString();
            SwitchTurn();
        }
    }
}
