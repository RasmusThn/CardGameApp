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
    public class CardDeckConfiguration : IEntityTypeConfiguration<CardDeck>
    {
        public void Configure(EntityTypeBuilder<CardDeck> builder)
        {
            builder.HasData(
                new CardDeck(52) { Id=1}
                );
        }
    }
}
