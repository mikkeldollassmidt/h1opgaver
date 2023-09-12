using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackStructExample.Model
{
    public struct Card
    {
        public int _cardDealerDeck { get; set; }
        /*{
            get { return _cardDealerDeck; }
            set { _cardDealerDeck = value; }
        }*/
        public int _userDeck { get; set; }
        /*{
            get { return _userDeck; }
            private set { _userDeck = value; }
        }*/
        public Card(int cardDealerDeck, int userDeck)
        {
            _cardDealerDeck = cardDealerDeck;
            _userDeck = userDeck;
        }
        public override string ToString()  
        {
            return $"Dealer cards: {_cardDealerDeck}, User cards: {_userDeck}";
        }
    }
}
