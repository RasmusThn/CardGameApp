
using CardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary.Cards
{
    public class Heart : ICard
    {
        public List<ICard> _heartsList = new List<ICard>();
        public int Id { get; set; }
        public CardSuit Suit { get; set ; } = CardSuit.Hearts;
        public CardNumber Number { get ; set ; }
        public string ImgUrl => "/images/hearts.jpg";

        public Heart(CardNumber i)
        {
            Number = i;
        }
        public Heart()
        {

        }
        public List<ICard> CreateCards()
        {
            foreach (CardNumber i in Enum.GetValues(typeof(CardNumber)))
            {
                Heart heart = new Heart(i);
                
                _heartsList.Add(heart);
            }
            return _heartsList;
        }

        public void GetCard()
        {
            Console.WriteLine($"{Suit} - {Number}");
        }
    }
}
