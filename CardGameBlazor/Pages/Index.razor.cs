using CardGameBlazor.HttpService;
using Microsoft.AspNetCore.Components;
using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.Pages
{
    public partial class Index
    {
        public List<CardDto> CardsList { get; set; }
        [Inject]
        public ICardHttpService? CardService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            CardsList = await CardService.GetAllCardsAsync();
        }
    }
}
