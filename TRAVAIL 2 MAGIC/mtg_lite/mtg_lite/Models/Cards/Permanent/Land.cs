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
        private Mana manaCreated;

        public Mana ManaCreated { get => manaCreated; }
        public Land(string name, string type, Mana manaCost, Bitmap picture, Mana manaCreated) : base(name, type, manaCost, picture)
        {
            this.manaCreated = manaCreated;
        }


        static public Land FabriquerLand(string name)
        {
            switch (name)
            {
                case "Island":
                    return new Land("Island", "Land", new Mana(0, 0, 0, 0, 0, 0), Resource.island, new Mana(0, 1, 0, 0, 0, 0));
                    break;
                case "Mountain":
                    return new Land("Mountain", "Land", new Mana(0, 0, 0, 0, 0, 0), Resource.mountain, new Mana(0, 0, 0, 1, 0, 0));
                    break;
                case "Swamp":
                    return new Land("Swamp", "Land", new Mana(0, 0, 0, 0, 0, 0), Resource.swamp, new Mana(1, 0, 0, 0, 0, 0));
                    break;
                case "Forest":
                    return new Land("Forest", "Land", new Mana(0, 0, 0, 0, 0, 0), Resource.forest, new Mana(0, 0, 1, 0, 0, 0));
                    break;
                case "Plains":
                    return new Land("Plains", "Land", new Mana(0, 0, 0, 0, 0, 0), Resource.plains, new Mana(0, 0, 0, 0, 1, 0));
                    break;
                default:
                    throw new Exception("Erreur lors de la création de la land");
                    break;
            }
        }
    }
}
