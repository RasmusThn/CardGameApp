
using CardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary.Cards
{
    public class Club : ICard
    {
        public List<ICard> _clubsList = new List<ICard>();
        public int Id { get ;set; }
        public CardSuit Suit { get; set; } = CardSuit.Clubs;
        public CardNumber Number { get; set; }

        public string ImgUrl => "/images/clubs.jpg";

        public Club(CardNumber i)
        {
            Number = i;
        }
        public Club()
        {

        }
        public List<ICard> CreateCards()
        {
            foreach (CardNumber i in Enum.GetValues(typeof(CardNumber)))
            {
                Club club = new Club(i);

                _clubsList.Add(club);
            }
            return _clubsList;
        }

        public void GetCard()
        {
            Console.WriteLine($"{Suit} - {Number}");
        }
    }
}
