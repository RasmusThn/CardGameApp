using Contracts;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        public CardRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Card>> GetAllCardsAsync(bool trackChanges) =>
           await FindAll(trackChanges)
                .OrderBy(c => c.Id)
                .ToListAsync();

        public async Task<Card> GetCardAsync(int id, bool trackChanges) =>
           await FindByCondition(c => c.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        
    }
}
