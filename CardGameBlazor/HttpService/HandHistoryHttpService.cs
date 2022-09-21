namespace CardGameBlazor.HttpService
{
    public class HandHistoryHttpService : IHandHistoryHttpService
    {
        private readonly HttpClient _httpClient;
        public HandHistoryHttpService(HttpClient httpClient) => _httpClient = httpClient;


    }
}
