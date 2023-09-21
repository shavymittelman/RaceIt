using System.ComponentModel;
using System.Runtime.CompilerServices;
using static RaceItSystem.Game;

namespace RaceItSystem
{
    public class Spot : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        Random rnd = new Random();
        System.Drawing.Color _backcolor;
        private string _spotvalue;

        public System.Drawing.Color backcolor
        {
            get => _backcolor;
            set
            {
                _backcolor = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("backcolormaui");
            }
        }

        public Microsoft.Maui.Graphics.Color backcolormaui
        {
            get => this.ConvertToMauiColor(this.backcolor);
        }

        public string spotvalue {
            get => _spotvalue;
            set
            {
                _spotvalue = value;
                this.InvokePropertyChanged();
            } 
        }

        public void RandomSymbol(List<Spot> lstcolor)
        {
            lstcolor.ForEach(lst => lst.spotvalue = "");
            int randomspot1 = rnd.Next(2, lstcolor.Count);
            int randomspot2 = rnd.Next(2, lstcolor.Count);
            int randomspot3 = rnd.Next(2, lstcolor.Count);
            int randomspot4 = rnd.Next(2, lstcolor.Count);
            int randomspot5 = rnd.Next(2, lstcolor.Count);
            int randomspot6 = rnd.Next(2, lstcolor.Count);
            lstcolor[randomspot1].spotvalue = SymbolEnum.A.ToString();
            lstcolor[randomspot2].spotvalue = SymbolEnum.A.ToString();
            lstcolor[randomspot3].spotvalue = SymbolEnum.G.ToString();
            lstcolor[randomspot4].spotvalue = SymbolEnum.G.ToString();
            lstcolor[randomspot5].spotvalue = SymbolEnum.H.ToString();
            lstcolor[randomspot6].spotvalue = SymbolEnum.H.ToString();
        }

        private Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;

            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
