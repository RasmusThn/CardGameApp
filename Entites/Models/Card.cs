using CardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class Card
    {
        public int Id { get; set; }
        public CardSuit Suit { get; set; }
        public CardNumber Number { get; set; }
        public bool IsActive { get; set; } = false;
        public string ImgUrl { get; set; }

    }
}
