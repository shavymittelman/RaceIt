using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace RaceItSystem
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public enum SymbolEnum { A, G, H }
        public enum TurnEnum { Red, Blue }
        private Random rnd = new();
        public List<Spot> lstspots { get; set; } = new();
        public List<Spot> lstspotblue;
        public List<Spot> lstspotred;
        private string _txtdie = "Die";
        private string _msg = "";
        private bool _isenabled;

        public Game()
        {
            lstspots = new();
            for (int i = 0; i < 40; i++)
            {
                this.lstspots.Add(new Spot());
            }
            lstspotred = new() {
                this.lstspots[0],this.lstspots[1],this.lstspots[2],this.lstspots[3],this.lstspots[4],
                this.lstspots[5],this.lstspots[6],this.lstspots[7],this.lstspots[8],this.lstspots[9],
                this.lstspots[10],this.lstspots[11],this.lstspots[12],this.lstspots[13],this.lstspots[14],
                this.lstspots[15],this.lstspots[16],this.lstspots[17],this.lstspots[18],this.lstspots[19],
            };
            lstspotblue = new() {
                this.lstspots[20],this.lstspots[21],this.lstspots[22],this.lstspots[23],this.lstspots[24],
                this.lstspots[25],this.lstspots[26],this.lstspots[27],this.lstspots[28],this.lstspots[29],
                this.lstspots[30],this.lstspots[31],this.lstspots[32],this.lstspots[33],this.lstspots[34],
                this.lstspots[35],this.lstspots[36],this.lstspots[37],this.lstspots[38],this.lstspots[39],
            };
            msg = "Click Start to begin game.";
            isenabled = false;
            
        }
        public TurnEnum currentturn { get; set; }
        private System.Drawing.Color colorred { get; set; } = System.Drawing.Color.Red;
        private System.Drawing.Color colorblue { get; set; } = System.Drawing.Color.Blue;
        private System.Drawing.Color colorempty { get; set; } = System.Drawing.Color.Gainsboro;
        public bool isenabled
        {
            get => _isenabled;
            set
            {
                _isenabled = value;
                this.InvokePropertyChanged();
            }
        }
        public string txtdie
        {
            get => _txtdie;
            set
            {
                _txtdie = value;
                this.InvokePropertyChanged();
            }
        }
        public string msg
        {
            get => _msg;
            set
            {
                _msg = value;
                this.InvokePropertyChanged();
            }
        }

        public void StartSetup()
        {
            Spot spot = new Spot();
            this.lstspots.ForEach(lst => lst.backcolor = colorempty);
            lstspots[0].backcolor = colorred;
            lstspots[20].backcolor = colorblue;
            spot.RandomSymbol(lstspotred);
            spot.RandomSymbol(lstspotblue);
            currentturn = TurnEnum.Red;
            txtdie = "Die";
            isenabled = true;
            msg = "Red's turn to race!";

        }
        public void SwitchTurn()
        {
            if (currentturn == TurnEnum.Red)
            {
                FillSpots(lstspotred, colorred);
                currentturn = TurnEnum.Blue;
                StatusMessage(TurnEnum.Blue);
                DetectWinner(lstspotred, colorred, TurnEnum.Red);
            }
            else
            {
                FillSpots(lstspotblue, colorblue);
                currentturn = TurnEnum.Red;
                StatusMessage(TurnEnum.Red);
                DetectWinner(lstspotblue, colorblue, TurnEnum.Blue);
            }
        }
        public void DetectWinner(List<Spot> list, Color turnscolor, Enum color)
        {
            if (list.All(lst => lst.backcolor.Equals(turnscolor)))
            {
                msg = color + " Won!!!!!!!!!!";
                isenabled = false;
            }
        }
        private void FillSpots(List<Spot> list, Color turnscolor)
        {
            string advancestring = txtdie;
            int.TryParse(advancestring, out int advancenumber);
            List<Spot> fillspots = list.Where(lst => lst.backcolor.Equals(colorempty)).Take(advancenumber).ToList();
            fillspots.ForEach(lst => lst.backcolor = turnscolor);
            HitSymbol(fillspots, list, turnscolor);
        }
        private void HitSymbol(List<Spot> fillspots, List<Spot> turnslist, Color turnscolor)
        {
            Spot lastspot = turnslist.LastOrDefault();
            if (fillspots.LastOrDefault().spotvalue == SymbolEnum.A.ToString())
            {
                turnslist.Where(lst => lst.backcolor.Equals(colorempty)).Take(2).ToList().ForEach(lst => lst.backcolor = turnscolor);
            }
            if (fillspots.LastOrDefault().spotvalue == SymbolEnum.G.ToString())
            {
                turnslist.Where(lst => lst.backcolor.Equals(colorempty)).Take(1).ToList().ForEach(lst => lst.backcolor = turnscolor);
            }
            if (fillspots.LastOrDefault().spotvalue == SymbolEnum.H.ToString() && fillspots.LastOrDefault() != lastspot)
            {
                turnslist.Where(lst => lst.backcolor.Equals(turnscolor)).TakeLast(1).ToList().ForEach(lst => lst.backcolor = colorempty);
            }
        }
        private void StatusMessage(TurnEnum color)
        {
            msg = color + "'s turn to race!";
        }
        public string GenerateDieNumber()
        {
            txtdie = rnd.Next(1, 7).ToString();
            return txtdie;
        }      
        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
