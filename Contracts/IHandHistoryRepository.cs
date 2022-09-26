using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IHandHistoryRepository
    {
        /// <summary>
        /// Creates a New HandHistory in the Database
        /// </summary>
        /// <param name="handHistory"></param>
        void CreateHandHistory(HandHistory handHistory);
        /// <summary>
        /// Gets ALL HandHistory from the Database
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<HandHistory>> GetAllHandHistoryAsync(bool trackChanges);
    }
}
