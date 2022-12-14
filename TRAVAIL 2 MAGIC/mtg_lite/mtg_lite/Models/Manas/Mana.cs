using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTGO_lite.Models.Manas.ManaColors;

namespace MTGO_lite.Models.Manas
{
    public class Mana
    {
        private Dictionary<string, ManaColor> manaColors;

        public ManaColor White
        {
            get => manaColors[ManaWhite.Name];
        }
        public ManaColor Blue
        {
            get => manaColors[ManaBlue.Name];
        }
        public ManaColor Black
        {
            get => manaColors[ManaBlack.Name];
        }
        public ManaColor Red
        {
            get => manaColors[ManaRed.Name];
        }
        public ManaColor Green
        {
            get => manaColors[ManaGreen.Name];
        }
        public ManaColor Colorless
        {
            get => manaColors[ManaColorless.Name];
        }
        public Dictionary<string, ManaColor> ManaColors { get => manaColors; }

        public Mana(): this(0, 0, 0, 0, 0, 0)
        {
        }

        public Mana(int black, int blue, int green, int red, int white, int colorless)
        {
            manaColors = new Dictionary<string, ManaColor>()
            {
                { ManaBlack.Name, new ManaBlack(black)},
                { ManaBlue.Name, new ManaBlue(blue)},
                { ManaGreen.Name, new ManaGreen(green)},
                { ManaRed.Name, new ManaRed(red)},
                { ManaWhite.Name, new ManaWhite(white)},
                { ManaColorless.Name, new ManaColorless(colorless)},
            };
        }

        public void Pay(Mana manaToPay)
        {
            if (Black < manaToPay.Black ||
                Blue < manaToPay.Blue ||
                Green < manaToPay.Green ||
                Red < manaToPay.Red ||
                White < manaToPay.White
                )
            {
                throw new Exception("Impossible de jouer cette carte. Mana Insuffisant");
            }


            Black.Remove(manaToPay.Black);
            Blue.Remove(manaToPay.Blue);
            Green.Remove(manaToPay.Green);
            Red.Remove(manaToPay.Red);
            White.Remove(manaToPay.White);
        }

        public void Add(Mana mana)
        {
            foreach (var manaColor in mana.manaColors)
            {
                manaColors[manaColor.Key].Add(manaColor.Value);
            }
        }
    }
}
