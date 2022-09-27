using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.HttpService
{
    public interface IHandHistoryHttpService
    {
        /// <summary>
        /// Sends in a HandHistoryDto object to create a new one in the DB
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        Task CreateHandHistoryAsync(HandHistoryDto hand);
        /// <summary>
        /// Returns a List of All HandHistory Objects in the DB
        /// </summary>
        /// <returns></returns>
        Task <List<HandHistoryDto>> GetAllHandHistoryAsync();
    }
}
