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
    public class HandHistoryRepository : RepositoryBase<HandHistory>, IHandHistoryRepository
    {
        public HandHistoryRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {
        }

        public void CreateHandHistory(HandHistory handHistory) => Create(handHistory);

        public async Task<IEnumerable<HandHistory>> GetAllHandHistoryAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderByDescending(h => h.Id)
                .ToListAsync();
    }
}
