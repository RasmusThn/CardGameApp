using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICardRepository
    {
        Task<IEnumerable<Card>> GetAllCardsAsync(bool trackChanges);
        Task<Card> GetCardAsync(int id, bool trackChanges);
    }
}
