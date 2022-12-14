using SharedDtos.DataTransferObjects;
using System.Net.Http.Json;

namespace CardGameBlazor.HttpService
{
    public class CardHttpService : ICardHttpService
    {
        private readonly HttpClient _httpClient;

        public CardHttpService(HttpClient httpClient)=> _httpClient = httpClient;

        public async Task<List<CardDto>> GetAllCardsAsync()
        {
            var cards = await _httpClient.GetFromJsonAsync<List<CardDto>>("cards");

            return cards.ToList();
        }

       
    }
}
