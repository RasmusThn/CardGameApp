using CardGameBlazor.HttpService;
using Microsoft.AspNetCore.Components;
using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.Pages
{
    public partial class Gaming
    {
        private bool _showCard = false;
        [Inject]
        public ICardHttpService? CardHttpService { get; set; }
        public CardDto CardToSend { get; set; }

       

        public async Task LoadRandomCard()
        {
            CardToSend = await CardHttpService.GetRandomActiveCardAsync();
            _showCard = true;
            StateHasChanged();
        }
    }
}
