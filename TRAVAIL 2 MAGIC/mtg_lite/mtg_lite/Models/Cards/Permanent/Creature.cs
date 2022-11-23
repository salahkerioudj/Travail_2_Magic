using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards.Permanent
{
    public class Creature : Permanent
    {
        public Creature(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
        }

        static public Creature FabriquerCreature(string creatureName)
        {
            switch (creatureName)
            {
                case "Fusion Elemental":
                    return new Creature("Fusion Elemental", new Mana(1, 1, 1, 1, 1, 0), Resource.fusion_elemental);
                    break;
                case "Savannah Lions":
                    return new Creature("Savannah Lions", new Mana(0, 0, 0, 0, 1, 0), Resource.savannah_lions);
                    break;
                case "Wooly Thoctar":
                    return new Creature("Wooly Thoctar", new Mana(0, 0, 1, 1, 1, 0), Resource.woolly_thoctar);
                    break;
                default:
                    throw new Exception("Erreur lors de la création de la créature");
                    break;
            }


        }
    }
}
