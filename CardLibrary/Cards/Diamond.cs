using CardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary.Cards
{
    public class Diamond : ICard
    {
        public List<ICard> _diamondsList = new List<ICard>();
        public int Id { get; set; }
        public CardSuit Suit { get; set; } = CardSuit.Diamonds;
        public CardNumber Number { get; set; }

        public string ImgUrl => "/images/diamonds.jpg";

        public Diamond(CardNumber i)
        {
            Number = i;
        }
        public Diamond()
        {

        }

        public List<ICard> CreateCards()
        {
            foreach (CardNumber i in Enum.GetValues(typeof(CardNumber)))
            {
                Diamond diamonds = new Diamond(i);

                _diamondsList.Add(diamonds);
                
            }
            return _diamondsList;
        }

        public void GetCard()
        {
            Console.WriteLine($"{Suit} - {Number}");
        }

        
    }
}
