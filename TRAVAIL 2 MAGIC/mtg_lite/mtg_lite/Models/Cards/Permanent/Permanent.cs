using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards.Permanent
{
    public class Permanent : Card
    {
        public override bool isPermanent { get => true;}

        public Permanent(string name, string type, Mana manaCost, Bitmap picture) : base(name, type, manaCost, picture)
        {

        }
    }
}
