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

                new Card
                {
                    Id = 1,
                    Number = CardNumber.Two,
                    Suit = CardSuit.Hearts,
                    ImgUrl = "/images/hearts.jpg",
                    IsActive = true

                }

                );
        }
    }
}
