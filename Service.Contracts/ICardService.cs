
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface ICardService
    {
        /// <summary>
        /// Gets all cards from Db
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        Task<IEnumerable<CardDto>> GetAllCardsAsync(bool trackChanges);
        /// <summary>
        /// Gets one card by Id from Db
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        Task<CardDto> GetCardAsync(int id,bool trackChanges);
        /// <summary>
        /// Returns a Random Card if the prop isActive is set to true
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        Task<CardDto> GetRandomActiveCard(bool trackChanges);
    }
}
