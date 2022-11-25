using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.CardBacks;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public class Deck : Zone
    {
        public override string Name { get => "Deck"; }

        public override Card TopCard
        {
            get
            {
                if (cards.Count > 0)
                {
                    return new CardBack();
                }
                else {
                    return new DarkCardBack();
                }
                
            }
        }
        public Deck(List<Card> cards, Player player) : base(cards, player)
        {


        }

        public override void clickCard(Card card)
        {
            if (cards.Count >= 1)
            {
                RemoveTopCard();

            }
            else
            {
                throw new Exception("Il n'y plus de cartes dans votre deck");
            }
        }


    }
}
