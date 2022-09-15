using CardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary.Cards
{
    public interface ICard
    {
        public int Id { get; set; }
        public CardSuit Suit { get; set; }
        public CardNumber Number { get; set; }
        public string ImgUrl { get; }

        public List<ICard> CreateCards();
        public void GetCard();
    }
}
