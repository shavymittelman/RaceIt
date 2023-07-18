using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_ItApp
{
    public partial class frmRaceIt : Form
    {
        Random rnd = new Random();
        List<Label> lstlblred;
        List<Label> lstlblblue;
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

        private void RandomSymbol(List<Label>list)
        {
            list.ForEach(lst => lst.Text = "");
            int randomlbl1 = rnd.Next(2, list.Count);
            int randomlbl2 = rnd.Next(2, list.Count);
            int randomlbl3 = rnd.Next(2, list.Count);                       
            list.ForEach(lst => lst.Font = new Font("Wingdings", 20));
            list[randomlbl1].Text = "G";
            list[randomlbl2].Text = "A";
            list[randomlbl3].Text = "H";     
        }

        private void HitSymbol()
        {
            if (lstlblblue.ForEach(lst => lst.Text))
        }
        private void StatusMessage(TurnEnum color)
        {
            lblStatus.Text = color + "'s turn to race!";
        }

        private void FillSquares(List<Label> list, Color turnscolor)
        {
            string advancestring = btnDie.Text;
            int.TryParse(advancestring, out int advancenumber);
            List<Label> labelstobefilled = list.Where(b => b.BackColor.Equals(Color.Gainsboro)).Take(advancenumber).ToList();
            labelstobefilled.ForEach(lst => lst.BackColor = turnscolor);
        }
        private void SwitchTurn()
        {
            if (currentturn == TurnEnum.Red)
            {
                FillSquares(lstlblred, Color.Red);
                currentturn = TurnEnum.Blue;
                StatusMessage(TurnEnum.Blue);                
            }
            else
            {
                FillSquares(lstlblblue, Color.Blue);
                currentturn = TurnEnum.Red;
                StatusMessage(TurnEnum.Red);
            }
        }
        
        private void BtnStart_Click(object? sender, EventArgs e)
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
        }

        private void BtnDie_Click(object? sender, EventArgs e)
        {
            btnDie.Text = rnd.Next(1, 7).ToString();
            
            SwitchTurn();
        }
    }
}
