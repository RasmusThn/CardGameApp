using Contracts;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CardDeckRepository : RepositoryBase<CardDeck>, ICardDeckRepository
    {
        public CardDeckRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }
    }
}
