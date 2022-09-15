using CardLibrary.Cards;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary.CardDeck
{
    public class CardDeck
    {
        public int Id { get; set; }
        private ICard _card;
        private List<ICard> _cards;
        public static int DeckSize { get; set; }
        public List<ICard> CardsList = new List<ICard>(DeckSize);


        public CardDeck(int size)
        {
            DeckSize = size;
            AddHeartsCards();
            AddSpadesCards();
            AddDiamondCards();
            AddClubCards();
        }
        private void AddClubCards()
        {
            _card = new Club();
            _cards = _card.CreateCards();
            CardsList.AddRange(_cards);
        }
        public void AddHeartsCards()
        {
            _card = new Heart();
            _cards = _card.CreateCards();
            CardsList.AddRange(_cards);
        }
        public void AddSpadesCards()
        {
            _card = new Spade();
            _cards = _card.CreateCards();
            CardsList.AddRange(_cards);
        }
        public void AddDiamondCards()
        {
            _card = new Diamond();
            _cards = _card.CreateCards();
            CardsList.AddRange(_cards);
        }
    }
}
