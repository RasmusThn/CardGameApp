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
        /// <summary>
        /// Returns a List of all Cards from DB
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        Task<IEnumerable<Card>> GetAllCardsAsync(bool trackChanges);
        /// <summary>
        /// Returns the Card with Id that is passed in
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        Task<Card> GetCardAsync(int id, bool trackChanges);
    }
}
