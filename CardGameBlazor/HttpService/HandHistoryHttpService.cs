using SharedDtos.DataTransferObjects;
using System.Net.Http.Json;

namespace CardGameBlazor.HttpService
{
    public class HandHistoryHttpService : IHandHistoryHttpService
    {
        private readonly HttpClient _httpClient;
        public HandHistoryHttpService(HttpClient httpClient) => _httpClient = httpClient;

        public async Task CreateHandHistoryAsync(HandHistoryDto hand)
        {
            await _httpClient.PostAsJsonAsync<HandHistoryDto>("/handhistory", hand);
        }
    }
}
