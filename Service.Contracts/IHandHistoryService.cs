using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IHandHistoryService
    {
        /// <summary>
        /// Creates a New HandHistory to DB with the passed in object
        /// </summary>
        /// <param name="handHistory"></param>
        /// <returns></returns>
        Task<HandHistoryDto> CreateHandHistory(HandHistoryDto handHistory);
        /// <summary>
        /// Returns a List of All HandHistory objects from the DB
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        Task<IEnumerable<HandHistoryDto>> GetAllHandHistoryAsync(bool trackChanges);
    }
}
