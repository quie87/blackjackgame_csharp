using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class Soft17HitStrategy : IHitStrategy
    {
        private const int g_hitLimit = 17;

        public bool DoHit(model.Player a_dealer)
        {
            List<Card> a_hand = (List<Card>)a_dealer.GetHand();

            if (a_dealer.CalcScore() == g_hitLimit)
            {
                return a_hand.Exists(x => x.GetValue() == Card.Value.Ace);
            } else
            {
                return a_dealer.CalcScore() < g_hitLimit;
            }

        }
    }
}
