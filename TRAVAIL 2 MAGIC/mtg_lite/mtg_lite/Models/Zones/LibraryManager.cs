using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.Permanent;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public static class LibraryManager
    {
        private static Dictionary<string, List<Card>> libraries = new Dictionary<string, List<Card>>();

        static LibraryManager()
        {
            List<Card> listCard = new List<Card>
            {
                Sorcery.FabriquerSorcery("False peace"),
                Sorcery.FabriquerSorcery("Gaea's Blessing"),
                Sorcery.FabriquerSorcery("Death by dragons"),
                Land.FabriquerLand("Island"),
                Land.FabriquerLand("Plains"),
                Land.FabriquerLand("Forest"),
                Land.FabriquerLand("Mountain"),
                Land.FabriquerLand("Swamp"),
                Creature.FabriquerCreature("Fusion Elemental"),
                Creature.FabriquerCreature("Savannah Lions"),
                Creature.FabriquerCreature("Wooly Thoctar")
            };

            var shuffled = listCard.OrderBy(x => Guid.NewGuid()).ToList();

            libraries.Add("Multicolor", shuffled);

        }

        public static List<Card> GetCards(string libraryName)
        {
            if (libraries.ContainsKey(libraryName))
            {
                return libraries[libraryName];
            }
            return new List<Card>();
        }
    }
}
