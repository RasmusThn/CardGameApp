using CardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary.Cards
{
    public class Spade : ICard
    {
        public List<ICard> _spadesList = new List<ICard>();
        public int Id { get; set; }
        public CardSuit Suit { get; set; } = CardSuit.Spades;
        public CardNumber Number { get; set; }

        public string ImgUrl => "/images/spades.jpg";

        public Spade(CardNumber i)
        {
            Number = i;
        }
        public Spade()
        {

        }
        public List<ICard> CreateCards()
        {
            foreach (CardNumber i in Enum.GetValues(typeof(CardNumber)))
            {
                Spade spade = new Spade(i);
          
                _spadesList.Add(spade);
            }
            return _spadesList;
        }
        public void GetCard()
        {
            Console.WriteLine($"{Suit} - {Number}");
        }
    }
}
