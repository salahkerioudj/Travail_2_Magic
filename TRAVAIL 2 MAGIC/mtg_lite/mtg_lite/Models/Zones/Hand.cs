using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public class Hand : Zone
    {
        
        public override string Name { get => "Hand"; }
        public Hand(List<Card> cards, Player player) : base(cards, player)
        {

        }

        public override void clickCard(Card card)
        {
            if (cards.Count >= 1)
            {
                player.PlayCard(card);
                RemoveCard(card);

            }
            else
            {
                throw new Exception("Il n'y plus de cartes dans votre main");
            }
        }
    }
}
