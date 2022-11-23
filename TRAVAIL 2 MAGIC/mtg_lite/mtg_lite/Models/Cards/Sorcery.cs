using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    public class Sorcery : Card
    {
        public Sorcery(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
        }

        static public Sorcery FabriquerSorcery(string sorceryName)
        {
            switch (sorceryName)
            {
                case "False peace":
                    return new Sorcery("False peace", new Mana(0, 0, 0, 0, 1, 0), Resource.false_peace);
                    break;
                case "Gaea's Blessing":
                    return new Sorcery("Gaea's Blessing", new Mana(0, 0, 1, 0, 0, 1), Resource.gaea_s_blessing);
                    break;
                case "Death by dragons":
                    return new Sorcery("Death by dragons", new Mana(0, 0, 0, 2, 0, 4), Resource.death_by_dragons);
                    break;
                default:
                    throw new Exception("Erreur lors de la création de sorcery");
                    break;
            }

            
        }
    }
}
