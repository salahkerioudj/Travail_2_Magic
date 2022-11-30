using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.Permanent;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public class Battelfield : Zone
    {
        public override string Name { get => "Battlefield"; }

        public Battelfield(List<Card> cards, Player player) : base(cards, player)
        {
            
        }

        public override void clickCard(Card card)
        {
            card.Picture.RotateFlip(RotateFlipType.Rotate180FlipNone);
            

            if (card.Type == "Land")
            {   

                var land = (Land)card;

                this.player.ManaPool.Add(land.ManaCreated);
            }
           
            
            
        }

    }
}
