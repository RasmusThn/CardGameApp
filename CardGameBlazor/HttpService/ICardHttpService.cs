using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.HttpService
{
    public interface ICardHttpService
    {
        Task<List<CardDto>> GetAllCardsAsync();
        Task<CardDto> GetRandomActiveCardAsync();
    }
}
