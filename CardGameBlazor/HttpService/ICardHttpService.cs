using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.HttpService
{
    public interface ICardHttpService
    {
        /// <summary>
        /// Returns a List of All Cards in the DB
        /// </summary>
        /// <returns></returns>
        Task<List<CardDto>> GetAllCardsAsync();
        
    }
}
