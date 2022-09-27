using CardGameBlazor.HttpService;
using Microsoft.AspNetCore.Components;
using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.Pages
{
    public partial class History
    {
        [Inject]
       public IHandHistoryHttpService? HandHistoryHttp { get; set; }
        public List<HandHistoryDto>? HandHistoryList { get; set; }

        protected override async Task OnInitializedAsync()
        {
           HandHistoryList = new();
           HandHistoryList = await HandHistoryHttp.GetAllHandHistoryAsync();
        }
    }
}
