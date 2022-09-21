using SharedDtos.DataTransferObjects;
using System.Net.Http.Json;

namespace CardGameBlazor.HttpService
{
    public class CardDeckHttpService : ICardDeckHttpService
    {
        private readonly HttpClient _httpClient;
        public CardDeckHttpService(HttpClient httpClient) => _httpClient = httpClient;

      
    }
}
