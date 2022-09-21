using CardLibrary.Enums;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasData(
            #region Hearts
                new Card
                {
                    Id = 1,
                    Number = CardNumber.Ace,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/ace.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 2,
                    Number = CardNumber.Two,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/2.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 3,
                    Number = CardNumber.Three,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/3.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 4,
                    Number = CardNumber.Four,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/4.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 5,
                    Number = CardNumber.Five,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/5.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 6,
                    Number = CardNumber.Six,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/6.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 7,
                    Number = CardNumber.Seven,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/7.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 8,
                    Number = CardNumber.Eight,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/8.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 9,
                    Number = CardNumber.Nine,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/9.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 10,
                    Number = CardNumber.Ten,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/10.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 11,
                    Number = CardNumber.Jack,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/jack.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 12,
                    Number = CardNumber.Queen,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/queen.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 13,
                    Number = CardNumber.King,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts/king.png",
                    IsActive = true

                },
            #endregion Hearts 
            #region Diamonds
                new Card
                {
                    Id = 14,
                    Number = CardNumber.Ace,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/ace.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 15,
                    Number = CardNumber.Two,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/2.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 16,
                    Number = CardNumber.Three,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/3.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 17,
                    Number = CardNumber.Four,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/4.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 18,
                    Number = CardNumber.Five,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/5.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 19,
                    Number = CardNumber.Six,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/6.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 20,
                    Number = CardNumber.Seven,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/7.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 21,
                    Number = CardNumber.Eight,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/8.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 22,
                    Number = CardNumber.Nine,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/9.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 23,
                    Number = CardNumber.Ten,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/10.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 24,
                    Number = CardNumber.Jack,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/jack.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 25,
                    Number = CardNumber.Queen,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/queen.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 26,
                    Number = CardNumber.King,
                    Suit = CardSuit.Diamonds,
                    ImgUrl = "/images/diamonds/king.png",
                    IsActive = true

                },
            #endregion
            #region Spades
                new Card
                {
                    Id = 27,
                    Number = CardNumber.Ace,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/ace.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 28,
                    Number = CardNumber.Two,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/2.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 29,
                    Number = CardNumber.Three,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/3.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 30,
                    Number = CardNumber.Four,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/4.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 31,
                    Number = CardNumber.Five,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/5.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 32,
                    Number = CardNumber.Six,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/6.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 33,
                    Number = CardNumber.Seven,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/7.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 34,
                    Number = CardNumber.Eight,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/8.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 35,
                    Number = CardNumber.Nine,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/9.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 36,
                    Number = CardNumber.Ten,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/10.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 37,
                    Number = CardNumber.Jack,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/jack.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 38,
                    Number = CardNumber.Queen,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/queen.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 39,
                    Number = CardNumber.King,
                    Suit = CardSuit.Spades,
                    ImgUrl = "/images/spades/king.png",
                    IsActive = true

                },
            #endregion
            #region Clubs
                new Card
                {
                    Id = 40,
                    Number = CardNumber.Ace,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/ace.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 41,
                    Number = CardNumber.Two,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/2.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 42,
                    Number = CardNumber.Three,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/3.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 43,
                    Number = CardNumber.Four,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/4.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 44,
                    Number = CardNumber.Five,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/5.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 45,
                    Number = CardNumber.Six,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/6.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 46,
                    Number = CardNumber.Seven,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/7.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 47,
                    Number = CardNumber.Eight,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/8.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 48,
                    Number = CardNumber.Nine,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/9.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 49,
                    Number = CardNumber.Ten,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/10.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 50,
                    Number = CardNumber.Jack,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/jack.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 51,
                    Number = CardNumber.Queen,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/queen.png",
                    IsActive = true

                },
                new Card
                {
                    Id = 52,
                    Number = CardNumber.King,
                    Suit = CardSuit.Clubs,
                    ImgUrl = "/images/clubs/king.png",
                    IsActive = true

                }
                #endregion
                );
        }
    }
}
