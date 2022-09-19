using CardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class CardDeck
    {
        public int Id { get; set; }
        public List<Card> CardList { get; set; }
        public int CardAmount { get; set; }
        public CardDeck(int cardAmount)
        {
            CardAmount = cardAmount;
            CardList = new List<Card>();
            CreateCards();
        }
        void CreateCards()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {

            foreach (CardNumber number in Enum.GetValues(typeof(CardNumber)))
            {
                Card card = new Card();
                    card.Suit = suit;
                    card.Number = number;
                   
                CardList.Add(card);
                
            }
            }
        }
    }
}
