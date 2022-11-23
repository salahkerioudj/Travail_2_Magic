using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards.Permanent
{
    public class Land : Permanent
    {
        public Land(string name, Mana manaCost, Bitmap picture) : base(name, manaCost, picture)
        {
        }

        static public Land FabriquerLand(Mana manaCreated)
        {
            switch (manaCreated)
            {
                case "":
                    return new Creature("", new Mana(1, 1, 1, 1, 1, 0), Resource.fusion_elemental);
                    break;
                case "":
                    return new Creature("", new Mana(0, 0, 0, 0, 1, 0), Resource.savannah_lions);
                    break;
                case "":
                    return new Creature("", new Mana(0, 0, 1, 1, 1, 0), Resource.woolly_thoctar);
                    break;
                default:
                    throw new Exception("Erreur lors de la création de la land");
                    break;
            }


        }
    }
}
